/*
 Программа "Калькулятор"
 Работа выполнена студентами группы П2-16 Корзухин А.И. и Дуругяном А.В.
 */
using System;
using System.Windows.Forms;
namespace Калькулятор
{
    public partial class Form1 : Form
    {
        // Объявление внешних переменных
        String Znak = String.Empty; // - знак арифметической операции:
        // Признак того, что пользователь вводит новое число:
        Boolean Начало_Ввода = true; 
        // Первое и второе числа, вводимые пользователем:
        Double Число1, Число2; 
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Калькулятор";
            button1.Text = "1";  button2.Text = "2";  button3.Text = "3";
            button4.Text = "4";  button5.Text = "5";  button6.Text = "6";
            button7.Text = "7";  button8.Text = "8";  button9.Text = "9";
            button10.Text = "0"; button11.Text = "="; button12.Text = "+";
            button13.Text = "-"; button14.Text = "*"; button15.Text = "/";
            button16.Text = "Очистить";
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            this.button1.Click += new System.EventHandler(this.ЦИФРА);
            this.button2.Click += new System.EventHandler(this.ЦИФРА);
            this.button3.Click += new System.EventHandler(this.ЦИФРА);
            this.button4.Click += new System.EventHandler(this.ЦИФРА);
            this.button5.Click += new System.EventHandler(this.ЦИФРА);
            this.button6.Click += new System.EventHandler(this.ЦИФРА);
            this.button7.Click += new System.EventHandler(this.ЦИФРА);
            this.button8.Click += new System.EventHandler(this.ЦИФРА);
            this.button9.Click += new System.EventHandler(this.ЦИФРА);
            this.button10.Click += new System.EventHandler(this.ЦИФРА);
            this.button12.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button13.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button14.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button15.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button11.Click += new System.EventHandler(this.РАВНО);
            this.button16.Click += new System.EventHandler(this.ОЧИСТИТЬ);
        }
        private void ЦИФРА(object sender, EventArgs e)
        {
            // Обработка события нажатия кнопки-цифры.
            Button Кнопка = (Button)sender;
            String Digit = Кнопка.Text;
            if (Начало_Ввода == true)
            { 
                textBox1.Text = Digit;
                Начало_Ввода = false; return;
            }
            if (Начало_Ввода == false) 
                       textBox1.Text = textBox1.Text + Digit;
        }
        private void ОПЕРАЦИЯ(object sender, EventArgs e)
        {
            // Обработка события нажатия кнопки арифметической операции:
            Число1 = Double.Parse(textBox1.Text);
            Button Кнопка = (Button)sender;
            Znak = Кнопка.Text;
            Начало_Ввода = true; 
        }
        private void РАВНО(object sender, EventArgs e)
        {
            // Обработка события нажатия клавиши "равно"
            double Результат = 0;
            Число2 = Double.Parse(textBox1.Text);
            if (Znak == "+") Результат = Число1 + Число2;
            if (Znak == "-") Результат = Число1 - Число2;
            if (Znak == "*") Результат = Число1 * Число2;
            if (Znak == "/") Результат = Число1 / Число2;
            Znak = null;
            // Отображение результата в текстовом поле:
            textBox1.Text = Результат.ToString();
            Число1 = Результат; Начало_Ввода = true;
        }
        private void ОЧИСТИТЬ(object sender, EventArgs e)
        {
            // Обработка события нажатия клавиши "Очистить"
            textBox1.Text = "0"; Znak = null; Начало_Ввода = true;
        }
    }
}
