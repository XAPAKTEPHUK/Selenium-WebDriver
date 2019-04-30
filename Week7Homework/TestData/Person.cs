using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareTest.TestData
{
    public class Person
    {
        public Person()
        {
            SeedRandomData();
        }

        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;

        public void SeedRandomData()
        {
            var faker = new Faker();
            var testPhoneNumber = faker.Phone.PhoneNumber();
            var testEmail = faker.Internet.Email();
            var firstNameValue = faker.Name.FirstName();
            var lastNameValue = faker.Name.LastName();

        }

    }
}
