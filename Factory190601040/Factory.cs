using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory190601040
{
    class Factory
    {
        public string facName { get; set; }
        public string adress { get; set; }
        public List<Staff> staffs { get; set; }
        public Factory(string facName, string adress)
        {
            this.facName = facName;
            this.adress = adress;
            staffs = new List<Staff>();
        }
        public void Recruit(Staff staff)
        {
            staffs.Add(staff);
        }
        public void Fire(int index)
        {
            staffs.RemoveAt(index);
        }
    }
}
