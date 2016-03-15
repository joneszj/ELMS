using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELMS.BLL
{
    public class Base
    {
        public ELMS.DAL._Context.ELMSCoreContext context;

        public Base()
        {
            this.context = new DAL._Context.ELMSCoreContext();
        }
    }
}
