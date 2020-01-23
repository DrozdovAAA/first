using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    interface IWritableObject
    {
         void Write(SaveManager man);
    }

    class SaveManager
    {
        FileInfo file;

        public SaveManager(string filename) {
            file = new FileInfo(filename);
            file.CreateText();
        }

        public void WriteLine(string Line) {
            StreamWriter output = file.AppendText();
            output.WriteLine(Line);
            output.Close();
        }

        public void WriteObject(IWritableObject obj) {
            obj.Write(this);
        }
    }
}
