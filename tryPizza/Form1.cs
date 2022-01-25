﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection cnn;
            string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\matt_\OneDrive\Documents\pizza.mdf;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            // how to call querry
            //string sql = "select * from dbo.pizza";

            SqlCommand command;
            SqlDataReader dataReader;
            string output = "";

            // how to call a stored procesure
            command = new SqlCommand("GetAllPizza", cnn);
            dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                output = output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + "\n";
            }
            MessageBox.Show(output);
            command.Dispose();
            cnn.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(idTB.Text != "" && nameTB.Text != "" && ownTB.Text != "")
            {
                MessageBox.Show("Added!");
            }
            else
            {
                if (idTB.Text == "" && nameTB.Text == "" && ownTB.Text == "")
                {
                    MessageBox.Show("error all textboxes must be filled");
                }
                else if (idTB.Text == "" && nameTB.Text == "" && ownTB.Text != "")
                {
                    MessageBox.Show("error id textbox and name textbox must be completed");
                }
                else if (idTB.Text == "" && nameTB.Text != "" && ownTB.Text == "")
                {
                    MessageBox.Show("error id textbox and own textbox must be completed");
                }
                else if (idTB.Text == "" && nameTB.Text != "" && ownTB.Text != "")
                {
                    MessageBox.Show("error id textbox must be completed");
                }
                else if (idTB.Text != "" && nameTB.Text == "" && ownTB.Text == "")
                {
                    MessageBox.Show("error name textbox and own textbox must be completed");
                }
                else if (idTB.Text != "" && nameTB.Text != "" && ownTB.Text == "")
                {
                    MessageBox.Show("error own textbox must be completed");
                }
                else if (idTB.Text != "" && nameTB.Text == "" && ownTB.Text != "")
                {
                    MessageBox.Show("error name textbox must be completed");
                }
            }
        }
    }
}
