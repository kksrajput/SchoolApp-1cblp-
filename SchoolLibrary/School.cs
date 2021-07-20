using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
   
    public class School
    {

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { set; get; }

        public string PhoneNumber { get; set; }
        private string _tweet;
        public string TwitterAdress
        {
            get { return _tweet; }
            set
            {
                if (value.StartsWith("@k"))
                {
                    _tweet = value;
                }
                else
                {
                    throw new Exception("The twitter address should start with @");
                }
            }
        }
        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "000-1111";   
        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }
        //ctor+2timestab
        //public float AverageThreeScores(float a,float b,float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}
        //fn.bodied expression in c#6 ||for simple expressions
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        
        public static int AverageThreeScores(int a,int b,int c)
        {
            //var temp = 15;
            //temp.ToString();
            var result = (a + b + c) / 3;
            return result;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.AppendLine(", ");
            sb.AppendLine(State);
            //sb.AppendLine(" ");
            sb.AppendLine(Zip);
            sb.AppendLine(TwitterAdress);
            return sb.ToString();
        }
    }
}
