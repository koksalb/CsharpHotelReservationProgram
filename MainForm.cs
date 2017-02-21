using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project7
{
    public partial class Mainprogramform : Form
    {
        private const int maxnumberofpeopleinoneroom = 10;//just to be sure i said 10 to this. normally it is 8 for dormitory room which is maximum
        private const int maxnumofrooms = 50;//maximum amount of rooms that your hotel can have.

        roomdetail currRoomdetail = new roomdetail(maxnumberofpeopleinoneroom);//one room object
        roomdetailmanager roomMngr = new roomdetailmanager(maxnumofrooms);//one manager list object


        public Mainprogramform()
        {
            InitializeComponent();
            InitializeGUI();//mine
            AddReadyRoomsToTest();//adding 4 rooms to test the project when startup. you can delete it too or keep it
            UpdateGUI();//update graphical user interface
        }
        /// <summary>
        /// initializegui to startup position
        /// </summary>
        private void InitializeGUI()
        {
            roomtypecombobox.Items.Clear();//clear combobox
            RoomType[] e = (RoomType[])(Enum.GetValues(typeof(RoomType)));//add my enum items
            for (int i = 0; i < e.Length; i++)
            {
                roomtypecombobox.Items.Add(e[i].ToString().Replace("_", " "));//replace _ with spaces in combobox items
            }

            roomtypecombobox.SelectedIndex = (int)currRoomdetail.Roomtype;//choose single room at startup which will be different later on



        }
        /// <summary>
        /// AddRoom button creates a new room object with empty name lastname list and adds it to the manager.
        /// </summary>
        private void addnewroombutton_Click(object sender, EventArgs e)
        {
            if (allroomslistbox.SelectedIndex != -1) { MessageBox.Show("You choose a room from the list then pressed add a room button. You cannot do that. Please unselect your choice then try again."); return; }
            currRoomdetail = new roomdetail(maxnumberofpeopleinoneroom);
            currRoomdetail.Roomtype = (RoomType)roomtypecombobox.SelectedIndex;
            currRoomdetail.Capacity = currRoomdetail.GetCapacity((RoomType)roomtypecombobox.SelectedIndex);
            roomMngr.Add(currRoomdetail.Name, currRoomdetail.Lastname, currRoomdetail.Checkindate, currRoomdetail.Checkoutdate, currRoomdetail.Roomtype, currRoomdetail.Money,currRoomdetail.Capacity);
            UpdateGUI();
        }

        /// <summary>
        /// Updates the form. clears the lists and fills them again. fixes lists. generates radiobuttonchoices.refreshes totalroomlabel
        /// </summary>
        private void UpdateGUI() {

            string[] roomliststrings = roomMngr.roomdetailmanagertostring();
            allroomslistbox.Items.Clear();
            allroomslistbox.Items.AddRange(roomliststrings);
            roomMngr.Roomlist = roomMngr.FixList(roomMngr.Roomlist);
            radiobuttonfunction();
            Totalroomslabel.Text = "Total Rooms: "+roomMngr.CurrentNumOfRooms().ToString();
            

            
        
        }

        /// <summary>
        /// checks if the room is empty or not. if it is empty then deletes it. then in the end currroomdetail will be an empty object to be filled again.
        /// </summary>
        private void deleteroombutton_Click(object sender, EventArgs e)
        {
            if (allroomslistbox.SelectedIndex == -1) { MessageBox.Show("Error. You shouldnt be able to press this button when there is a choice you made from the listbox below."); return; }
            if (allroomslistbox.SelectedIndex != -1)
            {
                if (roomMngr.GetroomdetailAt(allroomslistbox.SelectedIndex).CurrentNumOfCostumers() == 0)
                {
                    roomMngr.DeleteElement(allroomslistbox.SelectedIndex);
                    allroomslistbox.Items.RemoveAt(allroomslistbox.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("You cannot delete a room when there is/are " + roomMngr.GetroomdetailAt(allroomslistbox.SelectedIndex).CurrentNumOfCostumers().ToString() + "costumer(s) inside! Cancel reservation or delete costumers first.");
                }
            }
            else { MessageBox.Show("You cannot delete a room without selecting it from the list!"); }

            currRoomdetail = new roomdetail(maxnumberofpeopleinoneroom);//after deleting a recipe i will use this line to delete everything else about that recipe.
            UpdateGUI();//then update in the end

        }


        /// <summary>
        /// generates the usual parts for object. then opens the other form and sends it to there inside as a parameter to be filled other information there.
        /// </summary>
        private void reserveroombutton_Click(object sender, EventArgs e)
        {
            if (allroomslistbox.SelectedIndex == -1) { MessageBox.Show("You did not choose a valid room to edit or reserve.Error"); return; }
            currRoomdetail = roomMngr.GetroomdetailAt(allroomslistbox.SelectedIndex);
            int index = allroomslistbox.SelectedIndex;
            currRoomdetail.Roomtype = (RoomType)roomtypecombobox.SelectedIndex;
            currRoomdetail.Capacity = currRoomdetail.GetCapacity((RoomType)roomtypecombobox.SelectedIndex);
            RoomDetailForm dlg = new RoomDetailForm(currRoomdetail);
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                roomMngr.ChangeElement(index, currRoomdetail);
            }
            UpdateGUI();
        }

        /// <summary>
        /// if there are people in the selected room. cancels reservation by deleting everyone from that list. and refreshes checkinoutdates. if there are noone gives error.
        /// </summary>
        private void cancelreservationbutton_Click(object sender, EventArgs e)
        {
            if (allroomslistbox.SelectedIndex == -1) { MessageBox.Show("You did not choose a valid room to cancel.Error"); return; }
           
            currRoomdetail = new roomdetail(currRoomdetail.GetCapacity((RoomType)roomtypecombobox.SelectedIndex));
           currRoomdetail= roomMngr.GetroomdetailAt(allroomslistbox.SelectedIndex);
           currRoomdetail.DefaultValues();
           currRoomdetail.Roomtype = (RoomType)roomtypecombobox.SelectedIndex;
           currRoomdetail.Capacity = currRoomdetail.GetCapacity((RoomType)roomtypecombobox.SelectedIndex);
           UpdateGUI();
        }

        /// <summary>
        /// when you choose a room from allroomslistbox it will put its information into form. then tries to find it from list2 is found selects it. if not keeps it empty.
        /// </summary>
        private void allroomslistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (allroomslistbox.SelectedIndex >= 0)
            {
                if (roomMngr.GetroomdetailAt(allroomslistbox.SelectedIndex) != null)
                {
                    currRoomdetail = roomMngr.GetroomdetailAt(allroomslistbox.SelectedIndex);
                    roomtypecombobox.SelectedIndex = (int)currRoomdetail.Roomtype;
                }


                int test = qualifiedroomslistbox.FindString(allroomslistbox.SelectedItem.ToString(), -1);
                if (test >= 0)
                {
                    qualifiedroomslistbox.SelectedIndex = test;
                }
                else { qualifiedroomslistbox.SelectedIndex = -1; }

                


            }


            //this part is for buttons enable disable options. I do not want the user to be able to click addroom when some room is chosen or delete when nothing is chosen.
            if (allroomslistbox.SelectedIndex == -1)
            {
                reserveroombutton.Enabled = false;
                cancelreservationbutton.Enabled = false;
                if (roomtypecombobox.SelectedIndex != -1)
                {                  
                    changeroomtypebutton.Enabled = false;
                    deleteroombutton.Enabled = false;
                   
                }
            }
            else
            {
                changeroomtypebutton.Enabled = true;
                deleteroombutton.Enabled = true;

                reserveroombutton.Enabled = true;

                if (currRoomdetail.CurrentNumOfCostumers() != 0) { reserveroombutton.Text = "Edit Room"; cancelreservationbutton.Enabled = true; }
                else { reserveroombutton.Text = "Reserve Room"; cancelreservationbutton.Enabled = false; }
            }


            
        }

        /// <summary>
        /// You can change a rooms type to a bigger room. but not to a smaller one. because it might cause problems
        /// </summary>
        private void changeroomtypebutton_Click(object sender, EventArgs e)
        {
            if (allroomslistbox.SelectedIndex == -1) { MessageBox.Show("Error. You cannot do this while an item is selected from listbox."); return; }
            currRoomdetail =  roomMngr.GetroomdetailAt(allroomslistbox.SelectedIndex);
            if ((int)currRoomdetail.Capacity > currRoomdetail.GetCapacity((RoomType)roomtypecombobox.SelectedIndex)) {MessageBox.Show("New type is smaller than before. This may cause problems with the code so you cannot do this."); return; }
            currRoomdetail.Roomtype=(RoomType)roomtypecombobox.SelectedIndex;
            currRoomdetail.Capacity=currRoomdetail.GetCapacity((RoomType)roomtypecombobox.SelectedIndex);

            roomMngr.ChangeElement(allroomslistbox.SelectedIndex, currRoomdetail);
            UpdateGUI();
        }



        /// <summary>
        /// depending on the radiobutton choice this function will edit the text in qualifiedroomslistbox. to show which kind of qualified look that user needs.
        /// </summary>
        private void radiobuttonfunction()
        {
            if (allroomsradiobutton.Checked == true)
            {
                string[] roomliststrings = roomMngr.roomdetailmanagertostring();
                allroomslistbox.Items.Clear();
                qualifiedroomslistbox.Items.Clear();
                allroomslistbox.Items.AddRange(roomliststrings);
                for (int i = 0; i < roomliststrings.Length; i++)
                {

                    if (roomMngr.Roomlist[i].CurrentNumOfCostumers() == 0) { qualifiedroomslistbox.Items.Add(roomliststrings[i] + " Available to book "); }
                    if (roomMngr.Roomlist[i].CurrentNumOfCostumers() != 0) { qualifiedroomslistbox.Items.Add(roomliststrings[i] + " Checkout:" + roomMngr.Roomlist[i].Checkoutdate.ToString("dd:MM:yyyy")); }

                }
            }

                if (emptyroomsradiobutton.Checked == true)
                {

                    string[] roomliststrings = roomMngr.roomdetailmanagertostring();
                    qualifiedroomslistbox.Items.Clear();

                    for (int i = 0; i < roomliststrings.Length; i++)
                    {
                        if (roomMngr.Roomlist[i].CurrentNumOfCostumers() == 0) { qualifiedroomslistbox.Items.Add(roomliststrings[i] + " Available to book "); }
                    }


                }


                if (reservedroomsradiobutton.Checked == true)
                {

                    string[] roomliststrings = roomMngr.roomdetailmanagertostring();
                    qualifiedroomslistbox.Items.Clear();

                    for (int i = 0; i < roomliststrings.Length; i++)
                    {
                        if (roomMngr.Roomlist[i].CurrentNumOfCostumers() != 0) { qualifiedroomslistbox.Items.Add(roomliststrings[i] + " Checkout:" + roomMngr.Roomlist[i].Checkoutdate.ToString("dd:MM:yyyy")); }
                    }

                }

            }

        /// <summary>
        /// when you choose another one this will trigger and execute same function again.
        /// </summary>
        private void radiounselectbutton_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonfunction();
            
        }

        /// <summary>
        /// when you choose another one this will trigger and execute same function again.
        /// </summary>
        private void radioreserveroombutton_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonfunction();
        }

        /// <summary>
        /// when you choose another one this will trigger and execute same function again.
        /// </summary>
        private void radiocancelreservationbutton_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonfunction();
        }

        /// <summary>
        /// unselects your option from listbox. i didnt put an updateGUI here because updategui has this too that was causing infinite loop.
        /// </summary>
        private void unselectbutton_Click(object sender, EventArgs e)
        {
            
            allroomslistbox.SelectedIndex = -1;
            
            
        }




        /// <summary>
        /// 4 rooms that I added for you to test the program with every property that it has.
        /// </summary>
        public void AddReadyRoomsToTest()
        {
            //test room 1
            currRoomdetail = new roomdetail(maxnumberofpeopleinoneroom);
            currRoomdetail.Roomtype = RoomType.Single_Room;
            currRoomdetail.Capacity = currRoomdetail.GetCapacity(RoomType.Single_Room);
            roomMngr.Add(currRoomdetail);

            //test room 2
            currRoomdetail = new roomdetail(maxnumberofpeopleinoneroom);
            currRoomdetail.Roomtype = RoomType.Double_Room;
            currRoomdetail.Capacity = currRoomdetail.GetCapacity(RoomType.Double_Room);
            currRoomdetail.AddPerson("Berkay","KÖKSAL");
            currRoomdetail.AddPerson("Ayberk", "KÖKSAL");
            currRoomdetail.Checkindate = DateTime.Now;
            currRoomdetail.Checkoutdate = (currRoomdetail.Checkindate.AddDays(4));
            roomMngr.Add(currRoomdetail);

            //test room 3
            currRoomdetail = new roomdetail(maxnumberofpeopleinoneroom);
            currRoomdetail.Roomtype = RoomType.Family_Room;
            currRoomdetail.Capacity = currRoomdetail.GetCapacity(RoomType.Family_Room);
            roomMngr.Add(currRoomdetail);

            //test room 4
            currRoomdetail = new roomdetail(maxnumberofpeopleinoneroom);
            currRoomdetail.Roomtype = RoomType.Dormitory_Room;
            currRoomdetail.Capacity = currRoomdetail.GetCapacity(RoomType.Dormitory_Room);
            currRoomdetail.AddPerson("Adrian", "Rekalde");
            currRoomdetail.AddPerson("Elisabeth", "Rouvier");
            currRoomdetail.AddPerson("Michelle", "Thompson");
            currRoomdetail.Checkindate = DateTime.Now;
            currRoomdetail.Checkoutdate = (currRoomdetail.Checkindate.AddDays(3));
            roomMngr.Add(currRoomdetail);


            currRoomdetail = new roomdetail(maxnumberofpeopleinoneroom);
        
        }

        /// <summary>
        /// when you choose another item form qualifiedroomslistbox it is certain that it will be in allroomslistbox too. but only first 20 characters from the string. because whole string is different. but first 20 is same something like: "roomtype people/capacity " this part is same
        /// </summary>
        private void qualifiedroomslistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (qualifiedroomslistbox.SelectedIndex != -1)
            {
                string halfstr = new string(qualifiedroomslistbox.SelectedItem.ToString().Take(20).ToArray());
                allroomslistbox.SelectedIndex = allroomslistbox.FindString(halfstr, -1);
            }

        }

   
    }
}
