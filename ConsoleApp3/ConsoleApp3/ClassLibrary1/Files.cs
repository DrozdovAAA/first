using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Files
    {
        public static void OpenFile1(string a)
        {
            FileStream file = new FileStream(a, FileMode.Open); //открывает файл только на чтение
            StreamReader reader = new StreamReader(file); // создаем «потоковый читатель» и связываем его с файловым потоком 
           

            Console.WriteLine(reader.ReadToEnd());
            
           
            reader.Close();
            
        }

       /* public static void DataFile(ref List<Object1> object1, string a1)
        {
            StreamReader sr = new StreamReader(a1); // создаем «потоковый читатель» и связываем его с файловым 
            string line;
            int j = 0;
            string[] mass = new string[12];
            Console.WriteLine("********");

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                mass[j] = line;
                
                if (line == "*")
                {
                   
                    object1.Add(new *Object1(mass[0], mass[1], mass[2], mass[3], mass[4], mass[5], mass[6], mass[7], mass[8], mass[9], mass[10],mass[11]));
                    
                }
            }
            sr.Close();
        }
        */
        public static void DeleteFil(ref List<Object1> object1,string a) {
            Console.WriteLine("Введите объект, который вы хотите удалить");
            string DeleteOwner = Console.ReadLine();
            FileStream file1 = new FileStream("C:\\Users\\79889\\source\\repos\\ConsoleApp3\\Files\\Object.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            foreach (Object1 p in object1)
            {
                if (p.getTypeOfProperty() == DeleteOwner)
                {
                    object1.Remove(p);
                    break;
                }
                //else { Console.WriteLine("Нет такого человека"); }  
            }
            foreach (Object1 p in object1)
            {
                writer.Write("\n" + p.getTypeOfProperty() + p.getPriceObject() + p.getDistrict() + p.getStreet() +
                    p.getNumberHouse() + p.getNumberApartament() +
                   p.getAreaObject() + p.getNumberRoom() +
                    p.getTime() + p.getDetails()); //записываем в файл
            }
            writer.Close();
        }
        
        public static void InFile(ref List<Object1> object1,string a) {
            FileStream file1 = new FileStream(a, FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            foreach (Object1 p in object1) {
                writer.Write(p.getTypeOfProperty() + "\nцена:" + p.getPriceObject()+ "\nрайон"+ p.getDistrict() +"\nулица:"+p.getStreet()+
                    "\nномер дома:"+p.getNumberHouse()+"\nномер квартиры:"+p.getNumberApartament()+
                    "\nплощадь:"+p.getAreaObject()+"\nколичество комнат:"+p.getNumberRoom()+
                    "\nвремя:"+p.getTime()+"\nдетали:"+p.getDetails()+"\n*"); //записываем в файл
            }
           
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
            file1.Close();
        }


        public static void DeleteFil(ref List<Owner> owner, string a)
        {
            Console.WriteLine("Введите ФИО владельца, которого вы хотите удалить");
            string DeleteOwner = Console.ReadLine();
            FileStream file1 = new FileStream(a, FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            foreach (Owner p in owner)
            {
                if (p.getFIO() == DeleteOwner)
                {
                    owner.Remove(p);
                    break;
                }
                //else { Console.WriteLine("Нет такого человека"); }  
            }
            foreach (Owner p in owner)
            {
                writer.Write("\n" + p.getFIO() +" "+ p.getPhone()); //записываем в файл
            }
            writer.Close();
        }

    }
}
