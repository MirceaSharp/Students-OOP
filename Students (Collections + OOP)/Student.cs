using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students__Collections___OOP_
{
    class Student
    {


        private string _firstname;
        private string _lastname;
        public string FirstName {get;set;}
        public string LastName { get; set; }



        public Student(string firstname, string lastname)
        {
          this.FirstName = firstname;
            this.LastName = lastname;
            

        }

        public string Naam()
        {
            return this.FirstName +  " " +  this.LastName;

        }




    }
}
