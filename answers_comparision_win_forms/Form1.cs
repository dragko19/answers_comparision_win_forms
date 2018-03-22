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
            string filePath = openFileDialog1.FileName;

            Program.obj.File_reader(filePath, 1);
        }

        private void buttonLoadTeachFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = ".txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;

            Program.obj.File_reader(filePath,2);          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.obj.Compare();
        }
    }
}
