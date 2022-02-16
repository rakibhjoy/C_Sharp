using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contact
{
    class Contact
    {
        string personName;
        string personId;
        int age;
        string mobileNumber;
        char gender ;

        public Contact()
        { }
        public Contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            

        }
        public void setPersonName (string personName)
        {
            this.personName = personName;
        }
        public void setPersonId(string personId)
        {
            this.personId = personId;
        }
        public void setAge(int age)
        {
            this.age=age;
        }
        public void setMobileNumber(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }
        public void setGender(char gender)
        {
            this.gender = gender;
        }
        
         public string  getPersonName ()
        {
            return personName;
        }
        public string getPersonId()
        {
           return personId;
        }
        public int getAge()
        {
            return age;
        }
        public string getMobileNumber()
        {
            return mobileNumber;
        }
        public char getGender()
        {
            return gender;
        }



        public string PersonName { get; set; }
        public string PersonId { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }
        public char Gender { get; set; }

        public void ShowPersonInfo()
        {
            Console.WriteLine("PersonName: " + getPersonName());
            Console.WriteLine("PersonId: " + getPersonId());
            Console.WriteLine("Person Age: " + getAge());
            Console.WriteLine("MobileNumber: " + getMobileNumber());
            Console.WriteLine("Gender: " + getGender());
            

        }
        public void DetectMobileOperator()
        {
            
            if (mobileNumber[0] == 0 && mobileNumber[1] == 1 && mobileNumber[3]==8)
                {
                    Console.WriteLine("Robi number");
                }

            else if (mobileNumber[0] == 0 && mobileNumber[1] == 1 && mobileNumber[3] == 3)
                {
                    Console.WriteLine("GP number");
                }
            else
            {
                Console.WriteLine("other number");
            }
            

        }
    }
}
