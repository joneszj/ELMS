using ELMS.DAL.Common;
using ELMS.DAL.Forms;
using ELMS.DAL.Forms.Sections;
using ELMS.DAL.Programs;
using ELMS.DAL.Schools;
using ELMS.DAL.StandardOptions;
using ELMS.DAL.Standards;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.DAL._Context
{
    public class ELMSCoreContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        //public override int SaveChanges()
        //{
        //    NotSupportedException ex = new NotSupportedException("Synchronous SaveChanges method is not supported. Use the Async method.");
        //    throw ex;
        //}

        public override Task<int> SaveChangesAsync()
        {
            //sets audit data on base class : modify
            foreach (var entry in ChangeTracker.Entries()
                      .Where(p => p.State == EntityState.Modified
                      && p.Entity is Base.Base))
            {
                SetModified(entry);
            }

            //sets audit data on base class : create
            foreach (var entry in ChangeTracker.Entries()
                      .Where(p => p.State == EntityState.Added
                      && p.Entity is Base.Base))
            {
                SetCreated(entry);
            }

            //preform soft delete for deleted records
            foreach (var entry in ChangeTracker.Entries()
                      .Where(p => p.State == EntityState.Deleted
                      && p.Entity is Base.Base))
            { 
                SoftDelete(entry);
            }

            return base.SaveChangesAsync();
        }

        private void SetCreated(DbEntityEntry entry)
        {
            var e = entry.Entity as Base.Base;

            e.DateCreated = DateTime.Now;
            e.Active = true;
        }

        private void SetModified(DbEntityEntry entry)
        {
            var e = entry.Entity as Base.Base;

            e.DateModified = DateTime.Now;
        }

        private void SoftDelete(DbEntityEntry entry)
        {
            var e = entry.Entity as Base.Base;
            string tableName = GetTableName(e.GetType(), this);
            Database.ExecuteSqlCommand(
                     String.Format("UPDATE {0} SET Active = 0 WHERE ID = @id", tableName)
                     //TODO: set userID
                     , new SqlParameter("id", e.Id));

            //Marking it Unchanged prevents the hard delete
            //entry.State = EntityState.Unchanged;
            //So does setting it to Detached:
            //And that is what EF does when it deletes an item
            //http://msdn.microsoft.com/en-us/data/jj592676.aspx
            entry.State = EntityState.Detached;
        }

        public static string GetTableName(Type type, DbContext context)
        {
            var metadata = ((IObjectContextAdapter)context).ObjectContext.MetadataWorkspace;

            // Get the part of the model that contains info about the actual CLR types
            var objectItemCollection = ((ObjectItemCollection)metadata.GetItemCollection(DataSpace.OSpace));

            // Get the entity type from the model that maps to the CLR type
            var entityType = metadata
                    .GetItems<EntityType>(DataSpace.OSpace)
                    .Single(e => objectItemCollection.GetClrType(e) == type);

            // Get the entity set that uses this entity type
            var entitySet = metadata
                .GetItems<EntityContainer>(DataSpace.CSpace)
                .Single()
                .EntitySets
                .Single(s => s.ElementType.Name == entityType.Name);

            // Find the mapping between conceptual and storage model for this entity set
            var mapping = metadata.GetItems<EntityContainerMapping>(DataSpace.CSSpace)
                    .Single()
                    .EntitySetMappings
                    .Single(s => s.EntitySet == entitySet);

            // Find the storage entity set (table) that the entity is mapped
            var table = mapping
                .EntityTypeMappings.Single()
                .Fragments.Single()
                .StoreEntitySet;

            // Return the table name from the storage entity set
            return (string)table.MetadataProperties["Table"].Value ?? table.Name;
        }

        //Schools
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolProfile> SchoolProfiles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<SchoolType> SchoolTypes { get; set; }

        //Common
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EducationProfile> EducationProfiles { get; set; }
        public DbSet<EducationHistory> EducationHistories { get; set; }
        public DbSet<Person> People { get; set; }

        //Standard Options
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<EducationMajor> EducationMajors { get; set; }
        public DbSet<EducationMajorSubject> EducationMajorSubjects { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<County> Counties { get; set; }

        //Programs
        public DbSet<Program> Programs { get; set; }
        public DbSet<ProgramMapping> ProgramMappings { get; set; }
        public DbSet<ProgramTag> ProgramTags { get; set; }

        //Forms
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormType> FormTypes { get; set; }
        public DbSet<FormInput> FormInputs { get; set; }
        public DbSet<FormInputValue> FormValues { get; set; }
        //Form Sections
        public DbSet<Section> Sections { get; set; }
        public DbSet<StandardSection> StandardSections { get; set; }
        public DbSet<StandardSectionType> StandardSectionTypes { get; set; }
    }
}
