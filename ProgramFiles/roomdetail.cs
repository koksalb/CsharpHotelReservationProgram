using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project7
{
    /// <summary>
    /// main object that has information for a room inside
    /// </summary>
    public class roomdetail
    {
        private string[] name;//name of people living in the room as string array
        private string[] lastname;//lastname of people living in the room as string array
        
        DateTime checkindate;//every room will have only one checkindate for everyone
        DateTime checkoutdate;//every room will have only one checkoutdate for everyone

        RoomType roomtype;//room type coming from enum class

        int picturenumber;//picturenumber as integer which will be used to put picture to the picturebox from the imagelist

        int money;//money that has to be paid by all

        private int capacity;//room capacity depending on the roomtype

        /// <summary>
        /// Property of roomtype
        /// </summary>
        public RoomType Roomtype
        {
            get { return this.roomtype; }
            set { this.roomtype = value; }
        }

        /// <summary>
        /// Property of Name
        /// </summary>
        public string[] Name
        {
            get
            {
                string[] target = new string[this.name.Length];
                Array.Copy(this.name, target, this.name.Length);
                return FixStringArray(target);
            }
            set { this.name = value; }
        }

        /// <summary>
        /// Property of Lastname
        /// </summary>
        public string[] Lastname
        {
            get
            {
                string[] target = new string[this.lastname.Length];
                Array.Copy(this.lastname, target, this.lastname.Length);
                return FixStringArray(target);
            }
            set { this.lastname = value; }
        }

        /// <summary>
        /// Property of checkindate
        /// </summary>
        public DateTime Checkindate
        {
            get { return this.checkindate; }
            set { this.checkindate = value; }
        }

        /// <summary>
        /// Property of checkoutdate
        /// </summary>
        public DateTime Checkoutdate
        {
            get { return this.checkoutdate; }
            set { this.checkoutdate = value; }
        }

        /// <summary>
        /// Property of money
        /// </summary>
        public int Money { get { return this.money; } set { this.money = value; } }

        /// <summary>
        /// Property of picturenumber which i need to access from second form so it is public too
        /// </summary>
        public int Picturenumber { get { return Getpicturenumber(); } set { this.picturenumber = value; } }

        /// <summary>
        /// Property of capacity
        /// </summary>
        public int Capacity { get { return this.capacity; } set { this.capacity = value; } }

        /// <summary>
        /// Property of maxnumberofpeople which is the name lenght which will be 10. just to be sure
        /// </summary>
        public int MaxNumOfPeople
        {
            get { return name.Length; }
        }

        /// <summary>
        /// Property of roomdetail which will create a roomdetail object with defaultvalues inside of it to be filled afterwards
        /// </summary>
        public roomdetail(int roomcapacity)
        {
            name = new string[roomcapacity];
            lastname = new string[roomcapacity];
            DefaultValues();
        }

        /// <summary>
        /// Method which I use to take capacity of a roomtype to be assigned to objects later on
        /// </summary>
        public int GetCapacity(RoomType x)
        {
            if (x == RoomType.Single_Room) { return 1; }
            if (x == RoomType.Double_Room) { return 2; }
            if (x == RoomType.Family_Room) { return 4; }
            if (x == RoomType.Lux_Room) { return 1; }
            if (x == RoomType.Dormitory_Room) { return 8; }
            return 0;
        }

        /// <summary>
        /// Method that puts defaultvalues to an object
        /// </summary>
        public void DefaultValues()
        {
            //10 times
            for (int index = 0; index < MaxNumOfPeople; index++)
            {
                name[index] = string.Empty;
                lastname[index] = string.Empty;                
            }
            //1 times
            checkindate = DateTime.Now;
            checkoutdate = DateTime.Now;
            roomtype = RoomType.Single_Room;
            capacity = GetCapacity(roomtype);
            money = Getmoney();
        }

        /// <summary>
        /// Method that finds the first empty place in the name list which will be the same for lastname list too because everyone has one name and one lastname
        /// </summary>
        private int FindVacantPosition()
        {
            bool ok = false;

            Name = FixStringArray(Name);
            Lastname = FixStringArray(Lastname);

            int i = 0;
            do
            {
                if (name[i] == "")//found
                    ok = true;
                else
                    i++;  //go to next

            } while (!ok && CheckIndex(i));

            //return -1 if ok is still true and i if ok is false which means i found it
            return (ok ? i : -1);
        }

        /// <summary>
        /// Method that checks if index is in the range of name array. which will be same for the lastname list too since everyone will have one of them each.
        /// </summary>
        private bool CheckIndex(int index)
        {
            bool valid = true;
            if (index > name.Length) { valid = false; }
            if (index < 0) { valid = false; }
            return valid;

        }

        /// <summary>
        /// Method that checks if input values are valid then adds them to the list
        /// </summary>
        public bool AddPerson(string inputname, string inputlastname)
        {
            bool ok = true;
            
            int index = FindVacantPosition();

            
            if (index >= 0)
            {
                name[index] = inputname;
                lastname[index] = inputlastname;
            }
            else { ok = false; }
            return ok;
        }

        /// <summary>
        /// Method that finds the object and deletes it from the list of name and lastname
        /// </summary>
        public bool DeletePerson(int index)
        {
            bool deleted = true;
            if (CheckIndex(index))
            {
                name[index] = string.Empty;
                lastname[index] = string.Empty;
            }
            else
            {
                deleted = false;
            }
            return deleted;
        }

        public bool ChangePerson(int index, string inputname, string inputlastname)
        {
            DeletePerson(index);//each time you try change an index i will use this method to make it string.Empty first! then add another one

            bool bok = true;
            if (CheckIndex(index))
            {
                name[index] = inputname;
                lastname[index] = inputlastname;
            }
            else
            {
                bok = false;
            }
            return bok;
        }

        /// <summary>
        /// Method that finds the numberofpeople in that room specifictly
        /// </summary>
        public int CurrentNumOfCostumers()
        {
            int count = 0;
            for (int index = 0; index < name.Length; index++)
            {
                if (!string.IsNullOrEmpty(name[index]))//name or lastname doesnt matter they both have to be exist for one person
                { count++; }
            }
            return count;
        }

        /// <summary>
        /// Method that returns integer money information depending on the roomtype. after all information is set
        /// </summary>
        public int Getmoney()
        {
            int price = 0;
            if (this.Roomtype == RoomType.Single_Room) { price = 20; }
            if (this.Roomtype == RoomType.Double_Room) { price = 35; }
            if (this.Roomtype == RoomType.Family_Room) { price = 78; }
            if (this.Roomtype == RoomType.Lux_Room) { price = 100; }
            if (this.Roomtype == RoomType.Dormitory_Room) { price = 10; }
            
            int nightsofstay = (Checkoutdate - Checkindate).Days;
            if (nightsofstay == 0) { nightsofstay++; }
            price = price * nightsofstay;
            return price;
        }

        /// <summary>
        /// Method that returns to the imagenumber integer that will be used from the imagelist afterwards
        /// </summary>
        public int Getpicturenumber()
        {
            int temp = 0;
            if (this.Roomtype == RoomType.Single_Room) { temp = 0; }
            if (this.Roomtype == RoomType.Double_Room) { temp = 2; }
            if (this.Roomtype == RoomType.Family_Room) { temp = 3; }
            if (this.Roomtype == RoomType.Lux_Room) { temp = 1; }
            if (this.Roomtype == RoomType.Dormitory_Room) { temp = 4; }
            return temp;
        }
        /// <summary>
        /// override string method that will give us the information that we want to add to the listbox in the end
        /// </summary>
        public override string ToString()
        {
            string nightstring;
            if (Checkoutdate == Checkindate) { nightstring = "0"; if (CurrentNumOfCostumers() != 0) { nightstring = "1"; } }
            else { nightstring = ((Checkoutdate - Checkindate).Days).ToString(); }
            string str = Roomtype.ToString() + "     " + CurrentNumOfCostumers().ToString() + " / " + capacity.ToString() +" Total Nights:" +nightstring;
            return str;
        
        }


        /// <summary>
        /// Very very important method that I use to shift list members to the empty slots.
        /// Basicly what it does is: it generates a new stringarray and puts every existing item from old list to this one and returns to it. which will remove every empty spot in the middle of the list. So that there will be no empty slot in the list
        /// This will make it possible to use listbox.Selectedindex all the time even after i delete some items.
        /// </summary>
        public string[] FixStringArray(string [] X)
        {
            string[] temp = new string[X.Length];

            
            for (int i = 0; i < X.Length; i++)
            {
                temp[i] = string.Empty;
            }

            int j = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] != string.Empty) { temp[j] = X[i]; j++; }

            }
            return temp;
        }
        
    }
}
