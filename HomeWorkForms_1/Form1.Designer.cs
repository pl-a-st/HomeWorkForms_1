namespace HomeWorkForms_1
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
            this.number1TB = new System.Windows.Forms.TextBox();
            this.number2TB = new System.Windows.Forms.TextBox();
            this.number1Lb = new System.Windows.Forms.Label();
            this.number2Lb = new System.Windows.Forms.Label();
            this.inPutGB = new System.Windows.Forms.GroupBox();
            this.operationsGB = new System.Windows.Forms.GroupBox();
            this.sumRB = new System.Windows.Forms.RadioButton();
            this.differenceRB = new System.Windows.Forms.RadioButton();
            this.multiplicationRB = new System.Windows.Forms.RadioButton();
            this.divisionRB = new System.Windows.Forms.RadioButton();
            this.resolutionCB = new System.Windows.Forms.CheckBox();
            this.calculateBt = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.inPutGB.SuspendLayout();
            this.operationsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // number1TB
            // 
            this.number1TB.Location = new System.Drawing.Point(6, 45);
            this.number1TB.Name = "number1TB";
            this.number1TB.Size = new System.Drawing.Size(107, 20);
            this.number1TB.TabIndex = 0;
            // 
            // number2TB
            // 
            this.number2TB.Location = new System.Drawing.Point(6, 86);
            this.number2TB.Name = "number2TB";
            this.number2TB.Size = new System.Drawing.Size(107, 20);
            this.number2TB.TabIndex = 1;
            // 
            // number1Lb
            // 
            this.number1Lb.AutoSize = true;
            this.number1Lb.Location = new System.Drawing.Point(6, 26);
            this.number1Lb.Name = "number1Lb";
            this.number1Lb.Size = new System.Drawing.Size(48, 13);
            this.number1Lb.TabIndex = 2;
            this.number1Lb.Text = "Число 1";
            // 
            // number2Lb
            // 
            this.number2Lb.AutoSize = true;
            this.number2Lb.Location = new System.Drawing.Point(3, 70);
            this.number2Lb.Name = "number2Lb";
            this.number2Lb.Size = new System.Drawing.Size(48, 13);
            this.number2Lb.TabIndex = 3;
            this.number2Lb.Text = "Число 2";
            // 
            // inPutGB
            // 
            this.inPutGB.Controls.Add(this.number1TB);
            this.inPutGB.Controls.Add(this.number2TB);
            this.inPutGB.Controls.Add(this.number2Lb);
            this.inPutGB.Controls.Add(this.number1Lb);
            this.inPutGB.Location = new System.Drawing.Point(12, 12);
            this.inPutGB.Name = "inPutGB";
            this.inPutGB.Size = new System.Drawing.Size(119, 118);
            this.inPutGB.TabIndex = 4;
            this.inPutGB.TabStop = false;
            this.inPutGB.Text = "Входные данные";
            // 
            // operationsGB
            // 
            this.operationsGB.Controls.Add(this.resolutionCB);
            this.operationsGB.Controls.Add(this.divisionRB);
            this.operationsGB.Controls.Add(this.multiplicationRB);
            this.operationsGB.Controls.Add(this.differenceRB);
            this.operationsGB.Controls.Add(this.sumRB);
            this.operationsGB.Location = new System.Drawing.Point(160, 12);
            this.operationsGB.Name = "operationsGB";
            this.operationsGB.Size = new System.Drawing.Size(238, 118);
            this.operationsGB.TabIndex = 5;
            this.operationsGB.TabStop = false;
            this.operationsGB.Text = "Операции";
            // 
            // sumRB
            // 
            this.sumRB.AutoSize = true;
            this.sumRB.Location = new System.Drawing.Point(7, 20);
            this.sumRB.Name = "sumRB";
            this.sumRB.Size = new System.Drawing.Size(59, 17);
            this.sumRB.TabIndex = 0;
            this.sumRB.TabStop = true;
            this.sumRB.Text = "Сумма";
            this.sumRB.UseVisualStyleBackColor = true;
            // 
            // differenceRB
            // 
            this.differenceRB.AutoSize = true;
            this.differenceRB.Location = new System.Drawing.Point(7, 43);
            this.differenceRB.Name = "differenceRB";
            this.differenceRB.Size = new System.Drawing.Size(73, 17);
            this.differenceRB.TabIndex = 1;
            this.differenceRB.TabStop = true;
            this.differenceRB.Text = "Разность";
            this.differenceRB.UseVisualStyleBackColor = true;
            // 
            // multiplicationRB
            // 
            this.multiplicationRB.AutoSize = true;
            this.multiplicationRB.Location = new System.Drawing.Point(7, 66);
            this.multiplicationRB.Name = "multiplicationRB";
            this.multiplicationRB.Size = new System.Drawing.Size(85, 17);
            this.multiplicationRB.TabIndex = 2;
            this.multiplicationRB.TabStop = true;
            this.multiplicationRB.Text = "Умножение";
            this.multiplicationRB.UseVisualStyleBackColor = true;
            // 
            // divisionRB
            // 
            this.divisionRB.AutoSize = true;
            this.divisionRB.Location = new System.Drawing.Point(7, 89);
            this.divisionRB.Name = "divisionRB";
            this.divisionRB.Size = new System.Drawing.Size(70, 17);
            this.divisionRB.TabIndex = 3;
            this.divisionRB.TabStop = true;
            this.divisionRB.Text = "Деление";
            this.divisionRB.UseVisualStyleBackColor = true;
            // 
            // resolutionCB
            // 
            this.resolutionCB.AutoSize = true;
            this.resolutionCB.Location = new System.Drawing.Point(99, 22);
            this.resolutionCB.Name = "resolutionCB";
            this.resolutionCB.Size = new System.Drawing.Size(136, 17);
            this.resolutionCB.TabIndex = 4;
            this.resolutionCB.Text = "Разрешить посчитать";
            this.resolutionCB.UseVisualStyleBackColor = true;
            // 
            // calculateBt
            // 
            this.calculateBt.Location = new System.Drawing.Point(160, 136);
            this.calculateBt.Name = "calculateBt";
            this.calculateBt.Size = new System.Drawing.Size(238, 55);
            this.calculateBt.TabIndex = 6;
            this.calculateBt.Text = "Посчитать";
            this.calculateBt.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(18, 157);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(62, 13);
            this.Result.TabIndex = 7;
            this.Result.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 207);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.calculateBt);
            this.Controls.Add(this.operationsGB);
            this.Controls.Add(this.inPutGB);
            this.Name = "Form1";
            this.Text = "Задание 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inPutGB.ResumeLayout(false);
            this.inPutGB.PerformLayout();
            this.operationsGB.ResumeLayout(false);
            this.operationsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1TB;
        private System.Windows.Forms.TextBox number2TB;
        private System.Windows.Forms.Label number1Lb;
        private System.Windows.Forms.Label number2Lb;
        private System.Windows.Forms.GroupBox inPutGB;
        private System.Windows.Forms.GroupBox operationsGB;
        private System.Windows.Forms.CheckBox resolutionCB;
        private System.Windows.Forms.RadioButton divisionRB;
        private System.Windows.Forms.RadioButton multiplicationRB;
        private System.Windows.Forms.RadioButton differenceRB;
        private System.Windows.Forms.RadioButton sumRB;
        private System.Windows.Forms.Button calculateBt;
        private System.Windows.Forms.Label Result;
    }
}

