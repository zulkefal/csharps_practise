using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create console application that prints your first and last name using string function.
            String firstName = "Zulkefal";
            String lastName = "Mohammadzai";
            String fullName = String.Concat(firstName, " ", lastName);

            Console.WriteLine("\n My First Name is :" + firstName);
            Console.WriteLine(" My Last Name is : {0}", lastName);
            Console.WriteLine(" My Full Name is : {0}", fullName);

            //Create a console application that prints the current date and time.
            DateTime timeNow = DateTime.Now;
            Console.WriteLine("The Current time is " + timeNow);

            //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
            Console.WriteLine("Enter any number to Upto which the series will Print :");
            int limit = int.Parse(Console.ReadLine());

            for (int i = 2; i < limit; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(",{0},", -i);
                }

            }

            //Write a program to read your age from the console and print how old you will be after 10 years.
            Console.Write("Enter Your Current Age : ");
            byte ageNow = byte.Parse(Console.ReadLine());
            Console.WriteLine("Your Current Age is : " + ageNow);
            ageNow += 10;
            Console.WriteLine("Your age after 10 years will be : " + ageNow);

            Console.ReadLine();

            /*  A company has name, address, phone number, fax number, web site and manager. The manager
                has first name, last name, age and a phone number. Write a program that reads the information
                 about a company and its manager and prints them on the console. Names should be printed in
                upper case. Apply any four string methods on these inputs. Use appropriate data types and descriptive names.*/

            byte managerAge;
            String companyName, companyAddress, website, managerFirstName, managerLastName;
            long companyPhone, companyFax, managerPhone;

            Console.WriteLine("\n**********Enter Details of Company**********");
            Console.Write("Enter Name:\t");
            companyName = Console.ReadLine();

            Console.Write("Enter Address:\t");
            companyAddress = Console.ReadLine();

            Console.Write("Enter Phone Number:\t");
            companyPhone = long.Parse(Console.ReadLine());

            Console.Write("Enter Fax Number:\t");
            companyFax = long.Parse(Console.ReadLine());

            Console.Write("Enter Website: \t");
            website = Console.ReadLine();

            Console.WriteLine("\n\n**********Enter Details of Manager**********");
            Console.Write("Enter First Name:\t");
            managerFirstName = (Console.ReadLine().ToUpper());

            Console.Write("Enter Last Name:\t");
            managerLastName = (Console.ReadLine().ToUpper());

            Console.Write("Enter Phone number:\t");
            managerPhone = long.Parse(Console.ReadLine());

            Console.Write("Enter Age:\t");
            managerAge = byte.Parse(Console.ReadLine());


            Console.WriteLine("\n\n********** Details of Company **********");
            Console.WriteLine("Company Name : \t" + companyName);
            Console.WriteLine("Company Address : \t" + companyAddress);
            Console.WriteLine("Company Phone Number : \t" + companyPhone);
            Console.WriteLine("Company Fax Number : \t" + companyPhone);
            Console.WriteLine("Company Website : \t" + website);

            Console.WriteLine("\n\n********** Details of Manager **********");
            Console.WriteLine("First Name  : \t" + managerFirstName);
            Console.WriteLine("Last Name  : \t" + managerLastName);
            Console.WriteLine("Age : \t" + managerPhone);
            Console.WriteLine("Phone Number : \t" + managerAge);


            // Write a program that gets two numbers from the console and prints the greater of them. Without using if statements.
            Console.Write("Enter First Number : ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second Number : ");
            int secondNum = int.Parse(Console.ReadLine());
            int greater = Math.Max(firstNum, secondNum);
            Console.WriteLine("\nThe Greater Number is : " + greater);

            //Write a program that reads an integer number n from the console and prints all the numbers in the interval[1….n], each on a single line.
           
            Console.Write("Enter Any Number : ");
            byte num = byte.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write(" " + i, ",");
            }


            /*Write program that Counts zeros, odds, and evens using loop.This program counts the 
             number of odd and even numbers. The program also counts the number of zeros.*/
            int even = 0, odd = 0, zeros = 0;
            Console.WriteLine("Enter Any 10 Number : ");
            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    if (num == 0)
                    {
                        zeros += 1;
                    }

                    else
                    {
                        even += 1;
                    }
                }
                else
                {
                    odd += 1;
                }

            }
            Console.WriteLine("Total Even Numbers Entered are : " + even);
            Console.WriteLine("Total Odd Numbers Entered are : " + odd);
            Console.WriteLine("Total Zeros Entered are : " + zeros);


            // Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
            for (int i = 2, j = 3 ; i <20; i+=2, j+=2 )
            {
                Console.Write("{0},{1},",i, -j);
            }
                Console.ReadLine();
        }
    }
}
