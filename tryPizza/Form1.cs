using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using tryPizza.Data;

namespace tryPizza
{ 
    public partial class Form1 : Form
    {
        static public string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\Users\matt_\OneDrive\Documents\pizza.mdf;";
        SqlConnection cnn = new SqlConnection(connetionString);
        private readonly IPizzaItemData _pizzaItemData;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(IPizzaItemData pizzaItemData)
        {
            _pizzaItemData = pizzaItemData;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            IPizzaItemData user = new PizzaSql();
            Task<string> getPizza = user.GetPizza();
            await getPizza;

            MessageBox.Show(getPizza.Result);

        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            int id = ReturnNextId();
            

            if (nameTB.Text != "" && glutenTB.Text != "")
            {
                IPizzaItemData user = new PizzaSql();
                Task AddPizza = user.AddPizza(id, nameTB.Text, glutenTB.Text);
                await AddPizza;
                MessageBox.Show("Added!");
            }
            else
            {
                if (nameTB.Text == "" && glutenTB.Text == "")
                {
                    MessageBox.Show("error all textboxes must be filled");
                }
                else if ( nameTB.Text == "" && glutenTB.Text != "")
                {
                    MessageBox.Show("error name textbox must be completed");
                }
                else if (nameTB.Text != "" && glutenTB.Text == "")
                {
                    MessageBox.Show("error, gluten free textbox must be completed");
                }
                else if ( nameTB.Text == "" && glutenTB.Text == "")
                {
                    MessageBox.Show("error name textbox and gluten free textbox must be completed");
                }
            }
        }

        public int ReturnNextId()
        {
            cnn.Open();
            //int count = 0;
            string output = "";

            SqlCommand command;
            SqlDataReader dataReader;

            // how to call a stored procesure
            command = new SqlCommand("GetAllPizza", cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = (string)dataReader.GetValue(0).ToString();
                
                //count++;
            }
            int tocount = int.Parse(output);
            command.Dispose();
            cnn.Close();

            //return count + 1;
            return tocount + 1;
        }
    }
}
