using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WF_Udvoitel
{

    //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
    //в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
    //Вся логика игры должна быть реализована в классе с удвоителем.
    // Дмитрий Волков

    public partial class Form1 : Form
    {
        Stack<int> redo_list = new Stack<int>();
        Random x = new Random();
        private static int Counter = 0;
        int Guess = 0;
        int Steps = 0;

        private void Reset()
        {
            lblNumber.Text = "1";
            Counter = 0;
            btnCommand1.Enabled = false;
            btnCommand2.Enabled = false;
            redo_list.Clear();
        }

        bool Fail()
        {
            if (Counter > Steps) return false;
            return true;
        }

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            redo_list.Push(int.Parse(lblNumber.Text));
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            Counter++;
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            redo_list.Push(int.Parse(lblNumber.Text));
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            Counter++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guess = x.Next(4,20);
            Steps = (int)Math.Round(Math.Sqrt(Guess));
            MessageBox.Show($"Привет! Попробуй набрать число {Guess} за {Steps} шага(ов).");
            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (redo_list.Count>0) lblNumber.Text = redo_list.Pop().ToString();
        }
    }
}
