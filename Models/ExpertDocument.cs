using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_C_.Models
{
    public class ExpertDocument:ProDocumentProgram
    {
        public override sealed void SaveDocument()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Document Saved in pdf format!");
            Console.ForegroundColor = ConsoleColor.White;
           
        }
    }
}
