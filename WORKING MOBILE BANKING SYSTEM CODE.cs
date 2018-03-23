
using System;

namespace Mobilebanking
{
    class Mobilebanking
    {
        static void Main(string[] args)
        {
            string userName;


            int i = 0;

            Console.WriteLine("Good Day User Welcome to FOBS Bank");
            Console.WriteLine("Enter Your User Name");

            userName = Console.ReadLine();

            Console.WriteLine(" Please Enter Your Pin Number ");

            string password = Console.ReadLine();

            Console.WriteLine(userName + "      Welcome to FOBS Banking Services  ");

            Console.WriteLine("1. Balance Enquiry");
            Console.WriteLine("2. Mini Statement");
            Console.WriteLine("3. Buy Airtime");
            Console.WriteLine("4. Zesa Prepaid");
            Console.WriteLine("5. Bank transfers");
            Console.WriteLine("6. Change Pin");


            i = Convert.ToInt32(Console.ReadLine());

            if (i == 1)
            {
                Console.WriteLine("You have Insufficient Funds ");
                Console.ReadLine();
            }
            if (i == 2)
            {
                Console.WriteLine("    01/01/2018:        0.00     0.00");
                Console.ReadLine();
            }

            if (i == 3)
            {

                Console.WriteLine("Please select from options below");
                Console.WriteLine("1. Buy for your self");
                Console.WriteLine("2. Buy for other");

                int z = Convert.ToInt32(Console.ReadLine());

                if (z == 1)
                {
                    int amount;
                    Console.WriteLine("Enter amount");
                    amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Airtime worth  " + amount + " dollars  was successfull");

                }

                if (z == 2)
                {
                    int phoneNumer;
                    int amount2;
                    Console.WriteLine("Enter Phone Number");
                    phoneNumer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Amount");
                    amount2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Airtime worth  " + amount2 +  " dollars to  " + phoneNumer + "   was successfull ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Result unknown");
                }

            }

            if (i == 4)
            {
                Console.WriteLine("Enter meter number");
                Console.ReadLine();
                Console.WriteLine("Enter Amount");
                int zesaAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your have successfully purchased a ZESA token worth  $" + zesaAmount );
                Console.ReadLine();
            }

            if (i == 5)
            {


                Console.WriteLine("1. RTGS");
                Console.WriteLine("2. Internal transfers");
                Console.WriteLine("3. ZIPIT");

                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                {
                    Console.WriteLine("PLEASE SELECT FROM THE LIST BELOW:");

                    Console.WriteLine("1. BARCLAS BANK");
                    Console.WriteLine("2. CABS");
                    Console.WriteLine("3. CBZ BANK");
                    Console.WriteLine("4. CENTRAL BANK");
                    Console.WriteLine("5. STANBIC BANK");
                    Console.WriteLine("6. STEWARD BANK");


                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.Write(" System busy please try again later");
                    Console.ReadLine();



                }

                if (n == 2)
                {
                    Console.WriteLine("Enter Account Number");
                    int accounNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Amount");

                    Console.ReadLine();
                    Console.WriteLine("Internal transfer to  " + accounNumber + " was successfull");
                    Console.ReadLine();
                }

                if (n == 3)
                {
                    Console.WriteLine("PLEASE SELECT FROM THE LIST BELOW:");

                    Console.WriteLine("1. BARCLAS BANK");
                    Console.WriteLine("2. CABS");
                    Console.WriteLine("3. CBZ BANK");
                    Console.WriteLine("4. CENTRAL BANK");
                    Console.WriteLine("5. STANBIC BANK");
                    Console.WriteLine("6. STEWARD BANK");
                    Console.ReadLine();
                    Console.Write(" System busy please try again later");
                    Console.ReadLine();
                }

            }

            if (i == 6)
            {
                Console.WriteLine("Enter New Pin Number");
                Console.ReadLine();
                Console.WriteLine("Pin has been changed successifull");
                Console.ReadLine();
            }

            else 
            {
                Console.WriteLine("Result Unknown");;
                


            }

            Console.WriteLine("Thank you " + userName + "  for choosing FOBS Bank ");
            Console.ReadLine();
        }
    }
}