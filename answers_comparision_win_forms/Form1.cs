using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace answers_comparision_win_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadStudFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = ".txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ShowDialog();

            Program.Student.File_reader(openFileDialog1.FileName);

            textBox1.Text = openFileDialog1.FileName;
        }

        private void buttonLoadTeachFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = ".txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog2.ShowDialog();

            Program.Teacher.File_reader(openFileDialog2.FileName);
            textBox2.Text = openFileDialog2.FileName;
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            Program.Output_message.Compare(Program.Student._answers, Program.Teacher._answers);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = ".txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.Output_message.Save_file(saveFileDialog1.FileName);
            }
        }
    }
}
