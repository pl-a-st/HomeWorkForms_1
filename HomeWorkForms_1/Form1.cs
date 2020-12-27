using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        ////Число 1
        /// </summary>
        public double Number1
        {
            get; private set;
        }
        /// <summary>
        ///Число 2
        /// </summary>
        public double Number2
        {
            get; private set;
        }
        /// <summary>
        /// Результат операции
        /// </summary>
        public double ResultOperation
        {
            get; private set;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckResolution();
        }
        /// <summary>
        /// Проверить разрешение вычисления
        /// </summary>
        private void CheckResolution()
        {
            if (resolutionCB.Checked)
            {
                calculateBt.Enabled=true;
            }
            else
            {
                calculateBt.Enabled = false;
            }
        }
       /// <summary>
       /// Проверить и зарегестрировать введенные числа
       /// </summary>
       /// <returns></returns>
        private bool CheckRegisterInputData()
        {
            try
            {
                Number1= Convert.ToDouble(number1TB.Text);
                Number2= Convert.ToDouble(number2TB.Text);
                return true;
            }
            catch
            {
                try
                {
                    Convert.ToDouble(number1TB.Text);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Введите корректное значение в коно \"{0}\"",number1Lb.Text),"Ошибка");
                }
                try
                {
                    Convert.ToDouble(number2TB.Text);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Введите корректное значение в коно \"{0}\"", number2Lb.Text), "Ошибка");
                }
            }
            return false;

        }
        /// <summary>
        /// Изменить разрешение на вычисление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resolutionCB_CheckStateChanged(object sender, EventArgs e)
        {
            CheckResolution();
        }
        /// <summary>
        /// Посчитать результат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateBt_Click(object sender, EventArgs e)
        {
            if(CheckRegisterInputData())
            {
                if (sumRB.Checked)
                {
                    ResultOperation = Number1 + Number2;
                }
                if (differenceRB.Checked)
                {
                    ResultOperation = Number1 - Number2;
                }
                if (multiplicationRB.Checked)
                {
                    ResultOperation = Number1 * Number2;
                }
                if (divisionRB.Checked)
                {
                    ResultOperation = Number1 / Number2;
                }
                ResultOperation = Math.Round(ResultOperation, 2);
                Result.Text = string.Format("Результат: {0}",ResultOperation);
            }
        }
    }
}
