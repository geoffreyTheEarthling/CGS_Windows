namespace CGS_Windows
{
    partial class mainForm
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_AddCur = new System.Windows.Forms.Button();
            this.btn_SaveCur = new System.Windows.Forms.Button();
            this.btn_ViewCur = new System.Windows.Forms.Button();
            this.txt_IdCur = new System.Windows.Forms.TextBox();
            this.txt_fnameCur = new System.Windows.Forms.TextBox();
            this.txt_lnameCur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveArtist = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_AddArtist = new System.Windows.Forms.Button();
            this.textBtxt_IDArtistox3 = new System.Windows.Forms.TextBox();
            this.txt_lnameArtist = new System.Windows.Forms.TextBox();
            this.txt_fnameArtist = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveArtPiece = new System.Windows.Forms.Button();
            this.btn_ListPieces = new System.Windows.Forms.Button();
            this.btn_SellArtPiece = new System.Windows.Forms.Button();
            this.btn_AddArtPiece = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtCuratorID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtArtistID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(6, 11);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(509, 338);
            this.tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.btn_AddCur);
            this.tabPage1.Controls.Add(this.btn_SaveCur);
            this.tabPage1.Controls.Add(this.btn_ViewCur);
            this.tabPage1.Controls.Add(this.txt_IdCur);
            this.tabPage1.Controls.Add(this.txt_fnameCur);
            this.tabPage1.Controls.Add(this.txt_lnameCur);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Curators";
            // 
            // btn_AddCur
            // 
            this.btn_AddCur.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddCur.Location = new System.Drawing.Point(347, 158);
            this.btn_AddCur.Name = "btn_AddCur";
            this.btn_AddCur.Size = new System.Drawing.Size(140, 36);
            this.btn_AddCur.TabIndex = 4;
            this.btn_AddCur.Text = "Add Curator";
            this.btn_AddCur.UseVisualStyleBackColor = false;
            this.btn_AddCur.Click += new System.EventHandler(this.btn_AddCur_Click);
            // 
            // btn_SaveCur
            // 
            this.btn_SaveCur.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SaveCur.Location = new System.Drawing.Point(347, 200);
            this.btn_SaveCur.Name = "btn_SaveCur";
            this.btn_SaveCur.Size = new System.Drawing.Size(140, 36);
            this.btn_SaveCur.TabIndex = 5;
            this.btn_SaveCur.Text = "Save Curator";
            this.btn_SaveCur.UseVisualStyleBackColor = false;
            this.btn_SaveCur.Click += new System.EventHandler(this.btn_SaveCur_Click);
            // 
            // btn_ViewCur
            // 
            this.btn_ViewCur.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ViewCur.Location = new System.Drawing.Point(347, 256);
            this.btn_ViewCur.Name = "btn_ViewCur";
            this.btn_ViewCur.Size = new System.Drawing.Size(140, 36);
            this.btn_ViewCur.TabIndex = 6;
            this.btn_ViewCur.Text = "View Curators";
            this.btn_ViewCur.UseVisualStyleBackColor = false;
            this.btn_ViewCur.Click += new System.EventHandler(this.btn_ViewCur_Click);
            // 
            // txt_IdCur
            // 
            this.txt_IdCur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdCur.Location = new System.Drawing.Point(140, 137);
            this.txt_IdCur.Name = "txt_IdCur";
            this.txt_IdCur.Size = new System.Drawing.Size(143, 27);
            this.txt_IdCur.TabIndex = 3;
            // 
            // txt_fnameCur
            // 
            this.txt_fnameCur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fnameCur.Location = new System.Drawing.Point(140, 62);
            this.txt_fnameCur.Multiline = true;
            this.txt_fnameCur.Name = "txt_fnameCur";
            this.txt_fnameCur.Size = new System.Drawing.Size(143, 27);
            this.txt_fnameCur.TabIndex = 1;
            // 
            // txt_lnameCur
            // 
            this.txt_lnameCur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lnameCur.Location = new System.Drawing.Point(140, 100);
            this.txt_lnameCur.Name = "txt_lnameCur";
            this.txt_lnameCur.Size = new System.Drawing.Size(143, 27);
            this.txt_lnameCur.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Curator Information:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.btnSaveArtist);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btn_AddArtist);
            this.tabPage2.Controls.Add(this.textBtxt_IDArtistox3);
            this.tabPage2.Controls.Add(this.txt_lnameArtist);
            this.tabPage2.Controls.Add(this.txt_fnameArtist);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artists";
            // 
            // btnSaveArtist
            // 
            this.btnSaveArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveArtist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveArtist.Location = new System.Drawing.Point(336, 174);
            this.btnSaveArtist.Name = "btnSaveArtist";
            this.btnSaveArtist.Size = new System.Drawing.Size(122, 36);
            this.btnSaveArtist.TabIndex = 8;
            this.btnSaveArtist.Text = "Save Artist";
            this.btnSaveArtist.UseVisualStyleBackColor = true;
            this.btnSaveArtist.Click += new System.EventHandler(this.btnSaveArtist_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(336, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "View Artists";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_AddArtist
            // 
            this.btn_AddArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddArtist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddArtist.Location = new System.Drawing.Point(336, 216);
            this.btn_AddArtist.Name = "btn_AddArtist";
            this.btn_AddArtist.Size = new System.Drawing.Size(122, 36);
            this.btn_AddArtist.TabIndex = 4;
            this.btn_AddArtist.Text = "Add Artist";
            this.btn_AddArtist.UseVisualStyleBackColor = true;
            this.btn_AddArtist.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBtxt_IDArtistox3
            // 
            this.textBtxt_IDArtistox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBtxt_IDArtistox3.Location = new System.Drawing.Point(140, 136);
            this.textBtxt_IDArtistox3.Multiline = true;
            this.textBtxt_IDArtistox3.Name = "textBtxt_IDArtistox3";
            this.textBtxt_IDArtistox3.Size = new System.Drawing.Size(169, 28);
            this.textBtxt_IDArtistox3.TabIndex = 3;
            // 
            // txt_lnameArtist
            // 
            this.txt_lnameArtist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lnameArtist.Location = new System.Drawing.Point(140, 100);
            this.txt_lnameArtist.Multiline = true;
            this.txt_lnameArtist.Name = "txt_lnameArtist";
            this.txt_lnameArtist.Size = new System.Drawing.Size(169, 28);
            this.txt_lnameArtist.TabIndex = 2;
            // 
            // txt_fnameArtist
            // 
            this.txt_fnameArtist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fnameArtist.Location = new System.Drawing.Point(140, 63);
            this.txt_fnameArtist.Multiline = true;
            this.txt_fnameArtist.Name = "txt_fnameArtist";
            this.txt_fnameArtist.Size = new System.Drawing.Size(169, 28);
            this.txt_fnameArtist.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(23, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(23, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Last name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(23, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "First name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(22, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Artist Information:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage3.Controls.Add(this.btnSaveArtPiece);
            this.tabPage3.Controls.Add(this.btn_ListPieces);
            this.tabPage3.Controls.Add(this.btn_SellArtPiece);
            this.tabPage3.Controls.Add(this.btn_AddArtPiece);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.txtCuratorID);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.txtArtistID);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtValue);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtYear);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtTitle);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtID);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(501, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Art Pieces";
            // 
            // btnSaveArtPiece
            // 
            this.btnSaveArtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveArtPiece.Location = new System.Drawing.Point(297, 267);
            this.btnSaveArtPiece.Name = "btnSaveArtPiece";
            this.btnSaveArtPiece.Size = new System.Drawing.Size(198, 32);
            this.btnSaveArtPiece.TabIndex = 16;
            this.btnSaveArtPiece.Text = "Save Art Piece";
            this.btnSaveArtPiece.UseVisualStyleBackColor = true;
            this.btnSaveArtPiece.Click += new System.EventHandler(this.btnSaveArtPiece_Click);
            // 
            // btn_ListPieces
            // 
            this.btn_ListPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListPieces.Location = new System.Drawing.Point(297, 231);
            this.btn_ListPieces.Name = "btn_ListPieces";
            this.btn_ListPieces.Size = new System.Drawing.Size(198, 32);
            this.btn_ListPieces.TabIndex = 15;
            this.btn_ListPieces.Text = "List Pieces";
            this.btn_ListPieces.UseVisualStyleBackColor = true;
            this.btn_ListPieces.Click += new System.EventHandler(this.btn_ListPieces_Click);
            // 
            // btn_SellArtPiece
            // 
            this.btn_SellArtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SellArtPiece.Location = new System.Drawing.Point(297, 187);
            this.btn_SellArtPiece.Name = "btn_SellArtPiece";
            this.btn_SellArtPiece.Size = new System.Drawing.Size(198, 32);
            this.btn_SellArtPiece.TabIndex = 14;
            this.btn_SellArtPiece.Text = "Sell Art Piece";
            this.btn_SellArtPiece.UseVisualStyleBackColor = true;
            this.btn_SellArtPiece.Click += new System.EventHandler(this.btn_SellArtPiece_Click);
            // 
            // btn_AddArtPiece
            // 
            this.btn_AddArtPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddArtPiece.Location = new System.Drawing.Point(297, 149);
            this.btn_AddArtPiece.Name = "btn_AddArtPiece";
            this.btn_AddArtPiece.Size = new System.Drawing.Size(198, 32);
            this.btn_AddArtPiece.TabIndex = 13;
            this.btn_AddArtPiece.Text = "Add Art Piece";
            this.btn_AddArtPiece.UseVisualStyleBackColor = true;
            this.btn_AddArtPiece.Click += new System.EventHandler(this.btn_AddArtPiece_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(297, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "In Storage";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "On Display";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtCuratorID
            // 
            this.txtCuratorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuratorID.Location = new System.Drawing.Point(115, 227);
            this.txtCuratorID.Multiline = true;
            this.txtCuratorID.Name = "txtCuratorID";
            this.txtCuratorID.Size = new System.Drawing.Size(162, 28);
            this.txtCuratorID.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 235);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "Curator ID:";
            // 
            // txtArtistID
            // 
            this.txtArtistID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtistID.Location = new System.Drawing.Point(115, 193);
            this.txtArtistID.Multiline = true;
            this.txtArtistID.Name = "txtArtistID";
            this.txtArtistID.Size = new System.Drawing.Size(162, 28);
            this.txtArtistID.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 20);
            this.label18.TabIndex = 9;
            this.label18.Text = "Artist ID:";
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Location = new System.Drawing.Point(115, 159);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(162, 28);
            this.txtValue.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Value:";
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Location = new System.Drawing.Point(115, 125);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(162, 28);
            this.txtYear.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Year:";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(115, 91);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(162, 28);
            this.txtTitle.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Title:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(115, 57);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(162, 28);
            this.txtID.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Art Piece Information:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.richTextBox);
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.tab);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 582);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox2.Location = new System.Drawing.Point(0, 545);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(628, 31);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "Curators";
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox.Location = new System.Drawing.Point(21, 355);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(626, 153);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(521, 309);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(140, 40);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(12, 12);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(661, 31);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "File";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(698, 621);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_IdCur;
        private System.Windows.Forms.TextBox txt_fnameCur;
        private System.Windows.Forms.TextBox txt_lnameCur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddCur;
        private System.Windows.Forms.Button btn_SaveCur;
        private System.Windows.Forms.Button btn_ViewCur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_AddArtist;
        private System.Windows.Forms.TextBox textBtxt_IDArtistox3;
        private System.Windows.Forms.TextBox txt_lnameArtist;
        private System.Windows.Forms.TextBox txt_fnameArtist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuratorID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtArtistID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_ListPieces;
        private System.Windows.Forms.Button btn_SellArtPiece;
        private System.Windows.Forms.Button btn_AddArtPiece;
        private System.Windows.Forms.Button btnSaveArtist;
        private System.Windows.Forms.Button btnSaveArtPiece;
    }
}