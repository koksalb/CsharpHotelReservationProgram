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
    public partial class RoomDetailForm : Form
    {
        roomdetail m_roomdetail;//one room object
        public RoomDetailForm(roomdetail roomdetailmain)//form object that comes with one roomobject from the mainform with roomtype information only. so that I will fill the rest here
        {
            InitializeComponent();
            m_roomdetail=roomdetailmain;//taking input room to code.
            InitializeGUI();//initialize things
            this.Text = roomdetailmain.Roomtype.ToString().Replace("_"," ") + " Costumer Edit Form";//putting form title!
            roompicturepicturebox.Size = new System.Drawing.Size(256, 256);//arranging picturebox to be square
            roompicturepicturebox.Image=imagelistforrooms.Images[roomdetailmain.Picturenumber];//adding the picture for this roomtype which i use the picturenumber property from roomdetail file
            roomtypelabel.Text = roomdetailmain.Roomtype.ToString().Replace("_", " ") + " Picture";//adding roomtype text on the picture
        }


        /// <summary>
        /// add person button will check if name or lastname is empty or not. if they both are valid it will add this to room object. then it will take dates and other details.
        /// </summary>
        private void addpersonbutton_Click(object sender, EventArgs e)
        {

            if (costumerslistbox.SelectedIndex != -1) { MessageBox.Show("Error. You choose someone from the listbox then clicked add. You cannot do that."); return; }
            if (checkinputinformation())
            {
                if (m_roomdetail.CurrentNumOfCostumers() < m_roomdetail.Capacity)
                {
                    m_roomdetail.AddPerson(costumernametextbox.Text, costumerlastnametextbox.Text);
                    m_roomdetail.Checkindate = checkindatetimepicker.Value;
                    m_roomdetail.Checkoutdate = checkoutdatetimepicker.Value;
                }
                else { MessageBox.Show("This room has reached its limit please check your execution."); }
                UpdateGUI();
            }
        }

        /// <summary>
        /// updates: textboxes, listbox items, moneytotal, moneyeach, then listbox selected item will be -1 because you completed one execution
        /// </summary>
        public void UpdateGUI()
        {
            costumernametextbox.Text = "";
            costumerlastnametextbox.Text = "";
            costumerslistbox.Items.Clear();
            
            for (int i = 0; i < m_roomdetail.Name.Length; i++)
            {
                if (m_roomdetail.Name[i] != "") { costumerslistbox.Items.Add(m_roomdetail.Name[i] + "  " + m_roomdetail.Lastname[i] + " Checkin:" + m_roomdetail.Checkindate.ToString("dd:MM:yyyy") + " Checkout:" + m_roomdetail.Checkoutdate.ToString("dd:MM:yyyy")); }
            }
            totalamounttopaylabel2.Text = m_roomdetail.Getmoney().ToString()+" €";
            if (m_roomdetail.CurrentNumOfCostumers() != 0)
            {
                amounttopayforeachlabel2.Text = (m_roomdetail.Getmoney() / m_roomdetail.CurrentNumOfCostumers()).ToString() + " €";
            }
            else { amounttopayforeachlabel2.Text = "0 €"; }
            nightstostaylabel.Text = "Nights to stay: "+((checkoutdatetimepicker.Value - checkindatetimepicker.Value).Days+1).ToString();
            costumerslistbox.SelectedIndex = -1;

        }
        /// <summary>
        /// deleting a person will cause an empty spot in array. fixstringarray method will fix that afterwards.
        /// </summary>
        private void deletepersonbutton_Click(object sender, EventArgs e)
        {
            if (costumerslistbox.SelectedIndex == -1) { MessageBox.Show("Error. Choose someone first"); return; }
            m_roomdetail.DeletePerson(costumerslistbox.SelectedIndex);
            m_roomdetail.Checkindate = checkindatetimepicker.Value;
            m_roomdetail.Checkoutdate = checkoutdatetimepicker.Value;
            m_roomdetail.Name = m_roomdetail.FixStringArray(m_roomdetail.Name);
            m_roomdetail.Lastname = m_roomdetail.FixStringArray(m_roomdetail.Lastname);

            UpdateGUI();
        }


        /// <summary>
        /// change person will check if name lastname is empty or not. if they are not then you are good to go
        /// </summary>
        private void changeinfopersonbutton_Click(object sender, EventArgs e)
        {
            if (costumerslistbox.SelectedIndex == -1) { MessageBox.Show("Error. Choose someone first"); return; }
            if (checkinputinformation())
            {
                m_roomdetail.ChangePerson(costumerslistbox.SelectedIndex, costumernametextbox.Text, costumerlastnametextbox.Text);
                m_roomdetail.Checkindate = checkindatetimepicker.Value;
                m_roomdetail.Checkoutdate = checkoutdatetimepicker.Value;
                UpdateGUI();
            }
        }

        /// <summary>
        /// when form is load updategui for first time to make everything smooth.
        /// </summary>
        private void RoomDetailForm_Load(object sender, EventArgs e)
        {
            UpdateGUI();
        }
        /// <summary>
        /// in the very very end when you click save this will take Monet input from the form.
        /// </summary>
        private void savereservationbutton_Click(object sender, EventArgs e)
        {
            m_roomdetail.Money = m_roomdetail.Getmoney();
        }

        /// <summary>
        /// startup values
        /// </summary>
        private void InitializeGUI() {
            checkindatetimepicker.Value = m_roomdetail.Checkindate;
            checkoutdatetimepicker.Value = m_roomdetail.Checkoutdate;
        }

        /// <summary>
        /// when you choose someone from listbox it will fill the textboxes and other form objects with information form that object
        /// </summary>
        private void costumerslistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (costumerslistbox.SelectedIndex == -1) { addpersonbutton.Enabled = true; changeinfopersonbutton.Enabled = false; deletepersonbutton.Enabled = false; return; }
            if (costumerslistbox.SelectedIndex != -1) { addpersonbutton.Enabled = false; changeinfopersonbutton.Enabled = true; deletepersonbutton.Enabled = true; }
            costumernametextbox.Text = m_roomdetail.Name[costumerslistbox.SelectedIndex];
            costumerlastnametextbox.Text = m_roomdetail.Lastname[costumerslistbox.SelectedIndex];
        }

        /// <summary>
        /// update checkindate
        /// </summary>
        private void checkindatetimepicker_ValueChanged(object sender, EventArgs e)
        {
            if (checkindatetimepicker.Value > checkoutdatetimepicker.Value) { MessageBox.Show("Checkout date cannot be before the checkin please check your input."); return; }
            m_roomdetail.Checkindate = checkindatetimepicker.Value;
           
            UpdateGUI();
        }

        /// <summary>
        /// update checkoutdate
        /// </summary>
        private void checkoutdatetimepicker_ValueChanged(object sender, EventArgs e)
        {
            if (checkindatetimepicker.Value > checkoutdatetimepicker.Value) { MessageBox.Show("Checkout date cannot be before the checkin please check your input."); return; }
            m_roomdetail.Checkoutdate = checkoutdatetimepicker.Value;
            UpdateGUI();
        }

        /// <summary>
        /// when you start writing something if noone is selected from the listbox it will open addperson button for you
        /// </summary>
        private void costumernametextbox_TextChanged(object sender, EventArgs e)
        {
            if (costumerslistbox.SelectedIndex == -1) { addpersonbutton.Enabled = true; }
        }

        /// <summary>
        /// when you start writing something if noone is selected from the listbox it will open addperson button for you
        /// </summary>
        private void costumerlastnametextbox_TextChanged(object sender, EventArgs e)
        {
            if (costumerslistbox.SelectedIndex == -1) { addpersonbutton.Enabled = true; }
        }

        /// <summary>
        /// unselect button.
        /// </summary>
        private void unselectbutton_Click(object sender, EventArgs e)
        {
            costumerslistbox.SelectedIndex = -1;
            costumernametextbox.Text = "";
            costumerlastnametextbox.Text = "";
        }

        /// <summary>
        /// checks if input form objects are filled right or not.
        /// </summary>
        private bool checkinputinformation(){
         if (costumernametextbox.Text == "") { MessageBox.Show("Name cannot be empty."); return false; }
            if (costumerlastnametextbox.Text == "") { MessageBox.Show("Name cannot be empty."); return false; }
            if (checkindatetimepicker.Value > checkoutdatetimepicker.Value) {  MessageBox.Show("Checkout date cannot be before the checkin please check your input."); return false;  }
            return true;
        }
    }
}
