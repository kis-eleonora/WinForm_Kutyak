using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WinForm_Kutyak
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "kutyak";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ToString());
            sql = connection.CreateCommand();
            KutyakBetoltes();
        }

        private void KutyakBetoltes()
        {
            listBox_kutyak.Items.Clear();
            try
            {
                connection.Open();
                sql.CommandText = "SELECT `nev`, `fajta`, `suly`, `szuletesi datum` FROM `kutyak` WHERE 1;";
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Kutya uj = new Kutya(dr.GetString("nev"), dr.GetString("fajta"), dr.GetInt32("suly"), dr.GetString("szuletesi datum"));
                        listBox_kutyak.Items.Add(uj);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Kötelező kitölteni!");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Fajta.Text))
            {
                MessageBox.Show("Kötelező kitölteni!");
                return;
            }
            if (numericUpDown_Suly.Equals(null))
            {
                MessageBox.Show("Kötelező kitölteni!");
                return;
            }

            sql.CommandText = "INSERT INTO `kutyak`(`nev`, `fajta`, `suly`, `szuletesi datum`) VALUES (@nev, @fajta, @suly, @datum);";
            sql.Parameters.AddWithValue("@nev", textBox_Nev.Text);
            sql.Parameters.AddWithValue("@fajta", textBox_Fajta.Text);
            sql.Parameters.AddWithValue("@suly", numericUpDown_Suly.Value);
            sql.Parameters.AddWithValue("@datum", dateTimePicker_Datum.Value);
            try
            {
                connection.Open();
                sql.ExecuteNonQuery();
                MessageBox.Show("Sikeres mentés!");
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            connection.Close();
            KutyakBetoltes();
            textBox_Nev.Text = "";
            textBox_Fajta.Text = "";
            numericUpDown_Suly.Value = 0;

        }

        private void listBox_kutyak_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kutya kivalasztott = (Kutya)listBox_kutyak.SelectedItem;
            textBox_Nev.Text = kivalasztott.Nev;
            textBox_Fajta.Text = kivalasztott.Fajta;
            numericUpDown_Suly.Value = (decimal)kivalasztott.Suly;
            dateTimePicker_Datum.Value = DateTime.Parse(kivalasztott.Datum);
        }

        private void button_Torol_Click(object sender, EventArgs e)
        {
            Kutya kiv = (Kutya)listBox_kutyak.SelectedItem;
            try
            {
                connection.Open();
                sql.CommandText = "DELETE FROM `kutyak` WHERE `nev` =" + kiv.Nev;
                sql.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            KutyakBetoltes();
        }

        private void button_Mosodit_Click(object sender, EventArgs e)
        {
            if (listBox_kutyak.SelectedIndex < 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Kötelező kitölteni!");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Fajta.Text))
            {
                MessageBox.Show("Kötelező kitölteni!");
                return;
            }
            if (numericUpDown_Suly.Equals(null))
            {
                MessageBox.Show("Kötelező kitölteni!");
                return;
            }

            sql.CommandText = "UPDATE `kutyak` SET `fajta`= @fajta,`suly`=@suly,`szuletesi datum`= @datum WHERE 'nev' = @nev; ";
            string nev = textBox_Nev.Text;
            string fajta = textBox_Fajta.Text;
            decimal suly = numericUpDown_Suly.Value;
            string datum = dateTimePicker_Datum.Value.ToString();
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@nev", nev);
            sql.Parameters.AddWithValue("@fajta", fajta);
            sql.Parameters.AddWithValue("@suly", suly);
            sql.Parameters.AddWithValue("@datum", datum);
            try
            {
                connection.Open();
                if (sql.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("A módosítás nem sikerült.");
                    return;
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("A módosítás sikeres.");
                    KutyakBetoltes();
                    textBox_Nev.Text = "";
                    textBox_Fajta.Text = "";
                    numericUpDown_Suly.Value = 0;
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            sql.ExecuteNonQuery();
        }
    }
}
