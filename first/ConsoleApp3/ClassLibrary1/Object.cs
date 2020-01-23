using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Object1
    {
        private string TypeOfProperty;
        private string PriceObject;
        private string District;
        private string Street;
        private string NumberHouse;
        private string NumberApartament;
        private string AreaObject;
        private string NumberRoom;
        private string Time;
        private string Details;

        private static string Owner;
        private static string Lodger;
        private static string a1 = "C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Object.txt";
        public static int global = 0;
        static string doop;
        public Object1(string TypeOfProperty, string PriceObject, string District, string Street, string NumberHouse, string NumberApartament, string AreaObject, string NumberRoom, string Time, string Details, string Owner, string Lodger )
        {
            this.TypeOfProperty = TypeOfProperty;
            this.PriceObject = PriceObject;
            this.District = District;
            this.Street = Street;
            this.NumberHouse = NumberHouse;
            this.NumberApartament = NumberApartament;
            this.AreaObject = AreaObject;
            this.NumberRoom = NumberRoom;
            this.Details = Details;
            this.Time = Time;
            setOwner(Owner);
            setLodger(Lodger);
            FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Object.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write(TypeOfProperty + "\n" + PriceObject + "\n" + District + "\n" + Street + "\n" + NumberHouse +
                "\n" + NumberApartament + "\n" + AreaObject + "\n" + NumberRoom +
                "\n" + Time + "\n" + Details + "\n" + Owner +
                "\n" + Lodger + "\n*\n"); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется */
        }

        public Object1(string TypeOfProperty, string PriceObject, string District, string Street, string NumberHouse, string NumberApartament, string AreaObject, string NumberRoom, string Time, string Details,string Owner,string Lodger,ref List<Object1> object1)
        {
            this.TypeOfProperty = TypeOfProperty;
            this.PriceObject = PriceObject;
            this.District = District;
            this.Street = Street;
            this.NumberHouse = NumberHouse;
            this.NumberApartament = NumberApartament;
            this.AreaObject = AreaObject;
            this.NumberRoom = NumberRoom;
            this.Details = Details;
            this.Time = Time;
            setOwner(Owner);
            setLodger(Lodger);
           // Files.InFile(ref object1,a1);
            FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Object.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write("\n" + TypeOfProperty + "\nЦена = " + PriceObject + "\nрайон: " + District + "\nулица: " + Street + "\nномер дома: " + NumberHouse +
                "\nномер квартиры: " + NumberApartament + "\nплощадь: " + AreaObject + "\nколичество комнат: " + NumberRoom +
                "\nвремя сдачи в аренду: " + Time + "\nдетали:" + Details + "\n\nФио владельца:" + Owner +
                "\nИмя квартиросъемщика:" + Lodger + "\n---------------\n"); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется */
        }


        public static void setOwner(string as1) { Owner = as1; }
        public static void setLodger(string as1) { Lodger = as1; }

        public string getTypeOfProperty() { return TypeOfProperty; }
        public string getPriceObject() { return PriceObject; }
        public string getDistrict() { return District; }
        public string getStreet() { return Street; }
        public string getNumberHouse() { return NumberHouse; }
        public string getNumberApartament() { return NumberApartament; }
        public string getAreaObject() { return AreaObject; }
        public string getNumberRoom() { return NumberRoom; }
        public string getDetails() { return Details; }
        public string getOwner() { return Owner; }
        public string getLodger() { return Lodger; }
        public string getTime() { return Time; }
    
        // public static string getTypeOfProperty() { return TypeOfProperty; }

        /*public static void OpenFile1(string a)
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

        /*public static void DataFile(List<Object1> object1) {
            StreamReader sr = new StreamReader(a1); // создаем «потоковый читатель» и связываем его с файловым 
            string line;
            int j = 0;
             string[] mass = new string[30];
            Console.WriteLine("********");

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                  mass[j] = line;
                
                  if (line == "---------------" || line == "---------------")
                  {
                     object1.Add(new Object1(mass[0], mass[1], mass[2], mass[3], mass[4], mass[5], mass[6], mass[7], mass[8], mass[9]));
                    setOwner(mass[10]);
                    setLodger(mass[11]);
                    for (int i = 0; i < j; i++) {
                        Console.WriteLine(mass[i]);
                    }
                    Console.WriteLine("Готово");
                      j = 0;
                  }
                  j++;
            }
            Console.WriteLine("********");
            sr.Close();
    }*/

        public static void InputObject1(ref List<Object1> object1, ref List<Owner> owner)
        {
           /* if (global == 0)
            {
                Files.DataFile(ref object1, a1);

            }*/
            global++;
            
            do
            {
                Console.WriteLine("Просмотреть список недвижимости - 1, добавить новый объект - 2, удалить-3, Закончить - 4, 5 - отладка");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Files.OpenFile1("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Object.txt");
                }
                if (a == 2)
                {
                    Console.WriteLine("Введите тип объекта:");
                    string a1 = Console.ReadLine();
                    Console.WriteLine("Введите цену объекта:");
                    string a2 = Console.ReadLine();
                    Console.WriteLine("Введите район, где находится объект:");
                    string a3 = Console.ReadLine();
                    Console.WriteLine("Введите улицу:");
                    string a4 = Console.ReadLine();
                    Console.WriteLine("Введите номер дома:");
                    string a5 = Console.ReadLine();
                    Console.WriteLine("Введите номер квартиры:");
                    string a6 = Console.ReadLine();
                    Console.WriteLine("Введите площадь объекта:");
                    string a7 = Console.ReadLine();
                    Console.WriteLine("Введите количество комнат:");
                    string a8 = Console.ReadLine();
                    Console.WriteLine("Введите время сдачи объекта в аренду:");
                    string a9 = Console.ReadLine();
                    Console.WriteLine("Введите уточнения:");
                    string a10 = Console.ReadLine();
                    Console.WriteLine("Введит ФИО владельца объека:");
                    Owner = Console.ReadLine();
                    Console.WriteLine("Ввдите номер владельца:");
                    string a12 = Console.ReadLine();
                    Console.WriteLine("Ввдеит агенство, услугами которого пользуется владелец "+Owner);
                    string a11 = Console.ReadLine();
                    owner.Add(new Owner(Owner, a12,a11, ref owner,ref object1));
                    Console.WriteLine("Введит ФИО съемщика объека:");
                    Lodger = Console.ReadLine();

                    object1.Add(new Object1(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10,Owner,Lodger, ref object1) { });

                    Console.WriteLine("Готово");
                }
                if (a == 3)
                {
                    Files.DeleteFil(ref object1,a1);
                }
                if (a == 4) break;
                if (a == 5) { Files.InFile(ref object1, a1); }
            } while (true);
        }

        public static void InputDop(ref List<Object1> object1) {
            Console.WriteLine("Введите тип объекта:");
            string a1 = Console.ReadLine();
            Console.WriteLine("Введите цену объекта:");
            string a2 = Console.ReadLine();
            Console.WriteLine("Введите район, где находится объект:");
            string a3 = Console.ReadLine();
            Console.WriteLine("Введите улицу:");
            string a4 = Console.ReadLine();
            Console.WriteLine("Введите номер дома:");
            string a5 = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры:");
            string a6 = Console.ReadLine();
            Console.WriteLine("Введите площадь объекта:");
            string a7 = Console.ReadLine();
            Console.WriteLine("Введите количество комнат:");
            string a8 = Console.ReadLine();
            Console.WriteLine("Введите время сдачи объекта в аренду:");
            string a9 = Console.ReadLine();
            Console.WriteLine("Введите уточнения:");
            string a10 = Console.ReadLine();
            object1.Add(new Object1(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, Owner, Lodger, ref object1) { });

            Console.WriteLine("Готово");
        }

        public static void InputOwner(ref List<Owner> owner)
        {
            
            /* foreach (Owner p in owner)
             {
                 int i = 0;
                 if (Owner == p.getFIO()) {
                     i++;
                     Console.WriteLine("Такой владелец уже зарегестрирован, хотите посмотреть его данные? 1-да, 2-нет");
                     int c = Convert.ToInt32(Console.ReadLine());
                     if (c == 1) { OpenFile1(p.getA()); }
                     else { break; }
                 }
                 if(Owner != p.getFIO()){
                     Console.WriteLine("Ввдите номер владельца:");
                     owner.Add(new Owner(Owner,Console.ReadLine()));
                 }
             }*/

            // ClassLibrary1.Owner.InputOwner(ref owner);

        }

        public static void dop(ref List<Owner> owner, ref List<Object1> object1,string dop2) {
             
            Console.WriteLine(dop2 + " владеет объектами:");
            foreach (Object1 p in object1) {
                foreach (Owner p2 in owner) {
                    
                    if (dop2 == p2.getFIO()) {
                        if (p2.getFIO() == p.getOwner()) {
                          Console.WriteLine(p.getTypeOfProperty());
                            doop = p2.getAgenccy();
                        }

                    }
                }
            }
            Console.WriteLine("Пользуется услугами агенства по недвижимости: " + doop);
            Console.WriteLine("Хотите добавить объект? 1-да, 2-нет");
            int dop4 = Convert.ToInt32(Console.ReadLine());
            if (dop4 == 1) { InputDop(ref object1); }
            
        }
    }
}


