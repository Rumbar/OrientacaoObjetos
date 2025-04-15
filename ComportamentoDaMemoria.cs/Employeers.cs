using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoDaMemoria
{
     class Employeers
    {

        public string Name {  get; set; }
        public int Id {  get; set; }
        public double Salary { get; private set; }

        public Employeers(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
            
        }


    }
}
