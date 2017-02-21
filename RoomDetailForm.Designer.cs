namespace project7
{
    partial class RoomDetailForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomDetailForm));
            this.checkindatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.checkoutdatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.costumerslistbox = new System.Windows.Forms.ListBox();
            this.addpersonbutton = new System.Windows.Forms.Button();
            this.changeinfopersonbutton = new System.Windows.Forms.Button();
            this.deletepersonbutton = new System.Windows.Forms.Button();
            this.costumernametextbox = new System.Windows.Forms.TextBox();
            this.costumerlastnametextbox = new System.Windows.Forms.TextBox();
            this.savereservationbutton = new System.Windows.Forms.Button();
            this.totalamounttopaylabel2 = new System.Windows.Forms.Label();
            this.totalamounttopaylabel = new System.Windows.Forms.Label();
            this.unselectbutton = new System.Windows.Forms.Button();
            this.roompicturepicturebox = new System.Windows.Forms.PictureBox();
            this.imagelistforrooms = new System.Windows.Forms.ImageList(this.components);
            this.roomtypelabel = new System.Windows.Forms.Label();
            this.amounttopayforeachlabel = new System.Windows.Forms.Label();
            this.amounttopayforeachlabel2 = new System.Windows.Forms.Label();
            this.nightstostaylabel = new System.Windows.Forms.Label();
            this.checkindatelabel = new System.Windows.Forms.Label();
            this.checkoutdatelabel = new System.Windows.Forms.Label();
            this.costumerinformationgroupbox = new System.Windows.Forms.GroupBox();
            this.costumerlastnamelabel = new System.Windows.Forms.Label();
            this.costumernamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roompicturepicturebox)).BeginInit();
            this.costumerinformationgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkindatetimepicker
            // 
            this.checkindatetimepicker.Location = new System.Drawing.Point(35, 37);
            this.checkindatetimepicker.Name = "checkindatetimepicker";
            this.checkindatetimepicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkindatetimepicker.Size = new System.Drawing.Size(182, 20);
            this.checkindatetimepicker.TabIndex = 0;
            this.checkindatetimepicker.ValueChanged += new System.EventHandler(this.checkindatetimepicker_ValueChanged);
            // 
            // checkoutdatetimepicker
            // 
            this.checkoutdatetimepicker.Location = new System.Drawing.Point(253, 37);
            this.checkoutdatetimepicker.Name = "checkoutdatetimepicker";
            this.checkoutdatetimepicker.Size = new System.Drawing.Size(182, 20);
            this.checkoutdatetimepicker.TabIndex = 1;
            this.checkoutdatetimepicker.ValueChanged += new System.EventHandler(this.checkoutdatetimepicker_ValueChanged);
            // 
            // costumerslistbox
            // 
            this.costumerslistbox.FormattingEnabled = true;
            this.costumerslistbox.Location = new System.Drawing.Point(11, 27);
            this.costumerslistbox.Name = "costumerslistbox";
            this.costumerslistbox.Size = new System.Drawing.Size(289, 173);
            this.costumerslistbox.TabIndex = 2;
            this.costumerslistbox.SelectedIndexChanged += new System.EventHandler(this.costumerslistbox_SelectedIndexChanged);
            // 
            // addpersonbutton
            // 
            this.addpersonbutton.Location = new System.Drawing.Point(404, 99);
            this.addpersonbutton.Name = "addpersonbutton";
            this.addpersonbutton.Size = new System.Drawing.Size(91, 23);
            this.addpersonbutton.TabIndex = 3;
            this.addpersonbutton.Text = "Add Person";
            this.addpersonbutton.UseVisualStyleBackColor = true;
            this.addpersonbutton.Click += new System.EventHandler(this.addpersonbutton_Click);
            // 
            // changeinfopersonbutton
            // 
            this.changeinfopersonbutton.Enabled = false;
            this.changeinfopersonbutton.Location = new System.Drawing.Point(404, 128);
            this.changeinfopersonbutton.Name = "changeinfopersonbutton";
            this.changeinfopersonbutton.Size = new System.Drawing.Size(91, 23);
            this.changeinfopersonbutton.TabIndex = 4;
            this.changeinfopersonbutton.Text = "Change Info";
            this.changeinfopersonbutton.UseVisualStyleBackColor = true;
            this.changeinfopersonbutton.Click += new System.EventHandler(this.changeinfopersonbutton_Click);
            // 
            // deletepersonbutton
            // 
            this.deletepersonbutton.Enabled = false;
            this.deletepersonbutton.Location = new System.Drawing.Point(404, 157);
            this.deletepersonbutton.Name = "deletepersonbutton";
            this.deletepersonbutton.Size = new System.Drawing.Size(91, 23);
            this.deletepersonbutton.TabIndex = 5;
            this.deletepersonbutton.Text = "Delete Person";
            this.deletepersonbutton.UseVisualStyleBackColor = true;
            this.deletepersonbutton.Click += new System.EventHandler(this.deletepersonbutton_Click);
            // 
            // costumernametextbox
            // 
            this.costumernametextbox.Location = new System.Drawing.Point(378, 27);
            this.costumernametextbox.Name = "costumernametextbox";
            this.costumernametextbox.Size = new System.Drawing.Size(132, 20);
            this.costumernametextbox.TabIndex = 6;
            this.costumernametextbox.TextChanged += new System.EventHandler(this.costumernametextbox_TextChanged);
            // 
            // costumerlastnametextbox
            // 
            this.costumerlastnametextbox.Location = new System.Drawing.Point(378, 73);
            this.costumerlastnametextbox.Name = "costumerlastnametextbox";
            this.costumerlastnametextbox.Size = new System.Drawing.Size(132, 20);
            this.costumerlastnametextbox.TabIndex = 7;
            this.costumerlastnametextbox.TextChanged += new System.EventHandler(this.costumerlastnametextbox_TextChanged);
            // 
            // savereservationbutton
            // 
            this.savereservationbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.savereservationbutton.Location = new System.Drawing.Point(178, 741);
            this.savereservationbutton.Name = "savereservationbutton";
            this.savereservationbutton.Size = new System.Drawing.Size(163, 23);
            this.savereservationbutton.TabIndex = 8;
            this.savereservationbutton.Text = "Save Reservation Information";
            this.savereservationbutton.UseVisualStyleBackColor = true;
            this.savereservationbutton.Click += new System.EventHandler(this.savereservationbutton_Click);
            // 
            // totalamounttopaylabel2
            // 
            this.totalamounttopaylabel2.AutoSize = true;
            this.totalamounttopaylabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalamounttopaylabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalamounttopaylabel2.Location = new System.Drawing.Point(286, 104);
            this.totalamounttopaylabel2.Name = "totalamounttopaylabel2";
            this.totalamounttopaylabel2.Size = new System.Drawing.Size(88, 33);
            this.totalamounttopaylabel2.TabIndex = 9;
            this.totalamounttopaylabel2.Text = "label1";
            // 
            // totalamounttopaylabel
            // 
            this.totalamounttopaylabel.AutoSize = true;
            this.totalamounttopaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalamounttopaylabel.Location = new System.Drawing.Point(68, 104);
            this.totalamounttopaylabel.Name = "totalamounttopaylabel";
            this.totalamounttopaylabel.Size = new System.Drawing.Size(212, 25);
            this.totalamounttopaylabel.TabIndex = 10;
            this.totalamounttopaylabel.Text = "Total Amount to Pay:";
            // 
            // unselectbutton
            // 
            this.unselectbutton.Location = new System.Drawing.Point(237, 202);
            this.unselectbutton.Name = "unselectbutton";
            this.unselectbutton.Size = new System.Drawing.Size(75, 23);
            this.unselectbutton.TabIndex = 11;
            this.unselectbutton.Text = "Unselect";
            this.unselectbutton.UseVisualStyleBackColor = true;
            this.unselectbutton.Click += new System.EventHandler(this.unselectbutton_Click);
            // 
            // roompicturepicturebox
            // 
            this.roompicturepicturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roompicturepicturebox.Location = new System.Drawing.Point(103, 219);
            this.roompicturepicturebox.Name = "roompicturepicturebox";
            this.roompicturepicturebox.Size = new System.Drawing.Size(256, 256);
            this.roompicturepicturebox.TabIndex = 12;
            this.roompicturepicturebox.TabStop = false;
            // 
            // imagelistforrooms
            // 
            this.imagelistforrooms.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelistforrooms.ImageStream")));
            this.imagelistforrooms.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelistforrooms.Images.SetKeyName(0, "singleroom.jpg");
            this.imagelistforrooms.Images.SetKeyName(1, "luxroom.jpg");
            this.imagelistforrooms.Images.SetKeyName(2, "Doubleroom.jpg");
            this.imagelistforrooms.Images.SetKeyName(3, "familyroom.jpg");
            this.imagelistforrooms.Images.SetKeyName(4, "dormitoryroom.jpg");
            // 
            // roomtypelabel
            // 
            this.roomtypelabel.AutoSize = true;
            this.roomtypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomtypelabel.Location = new System.Drawing.Point(193, 200);
            this.roomtypelabel.Name = "roomtypelabel";
            this.roomtypelabel.Size = new System.Drawing.Size(45, 16);
            this.roomtypelabel.TabIndex = 13;
            this.roomtypelabel.Text = "label3";
            // 
            // amounttopayforeachlabel
            // 
            this.amounttopayforeachlabel.AutoSize = true;
            this.amounttopayforeachlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amounttopayforeachlabel.Location = new System.Drawing.Point(102, 155);
            this.amounttopayforeachlabel.Name = "amounttopayforeachlabel";
            this.amounttopayforeachlabel.Size = new System.Drawing.Size(178, 20);
            this.amounttopayforeachlabel.TabIndex = 15;
            this.amounttopayforeachlabel.Text = "Amount to pay for each:";
            // 
            // amounttopayforeachlabel2
            // 
            this.amounttopayforeachlabel2.AutoSize = true;
            this.amounttopayforeachlabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amounttopayforeachlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amounttopayforeachlabel2.Location = new System.Drawing.Point(286, 148);
            this.amounttopayforeachlabel2.Name = "amounttopayforeachlabel2";
            this.amounttopayforeachlabel2.Size = new System.Drawing.Size(72, 27);
            this.amounttopayforeachlabel2.TabIndex = 16;
            this.amounttopayforeachlabel2.Text = "label6";
            // 
            // nightstostaylabel
            // 
            this.nightstostaylabel.AutoSize = true;
            this.nightstostaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nightstostaylabel.Location = new System.Drawing.Point(192, 69);
            this.nightstostaylabel.Name = "nightstostaylabel";
            this.nightstostaylabel.Size = new System.Drawing.Size(105, 20);
            this.nightstostaylabel.TabIndex = 17;
            this.nightstostaylabel.Text = "Nights to stay";
            // 
            // checkindatelabel
            // 
            this.checkindatelabel.AutoSize = true;
            this.checkindatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkindatelabel.Location = new System.Drawing.Point(69, 9);
            this.checkindatelabel.Name = "checkindatelabel";
            this.checkindatelabel.Size = new System.Drawing.Size(109, 20);
            this.checkindatelabel.TabIndex = 18;
            this.checkindatelabel.Text = "Check in Date";
            // 
            // checkoutdatelabel
            // 
            this.checkoutdatelabel.AutoSize = true;
            this.checkoutdatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkoutdatelabel.Location = new System.Drawing.Point(282, 9);
            this.checkoutdatelabel.Name = "checkoutdatelabel";
            this.checkoutdatelabel.Size = new System.Drawing.Size(120, 20);
            this.checkoutdatelabel.TabIndex = 19;
            this.checkoutdatelabel.Text = "Check out Date";
            // 
            // costumerinformationgroupbox
            // 
            this.costumerinformationgroupbox.Controls.Add(this.costumerlastnamelabel);
            this.costumerinformationgroupbox.Controls.Add(this.costumernamelabel);
            this.costumerinformationgroupbox.Controls.Add(this.unselectbutton);
            this.costumerinformationgroupbox.Controls.Add(this.costumerlastnametextbox);
            this.costumerinformationgroupbox.Controls.Add(this.costumernametextbox);
            this.costumerinformationgroupbox.Controls.Add(this.deletepersonbutton);
            this.costumerinformationgroupbox.Controls.Add(this.changeinfopersonbutton);
            this.costumerinformationgroupbox.Controls.Add(this.addpersonbutton);
            this.costumerinformationgroupbox.Controls.Add(this.costumerslistbox);
            this.costumerinformationgroupbox.Location = new System.Drawing.Point(2, 482);
            this.costumerinformationgroupbox.Name = "costumerinformationgroupbox";
            this.costumerinformationgroupbox.Size = new System.Drawing.Size(517, 230);
            this.costumerinformationgroupbox.TabIndex = 20;
            this.costumerinformationgroupbox.TabStop = false;
            this.costumerinformationgroupbox.Text = "Costumer List";
            // 
            // costumerlastnamelabel
            // 
            this.costumerlastnamelabel.AutoSize = true;
            this.costumerlastnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.costumerlastnamelabel.Location = new System.Drawing.Point(306, 76);
            this.costumerlastnamelabel.Name = "costumerlastnamelabel";
            this.costumerlastnamelabel.Size = new System.Drawing.Size(70, 16);
            this.costumerlastnamelabel.TabIndex = 13;
            this.costumerlastnamelabel.Text = "Lastname:";
            // 
            // costumernamelabel
            // 
            this.costumernamelabel.AutoSize = true;
            this.costumernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.costumernamelabel.Location = new System.Drawing.Point(324, 27);
            this.costumernamelabel.Name = "costumernamelabel";
            this.costumernamelabel.Size = new System.Drawing.Size(48, 16);
            this.costumernamelabel.TabIndex = 12;
            this.costumernamelabel.Text = "Name:";
            // 
            // RoomDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 786);
            this.Controls.Add(this.costumerinformationgroupbox);
            this.Controls.Add(this.checkoutdatelabel);
            this.Controls.Add(this.checkindatelabel);
            this.Controls.Add(this.nightstostaylabel);
            this.Controls.Add(this.amounttopayforeachlabel2);
            this.Controls.Add(this.amounttopayforeachlabel);
            this.Controls.Add(this.roomtypelabel);
            this.Controls.Add(this.roompicturepicturebox);
            this.Controls.Add(this.totalamounttopaylabel);
            this.Controls.Add(this.totalamounttopaylabel2);
            this.Controls.Add(this.savereservationbutton);
            this.Controls.Add(this.checkoutdatetimepicker);
            this.Controls.Add(this.checkindatetimepicker);
            this.Name = "RoomDetailForm";
            this.Text = "RoomDetailForm";
            this.Load += new System.EventHandler(this.RoomDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roompicturepicturebox)).EndInit();
            this.costumerinformationgroupbox.ResumeLayout(false);
            this.costumerinformationgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker checkindatetimepicker;
        private System.Windows.Forms.DateTimePicker checkoutdatetimepicker;
        private System.Windows.Forms.ListBox costumerslistbox;
        private System.Windows.Forms.Button addpersonbutton;
        private System.Windows.Forms.Button changeinfopersonbutton;
        private System.Windows.Forms.Button deletepersonbutton;
        private System.Windows.Forms.TextBox costumernametextbox;
        private System.Windows.Forms.TextBox costumerlastnametextbox;
        private System.Windows.Forms.Button savereservationbutton;
        private System.Windows.Forms.Label totalamounttopaylabel2;
        private System.Windows.Forms.Label totalamounttopaylabel;
        private System.Windows.Forms.Button unselectbutton;
        private System.Windows.Forms.PictureBox roompicturepicturebox;
        private System.Windows.Forms.ImageList imagelistforrooms;
        private System.Windows.Forms.Label roomtypelabel;
        private System.Windows.Forms.Label amounttopayforeachlabel;
        private System.Windows.Forms.Label amounttopayforeachlabel2;
        private System.Windows.Forms.Label nightstostaylabel;
        private System.Windows.Forms.Label checkindatelabel;
        private System.Windows.Forms.Label checkoutdatelabel;
        private System.Windows.Forms.GroupBox costumerinformationgroupbox;
        private System.Windows.Forms.Label costumerlastnamelabel;
        private System.Windows.Forms.Label costumernamelabel;
    }
}