using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.IO;


namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Owner> owner = new List<Owner>();
            List<Agency> agency = new List<Agency>();
            List<Object1> object1 = new List<Object1>();
            List<Lodger> lodger = new List<Lodger>();

            FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Object.txt", FileMode.Create);
            FileStream file2 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Owner.txt", FileMode.Create);
            FileStream file3 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Agency.txt", FileMode.Create);
            FileStream file4 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Lodger.txt", FileMode.Create);
            file1.Close();
            file2.Close();
            file3.Close();
            file4.Close();
            Object1.InputObject1(ref object1, ref owner);
            Owner.InputOwner(ref owner,ref object1,ref agency);
            Agency.InputAgency(ref agency, ref owner);
            Lodger.InputLodger(ref agency, ref owner);
            Console.ReadKey();
            
            
        }
    }
}
