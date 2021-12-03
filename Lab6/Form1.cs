using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private byte[] fileArray = new byte[0];
        private byte[] randomArray = new byte[0];
        private byte[] resultArray = new byte[0];

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyGen.Checked = true;
            LengthKey.SelectedItem = "8";
            checkBox_viewPassWord.Checked = false;
        }

        private string StringHEX(byte[] randomArray)
        {
            BitArray randomBitArray = new BitArray(randomArray);
            string textHEX = BitConverter.ToString(randomArray);
            return textHEX.Replace("-", "");
        }

        private void CheckBox_hand_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hand.Checked)
            {
                FileKeyHEX.ReadOnly = false;
            }
            else
            {
                FileKeyHEX.ReadOnly = true;

                string pathFileKey = fileKey.Text;

                if (pathFileKey == "")
                {
                    MessageBox.Show("Вкажіть шлях до файлу з ключем", "Помилка в textBox_fileKey", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox_hand.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    fileKey.Focus();
                    return;
                }
                if (!File.Exists(pathFileKey))
                {
                    MessageBox.Show("Файл з ключем не існує, створіть файл", "Помилка файлу з ключем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox_hand.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    button_FileKey.Focus();
                    return;
                }

                randomArray = StringToByteArray(FileKeyHEX.Text);

                File.WriteAllBytes(pathFileKey, randomArray);
            }
        }

        private void FileKeyHEX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || (c >= 'a' && c <= 'f') || c == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        public byte[] StringToByteArray(string textHEX)
        {


            int len = textHEX.Length;
            if (len % 2 == 1)
            {
                textHEX = "0" + textHEX;
                FileKeyHEX.Text = textHEX;
                len++;
            }
            int len_half = len / 2;
            byte[] bs = new byte[len_half];
            for (int i = 0; i != len_half; i++)
            {
                bs[i] = (byte)int.Parse(textHEX.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return bs;
        }

        private void Button_fileOpen_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Всі файли (*.*)|*.*|Текстові файли (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathFileLoad = openFileDialog.FileName;

                fileArray = File.ReadAllBytes(pathFileLoad);

                label_fileOpen.Text = "файл";
                label_fileOpen.ForeColor = Color.Green;
                label_fileCipher.Text = "(відсутній)";
                label_fileCipher.ForeColor = Color.Red;
                label_fileSave.Text = "(відсутній)";
                label_fileSave.ForeColor = Color.Red;
                SystemSounds.Beep.Play();
            }
            Cursor = Cursors.Default;
        }

        private void Button_fileCipher_Click(object sender, EventArgs e)
        {
            int lenFile = fileArray.Length;
            if (lenFile == 0)
            {
                MessageBox.Show("Помилка з файлом", "Застереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int lenKey = randomArray.Length;
            if (lenKey == 0)
            {
                MessageBox.Show("Помилка з ключем", "Застереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor = Cursors.WaitCursor;
            resultArray = new byte[lenFile];
            for (int i = 0; i < lenFile; i++)
            {
                resultArray[i] = (byte)(fileArray[i] ^ randomArray[i % lenKey]);
            }
            label_fileCipher.Text = "файл";
            label_fileCipher.ForeColor = Color.Green;
            label_fileSave.Text = "(відсутній)";
            label_fileSave.ForeColor = Color.Red;
            SystemSounds.Beep.Play();
            Cursor = Cursors.Default;
        }

        private void Button_fileSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "Файл після шифрування",
                Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt",
                FilterIndex = 2,
                CreatePrompt = true,
                OverwritePrompt = true,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathKeySave = saveFileDialog.FileName;

                File.WriteAllBytes(pathKeySave, resultArray);
                if (resultArray.Length == 0)
                {
                    MessageBox.Show("Помилка з шифруванням" + Environment.NewLine
                                    + "файл створено, але його розмір" + "\r\n"
                                    + "0 байт",
                                    "Застереження",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                    return;
                }

                label_fileSave.Text = "файл";
                label_fileSave.ForeColor = Color.Green;
                SystemSounds.Beep.Play();
            }
            Cursor = Cursors.Default;
        }

        private void Author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Студент " + "\r\n" +
                            "Вербицький В.В." + "\r\n" +
                            "кафедри електроніки" + "\r\n" + 
                            "к.т.н., ст.викладач " + "\r\n" +
                            "Навроцький Д.О.",
                            "Реквізити автора:",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
        }

        private void CheckBox_viewPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_viewPassWord.Checked)
            {
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '*';
            }
        }

        private void KeyGen_CheckedChanged(object sender, EventArgs e)
        {
            if (KeyGen.Checked)
            {
                Perform.ImageIndex = 0;
                button_fileCipher.ImageIndex = 0;
                textBox_password.ForeColor = SystemColors.WindowText;
            }
        }

        private void LengthKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (PassWord.Checked)
            {
                Perform.ImageIndex = 1;
                button_fileCipher.ImageIndex = 1;
                textBox_password.ForeColor = Color.DarkGreen;
            }
        }

        private void Perform_Click(object sender, EventArgs e)
        {
            string pathFileKey = fileKey.Text;
            DateTime timeStart;
            DateTime timeFinish;
            TimeSpan timeAll;
            label_Time.Text = "00:00.00";

            if (pathFileKey == "")
            {
                MessageBox.Show("Вкажіть шлях до файлу з ключем", "Помилка в textBox_fileKey", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fileKey.Focus();
                return;
            }

            if (!File.Exists(pathFileKey))
            {
                MessageBox.Show("Файл з ключем не існує, створіть файл", "Помилка файлу з ключем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_FileKey.Focus();
                return;
            }

            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            timeStart = DateTime.Now;
            if (KeyGen.Checked)
            {
                randomArray = Lab6.KeyGen.generator_Key(int.Parse(LengthKey.Text));
            }
            if (PassWord.Checked)
            {
                PassWordGen pass = new PassWordGen(textBox_password.Text, LengthKey.Text);
                randomArray = pass.Result;
            }

            File.WriteAllBytes(pathFileKey, randomArray);

            FileKeyHEX.Text = StringHEX(randomArray);

            timeFinish = DateTime.Now;
            timeAll = timeFinish - timeStart;
            label_Time.Text = timeAll.ToString(@"hh\:mm\:ss");

            Cursor = Cursors.Default;
            SystemSounds.Hand.Play();
        }

        private void Button_FileKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "MyKey",
                Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt",
                FilterIndex = 2,
                CreatePrompt = true,
                OverwritePrompt = true,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileKey.Text = saveFileDialog.FileName;

                try
                {
                    string pathFileSave = fileKey.Text;
                    randomArray = File.ReadAllBytes(pathFileSave);
                    FileKeyHEX.Text = StringHEX(randomArray);
                    LengthKey.Text = randomArray.Length.ToString();
                }
                catch (Exception)
                {
                    randomArray = new byte[0];
                    File.Create(fileKey.Text);
                }
            }
        }

        private void comboBox_keyLength_byte_TextChanged(object sender, EventArgs e)
        {
            string str = LengthKey.Text;
            if (str != "")
            {
                label_bits.Text = Convert.ToString(Convert.ToInt32(str) * 8);
            }
        }


    }
}
