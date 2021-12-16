using Event_2.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event__2.Handlers
{
    internal class FileHandler
    {

        public static void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\Lexicon\List_test\test.csv"))
            {

                var list = ListHandler.GetParticipants();

                sw.WriteLine("id;firstname;lastname;email");

                foreach (var participant in list)
                {
                    sw.WriteLine($"{participant.Id};{participant.FirstName};{participant.LastName};{participant.Email}");
                }
            }
        }

        public static void ReadFromFile()
        {

        }




    }
}
