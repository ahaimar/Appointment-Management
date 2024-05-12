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
    public partial class SingUP : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string st, imgpath;
        public string key = "ab1ab2ab3ab4ab5ab6ab7ab8";
        public SingUP()
        {
            InitializeComponent();
        }
        public void Modifier()
        {
            db.cn.Open();
            st = "UPDATE `mydata`.`userm` SET `nom`='"+txtNom.Text+"', `passWord`='"+txtPas+"' WHERE  `nom`='"+txtNom.Text+"' AND `passWord`='"+txtPas.Text+"' LIMIT 1;";
        }
        public void enregistrer()
        {
            //string encryptedString = strEncrip.EncryptString(key, txtPas.Text);
            db.cn.Open();
            st = "INSERT INTO `mydata`.`userM` (`nom`, `passWord`) VALUES ('" + txtNom.Text + "', '" + txtPas.Text + "')";//encryptedString
            cmd = new MySqlCommand(st, db.cn);
            cmd.ExecuteNonQuery();
            db.cn.Close();
            MessageBox.Show("L' user est bien enregistrer");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
             try
                        {
                            enregistrer();
                        }
             catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Modifier();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
