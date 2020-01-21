using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Agency
    {
        private string Name;
        private static string Name2 = Name2;
        private string Phone { get; set; }
        private string Adress { get; set; }
        private static string a1 = "C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Agency.txt";
        public Agency(string Name, string Phone, string Adress)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Adress = Adress;
            FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Agency.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write("\n" + Name + "\n" + Phone + "\n" + Adress + "\n---------------\n"); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        }

        public static string getName() { return Name2; }
       // public static string getPhone() { return Name; }
       // public static string getName() { return Name; }
       /* public static void OpenFile1(string a)
        {
            FileStream file = new FileStream(a, FileMode.Open); //открывает файл только на чтение
            StreamReader reader = new StreamReader(file); // создаем «потоковый читатель» и связываем его с файловым потоком 
            StreamReader reader2 = new StreamReader(file);

            Console.WriteLine(reader.ReadToEnd());
            if (reader.ReadToEnd() == "")
            {
                Console.WriteLine("Пусто");

            }
            else Console.WriteLine(reader2.ReadToEnd());
            reader.Close();
            reader2.Close();
        }*/

        public static void InputAgency(ref List<Agency> agency, ref List<Owner> owner)
        {
            do
            {
                Console.WriteLine("Просмотреть список агенств - 1, добавить новое - 2, удалить-3, Закончить - 4");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                   Files.OpenFile1(a1);
                    Console.WriteLine("Хотите подробную информацию? 1-да, 2-нет");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    if (a3 == 1)
                    {
                        Console.WriteLine("Введите Агенство");
                        string dop1 = Console.ReadLine();
                        Owner.dop(ref owner, dop1);
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine("Введите Наименование, номер телефона и адресс агенства:");
                    agency.Add(new Agency(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()) { });
                    Console.WriteLine("Готово");
                }
                if (a == 3)
                {
                    Console.WriteLine("Введите Название агенства, которое вы хотите удалить:");
                    string DeleteAgency = Console.ReadLine();
                    FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Agency.txt", FileMode.Create); //создаем файловый поток
                    StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
                    foreach (Agency p in agency)
                    {
                        if (p.Name == DeleteAgency)
                        {
                            agency.Remove(p);
                            break;
                        }
                        //else { Console.WriteLine("Нет такого человека"); }  
                    }
                    foreach (Agency p in agency)
                    {
                        writer.Write("\n" + p.Name + "\n" + p.Phone + "\n" + p.Adress + "\n---------------"); //записываем в файл
                    }
                    writer.Close();
                }
                if (a == 4) break;
            } while (true);
        }

        
    }
}
