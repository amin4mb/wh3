using System.Drawing;

namespace wh3
{
    public class program
    {
        public Color BackColor { get; private set; }

        public static void Main()
        {
            string[] EnumArray = new string[2];
            foreach (ContactTypes e in Enum.GetValues(typeof(ContactTypes)))
            {
                int value = (int)e;
                var Status = GetDisplayName.DisplayName((ContactTypes)value);
                Console.Write("DisplayName = " + Status + " --- EnumNumber = " + value + " --- ");//eq 4 , eq 7 , eq second part (class GetDisplayName)
                Console.WriteLine("EnumValu = " + e);
                EnumArray[value - 1] = e.ToString();//eq 5

            }


            int x = 2;
            Console.WriteLine("*******************");
            Console.WriteLine((ContactTypes)x);//eq 6

            var ArrayOfEnum = Enum.GetValues(typeof(ContactTypes));//eq 5
            
            
            
            string sms = ContactTypes.SMS.ToString();
            string email = ContactTypes.Email.ToString();


            //Console.WriteLine("*******************");
            //Console.WriteLine("sms or email ");
            //string enuminput = Console.ReadLine();


            //switch (enuminput)
            //{
            //    case sms:
            //        Console.WriteLine("you selected sms");
            //        break;
            //    case ContactTypes.Email.ToString():
            //        Console.WriteLine("you selected email");
            //        break;
            //    default:
            //        break;

            //}


            //string red = "Red";

            //ContactTypes color = (ContactTypes)Enum.Parse(typeof(ContactTypes), red);

           

        }
    }
}




