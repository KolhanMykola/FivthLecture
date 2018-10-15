using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivthLecture
{
    public class StudentAddress
    {
        private string country;
        private string city;
        private string adress;

        public StudentAddress(string country, string city, string adress)
        {
            CheckValid.IsString(ref country);
            this.country = country;
            CheckValid.IsString(ref city);
            this.city = city;
            CheckValid.IsAdress(ref adress);
            this.adress = adress;
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public override string ToString()
        {
            return $"{country}\t{city}\t{adress}";
        }
    }
}
