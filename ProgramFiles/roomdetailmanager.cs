using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project7
{
    /// <summary>
    /// RoomManager object will keep my rooms inside the roomlist array.Not list.
    /// </summary>
    public class roomdetailmanager
    {
        private roomdetail[] roomlist;//this list will keep every rooms information which will have a size of max 50 items

        public roomdetailmanager(int maxNumOfRooms)
        {
            roomlist = new roomdetail[maxNumOfRooms];
        }

        /// <summary>
        /// Method that first fixes the list for possible empty slots. then finds the first empty slot which will be the end in every case.
        /// </summary>
        public int FindVacantPosition()
        {
            roomlist = FixList(roomlist);
            for (int index = 0; index < roomlist.Length; index++)
            {
                if (roomlist[index] == null) { return index; }
            }
            return -1;
        }


        public roomdetail[] Roomlist {

            get { return this.roomlist; }
            set { roomlist = value; }
        }
        /// <summary>
        /// Method that checks if input integer is inside the array sizes
        /// </summary>
        private bool CheckIndex(int index)
        {
            bool valid = true;
            if (index > roomlist.Length) { valid = false; }
            if (index < 0) { valid = false; }
            return valid;

        }

        /// <summary>
        /// Method that returns to the roomdetail object in the index. spot in the list.if it is null it will return to null
        /// </summary>
        public roomdetail GetroomdetailAt(int index)
        {
            
            if (CheckIndex(index))
            { if (roomlist[index] != null) { return roomlist[index]; } else { index++; return GetroomdetailAt(index); } }
            else
                return null;
        }

        /// <summary>
        /// Add method one which takes only the roomdetail to add
        /// </summary>
        public bool Add(roomdetail newroomdetail)
        {
            bool ok = true;
            int index = FindVacantPosition();

            if (index >= 0)
            {
                roomlist[index] = newroomdetail;
            }
            else { ok = false; }
            return ok;

        }
        /// <summary>
        /// Add method two which requires every information individually
        /// </summary>
        public bool Add(string[] name, string[] lastname, DateTime checkindate, DateTime Checkoutdate,RoomType roomtype, int money,int capacity)
        {
            bool ok = true;
            int index = FindVacantPosition();
            if (index >= 0)
            {
                roomdetail roomdetailobject = new roomdetail(name.Length);
                roomdetailobject.Name = name;
                roomdetailobject.Lastname = lastname;
                roomdetailobject.Checkindate = checkindate;
                roomdetailobject.Checkoutdate = Checkoutdate;
                roomdetailobject.Roomtype = roomtype;
                roomdetailobject.Money = money;
                roomdetailobject.Capacity = capacity;

                roomlist[index] = roomdetailobject;
            }
            else { ok = false; }


            return ok;

        }

        /// <summary>
        /// Change method which will change index. element to newroomdetail
        /// </summary>
        public bool ChangeElement(int index, roomdetail newroomdetail)
        {
            bool check = true;

            if (CheckIndex(index))
            {
                roomlist[index] = newroomdetail;
            }
            else { check = false; }
            return check;
        }

        /// <summary>
        /// delete method to delete a room from the list. which will cause an empty slot in the list. then the fixarray will fix it so no problem to have an empty slot here
        /// </summary>
        public bool DeleteElement(int index)
        {
            bool deleted = true;
            if (CheckIndex(index))
            {
               roomlist[index] = null;
            }
            else { deleted = false; }
            return deleted;
        }

        /// <summary>
        /// returns to an integer which will give us the number of total rooms. public because i need it on the main form
        /// </summary>
        public int CurrentNumOfRooms()
        {
            int count = 0;
            for (int index = 0; index < roomlist.Length; index++)
            {
                if (roomlist[index] != null)//not null
                { count++; }
            }
            return count;
        }

        /// <summary>
        /// takes every not null element from the array and puts them in a new array which it will return in the end. it replaces _'s in the enum class and replaces them with space to make it look better.
        /// Note to self: integer i and j are used in this loop so be careful when making a change here.
        /// </summary>
        public string[] roomdetailmanagertostring()
        {
            int itemcount = CurrentNumOfRooms();
            string[] strOut = new string[itemcount];
            int j = 0;
            for (int i = 0; i < itemcount; i++)
            {
                if (roomlist[i] != null) { strOut[j] = roomlist[i].ToString().Replace("_"," "); j++; }
                else { itemcount++; }
            }
            return strOut;
        }

        /// <summary>
        /// A perfect method that deletes empty slots in an array, by generating a new array to put everything in then returns to that one. so you can make it equal to a lsit to remove every empty spot inside.
        /// Note to self: integer i and j are used in this loop so be careful when making a change here.
        /// </summary>
        public roomdetail[] FixList(roomdetail[] m_list) {
            
            roomdetail[] newlist = new roomdetail[m_list.Length];
            for (int i = 0; i < roomlist.Length; i++)
            {
                newlist[i] = null;
            }

            int j = 0;
            for (int i = 0; i < roomlist.Length; i++) {
                if (roomlist[i] != null) { newlist[j] = roomlist[i]; j++; }
            
            }
            return newlist;
        }
    
    
    
    }
}
