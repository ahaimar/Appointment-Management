using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;
namespace Projet_Achraf
{
    public partial class FLogin : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st, imgpath;
        public string key = "ab1ab2ab3ab4ab5ab6ab7ab8";
        public DateTime d = DateTime.Now;

        public FLogin()
        {
            InitializeComponent();
        }//
        public void Lister()
        {
            db.cn.Open();
            st = "select cin, nom, prenom, adrsse, mdSu FROM `mydata`.`t1` where day (dateR)<= NOW() and TIME (dateR) BETWEEN('08:00:00' and '16:00:00') and isSup=0 ORDER BY dateR; ";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            DataGridView1.Rows.Clear();
            while (dr.Read())
            {
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            db.cn.Close();
        }

        public void loginuser()
        {
            db.cn.Open(); //and isactivated=1
            st = "SELECT * FROM `mydata`.`userM` where `nom`='" + txtNom.Text + "' and `passWord`='" + txtPas.Text + "'";//encryptedString
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                menuStrip1.Enabled = true;
                db.userid = dr[0].ToString();

            }
            else
                MessageBox.Show("Nom d'utilisateur ou le mot de passe incorect");
            db.cn.Close();
        }
        private void medecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FMedecin().Show();
        }

        private void gestionDeRenfezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new APatient().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        { 
            new SingUP().Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loginuser();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Lister();
            }
            catch(Exception ex ){MessageBox.Show(ex.Message);}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Invoices().Show();
        }
    }
}