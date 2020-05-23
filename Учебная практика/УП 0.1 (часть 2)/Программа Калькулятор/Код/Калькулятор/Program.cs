/*
Разработать программу-калькулятор с кнопками цифр. Управление калькулятором возможно только мышью. Данный калькулятор выполняет лишь арифметические операции
Работа выполнена студентами группы П2-16 Вологузовым В.В.и Дуругяном А.В.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
