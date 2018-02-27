using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace laba_2_s4
{
    public class Address
    {
        public string street;
        public string city;
        public int house;
        public int flat;
        public int index;

        public Address(string city, string street, int house, int flat, int index)
        {
            this.city = city;
            this.street = street;
            this.house = house;
            this.flat = flat;
            this.index = index;
        }
        public Address()
        {
            street = "";
            house = 0;
            flat = 0;
            index = 0;
        }
        public override string ToString()
        {
            return "City: " + city + "; Street: " + street + "; House: " + house + "; Flat: " + flat + "; Indexx: " + index;
        }
    }
}
