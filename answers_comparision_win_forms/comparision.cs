using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace answers_comparision_win_forms
{
    class Comparision
    {
        public List<string> _student_answers { get; private set; }
        public List<string> _teacher_answers { get; private set; }
        public Messenger Message { get; private set; }
        public Comparision()
        {
            _student_answers = new List<string>();
            _teacher_answers = new List<string>();
            Message = new Messenger();
            File_reader("student.txt",1);
            File_reader("teacher.txt",2);
        }

        public void Set_student_answers(params string[] list)
        {
            foreach(string elem in list)
            {
                _student_answers.Add(elem);
            }
        }
        public void Set_teacher_answers(params string[] list)
        {
            foreach (string elem in list)
            {
                _teacher_answers.Add(elem);
            }
        }
        public void Compare()
        {
            if (_student_answers.Count() != _teacher_answers.Count())
                Console.WriteLine("Different number of answers, cannot compare!");
            else
            {
                for (int i = 0; i < (int)_student_answers.Count(); i++)
                    if (_student_answers[i] == _teacher_answers[i])
                        Message.Add_message(_student_answers[i], _teacher_answers[i], true);
                    else
                        Message.Add_message(_student_answers[i], _teacher_answers[i], false);
            }
        }

        public void File_reader(string path, byte param)
        {
            StreamReader sr;
            string line;
            try
            {
                sr = new StreamReader(path);
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToUpper();
                    if (param == 1)
                        _student_answers.Add(line);
                    if (param == 2)
                        _teacher_answers.Add(line);
                }
                sr.Close();
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Cannot open File: {0}", path);
            }        
            catch (Exception ex)
            {
                Console.WriteLine("Error occured during reading file: {0}", path);
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
            FileInfo fi;
            try
            {
                fi = new FileInfo("report.txt");
                if (fi.Exists)
                    fi.Delete();

                memStr = new MemoryStream();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

        public void Save(string path)
        {
            memStr.Seek(0, SeekOrigin.Begin);
            try
            {
                using (FileStream fS = new FileStream(path, FileMode.OpenOrCreate))
                {
                    memStr.CopyTo(fS);
                    fS.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        

    } 
}


/*Odpowiedzi ucznia         Poprawna
A                                     A
Rezultat :
Ilosc błedów 0
Wynik 1/1
*/
