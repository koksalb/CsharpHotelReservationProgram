namespace project7
{
    partial class Mainprogramform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allroomslistbox = new System.Windows.Forms.ListBox();
            this.reserveroombutton = new System.Windows.Forms.Button();
            this.cancelreservationbutton = new System.Windows.Forms.Button();
            this.roomtypecombobox = new System.Windows.Forms.ComboBox();
            this.addnewroombutton = new System.Windows.Forms.Button();
            this.deleteroombutton = new System.Windows.Forms.Button();
            this.changeroomtypebutton = new System.Windows.Forms.Button();
            this.allroomsradiobutton = new System.Windows.Forms.RadioButton();
            this.emptyroomsradiobutton = new System.Windows.Forms.RadioButton();
            this.reservedroomsradiobutton = new System.Windows.Forms.RadioButton();
            this.qualifiedroomslistbox = new System.Windows.Forms.ListBox();
            this.qualifiedroomgroupbox = new System.Windows.Forms.GroupBox();
            this.unselectbutton = new System.Windows.Forms.Button();
            this.chooseroomtypelabel = new System.Windows.Forms.Label();
            this.Totalroomslabel = new System.Windows.Forms.Label();
            this.qualifiedroomgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // allroomslistbox
            // 
            this.allroomslistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.allroomslistbox.FormattingEnabled = true;
            this.allroomslistbox.ItemHeight = 20;
            this.allroomslistbox.Location = new System.Drawing.Point(12, 169);
            this.allroomslistbox.Name = "allroomslistbox";
            this.allroomslistbox.Size = new System.Drawing.Size(441, 304);
            this.allroomslistbox.TabIndex = 0;
            this.allroomslistbox.SelectedIndexChanged += new System.EventHandler(this.allroomslistbox_SelectedIndexChanged);
            // 
            // reserveroombutton
            // 
            this.reserveroombutton.Enabled = false;
            this.reserveroombutton.Location = new System.Drawing.Point(312, 97);
            this.reserveroombutton.Name = "reserveroombutton";
            this.reserveroombutton.Size = new System.Drawing.Size(141, 23);
            this.reserveroombutton.TabIndex = 2;
            this.reserveroombutton.Text = "Reserve Room";
            this.reserveroombutton.UseVisualStyleBackColor = true;
            this.reserveroombutton.Click += new System.EventHandler(this.reserveroombutton_Click);
            // 
            // cancelreservationbutton
            // 
            this.cancelreservationbutton.Enabled = false;
            this.cancelreservationbutton.Location = new System.Drawing.Point(312, 126);
            this.cancelreservationbutton.Name = "cancelreservationbutton";
            this.cancelreservationbutton.Size = new System.Drawing.Size(141, 23);
            this.cancelreservationbutton.TabIndex = 3;
            this.cancelreservationbutton.Text = "Cancel Reservation";
            this.cancelreservationbutton.UseVisualStyleBackColor = true;
            this.cancelreservationbutton.Click += new System.EventHandler(this.cancelreservationbutton_Click);
            // 
            // roomtypecombobox
            // 
            this.roomtypecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomtypecombobox.FormattingEnabled = true;
            this.roomtypecombobox.Location = new System.Drawing.Point(12, 31);
            this.roomtypecombobox.Name = "roomtypecombobox";
            this.roomtypecombobox.Size = new System.Drawing.Size(121, 21);
            this.roomtypecombobox.TabIndex = 4;
            
            // 
            // addnewroombutton
            // 
            this.addnewroombutton.Location = new System.Drawing.Point(12, 72);
            this.addnewroombutton.Name = "addnewroombutton";
            this.addnewroombutton.Size = new System.Drawing.Size(121, 23);
            this.addnewroombutton.TabIndex = 5;
            this.addnewroombutton.Text = "Add new Room";
            this.addnewroombutton.UseVisualStyleBackColor = true;
            this.addnewroombutton.Click += new System.EventHandler(this.addnewroombutton_Click);
            // 
            // deleteroombutton
            // 
            this.deleteroombutton.Enabled = false;
            this.deleteroombutton.Location = new System.Drawing.Point(12, 130);
            this.deleteroombutton.Name = "deleteroombutton";
            this.deleteroombutton.Size = new System.Drawing.Size(121, 23);
            this.deleteroombutton.TabIndex = 6;
            this.deleteroombutton.Text = "Delete Room";
            this.deleteroombutton.UseVisualStyleBackColor = true;
            this.deleteroombutton.Click += new System.EventHandler(this.deleteroombutton_Click);
            // 
            // changeroomtypebutton
            // 
            this.changeroomtypebutton.Enabled = false;
            this.changeroomtypebutton.Location = new System.Drawing.Point(12, 101);
            this.changeroomtypebutton.Name = "changeroomtypebutton";
            this.changeroomtypebutton.Size = new System.Drawing.Size(121, 23);
            this.changeroomtypebutton.TabIndex = 7;
            this.changeroomtypebutton.Text = "Change Room Type";
            this.changeroomtypebutton.UseVisualStyleBackColor = true;
            this.changeroomtypebutton.Click += new System.EventHandler(this.changeroomtypebutton_Click);
            // 
            // allroomsradiobutton
            // 
            this.allroomsradiobutton.AutoSize = true;
            this.allroomsradiobutton.Checked = true;
            this.allroomsradiobutton.Location = new System.Drawing.Point(41, 13);
            this.allroomsradiobutton.Name = "allroomsradiobutton";
            this.allroomsradiobutton.Size = new System.Drawing.Size(72, 17);
            this.allroomsradiobutton.TabIndex = 8;
            this.allroomsradiobutton.TabStop = true;
            this.allroomsradiobutton.Text = "All Rooms";
            this.allroomsradiobutton.UseVisualStyleBackColor = true;
            this.allroomsradiobutton.CheckedChanged += new System.EventHandler(this.radiounselectbutton_CheckedChanged);
            // 
            // emptyroomsradiobutton
            // 
            this.emptyroomsradiobutton.AutoSize = true;
            this.emptyroomsradiobutton.Location = new System.Drawing.Point(150, 13);
            this.emptyroomsradiobutton.Name = "emptyroomsradiobutton";
            this.emptyroomsradiobutton.Size = new System.Drawing.Size(90, 17);
            this.emptyroomsradiobutton.TabIndex = 9;
            this.emptyroomsradiobutton.Text = "Empty Rooms";
            this.emptyroomsradiobutton.UseVisualStyleBackColor = true;
            this.emptyroomsradiobutton.CheckedChanged += new System.EventHandler(this.radioreserveroombutton_CheckedChanged);
            // 
            // reservedroomsradiobutton
            // 
            this.reservedroomsradiobutton.AutoSize = true;
            this.reservedroomsradiobutton.Location = new System.Drawing.Point(272, 13);
            this.reservedroomsradiobutton.Name = "reservedroomsradiobutton";
            this.reservedroomsradiobutton.Size = new System.Drawing.Size(107, 17);
            this.reservedroomsradiobutton.TabIndex = 10;
            this.reservedroomsradiobutton.Text = "Reserved Rooms";
            this.reservedroomsradiobutton.UseVisualStyleBackColor = true;
            this.reservedroomsradiobutton.CheckedChanged += new System.EventHandler(this.radiocancelreservationbutton_CheckedChanged);
            // 
            // qualifiedroomslistbox
            // 
            this.qualifiedroomslistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.qualifiedroomslistbox.FormattingEnabled = true;
            this.qualifiedroomslistbox.ItemHeight = 20;
            this.qualifiedroomslistbox.Location = new System.Drawing.Point(5, 36);
            this.qualifiedroomslistbox.Name = "qualifiedroomslistbox";
            this.qualifiedroomslistbox.Size = new System.Drawing.Size(441, 164);
            this.qualifiedroomslistbox.TabIndex = 11;
            this.qualifiedroomslistbox.SelectedIndexChanged += new System.EventHandler(this.qualifiedroomslistbox_SelectedIndexChanged);
            // 
            // qualifiedroomgroupbox
            // 
            this.qualifiedroomgroupbox.Controls.Add(this.qualifiedroomslistbox);
            this.qualifiedroomgroupbox.Controls.Add(this.reservedroomsradiobutton);
            this.qualifiedroomgroupbox.Controls.Add(this.emptyroomsradiobutton);
            this.qualifiedroomgroupbox.Controls.Add(this.allroomsradiobutton);
            this.qualifiedroomgroupbox.Location = new System.Drawing.Point(7, 507);
            this.qualifiedroomgroupbox.Name = "qualifiedroomgroupbox";
            this.qualifiedroomgroupbox.Size = new System.Drawing.Size(459, 213);
            this.qualifiedroomgroupbox.TabIndex = 12;
            this.qualifiedroomgroupbox.TabStop = false;
            this.qualifiedroomgroupbox.Text = "Room Display";
            // 
            // unselectbutton
            // 
            this.unselectbutton.Location = new System.Drawing.Point(378, 478);
            this.unselectbutton.Name = "unselectbutton";
            this.unselectbutton.Size = new System.Drawing.Size(75, 23);
            this.unselectbutton.TabIndex = 13;
            this.unselectbutton.Text = "Unselect";
            this.unselectbutton.UseVisualStyleBackColor = true;
            this.unselectbutton.Click += new System.EventHandler(this.unselectbutton_Click);
            // 
            // chooseroomtypelabel
            // 
            this.chooseroomtypelabel.AutoSize = true;
            this.chooseroomtypelabel.Location = new System.Drawing.Point(28, 15);
            this.chooseroomtypelabel.Name = "chooseroomtypelabel";
            this.chooseroomtypelabel.Size = new System.Drawing.Size(92, 13);
            this.chooseroomtypelabel.TabIndex = 14;
            this.chooseroomtypelabel.Text = "Choose room type";
            // 
            // Totalroomslabel
            // 
            this.Totalroomslabel.AutoSize = true;
            this.Totalroomslabel.Location = new System.Drawing.Point(12, 476);
            this.Totalroomslabel.Name = "Totalroomslabel";
            this.Totalroomslabel.Size = new System.Drawing.Size(70, 13);
            this.Totalroomslabel.TabIndex = 15;
            this.Totalroomslabel.Text = "Total Rooms:";
            // 
            // Mainprogramform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 732);
            this.Controls.Add(this.Totalroomslabel);
            this.Controls.Add(this.chooseroomtypelabel);
            this.Controls.Add(this.unselectbutton);
            this.Controls.Add(this.qualifiedroomgroupbox);
            this.Controls.Add(this.changeroomtypebutton);
            this.Controls.Add(this.deleteroombutton);
            this.Controls.Add(this.addnewroombutton);
            this.Controls.Add(this.roomtypecombobox);
            this.Controls.Add(this.cancelreservationbutton);
            this.Controls.Add(this.reserveroombutton);
            this.Controls.Add(this.allroomslistbox);
            this.Name = "Mainprogramform";
            this.Text = "Hotel Reservation Program";
            this.qualifiedroomgroupbox.ResumeLayout(false);
            this.qualifiedroomgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allroomslistbox;
        private System.Windows.Forms.Button reserveroombutton;
        private System.Windows.Forms.Button cancelreservationbutton;
        private System.Windows.Forms.ComboBox roomtypecombobox;
        private System.Windows.Forms.Button addnewroombutton;
        private System.Windows.Forms.Button deleteroombutton;
        private System.Windows.Forms.Button changeroomtypebutton;
        private System.Windows.Forms.RadioButton allroomsradiobutton;
        private System.Windows.Forms.RadioButton emptyroomsradiobutton;
        private System.Windows.Forms.RadioButton reservedroomsradiobutton;
        private System.Windows.Forms.ListBox qualifiedroomslistbox;
        private System.Windows.Forms.GroupBox qualifiedroomgroupbox;
        private System.Windows.Forms.Button unselectbutton;
        private System.Windows.Forms.Label chooseroomtypelabel;
        private System.Windows.Forms.Label Totalroomslabel;
    }
}

