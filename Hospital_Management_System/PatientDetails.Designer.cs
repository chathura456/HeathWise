using System;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    partial class PatientDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDetails));
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_drName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSpecialist = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reg_picker = new System.Windows.Forms.DateTimePicker();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Btype = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.radiobtn_female = new System.Windows.Forms.CheckBox();
            this.radiobtn_male = new System.Windows.Forms.CheckBox();
            this.birth_picker = new System.Windows.Forms.DateTimePicker();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reset.Location = new System.Drawing.Point(275, 581);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 48);
            this.btn_reset.TabIndex = 39;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_submit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_submit.Location = new System.Drawing.Point(153, 581);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 48);
            this.btn_submit.TabIndex = 38;
            this.btn_submit.Text = "Save";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_drName
            // 
            this.txt_drName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_drName.Location = new System.Drawing.Point(212, 107);
            this.txt_drName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_drName.Name = "txt_drName";
            this.txt_drName.Size = new System.Drawing.Size(248, 29);
            this.txt_drName.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 24);
            this.label14.TabIndex = 55;
            this.label14.Text = "Doctor Name";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 24);
            this.label15.TabIndex = 54;
            this.label15.Text = "Specialist";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.comboBoxSpecialist);
            this.groupBox1.Controls.Add(this.txt_drName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(21, 386);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(534, 178);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Details";
            // 
            // comboBoxSpecialist
            // 
            this.comboBoxSpecialist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpecialist.FormattingEnabled = true;
            this.comboBoxSpecialist.Location = new System.Drawing.Point(212, 56);
            this.comboBoxSpecialist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSpecialist.Name = "comboBoxSpecialist";
            this.comboBoxSpecialist.Size = new System.Drawing.Size(248, 33);
            this.comboBoxSpecialist.TabIndex = 66;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.reg_picker);
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Btype);
            this.groupBox2.Controls.Add(this.txt_height);
            this.groupBox2.Controls.Add(this.txt_weight);
            this.groupBox2.Controls.Add(this.radiobtn_female);
            this.groupBox2.Controls.Add(this.radiobtn_male);
            this.groupBox2.Controls.Add(this.birth_picker);
            this.groupBox2.Controls.Add(this.txt_phone);
            this.groupBox2.Controls.Add(this.txt_lname);
            this.groupBox2.Controls.Add(this.txt_fname);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(21, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1416, 354);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 77;
            this.label1.Text = "Date";
            // 
            // reg_picker
            // 
            this.reg_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reg_picker.Location = new System.Drawing.Point(213, 50);
            this.reg_picker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reg_picker.Name = "reg_picker";
            this.reg_picker.Size = new System.Drawing.Size(249, 30);
            this.reg_picker.TabIndex = 76;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(706, 213);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(210, 86);
            this.txt_address.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 75;
            this.label7.Text = "Address";
            // 
            // txt_Btype
            // 
            this.txt_Btype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Btype.Location = new System.Drawing.Point(706, 156);
            this.txt_Btype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Btype.Name = "txt_Btype";
            this.txt_Btype.Size = new System.Drawing.Size(210, 29);
            this.txt_Btype.TabIndex = 74;
            // 
            // txt_height
            // 
            this.txt_height.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_height.Location = new System.Drawing.Point(706, 108);
            this.txt_height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(210, 29);
            this.txt_height.TabIndex = 73;
            // 
            // txt_weight
            // 
            this.txt_weight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_weight.Location = new System.Drawing.Point(706, 53);
            this.txt_weight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(210, 29);
            this.txt_weight.TabIndex = 72;
            // 
            // radiobtn_female
            // 
            this.radiobtn_female.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radiobtn_female.AutoSize = true;
            this.radiobtn_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_female.Location = new System.Drawing.Point(375, 217);
            this.radiobtn_female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtn_female.Name = "radiobtn_female";
            this.radiobtn_female.Size = new System.Drawing.Size(86, 24);
            this.radiobtn_female.TabIndex = 68;
            this.radiobtn_female.Text = "Female";
            this.radiobtn_female.UseVisualStyleBackColor = true;
            // 
            // radiobtn_male
            // 
            this.radiobtn_male.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radiobtn_male.AutoSize = true;
            this.radiobtn_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_male.Location = new System.Drawing.Point(213, 217);
            this.radiobtn_male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtn_male.Name = "radiobtn_male";
            this.radiobtn_male.Size = new System.Drawing.Size(67, 24);
            this.radiobtn_male.TabIndex = 67;
            this.radiobtn_male.Text = "Male";
            this.radiobtn_male.UseVisualStyleBackColor = true;
            // 
            // birth_picker
            // 
            this.birth_picker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.birth_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_picker.Location = new System.Drawing.Point(213, 261);
            this.birth_picker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birth_picker.Name = "birth_picker";
            this.birth_picker.Size = new System.Drawing.Size(249, 24);
            this.birth_picker.TabIndex = 66;
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_phone.Location = new System.Drawing.Point(213, 311);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(249, 29);
            this.txt_phone.TabIndex = 65;
            // 
            // txt_lname
            // 
            this.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_lname.Location = new System.Drawing.Point(213, 154);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(249, 29);
            this.txt_lname.TabIndex = 64;
            // 
            // txt_fname
            // 
            this.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_fname.Location = new System.Drawing.Point(213, 106);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(249, 29);
            this.txt_fname.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(564, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 24);
            this.label11.TabIndex = 62;
            this.label11.Text = "Blood Type";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(564, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 61;
            this.label10.Text = "Height";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 60;
            this.label9.Text = "Weight";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "First Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 587);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView2.Location = new System.Drawing.Point(604, 431);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(370, 198);
            this.dataGridView2.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(671, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 79;
            this.label8.Text = "Doctors";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_back.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(396, 581);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 48);
            this.btn_back.TabIndex = 80;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // PatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_submit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "PatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Details";
            this.Load += new System.EventHandler(this.PatientDetails_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_drName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Btype;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.CheckBox radiobtn_female;
        private System.Windows.Forms.CheckBox radiobtn_male;
        private System.Windows.Forms.DateTimePicker birth_picker;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxSpecialist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker reg_picker;
        private EventHandler PatientDetails_Load;
        private ErrorProvider errorProvider;
        private ErrorProvider errorProvider1;
        private DataGridView dataGridView2;
        private Label label8;
        private Button btn_back;

        public DataGridViewCellEventHandler DataGridViewDr_CellContentClick { get; private set; }
    }
}