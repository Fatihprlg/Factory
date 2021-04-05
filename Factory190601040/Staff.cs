using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory190601040
{
    class Staff
    {
        public int staffNo { get; set; }
        public string depart { get; set; }
        public Identity identity { get; set; }
        public Staff(Identity identity, int staffNo, string depart)
        {
            this.identity = identity;
            this.staffNo = staffNo;
            this.depart = depart;
        }
    }
}
