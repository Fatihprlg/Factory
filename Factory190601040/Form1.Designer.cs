namespace Factory190601040
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tcTxt = new System.Windows.Forms.MaskedTextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.departTxt = new System.Windows.Forms.TextBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.staffList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tckNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPerson = new System.Windows.Forms.Button();
            this.subtractPerson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fullLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addPerson
            // 
            this.addPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addPerson.Location = new System.Drawing.Point(120, 223);
            this.addPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPerson.MinimumSize = new System.Drawing.Size(221, 21);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(221, 21);
            this.addPerson.TabIndex = 0;
            this.addPerson.Text = "Personel Ekle";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(139, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel No :";
            // 
            // tcTxt
            // 
            this.tcTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tcTxt.Location = new System.Drawing.Point(210, 129);
            this.tcTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcTxt.Mask = "00000000000";
            this.tcTxt.MinimumSize = new System.Drawing.Size(78, 22);
            this.tcTxt.Name = "tcTxt";
            this.tcTxt.Size = new System.Drawing.Size(78, 22);
            this.tcTxt.TabIndex = 2;
            this.tcTxt.ValidatingType = typeof(int);
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTxt.Location = new System.Drawing.Point(210, 152);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTxt.MinimumSize = new System.Drawing.Size(121, 22);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(131, 22);
            this.nameTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(136, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC Kimlik No :";
            // 
            // idTxt
            // 
            this.idTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idTxt.Location = new System.Drawing.Point(210, 106);
            this.idTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTxt.Mask = "00000";
            this.idTxt.MinimumSize = new System.Drawing.Size(63, 22);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(63, 22);
            this.idTxt.TabIndex = 1;
            this.idTxt.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(184, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(167, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(175, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birim :";
            // 
            // departTxt
            // 
            this.departTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.departTxt.Location = new System.Drawing.Point(210, 199);
            this.departTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departTxt.MinimumSize = new System.Drawing.Size(121, 22);
            this.departTxt.Name = "departTxt";
            this.departTxt.Size = new System.Drawing.Size(131, 22);
            this.departTxt.TabIndex = 5;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.surnameTxt.Location = new System.Drawing.Point(210, 175);
            this.surnameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surnameTxt.MinimumSize = new System.Drawing.Size(121, 22);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(131, 22);
            this.surnameTxt.TabIndex = 4;
            // 
            // staffList
            // 
            this.staffList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.surname,
            this.depart,
            this.tckNo});
            this.staffList.FullRowSelect = true;
            this.staffList.HideSelection = false;
            this.staffList.Location = new System.Drawing.Point(9, 273);
            this.staffList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staffList.MinimumSize = new System.Drawing.Size(338, 150);
            this.staffList.Name = "staffList";
            this.staffList.Size = new System.Drawing.Size(450, 201);
            this.staffList.TabIndex = 9;
            this.staffList.UseCompatibleStateImageBehavior = false;
            this.staffList.View = System.Windows.Forms.View.Details;
            this.staffList.SelectedIndexChanged += new System.EventHandler(this.staffList_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Personel No";
            this.id.Width = 90;
            // 
            // name
            // 
            this.name.Text = "Ad";
            this.name.Width = 100;
            // 
            // surname
            // 
            this.surname.Text = "Soyad";
            this.surname.Width = 100;
            // 
            // depart
            // 
            this.depart.Text = "Birim";
            this.depart.Width = 85;
            // 
            // tckNo
            // 
            this.tckNo.Text = "TCK No";
            this.tckNo.Width = 70;
            // 
            // listPerson
            // 
            this.listPerson.Location = new System.Drawing.Point(9, 247);
            this.listPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listPerson.MinimumSize = new System.Drawing.Size(225, 21);
            this.listPerson.Name = "listPerson";
            this.listPerson.Size = new System.Drawing.Size(225, 21);
            this.listPerson.TabIndex = 10;
            this.listPerson.Text = "Personel Listele";
            this.listPerson.UseVisualStyleBackColor = true;
            this.listPerson.Click += new System.EventHandler(this.listPerson_Click);
            // 
            // subtractPerson
            // 
            this.subtractPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subtractPerson.Enabled = false;
            this.subtractPerson.Location = new System.Drawing.Point(238, 247);
            this.subtractPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subtractPerson.MinimumSize = new System.Drawing.Size(169, 21);
            this.subtractPerson.Name = "subtractPerson";
            this.subtractPerson.Size = new System.Drawing.Size(221, 21);
            this.subtractPerson.TabIndex = 11;
            this.subtractPerson.Text = "Personel Çıkar";
            this.subtractPerson.UseVisualStyleBackColor = true;
            this.subtractPerson.Click += new System.EventHandler(this.subtractPerson_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.fullLbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(65, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 81);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Factory190601040.Properties.Resources.factory1;
            this.pictureBox1.Location = new System.Drawing.Point(105, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // fullLbl
            // 
            this.fullLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fullLbl.AutoSize = true;
            this.fullLbl.BackColor = System.Drawing.Color.Transparent;
            this.fullLbl.Font = new System.Drawing.Font("Bauhaus 93", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.fullLbl.Location = new System.Drawing.Point(150, 12);
            this.fullLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullLbl.Name = "fullLbl";
            this.fullLbl.Size = new System.Drawing.Size(99, 37);
            this.fullLbl.TabIndex = 13;
            this.fullLbl.Text = "FULL";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(78, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "F a c t o r y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.subtractPerson);
            this.Controls.Add(this.listPerson);
            this.Controls.Add(this.staffList);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.departTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.tcTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Full Factory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tcTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox idTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox departTxt;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.ListView staffList;
        private System.Windows.Forms.Button listPerson;
        private System.Windows.Forms.Button subtractPerson;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader depart;
        private System.Windows.Forms.ColumnHeader tckNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fullLbl;
        private System.Windows.Forms.Label label7;
    }
}

