/*
 Программа "Графический редактор"
 Работа выполнена студентами группы П2-16 Корзухин А.И. и Дуругяном А.В.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Графический_редактор
{
    public partial class MainForm : Form
    {
        string fileName = "";
        string w;
        bool Paint;
        bool Span;
       
        bool flag = false;
        public MainForm()
        
        {
            InitializeComponent();
                   }


        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
              Canvas.Image = Image.FromFile(openFileDialog1.FileName);
              fileName = openFileDialog1.SafeFileName;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Rectangle rec = Canvas.RectangleToScreen(Canvas.ClientRectangle);
            Bitmap bitmap = new Bitmap(Canvas.ClientSize.Width, Canvas.ClientSize.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(rec.Location, new Point(0, 0), rec.Size);
            saveFileDialog1.FileName = fileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                bitmap.Save(saveFileDialog1.FileName);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             Paint = false;
            Span = false;
            saveFileDialog1.Filter = " Рисунок (*.jpg)|*.txt|All files (*.*)|*.*";
            foreach (String Color in Enum.GetNames (typeof(KnownColor)))
                if (Color != "Transparent") ColorBox.Items.Add(Color);
            ColorBox.Text = "Black";
            SizeBox.Text = "15";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            w = PenButton.Text;
            Span = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            w = BrushButton.Text;
            Span = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            w = FillButton.Text;
            Span = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Teby = Canvas.CreateGraphics();
            Teby.Clear(this.BackColor);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Paint = true;
            if (Paint == true && Span == true && w == "Fill")
            {
                var color = Color.FromName(ColorBox.Text);
                Canvas.BackColor = color;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Paint==true && Span==true && w=="Pen")
            {
                
                Graphics g = Canvas.CreateGraphics();
               var d = new Pen(Color.FromName(ColorBox.Text), int.Parse(SizeBox.Text));
                g.DrawLine(d, e.X, e.Y, e.X+ 1, e.Y+1);
            }
            else if(Paint == true && Span == true && w == "Brush")
            {
                Graphics g = Canvas.CreateGraphics();
                SolidBrush shadowBrush = new SolidBrush(Color.FromName(ColorBox.Text));
                g.FillEllipse(shadowBrush, e.X, e.Y, int.Parse(SizeBox.Text), int.Parse(SizeBox.Text));
            }
           



        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Paint = false;
        }

    }
    }

