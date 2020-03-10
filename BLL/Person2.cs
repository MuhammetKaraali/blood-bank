using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Person2
    {
        int adressId;
        int bloodBankId;
        string gender;
        string birthDate;
        string name;
        string email;
        string password;


        public Person2()
        {

        }

        public Person2(int adressId, int bloodBankId, string gender, string birthDate, string name, string email, string password)
        {
            this.adressId = adressId;
            this.bloodBankId = bloodBankId;
            this.gender = gender;
            this.birthDate = birthDate;
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public int AdressId { get => adressId; set => adressId = value; }
        public int BloodBankId { get => bloodBankId; set => bloodBankId = value; }
        public string Gender { get => gender; set => gender = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public abstract int Login(string email, string password);


       

       

    }
}
