using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSInterview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.name = "PARAS";
            e1.address = "Mumbai";
            e1.Validate();


        }

        //Class
        public class Employee
        {
            public string name {  get; set; }
            public string address { get; set; }
            public virtual void Validate()
            {
                ValidateName();
                ValidateAddress();
            }

            public virtual void age () { }



            //Encapsulation & Abstraction
            private void ValidateName()
            {

            }

            //Encapsulation & Astraction
            private void ValidateAddress()
            {

            }

            //Inheritance
            public class Manager : Employee
            {
                public string ManagerTask {get; set; }

                public override void Validate()
                {
                    //Your Overriden Logic
                }

                public override void age()
                {
                    //Your override logic here
                }




            }
        }

    }
}
