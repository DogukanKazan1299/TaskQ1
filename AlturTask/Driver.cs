using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlturTask
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Ana sürücü mü, yedek sürücü mü?
        public bool IsMainDriver { get; set; } 

        public Driver(int id,string name, bool isMainDriver)
        {
            Id = Id;
            Name = name;
            IsMainDriver = isMainDriver;
        }
    }
}
