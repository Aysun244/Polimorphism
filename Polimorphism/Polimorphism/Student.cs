using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    public class Student :ICodeAcademy 
    {
        private static int count = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }

        public Student( string name, string surname) 
        {
            Name = name;
            Surname = surname;
            count++;
            Id = count;
            GenerateEmail();
        }
        public void GenerateEmail()
        {
            string lastEmail = ($"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az");
           CodeEmail = lastEmail;
        }
    }
}
