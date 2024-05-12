using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet_Achraf
{
    public partial class Invoices : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st;
        public Invoices()
        {
            InitializeComponent();
        }
        /*public int res()
        {
            int a = 0;
            try
            {
                db.cn.Open();
                st = "SELECT max(numFac) FROM fac";
                cmd = new MySqlCommand(st, db.cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a = Convert.ToInt32(dr[0]);
                    a++;
                    break;
                }
                db.cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return a;
        }*/
        public void enregistrer()
        {
            //int c = res();
            db.cn.Open();
            st = "INSERT INTO `mydata`.`fac` (`numFac`, `cinP`, `nomP`, `preP`, `dateR`, `nomM`, `preM`, `farm`, `com`, `fac`) VALUES ('"+txtNum.Text+"', '"+comboBox1.Text+"', '"+txtNom.Text+"','"+txtPre.Text+"', '"+dateTimePicker1.Text+"', '"+comboBox2.Text+"', '"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox5.Text+"', '"+textBox4.Text+"')";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("L'information de Medecin est bien enregistrer . ");
        }
        public void rechercher2()
        {
            db.cn.Open();
            st = "SELECT * FROM t2 WHERE cin = '" + comboBox2.Text + "'";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
            }
            db.cn.Close();
        }
        public void remplir2()
        {
            try
            {
                db.cn.Open();
                st = "SELECT cin FROM t2";//
                cmd = new MySqlCommand(st, db.cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr[0]);
                }
                db.cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void remplir()
        {
            try
            {
                db.cn.Open();
                st = "SELECT cin FROM t1 where isSup=0";//
                cmd = new MySqlCommand(st, db.cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0]);
                }
                db.cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void rechercher()
        {
            try
            {
                db.cn.Open();
                st = "SELECT * FROM t1 WHERE cin ='" + comboBox1.Text+ "' and isSup=0";// 
                cmd = new MySqlCommand(st, db.cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNom.Text = dr[1].ToString();
                    txtPre.Text = dr[2].ToString();
                    dateTimePicker1.Text = dr[5].ToString();
                }
                db.cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void cmbCin_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercher();
        }
        private void cmbCin_Click(object sender, EventArgs e)
        {
            remplir();
        }
        private void cmbCin2_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercher2();
        }
        private void cmbCin2_Click(object sender, EventArgs e)
        {
            remplir2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enregistrer();
        }

    }
}
