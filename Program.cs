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

            //Polymorpshism
            Employee e2 = new Manager();
            e2 = new Supervisor();
        }

        //Class
        public class Employee
        {
            public string name {  get; set; }
            public string address { get; set; }
           
            //Overriding
            public virtual void Validate()
            {
                ValidateName();
                ValidateAddress();
            }

            //Overriding //Run Time Polymorphsim
            public virtual void age()
            {

            }


            //Encapsulation & Abstraction
            private void ValidateName()
            {

            }

            
            //Encapsulation & Astraction
            private void ValidateAddress()
            {

            }

        }
        //Inheritance
        public class Manager : Employee
        {
            public string ManagerTask { get; set; }

            //Overriding //Run Time Polymorphsim
            public override void Validate()
            {
                //Your Overriden Logic
            }


            //Overloading   //Compile Time Polymorphism   //Static Polymorpshism
            public void ValidateName(int id)
            {

            }

            public void ValidateName(int id, string name)
            {

            }

            public void ValidateName(int id, string name, string address)
            {

            }


            //Overriding //Run Time Polymorphism   //Dynamic Polymorpshism
            public override void age()
            {
                //Your override logic here
            }




        }

        //Class Inheritance
        public class Supervisor : Employee
        {
            //Some properties
        }


    }
}
