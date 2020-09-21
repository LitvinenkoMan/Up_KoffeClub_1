using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Up_KoffeClub_1
{
    public partial class MainForm : Form
    {
        SQLiteConnection connection;
        SQLiteDataAdapter adapter;
        DataSet dataset;
        SQLiteCommandBuilder comBuilder;
        string comm;
        int i = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }
        public void FillGrid(DataGridView Table, string comm)
        {
            using (connection = new SQLiteConnection($"data source = {Directory.GetCurrentDirectory()}\\DB_Koffe.db"))
            {
                dataset = new DataSet();
                adapter = new SQLiteDataAdapter(comm, connection);
                comBuilder = new SQLiteCommandBuilder(adapter);
                adapter.Fill(dataset);
                Table.DataSource = dataset.Tables[0];
            }
        }

        private void textBoxSerch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSerch.Text != "")
            {
                switch (tabControlView.SelectedIndex)
                {
                    case 0:
                        {
                            comm = $"SELECT * FROM Categorees WHERE Category LIKE '%{textBoxSerch.Text}%' OR RealizationData LIKE '%{textBoxSerch.Text}%' OR Bonus LIKE '%{textBoxSerch.Text}%'";
                            break;
                        }
                    case 1:
                        {
                            comm = $"SELECT * FROM Drinks WHERE DrinkName LIKE '%{textBoxSerch.Text}%' OR Weight LIKE '%{textBoxSerch.Text}%' OR Cost LIKE '%{textBoxSerch.Text}%' OR Category LIKE '%{textBoxSerch.Text}%'";
                            break;
                        }
                    case 2:
                        {
                            comm = $"SELECT * FROM Sells WHERE SellNumber LIKE '%{textBoxSerch.Text}%' OR DrinkName LIKE '%{textBoxSerch.Text}%' OR Amount LIKE '%{textBoxSerch.Text}%' OR SellingDate LIKE '%{textBoxSerch.Text}%'";
                            break;
                        }
                    default:
                        break;
                }
                FillGrid(dataGridView1, comm);
            }
            else
            {
                switch (tabControlView.SelectedIndex)
                {
                    case 0:
                        {
                            comm = $"SELECT * FROM Categorees";
                            break;
                        }
                    case 1:
                        {
                            comm = $"SELECT * FROM Drinks";
                            break;
                        }
                    case 2:
                        {
                            comm = $"SELECT * FROM Sells";
                            break;
                        }
                    default:
                        break;
                }
                FillGrid(dataGridView1, comm);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid(dataGridView1, $"SELECT * FROM Categorees");
        }

        private void tabControlView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlView.SelectedIndex)
            {
                case 0:
                    {
                        comm = $"SELECT * FROM Categorees";
                        break;
                    }
                case 1:
                    {
                        comm = $"SELECT * FROM Drinks";
                        break;
                    }
                case 2:
                    {
                        comm = $"SELECT * FROM Sells";
                        break;
                    }
                default:
                    break;
            }
            FillGrid(dataGridView1, comm);
        }

        private void labelSerch_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                textBoxFrom.Visible = true;
                textBoxTo.Visible = true;
                textBoxSerch.Visible = false;
            }
            else
            {
                textBoxFrom.Visible = false;
                textBoxTo.Visible = false;
                textBoxSerch.Visible = true;
            }
            i++;
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    switch (tabControlView.SelectedIndex)
                    {
                        case 0:
                            {
                                comm = $"SELECT * FROM Categorees WHERE RealizationData BETWEEN {textBoxFrom.Text} AND {textBoxTo.Text} OR Bonus BETWEEN {textBoxFrom.Text} AND {textBoxTo.Text} ";
                                break;
                            }
                        case 1:
                            {
                                comm = $"SELECT * FROM Drinks WHERE Weight BETWEEN {textBoxFrom.Text} AND {textBoxTo.Text} OR Cost BETWEEN {textBoxFrom.Text} AND {textBoxTo.Text}";
                                break;
                            }
                        case 2:
                            {
                                comm = $"SELECT * FROM Sells WHERE SellNumber BETWEEN {textBoxFrom.Text} AND {textBoxTo.Text} OR Amount BETWEEN {textBoxFrom.Text} AND {textBoxTo.Text}";
                                break;
                            }
                        default:
                            break;
                    }
                    FillGrid(dataGridView1, comm);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно введены данные");
            }
        }
    }
}
