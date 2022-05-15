using System;
using System.Collections.Generic;
using System.Text;

namespace First_Task
{
    class Events
    {
        public int CountOfMembers => countOfMembers; // ����������� ���������� ���������� 
        public int CountOfMembersCollected => countOfMembersCollected; // ���������� ��������� ����������

        private int countOfMembers;
        private int countOfMembersCollected;
        public bool Verify => CountOfMembersCollected >= CountOfMembers; // ��������, ��������� �� �����������
        private string descripton; // �������� �����������
        private DateTime date; // ���� �����������

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
