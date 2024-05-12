using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace Projet_Achraf
{
    public partial class FMedecin : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st, imgpath;


        public FMedecin()
        {
            InitializeComponent();
        }
        public void nouveau()
        {
            txtCin.Text = null;
            txtNom.Text = null;
            txtPre.Text = null;
            txtAdr.Text = null;
            txtTel.Text = null;
            txtEma.Text = null;
            txtFrm.Text = null;
            pictureBox1.BackgroundImage = Image.FromFile("image.jpg");
            txtCin.Focus();
            txtClass.Text = null;
        }
        public void enregistrer()
        {
            db.cn.Open(); // Opens a database connection (assuming "cn" is a connection object)

            /*//imgpath = "avatar.jpg";  Sets a default value for the image path

            try
            {
                WebClient cl = new WebClient(); // Creates a WebClient instance
                cl.UploadFile("http://localhost/upload.php", openFileDialog1.FileName); // Uploads a file to a server
                imgpath = openFileDialog1.SafeFileName.ToString(); // Updates the image path with the uploaded file's name
            }
            catch (Exception ex)
            {
                // Handles exceptions by logging the details to a file (log.txt)
                string text = System.IO.File.ReadAllText("log.txt");
                using (var writer = new System.IO.StreamWriter("log.txt"))
                {
                    writer.WriteLine(text + DateTime.Now.ToString() + "  :  " + ex.Message.ToString() + Environment.NewLine);
                    writer.Close();
                }
            }*/
            st = "INSERT t2 VALUES ('" + txtCin.Text + "','" + txtNom.Text + "','" + txtPre.Text + "','" + txtAdr.Text + "','" + txtTel.Text + "','" + txtEma.Text + "','" + txtFrm.Text + "','" + imgpath + "',0);";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("L'information de Medecin est bien enregistrer . ");
        }
        public void modifier()
        {
            db.cn.Open();
            st = "UPDATE `mydata`.`t2` SET `nom`='" + txtNom.Text + "', `prenom`='" + txtPre.Text + "', `adresse`='" + txtAdr + "',`tel`='" + txtTel.Text + "', `amail`='" + txtEma.Text + "', `frm`='" + txtFrm.Text + "', `photo`='" + imgpath + "' WHERE  `cin`='" + txtCin.Text + "'";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("Le Medecin est bien :modifier . ");
        }
        public void rechercher()
        {
            db.cn.Open();
            st = "SELECT * FROM t2 WHERE cin = '" + txtCin.Text + "' and isSup=0";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtNom.Text = dr[1].ToString();
                txtPre.Text = dr[2].ToString();
                txtAdr.Text = dr[3].ToString();
                txtTel.Text = dr[4].ToString();
                txtEma.Text = dr[5].ToString();
                txtFrm.Text = dr[6].ToString();
                pictureBox1.Load("http://localhost/images/" + dr[7].ToString());
                imgpath = dr[7].ToString();
            }
            db.cn.Close();
        }
        public void Lister()
        {
            db.cn.Open();
            st = "SELECT * FROM t2 where isSup=0 ORDER BY cin";
            cmd = new MySqlCommand(st, db.cn);
            dr = cmd.ExecuteReader();
            DataGridView1.Rows.Clear();
            while (dr.Read())
            {
                DataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            db.cn.Close();
        }

        public void supprimer()
        {
            db.cn.Open();
            st = "UPDATE `mydata`.`t2` SET `isSup`=1 WHERE  `cin`='" + txtCin.Text + "'";
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("le Medecin est bien supprimer . ");

        }
        private void mnEnregistrer_Click_1(object sender, EventArgs e)
        {
            imgpath = "avatar.jpg";
            try
            {
                WebClient cl = new WebClient();
                cl.UploadFile("http://localhost/upload.php", openFileDialog1.FileName);
                imgpath = openFileDialog1.SafeFileName.ToString();
            }
            catch (Exception ex) { }
            try
            {
                enregistrer();
                nouveau();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void mnRechercher_Click_1(object sender, EventArgs e)
        {
            try
            {
                rechercher();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mnLister_Click_1(object sender, EventArgs e)
        {
            try
            {
                Lister();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mnModifier_Click_1(object sender, EventArgs e)
        {
            try
            {
                modifier();
                nouveau();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mnSupprimer_Click_1(object sender, EventArgs e)
        {
            try
            {
                supprimer();
                nouveau();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            FMedecin f = new FMedecin();
            f.Close();
            new FLogin().Show();
            

        }

        private void label10_Click(object sender, EventArgs e)
        {
            new SingUP().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imgpath = openFileDialog1.SafeFileName.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
