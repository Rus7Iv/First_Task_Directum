using System;
using System.Collections.Generic;
using System.Text;

namespace First_Task
{
    class Events
    {
        public int CountOfMembers => countOfMembers; // необходимое количество участников 
        public int CountOfMembersCollected => countOfMembersCollected; // количество собранных участников

        private int countOfMembers;
        private int countOfMembersCollected;
        public bool Verify => CountOfMembersCollected >= CountOfMembers; // проверка, состоится ли мероприятие
        private string descripton; // описание мероприятия
        private DateTime date; // дата мероприятия

        public Events(int CountOfMembers, int CountOfMembersCollected)
        {
            countOfMembers = CountOfMembers;
            countOfMembersCollected = CountOfMembersCollected;
        }

        public string Description
        {
            get => descripton;
            set
            {
                descripton = value;
            }
        }
        
        public DateTime DateOfEvent
        {
            get => date.Date;
            set
            {
                date = value;
            }
        }
    }
}
