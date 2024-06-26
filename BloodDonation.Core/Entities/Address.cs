using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodDonation.Core.ValueObjects;

namespace BloodDonation.Core.Entities
{
    public class Address : BaseEntity
    {
        public Address(string street, string city, string state, string postalCode, string country, int userId, bool actualAddress)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
            UserId = userId;
            ActualAddress = actualAddress;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        public int UserId { get; private set; }
        public bool ActualAddress { get; private set; }
        public User? User { get; private set; }

        public void SetActualAddress(bool actualAddress)
        {
            ActualAddress = actualAddress;
        }
    }
}
