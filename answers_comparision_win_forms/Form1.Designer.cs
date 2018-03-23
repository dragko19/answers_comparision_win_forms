namespace answers_comparision_win_forms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadStudFile = new System.Windows.Forms.Button();
            this.buttonLoadTeachFile = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadStudFile
            // 
            this.buttonLoadStudFile.Location = new System.Drawing.Point(77, 101);
            this.buttonLoadStudFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoadStudFile.Name = "buttonLoadStudFile";
            this.buttonLoadStudFile.Size = new System.Drawing.Size(75, 31);
            this.buttonLoadStudFile.TabIndex = 0;
            this.buttonLoadStudFile.Text = "Load";
            this.buttonLoadStudFile.UseVisualStyleBackColor = true;
            this.buttonLoadStudFile.Click += new System.EventHandler(this.buttonLoadStudFile_Click);
            // 
            // buttonLoadTeachFile
            // 
            this.buttonLoadTeachFile.Location = new System.Drawing.Point(283, 101);
            this.buttonLoadTeachFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoadTeachFile.Name = "buttonLoadTeachFile";
            this.buttonLoadTeachFile.Size = new System.Drawing.Size(75, 31);
            this.buttonLoadTeachFile.TabIndex = 1;
            this.buttonLoadTeachFile.Text = "Load";
            this.buttonLoadTeachFile.UseVisualStyleBackColor = true;
            this.buttonLoadTeachFile.Click += new System.EventHandler(this.buttonLoadTeachFile_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(180, 186);
            this.buttonCompare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(87, 32);
            this.buttonCompare.TabIndex = 2;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Load student\'s file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Load teacher\'s file";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogStudent";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialogTeacher";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.textBox1.Location = new System.Drawing.Point(16, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 138);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(180, 255);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 32);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 363);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonLoadTeachFile);
            this.Controls.Add(this.buttonLoadStudFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadStudFile;
        private System.Windows.Forms.Button buttonLoadTeachFile;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSave;
    }
}

