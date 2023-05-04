using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_C_.Models
{
    public class ProDocumentProgram:DocumentProgram
    {
        public override sealed void EditDocument()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Document Edited!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void SaveDocument()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet!");
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
