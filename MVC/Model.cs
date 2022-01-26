using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVC
{
    public static class Model
    {
        public static TextBlock TBlockAnswer;
        public static TextBlock TBlockOperation;
        public static TextBox TBoxNum1;
        public static TextBox TBoxNum2;

        public static List<string> listOperations = new List<string>() {"Сложение","Вычитание","Умножение","Деление"};
        static int selectedOperation;

        public static int SelectCombo
        {
            set
            {
                selectedOperation = value;
                switch(value)
                {
                    case 0: TBlockOperation.Text = "+";
                        break;
                    case 1: TBlockOperation.Text = "-";
                        break;
                    case 2:
                        TBlockOperation.Text = "х";
                        break;
                    case 3:
                        TBlockOperation.Text = "/";
                        break;
                }
            }
        }

        public static void Counting()
        {
            try
            {
                double firstNum = Convert.ToDouble(TBoxNum1.Text);
                double secondNum = Convert.ToDouble(TBoxNum2.Text);
                if (Double.IsNaN(firstNum) || Double.IsNaN(secondNum))
                {
                    throw new Exception("Введите цифры для выполнения операций!");
                }
                switch (selectedOperation)
                {
                    case 0:
                        TBlockAnswer.Text = ""+(firstNum + secondNum);
                        break;
                    case 1:
                        TBlockAnswer.Text = "" + (firstNum - secondNum);
                        break;
                    case 2:
                        TBlockAnswer.Text = "" + (firstNum * secondNum);
                        break;
                    case 3:
                        TBlockAnswer.Text = "" + (firstNum / secondNum);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
           
        }
    }
}
