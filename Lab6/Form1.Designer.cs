
namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Author = new System.Windows.Forms.LinkLabel();
            this.label_Time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Perform = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_bits = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.RadioButton();
            this.KeyGen = new System.Windows.Forms.RadioButton();
            this.LengthKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_FileKey = new System.Windows.Forms.Button();
            this.fileKey = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_hand = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FileKeyHEX = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox_viewPassWord = new System.Windows.Forms.CheckBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_fileSave = new System.Windows.Forms.Button();
            this.label_fileSave = new System.Windows.Forms.Label();
            this.label_fileCipher = new System.Windows.Forms.Label();
            this.label_fileOpen = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_fileCipher = new System.Windows.Forms.Button();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(599, 221);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(60, 21);
            this.Author.TabIndex = 11;
            this.Author.TabStop = true;
            this.Author.Text = "Автор";
            this.Author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Author_LinkClicked);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Time.Location = new System.Drawing.Point(513, 219);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(73, 21);
            this.label_Time.TabIndex = 10;
            this.label_Time.Text = "00:00.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(243, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тривалість розрахунків (хв, сек):";
            // 
            // Perform
            // 
            this.Perform.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Perform.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Perform.ImageIndex = 0;
            this.Perform.ImageList = this.imageList1;
            this.Perform.Location = new System.Drawing.Point(10, 217);
            this.Perform.Name = "Perform";
            this.Perform.Size = new System.Drawing.Size(205, 29);
            this.Perform.TabIndex = 8;
            this.Perform.Text = "Згенерувати ключ";
            this.Perform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Perform.UseVisualStyleBackColor = true;
            this.Perform.Click += new System.EventHandler(this.Perform_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_bits);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PassWord);
            this.groupBox2.Controls.Add(this.KeyGen);
            this.groupBox2.Controls.Add(this.LengthKey);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(7, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 101);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // label_bits
            // 
            this.label_bits.AutoSize = true;
            this.label_bits.Location = new System.Drawing.Point(200, 60);
            this.label_bits.Name = "label_bits";
            this.label_bits.Size = new System.Drawing.Size(0, 21);
            this.label_bits.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "псевдовипадкових послідовностей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ключ з криптографічного генератора";
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Location = new System.Drawing.Point(301, 61);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(351, 25);
            this.PassWord.TabIndex = 4;
            this.PassWord.TabStop = true;
            this.PassWord.Text = "Ключ генерується розширенням пароля";
            this.PassWord.UseVisualStyleBackColor = true;
            this.PassWord.CheckedChanged += new System.EventHandler(this.PassWord_CheckedChanged);
            // 
            // KeyGen
            // 
            this.KeyGen.AutoSize = true;
            this.KeyGen.Location = new System.Drawing.Point(302, 30);
            this.KeyGen.Name = "KeyGen";
            this.KeyGen.Size = new System.Drawing.Size(14, 13);
            this.KeyGen.TabIndex = 3;
            this.KeyGen.TabStop = true;
            this.KeyGen.UseVisualStyleBackColor = true;
            this.KeyGen.CheckedChanged += new System.EventHandler(this.KeyGen_CheckedChanged);
            // 
            // LengthKey
            // 
            this.LengthKey.AutoCompleteCustomSource.AddRange(new string[] {
            "8, 16, 24, 32, 12500000"});
            this.LengthKey.FormattingEnabled = true;
            this.LengthKey.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32",
            "12500000"});
            this.LengthKey.Location = new System.Drawing.Point(204, 19);
            this.LengthKey.Name = "LengthKey";
            this.LengthKey.Size = new System.Drawing.Size(97, 29);
            this.LengthKey.TabIndex = 2;
            this.LengthKey.TextChanged += new System.EventHandler(this.comboBox_keyLength_byte_TextChanged);
            this.LengthKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LengthKey_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Довжина файлу (біти):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Довжина файлу (байти):";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 111);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 77);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Файл з ключем";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_FileKey);
            this.groupBox1.Controls.Add(this.fileKey);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шлях до файлу";
            // 
            // button_FileKey
            // 
            this.button_FileKey.Location = new System.Drawing.Point(596, 25);
            this.button_FileKey.Name = "button_FileKey";
            this.button_FileKey.Size = new System.Drawing.Size(46, 26);
            this.button_FileKey.TabIndex = 1;
            this.button_FileKey.Text = "...";
            this.button_FileKey.UseVisualStyleBackColor = true;
            this.button_FileKey.Click += new System.EventHandler(this.Button_FileKey_Click);
            // 
            // fileKey
            // 
            this.fileKey.Location = new System.Drawing.Point(7, 26);
            this.fileKey.Name = "fileKey";
            this.fileKey.Size = new System.Drawing.Size(583, 26);
            this.fileKey.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.checkBox_hand);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 77);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ключ у HEX форматі";
            // 
            // checkBox_hand
            // 
            this.checkBox_hand.AutoSize = true;
            this.checkBox_hand.Location = new System.Drawing.Point(553, 34);
            this.checkBox_hand.Name = "checkBox_hand";
            this.checkBox_hand.Size = new System.Drawing.Size(15, 14);
            this.checkBox_hand.TabIndex = 2;
            this.checkBox_hand.UseVisualStyleBackColor = true;
            this.checkBox_hand.CheckedChanged += new System.EventHandler(this.CheckBox_hand_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FileKeyHEX);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 71);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ключ (HEX формат)";
            // 
            // FileKeyHEX
            // 
            this.FileKeyHEX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileKeyHEX.Location = new System.Drawing.Point(3, 25);
            this.FileKeyHEX.Name = "FileKeyHEX";
            this.FileKeyHEX.ReadOnly = true;
            this.FileKeyHEX.Size = new System.Drawing.Size(538, 29);
            this.FileKeyHEX.TabIndex = 0;
            this.FileKeyHEX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FileKeyHEX_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.ErrorImage = global::Lab6.Properties.Resources.hex;
            this.pictureBox1.Image = global::Lab6.Properties.Resources.hex;
            this.pictureBox1.InitialImage = global::Lab6.Properties.Resources.hex;
            this.pictureBox1.Location = new System.Drawing.Point(572, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.checkBox_viewPassWord);
            this.tabPage3.Controls.Add(this.textBox_password);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(664, 77);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Власний пароль";
            // 
            // checkBox_viewPassWord
            // 
            this.checkBox_viewPassWord.AutoSize = true;
            this.checkBox_viewPassWord.Location = new System.Drawing.Point(556, 32);
            this.checkBox_viewPassWord.Name = "checkBox_viewPassWord";
            this.checkBox_viewPassWord.Size = new System.Drawing.Size(15, 14);
            this.checkBox_viewPassWord.TabIndex = 4;
            this.checkBox_viewPassWord.UseVisualStyleBackColor = true;
            this.checkBox_viewPassWord.CheckedChanged += new System.EventHandler(this.CheckBox_viewPassWord_CheckedChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(190, 24);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(360, 29);
            this.textBox_password.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "і запишіть його сюди:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Придумайте свій пароль";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.ErrorImage = global::Lab6.Properties.Resources.eye;
            this.pictureBox2.Image = global::Lab6.Properties.Resources.eye;
            this.pictureBox2.InitialImage = global::Lab6.Properties.Resources.eye;
            this.pictureBox2.Location = new System.Drawing.Point(575, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.button_fileSave);
            this.tabPage4.Controls.Add(this.label_fileSave);
            this.tabPage4.Controls.Add(this.label_fileCipher);
            this.tabPage4.Controls.Add(this.label_fileOpen);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.button_fileCipher);
            this.tabPage4.Controls.Add(this.button_fileOpen);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(664, 77);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Файл XOR Ключ";
            // 
            // button_fileSave
            // 
            this.button_fileSave.Image = global::Lab6.Properties.Resources.save;
            this.button_fileSave.Location = new System.Drawing.Point(594, 5);
            this.button_fileSave.Name = "button_fileSave";
            this.button_fileSave.Size = new System.Drawing.Size(61, 67);
            this.button_fileSave.TabIndex = 11;
            this.button_fileSave.UseVisualStyleBackColor = true;
            this.button_fileSave.Click += new System.EventHandler(this.Button_fileSave_Click);
            // 
            // label_fileSave
            // 
            this.label_fileSave.AutoSize = true;
            this.label_fileSave.ForeColor = System.Drawing.Color.Red;
            this.label_fileSave.Location = new System.Drawing.Point(475, 46);
            this.label_fileSave.Name = "label_fileSave";
            this.label_fileSave.Size = new System.Drawing.Size(95, 21);
            this.label_fileSave.TabIndex = 10;
            this.label_fileSave.Text = "(відсутній)";
            // 
            // label_fileCipher
            // 
            this.label_fileCipher.AutoSize = true;
            this.label_fileCipher.ForeColor = System.Drawing.Color.Red;
            this.label_fileCipher.Location = new System.Drawing.Point(239, 48);
            this.label_fileCipher.Name = "label_fileCipher";
            this.label_fileCipher.Size = new System.Drawing.Size(95, 21);
            this.label_fileCipher.TabIndex = 9;
            this.label_fileCipher.Text = "(відсутній)";
            // 
            // label_fileOpen
            // 
            this.label_fileOpen.AutoSize = true;
            this.label_fileOpen.ForeColor = System.Drawing.Color.Red;
            this.label_fileOpen.Location = new System.Drawing.Point(28, 46);
            this.label_fileOpen.Name = "label_fileOpen";
            this.label_fileOpen.Size = new System.Drawing.Size(95, 21);
            this.label_fileOpen.TabIndex = 8;
            this.label_fileOpen.Text = "(відсутній)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(458, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 21);
            this.label13.TabIndex = 6;
            this.label13.Text = "Зберегти файл:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(230, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Шифрування:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Відкрити файл:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(445, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "3.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(213, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "2.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "1.";
            // 
            // button_fileCipher
            // 
            this.button_fileCipher.ImageIndex = 0;
            this.button_fileCipher.ImageList = this.imageList2;
            this.button_fileCipher.Location = new System.Drawing.Point(355, 4);
            this.button_fileCipher.Name = "button_fileCipher";
            this.button_fileCipher.Size = new System.Drawing.Size(61, 69);
            this.button_fileCipher.TabIndex = 7;
            this.button_fileCipher.UseVisualStyleBackColor = true;
            this.button_fileCipher.Click += new System.EventHandler(this.Button_fileCipher_Click);
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.Image = ((System.Drawing.Image)(resources.GetObject("button_fileOpen.Image")));
            this.button_fileOpen.Location = new System.Drawing.Point(150, 6);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(61, 67);
            this.button_fileOpen.TabIndex = 4;
            this.button_fileOpen.UseVisualStyleBackColor = true;
            this.button_fileOpen.Click += new System.EventHandler(this.Button_fileOpen_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "key3.png");
            this.imageList1.Images.SetKeyName(1, "key.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "181379.png");
            this.imageList2.Images.SetKeyName(1, "1813797.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 249);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Perform);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(688, 288);
            this.MinimumSize = new System.Drawing.Size(688, 288);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор ключа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Author;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Perform;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_bits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton PassWord;
        private System.Windows.Forms.RadioButton KeyGen;
        private System.Windows.Forms.ComboBox LengthKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_FileKey;
        private System.Windows.Forms.TextBox fileKey;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox_hand;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox FileKeyHEX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBox_viewPassWord;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_fileSave;
        private System.Windows.Forms.Label label_fileSave;
        private System.Windows.Forms.Label label_fileCipher;
        private System.Windows.Forms.Label label_fileOpen;
        private System.Windows.Forms.Button button_fileCipher;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_fileOpen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

