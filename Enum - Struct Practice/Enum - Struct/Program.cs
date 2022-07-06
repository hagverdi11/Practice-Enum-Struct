using System;

namespace Enum___Struct
{
    class Program
    {





        static void Main(string[] args)
        {

            //    CheckRole(2);

            //CheckDay(15);


            //int? age = null;

            //var result = age ?? 66;

            //Console.WriteLine(result);

            //string result = Sum();
            //var test = result == null ? "Duzdur" : "Sehvdir";
            //Console.WriteLine(test);


            Practice practice = new Practice("salam");
        


        }

      
        



        //static string Sum()
        //{
        //    return "Salam";
        //}


        struct Practice
        {
            public int Number;

            public Practice(string name)
            {
                Number = 6;
                Console.WriteLine("Work");

            }


        }



        //public static void CheckDay(int dayTime)
        //{
        //    switch (dayTime)
        //    {
        //        case (int)Weeks.Monday:
        //            Console.WriteLine("First");
        //            break;


        //        case (int)Weeks.Sunday:
        //            Console.WriteLine("Second");
        //            break;



        //        case (int)Weeks.Tuesday:
        //            Console.WriteLine("Third");
        //            break;

        //        case (int)Weeks.Wednesday:
        //            Console.WriteLine("Fourth");
        //            break;

        //        default:
        //            Console.WriteLine("Not Found");
        //            break;






        //    }


    }











        //static void CheckRole (int roleId)
        //{
        //    switch (roleId)
        //    {
        //        case (int)Positions.SuperAdmin:
        //            Console.WriteLine("Super Admin");
        //                break;

        //        case (int)Positions.Admin:
        //            Console.WriteLine("Admin");
        //            break;

        //        case (int)Positions.Member:
        //            Console.WriteLine("Member");
        //            break;

        //        default:
        //            Console.WriteLine("Not found");
        //            break;
        //    }
        //}

        

}



    //public enum Positions
    //{
    //    SuperAdmin,
    //    Admin,
    //    Member
    //}

    

    //public enum Weeks
    //{
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Saturday
    //}
























