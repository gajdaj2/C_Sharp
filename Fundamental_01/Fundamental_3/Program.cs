using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_3
{


    class Program
    {
        

        static void Main(string[] args)
        {
         
            GradeBook book = new GradeBook();
            book.AddGrade(5);
            book.AddGrade(89.11f);

            SpeechSynthesizer speak = new SpeechSynthesizer();
            speak.Speak("Dupa Dupa Dupa");
            GradeBook book2 = book;
            book.AddGrade(55);

        }
    }
}
