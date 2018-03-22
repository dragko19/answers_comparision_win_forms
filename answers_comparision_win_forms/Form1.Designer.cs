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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonLoadStudFile
            // 
            this.buttonLoadStudFile.Location = new System.Drawing.Point(77, 116);
            this.buttonLoadStudFile.Name = "buttonLoadStudFile";
            this.buttonLoadStudFile.Size = new System.Drawing.Size(75, 31);
            this.buttonLoadStudFile.TabIndex = 0;
            this.buttonLoadStudFile.Text = "Load";
            this.buttonLoadStudFile.UseVisualStyleBackColor = true;
            this.buttonLoadStudFile.Click += new System.EventHandler(this.buttonLoadStudFile_Click);
            // 
            // buttonLoadTeachFile
            // 
            this.buttonLoadTeachFile.Location = new System.Drawing.Point(288, 116);
            this.buttonLoadTeachFile.Name = "buttonLoadTeachFile";
            this.buttonLoadTeachFile.Size = new System.Drawing.Size(75, 31);
            this.buttonLoadTeachFile.TabIndex = 1;
            this.buttonLoadTeachFile.Text = "Load";
            this.buttonLoadTeachFile.UseVisualStyleBackColor = true;
            this.buttonLoadTeachFile.Click += new System.EventHandler(this.buttonLoadTeachFile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Compare";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 82);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonLoadTeachFile);
            this.Controls.Add(this.buttonLoadStudFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadStudFile;
        private System.Windows.Forms.Button buttonLoadTeachFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

