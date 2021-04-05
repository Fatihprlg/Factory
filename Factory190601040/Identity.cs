using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory190601040
{
    class Identity
    {
        
        public long tckNo { get;  set; }
        public string name { get; set; }
        public string surname { get; set; }
        public Identity(long tckNo, string name, string surname)
        {
            this.tckNo = tckNo;
            this.name = name;
            this.surname = surname;
        }
        
    }
}
