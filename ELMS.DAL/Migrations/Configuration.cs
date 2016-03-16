namespace ELMS.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ELMS.DAL._Context.ELMSCoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ELMS.DAL._Context.ELMSCoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //context.Countries.AddOrUpdate(new _ENUMs.Country() { Name = "United States", Abbreviation = "US" });
            //context.States.AddOrUpdate(new _ENUMs.State() { Abbreviation = "FL", Name = "Florida" });
            //context.People.AddOrUpdate(new Standards.Person() { Age = 29, DateCreated = DateTime.Now, FirstName = "Zachary", MiddleName = "John", LastName = "Jones", });
            //context.Addresses.AddOrUpdate(new Standards.Address() { AptSuiteOther = "", Street = "635 Executive Center Dr.", Zip = "33415" });
            //context.Contacts.AddOrUpdate(new Standards.Contact() { PrimaryEmail = "joneszj@gmail.com", PrimaryPhone = "5612250918", SecondaryEmail = "zachary-jones@bisk.net", SecondaryPhone = "5613136648" });
            //context.EducationLevels.AddOrUpdate(new _ENUMs.EducationLevel() { Name = "High School", DisplayOrder = 1 });
            //context.EducationMajors.AddOrUpdate(new _ENUMs.EducationMajor() { Name = "Computer Science" });
            //context.Clients.AddOrUpdate(new Schools.Client() { Name = "Some Client" });
            //context.Brands.AddOrUpdate(new Schools.Brand() { Name = "Some Brand" });
            //context.SchoolTypes.AddOrUpdate(new Schools.SchoolType() { IsCampus = true, IsCollege = true, IsElementarySchool = true, IsHighSchool = true, IsMiddleSchool = true, IsPreSchool = false, IsOnline = true, IsVocationalSchool = true });
            //context.Schools.AddOrUpdate(new Schools.School() {  Name = "Some HS" });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
