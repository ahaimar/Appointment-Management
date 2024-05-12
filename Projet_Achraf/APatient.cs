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


    public partial class APatient : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st;
        public APatient()
        {
            InitializeComponent();
        }
        public void vouveau()
        {
            cmbCin.Text = null;
            txtnom.Text = null;
            txtPre.Text = null;
            txtTel.Text = null;
            txtPre.Text = null;
            txtAdr.Text = null;
            dateTimePicker1.Text = null;
            cmbMeSu.Text = null;
            txtnom.Focus();
        }
        public void enregistrer()
        {
            db.cn.Open();

            st = "INSERT INTO `mydata`.`t1` (`cin`, `nom`, `prenom`, `tel`, `adrsse`, `dateR`, `dateN`,`isSup`,`mdSu`) VALUES ('" + cmbCin.Text + "', '" + txtnom.Text + "', '" + txtPre.Text + "', '" + txtAdr.Text + "', '" + txtTel.Text + "', '" + dateTimePicker1.Text + "', now(),0,'" + cmbMeSu.Text + "')";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show(" V1");


        }
        public void modifier()
        {
            db.cn.Open();
            st = "UPDATE `mydata`.`t1` SET `nom`='" + txtnom.Text + "', `prenom`='" + txtPre.Text + "', `tel`='" + txtTel.Text + "', `adrsse`='" + txtAdr.Text + "', `dateR`='" + dateTimePicker1.Text + "' WHERE  `cin`='" + cmbCin.Text + "'";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("le rendez-vous de Patient est bien Modifier .");


        }
        public void Lister()
        {
            db.cn.Open();
            st = "SELECT * FROM t1 WHERE   isSup=0 order by dateN";// `isSup`
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            DataGridView1.Rows.Clear();
            while (dr.Read())
            {
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[8].ToString());//
            }
            db.cn.Close();
        }
        public void supprimer()
        {
            db.cn.Open();
            st = "update  t1 SET `isSup`=1 where cin = '" + cmbCin.Text + "'";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("LE modules est bien supprimer");

        }
        public void rechercher()
        {
            try
            {
                db.cn.Open();
                st = "SELECT * FROM t1 WHERE cin ='" + cmbCin.Text + "' and isSup=0";// 
                cmd = new MySqlCommand(st, db.cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbCin.Text = dr[0].ToString();
                    txtnom.Text = dr[1].ToString();
                    txtPre.Text = dr[2].ToString();
                    txtTel.Text = dr[3].ToString();
                    txtAdr.Text = dr[4].ToString();
                    dateTimePicker1.Text = dr[5].ToString();
                    cmbMeSu.Text = dr[8].ToString();
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
                cmbCin.Items.Clear();
                while (dr.Read())
                {
                    cmbCin.Items.Add(dr[0]);
                }
                db.cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void remplir2()
        {
            try
            {
                db.cn.Open();
                st = "SELECT nom FROM t2 where isSup=0";//
                cmd = new MySqlCommand(st, db.cn);
                dr = cmd.ExecuteReader();
                cmbMeSu.Items.Clear();
                while (dr.Read())
                {
                    cmbMeSu.Items.Add(dr[0]);
                }
                db.cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void mnEnregistrer_Click_1(object sender, EventArgs e)
        {
            try { enregistrer(); vouveau(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mnRechercher_Click_1(object sender, EventArgs e)
        {
            try { rechercher(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mnLister_Click_1(object sender, EventArgs e)
        {
            try { Lister(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mnModifier_Click_1(object sender, EventArgs e)
        {
            try
            {
                modifier();
                vouveau();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mnSupprimer_Click_1(object sender, EventArgs e)
        {
            try
            {
                supprimer();
                vouveau();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cmbM_Click(object sender, EventArgs e)
        {
            remplir2();
        }
        private void cmbCin_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercher();
        }
        private void cmbCin_Click(object sender, EventArgs e)
        {
            remplir();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            vouveau();
        }
    }
}
