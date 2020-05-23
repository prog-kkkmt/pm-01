using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DBComplexProgramm
{
    public partial class Form1 : Form
    {
        // Объявляем глобальные переменные
        DataSet наборДанных, наборДанныхДоходы, наборДанныхРасходы;
        OleDbDataAdapter адаптер, адаптерДоходы, адаптерРасходы;
        OleDbConnection подключение;
        OleDbCommand команда;
        string назвТабл = "empty";
        string curRecord = "-1";
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Связываем обработчик событий для смены таблиц
            this.доходыToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьТаблицу);
            this.расходыToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьТаблицу);

            panel1.Visible = false;
            panel2.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            saveWord.Visible = false;
            saveExcel.Visible = false;
            btnSave.Visible = false;
            btnInsert.Visible = false;
            выполнитьЗапросToolStripMenuItem.Visible = false;

            labelWord.Text = "Word";
            labelWord.ForeColor = System.Drawing.Color.Blue;
            labelWord.Font = new System.Drawing.Font("", 11, System.Drawing.FontStyle.Regular);
            labelWord.Visible = false;

            labelExcel.Text = "Excel";
            labelExcel.ForeColor = System.Drawing.Color.Green;
            labelExcel.Font = new System.Drawing.Font("", 11, System.Drawing.FontStyle.Regular);
            labelExcel.Visible = false;

     

            saveWord.Text = "Вывод";
            saveExcel.Text = "Вывод";
            btnSave.Text = "Сохранить изменения";
            btnInsert.Text = "Добавить запись";
            this.Text = "База данных \"Семейный бюджет\"";
            string путь =
            System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Семейный бюджет2.mdb");

            // Создаём подключение
            подключение = new OleDbConnection(
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + путь);
            
            наборДанных = new DataSet();
            команда = new OleDbCommand();

            if (подключение.State == ConnectionState.Closed)
                подключение.Open();

            наборДанныхДоходы = new DataSet();
            наборДанныхРасходы = new DataSet();


            адаптерДоходы = new OleDbDataAdapter(
                "Select * From [Доходы]", подключение);
            адаптерДоходы.Fill(наборДанныхДоходы, "Доходы");
            dataGridViewДоходы.DataSource = наборДанныхДоходы;
            dataGridViewДоходы.DataMember = "Доходы";

     
            адаптерРасходы = new OleDbDataAdapter(
                "Select * From [Расходы]", подключение);
            адаптерРасходы.Fill(наборДанныхРасходы, "Расходы");
            dataGridViewРасходы.DataSource = наборДанныхРасходы;
            dataGridViewРасходы.DataMember = "Расходы";
            подключение.Close();
        }



        // Сохранение изменений полей
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
                return;

            // Оперируем с выбранной таблицей
            switch (назвТабл)
            {
                case "Доходы":
                    {
                        команда.CommandText = "Update [Доходы] Set" +
                            "[Источник] = ?, [Сумма] = ? " +
                            "Where ([Номер] = ?)";

                        команда.Parameters.Add(
                            "Источник", OleDbType.VarWChar, 50, "Источник");
                        команда.Parameters.Add(
                            "Сумма", OleDbType.Decimal, 50, "Сумма");

                        break;
                    }

                case "Расходы":
                    {
                        команда.CommandText = "Update [Расходы] Set" +
                            "[Статья] = ?, [Предмет] = ?, " +
                            "[Цена] = ? Where ([Номер] = ?)";

                        команда.Parameters.Add(
                            "Статья", OleDbType.VarWChar, 50, "Статья");
                        команда.Parameters.Add(
                            "Предмет", OleDbType.VarWChar, 50, "Предмет");
                        команда.Parameters.Add(
                            "Цена", OleDbType.Decimal, 50, "Цена");

                        break;
                    }

                default:
                    break;
            }

            // Задаём общий параметр
            команда.Parameters.Add(
                new OleDbParameter(
                    "Номер", OleDbType.Integer, 0, ParameterDirection.Input,
                    false, (Byte)0, (Byte)0, "Номер", System.Data.DataRowVersion.Original, null));

            // Связываем адаптер и подключение
            адаптер.UpdateCommand = команда;
            команда.Connection = подключение;

            // Обновляем данные в БД

            адаптер.Update(наборДанных, назвТабл);
            ОбновитьТаблицу();


        }

        // Загрузка выбранной таблицы
        private void ЗагрузитьТаблицу(object sender, EventArgs e)
        {
            // Получаем название таблицы
            назвТабл = Convert.ToString(((ToolStripMenuItem)sender).Text);

            подключение.Open();

            // Передаём данные в адаптер
            адаптер = new OleDbDataAdapter(
                "Select * From [" + назвТабл + "]", подключение);
            ОбновитьТаблицу();
            подключение.Close();
        }

        // Обноление таблицы
        private void ОбновитьТаблицу()
        {
            // С помощью этого адаптера заполняем промежуточную таблицу
            наборДанных.Clear();
            адаптер.Fill(наборДанных, назвТабл);

            // Заполняем таблицу интерфейса
            dataGridView1.DataSource = наборДанных;
            dataGridView1.DataMember = назвТабл;
        }

        // Получение индекса нажатой записи
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            curRecord = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        // Добавление новой записи
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //if (подключение.State == ConnectionState.Closed)
            //return;

            подключение.Open();
            // Добавление записи в соответствии с выбранной таблицей
            string rec1 = (dataGridView1.Rows.Count - 1).ToString();
            //MessageBox.Show(dataGridView1.Rows[dataGridView1.Rows.Count-2].Cells[1].Value.ToString());
            string rec2 = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value.ToString();
            string rec3 = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value.ToString();


            // Если хотя бы одно значение не указано то прерываем работу функции
            if (rec2 == "" || rec3 == "")
            {
                MessageBox.Show("Заполнены не все поля.");
                ОбновитьТаблицу();
                подключение.Close();
                return;
            }
            switch (назвТабл)
            {
                case "Доходы":

                    команда.CommandText = "Insert into [Доходы]" +
                        "([Номер], [Источник], [Сумма])" +
                        "Values (" + rec1 + ", " + rec2 + ", " + rec3 + ")";
                    break;

                case "Расходы":

                    string rec4 = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value.ToString();
                    команда.CommandText = "Insert into [Расходы]" +
                        "([Номер], [Статья], [Предмет], [Цена])" +
                        "Values (" + rec1 + ", " + rec2 + ", " + rec3 + ", " + rec4 + ")";
                    break;

                default:
                    break;
            }

            команда.Connection = подключение;
            try { команда.ExecuteNonQuery(); }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка.");
            }

            ОбновитьТаблицу();
            подключение.Close();
        }

        // Удаление выбранной записи
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                return;
            MessageBox.Show("Delete");
            if (подключение.State == ConnectionState.Closed)
                подключение.Open();

            // Текст комманды и её выполнение
            команда.CommandText = "Delete * From [" + назвТабл + "] " +
                "Where [Номер] = " + curRecord;
            команда.Connection = подключение;
            команда.ExecuteNonQuery();

            // Обновляем dataGrid
            dataGridView1.DataSource = наборДанных;

            подключение.Close();

        }

        // При закрытии формы закрываем подключение если оно открыто
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (подключение.State == ConnectionState.Open)
                подключение.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (подключение.State == ConnectionState.Closed)
                подключение.Open();

            наборДанныхДоходы = new DataSet();
            наборДанныхРасходы = new DataSet();

            адаптерДоходы = new OleDbDataAdapter(
                "Select * From [Доходы]", подключение);
            адаптерДоходы.Fill(наборДанныхДоходы, "Доходы");
            dataGridViewДоходы.DataSource = наборДанныхДоходы;
            dataGridViewДоходы.DataMember = "Доходы";
            подключение.Close();
        }

        

        private void выполнитьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            saveWord.Visible = true;
            panel2.Visible = true;
            saveExcel.Visible = true;
            labelWord.Visible = true;
            labelExcel.Visible = true;

            int a1 = 0;
            a1++;
            MessageBox.Show("" + (char)a1 + "");

            подключение.Open();


            var командаЗапрос = new OleDbCommand(
                "Select * From [Расходы] Where [Цена] > 0", подключение);

            var адаптерЗапрос = new OleDbDataAdapter(командаЗапрос);

            var наборДанныхЗапрос = new DataSet();

            адаптерЗапрос.Fill(наборДанныхЗапрос, "Сделки");

            dataGridView2.DataSource = наборДанныхЗапрос;
            dataGridView2.DataMember = "Сделки";
            try {
                string fileName = @"G:\data.xml";
                наборДанных = (DataSet)dataGridView1.DataSource;
                наборДанных.WriteXml(fileName);
            }
            catch {
                MessageBox.Show("Файл уже существует");
            };
          
            подключение.Close();
        }

        //Вывод в Word
        private void saveWord_Click(object sender, EventArgs e)
        {
            string rec1 = (dataGridView2.Rows.Count - 1).ToString();
            //MessageBox.Show(dataGridView1.Rows[dataGridView1.Rows.Count-2].Cells[1].Value.ToString());
            string rec2 = dataGridView2.Rows[dataGridView2.Rows.Count - 2].Cells[1].Value.ToString();
            string rec3 = dataGridView2.Rows[dataGridView2.Rows.Count - 2].Cells[2].Value.ToString();
            string rec4 = dataGridView2.Rows[dataGridView2.Rows.Count - 2].Cells[3].Value.ToString();

            // Создаем новый экземпляр класса Word.Application:
            var Word1 = new Microsoft.Office.Interop.
                                      Word.Application();
            Word1.Visible = true;
            // Открываем новый документ MS Word:
            var Документ = Word1.Documents.Add();
            //Word1.ActiveDocument.Paragraphs.Add();
            

            Word1.ActiveDocument.Paragraphs[1].Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            
            var t3 = Microsoft.Office.Interop.Word.WdUnits.wdLine;
            // Вводим текст в документ MS WORD с текущей позиции:
            Word1.Selection.TypeText("ИТОГИ СЕМЕЙНОГО БЮДЖЕТА ЗА МЕСЯЦ");

            var w1 = dataGridViewРасходы.Rows.Count - 1;
            var h1 = dataGridViewРасходы.Columns.Count;
            var w2 = dataGridViewДоходы.Rows.Count - 1;
            var h2 = dataGridViewДоходы.Columns.Count;

            Word1.ActiveDocument.Paragraphs[1].Range.Font.Name = "Century Gothic";
            Word1.ActiveDocument.Paragraphs[1].Range.Font.Size = 15;
            Word1.Selection.TypeParagraph();
            //Word1.Selection.MoveDown(t3, 10, null);
            // Параметр, указывающий покаывать ли границы ячеек:
            var t1 = Microsoft.Office.Interop.
                         Word.WdDefaultTableBehavior.wdWord9TableBehavior;

            // Параметр, указывающий будет ли приложение Word автоматически
            // изменять размер ячеек в таблице для подгонки содержимого:
            var t2 = Microsoft.Office.Interop.
                         Word.WdAutoFitBehavior.wdAutoFitContent;
            Word1.Selection.TypeParagraph();
            //Word1.ActiveDocument.Paragraphs[2].Range.Text = "ДОХОДЫ";
            Word1.Selection.TypeText("ДОХОДЫ");
            // создание таблицы

            Word1.ActiveDocument.Tables.Add(Word1.Selection.Range,
                                                          w2, h2, t1, t2);
            Word1.ActiveDocument.Tables[1].Range.Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowCenter;
            var sumdoh = 0;
            // Заполнять ячейки таблицы можно так:
            for (int i = 0; i < w2; i++)
            {
                for (int j = 0; j < h2; j++)
                {
                    Word1.ActiveDocument.Tables[1].Cell(i + 1, j + 1).
                                         Range.InsertAfter(dataGridViewДоходы.Rows[i].Cells[j].Value.ToString());
                    if (j == h2 - 1)
                        sumdoh = sumdoh + int.Parse(dataGridViewДоходы.Rows[i].Cells[j].Value.ToString());
                }
            }
            // Назначаем единицы измерения в документе приложения MS Word:


            
            // Параметр, указывающий на девятую строку в документе MS Word:


            // Перевести текущую позицию (Selection) за пределы таблицы,
            // (в девятую строку), чтобы здесь вывести какой-либо текст:
            Word1.Selection.MoveDown(t3, 10, null);
            //Word1.Selection.Paragraphs.SpaceBefore = 10;
            Word1.Selection.TypeParagraph();
            Word1.Selection.TypeText("РАСХОДЫ");
            //Word1.Selection.MoveRight(t34, w1, null);
            Word1.ActiveDocument.Tables.Add(Word1.Selection.Range,
                                                          w1, h1, t1, t2);
            var sumras = 0;
            Word1.ActiveDocument.Tables[2].Range.Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowCenter;
            for (int i = 0; i < w1; i++)
            {
                for (int j = 0; j < h1; j++)
                {
                    Word1.ActiveDocument.Tables[2].Cell(i + 1, j + 1).
                                         Range.InsertAfter(dataGridViewРасходы.Rows[i].Cells[j].Value.ToString());
                    if (j == h1 - 1)
                        sumras = sumras + int.Parse(dataGridViewРасходы.Rows[i].Cells[j].Value.ToString());
                }
            }


            var sum = sumdoh - sumras;
            Word1.Selection.MoveDown(t3, 10, null);
            Word1.Selection.TypeParagraph();

            //Создание и настройка итоговой таблицы
            Word1.ActiveDocument.Tables.Add(Word1.Selection.Range,
                                                          1, 2, t1, t2);

            Word1.ActiveDocument.Tables[3].Range.Rows.Alignment = Microsoft.Office.Interop.Word.WdRowAlignment.wdAlignRowCenter;
            Word1.ActiveDocument.Tables[3].Range.Borders.Enable = 0;
            Word1.ActiveDocument.Tables[3].Range.Cells.Borders.Enable = 0;

            Word1.ActiveDocument.Tables[3].Cell(1, 1).
                                         Range.InsertAfter("Итог:");
            if (sumdoh > sumras)
            Word1.ActiveDocument.Tables[3].Cell(1, 2).
                                         Range.InsertAfter("+" + sum + "");
            else if (sumdoh < sumras)
            Word1.ActiveDocument.Tables[3].Cell(1, 2).
                                         Range.InsertAfter("-" + sum + "");
            else
                Word1.ActiveDocument.Tables[3].Cell(1, 2).
                                             Range.InsertAfter("" + sum + "");



        }

        private void доходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                выполнитьЗапросToolStripMenuItem.Visible = true;
                btnInsert.Visible = true;
                btnSave.Visible = true;
                panel1.Visible = true;
            }
        }

        private void расходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                выполнитьЗапросToolStripMenuItem.Visible = true;
                btnInsert.Visible = true;
                btnSave.Visible = true;
                panel1.Visible = true;
            }
        }

        //Вывод в Excel
        private void saveExcel_Click(object sender, EventArgs e)
        {
            var Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Visible = true;

            var t = Type.Missing;
            var Книга = Excel.Workbooks.Add(t);

            var Листы = Книга.Worksheets;
            Worksheet Лист = Листы.Item[1];

            var w1 = dataGridViewРасходы.Rows.Count - 1;
            var h1 = dataGridViewРасходы.Columns.Count;
            var w2 = dataGridViewДоходы.Rows.Count - 1;
            var h2 = dataGridViewДоходы.Columns.Count;
            int ord = 64;

            for (int i = 1; i <= w1; i++)
            {
                
                for (int j = 1; j <= h1; j++)
                {
                    ord++;
                    Лист.Range["" + (char)ord + "" + i, t].Value2 = dataGridViewРасходы.Rows[i-1].Cells[j-1].Value.ToString();
                }
                ord = 64;
            }

        }
    }
}
