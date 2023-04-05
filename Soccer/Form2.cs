using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Soccer
{
    public partial class Form2 : Form
    {
        public bool PenaltyShootout;
        public int GoalsForWin, MatchTime, GameMode;
        public HomeTeam home { get; set; }
        public AwayTeam away { get; set; }

        public Form2()
        {
            home = new HomeTeam();
            away = new AwayTeam();
            InitializeComponent();
            if (Program.f1.SinglePlayer == true)
            {
                label1.Text = "Игрок";
                label2.Text = "Компьютер";
            }
            AddTeams(comboBox1);
            AddTeams(comboBox2);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTeam(comboBox1, home);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTeam(comboBox2, away);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PenaltyShootout = checkBox1.Checked;
            try
            {
                MatchTime = Convert.ToInt32(textBox1.Text);
                GoalsForWin = Convert.ToInt32(textBox2.Text);
                Form3 form = new Form3();
                form.Show();
                this.Hide();
            }
            catch
            {
                if (MatchTime > 10 | MatchTime < 2)
                {
                    MessageBox.Show("Время матча может быть от 2 до 10 минут");
                }
                if (GoalsForWin <= 0)
                {
                    MessageBox.Show("Задайте корректное число голов");
                }
                if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false)
                {
                    MessageBox.Show("Выберите уровень сложности");
                }
                if (comboBox1.Text == "" | comboBox2.Text == "")
                {
                    MessageBox.Show("Выберите команды!");
                }
                MessageBox.Show("Ошибка - задайте параметры матча");
            }
        }
        public void AddTeams(ComboBox combo)
        {
            StreamReader r = new StreamReader(@"teams.txt", Encoding.Default);
            string s;
            combo.BeginUpdate();
            while ((s = r.ReadLine()) != null)
            {
                string[] sub = s.Split(',');
                combo.Items.Add(sub[0]);
            }
            r.Close();
        }
        public void ChangeTeam(ComboBox combo, Team team)
        {
            StreamReader r = new StreamReader(@"teams.txt", Encoding.Default);
            string s;
            combo.BeginUpdate();
            while ((s = r.ReadLine()) != null)
            {
                string[] sub = s.Split(',');
                if (sub[0] == combo.Text) { 
                team.Name = sub[0];
                team.Skin = sub[1];
                team.Hair = sub[2];
                team.Shirt = sub[3];
                team.Stripes = sub[4];
                team.Shorts = sub[5];
                team.Socks = sub[6];
                }
            }
            combo.EndUpdate();
            r.Close();
        }
        //private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Program.f1.SinglePlayer = false;
        //    Program.f1.Show();
        //}
    }
}
