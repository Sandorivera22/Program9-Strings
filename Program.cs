using System;
using System.Text;
namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string MyString = "My \"so-called\" life";
            //string MyString = "What if I need a\nnew line";
            //string MyString = "Go to your c:\\ drive";
            //string MyString = @"Go to your c:\ drive";

            //string MyString = String.Format("{0} = {1}", "First", "Second");

            //string MyString = string.Format("{0:C}", 123.45);
            //string MyString = string.Format("{0:N}", 1234567890);
            //string MyString = string.Format("Percentage: {0:P},", .123);
            //string MyString = string.Format("Phone Number: {0:(###)-###-####}", 123456789012);

            //string MyString = " That summer we took threes acrass the board  ";

            //MyString = MyString.Substring(6, 14);
            //MyString = MyString.ToUpper();
            //MyString = MyString.Replace(" ", "--");
            //MyString = MyString.Remove(6, 14);

            /*
            MyString = String.Format("Length before {0} -- Length after: {1}",
                MyString.Length, 
                MyString.Trim().Length);
            */

            /*
            string MyString = "";
            for (int i = 0; i < 100; i++)
            {
                MyString += "--" + i.ToString();
            }
            */
            
            StringBuilder MyString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                MyString.Append("--");
                MyString.Append(i);

            } 

            Console.WriteLine(MyString);
            Console.ReadLine();
        }
    }
}
