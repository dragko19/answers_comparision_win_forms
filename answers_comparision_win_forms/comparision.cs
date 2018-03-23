using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;


namespace answers_comparision_win_forms
{
    class Comparision
    {
        public List<string> _answers { get; private set; }
        public Comparision()
        {
            _answers = new List<string>();
        }

        public void Set_answers(params string[] list)
        {
            foreach(string elem in list)
            {
                _answers.Add(elem);
            }
        }

        public void File_reader(string path)
        {
            StreamReader sr;
            string line;
            try
            {
                sr = new StreamReader(path);
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToUpper();
                    _answers.Add(line);
                }
                sr.Close();
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Cannot open File: {0}", path);
            }        
            catch (Exception)
            {
                MessageBox.Show("Error occured during reading file: {0}", path);
            }      
            
        }
    }


    class Messenger
    {
        private int Errors = 0;
        private int Points = 0;
        private int Questions = 0;
        private MemoryStream memStr;
        
        public Messenger()
        {
            try
            {
                memStr = new MemoryStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Compare(List<string> tested_answers, List<string> correct_answers)
        {
            if (tested_answers.Count() != correct_answers.Count())
                MessageBox.Show("Different number of answers, cannot compare!");
            else
            {
                if (tested_answers.Count() == 0 || correct_answers.Count() == 0)
                    MessageBox.Show("One of files is empty, cannot compare!");
                else
                {
                    for (int i = 0; i < tested_answers.Count(); i++)
                        if (tested_answers[i] == correct_answers[i])
                            Add_message(tested_answers[i], correct_answers[i], true);
                        else
                            Add_message(tested_answers[i], correct_answers[i], false);
                    MessageBox.Show("Comparing complete!");
                }
            }
        }

        public void Add_message(string Student_answer, string Teacher_answer, bool confirmation)
        {
            Questions++;
            if (confirmation) Points++;
            else Errors++;

            StreamWriter strWr = new StreamWriter(memStr);

            strWr.WriteLine("Pytanie nr: {0}", Questions);
            strWr.WriteLine("Odpowiedz ucznia: " + Student_answer);
            strWr.WriteLine("Poprawna: " + Teacher_answer);
            strWr.WriteLine("Ilosc bledow: " + Errors);
            strWr.WriteLine("Wynik: " + Points + "/" + Questions);
            strWr.WriteLine("/--------------------------------------/");
            strWr.Flush();
        }

        public void Save_file(string path)
        {
            memStr.Seek(0, SeekOrigin.Begin);
            try
            {
                using (FileStream fS = new FileStream(path, FileMode.OpenOrCreate))
                {
                    memStr.CopyTo(fS);
                    fS.Flush();
                    MessageBox.Show("Process complete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   
    } 
}
