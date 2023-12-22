using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }



        public override string ToString()
        {
            return $"{Name}  |  {Description, -5}   |   {DueDate.ToString("D")}";
        }
    }

}
