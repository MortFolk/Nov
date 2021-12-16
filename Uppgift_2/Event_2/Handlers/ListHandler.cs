using Event_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_2.Handlers
{
    internal class ListHandler
    {
        public static List<Participant> participantList = new List<Participant>();


        public static void AddUser(Participant participant)
        {
            participantList.Add(participant);
        }

        public static void RemoveUser(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {

                var _id = Guid.Parse(id);
                participantList = participantList.Where(x => x.Id != _id).ToList();


            }

         
        }

        public static IEnumerable<Participant> GetParticipants()
        {
            return participantList;
        }


    }
}
