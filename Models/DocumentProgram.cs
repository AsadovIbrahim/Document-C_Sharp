using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Document_C_.Models
{
    public class DocumentProgram
    {
        private static int _Id;
        private string _Name;
        private string _Description;
        private readonly int _Size;

        public int Id { get { return _Id; } }
        public string Name { get { return _Name; }
            set
            {
                try
                {
                    if (_Name == null || _Name.Length < 3) throw new Exception("Invalid Name!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                _Name = value;
            }
        }
        public string Description { get { return _Description; } set { _Description = value; } }

        //Constructors
        static DocumentProgram() { _Id = 0; }
        public DocumentProgram() { }
        public DocumentProgram(string name, string description, int size)
        {
            _Id = GetCurrentID();
            Name = name;
            Description = description;
            _Size = size;
           
        }
        private int GetCurrentID() { return ++_Id; }
        private int SetSize(int value)
        {
            try
            {
                if (value > 0) return value;
                else throw new Exception("Size can be minimum 1!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return value;
        }
        public void OpenDocument()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Document has opened!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public virtual void EditDocument()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Can Edit in Pro and Expert versions!");
            Console.ForegroundColor = ConsoleColor.White;

        }
        public virtual void SaveDocument()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Can Save in Pro and Expert versions!");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
