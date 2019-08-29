using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionClassDemo
{
    class Application
    {
        string name;
        int age;
        public Application()
        {

        }
        public Application(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age
        {
            get => age;
            set
            {
                if (value >= 18)
                    age = value;
                else
                {
                    InapprorpiateAgeException ageException = new InapprorpiateAgeException("license can't be issued to applicant with age less than 18");
                    throw ageException;
                }
            }
        }
    }
}
