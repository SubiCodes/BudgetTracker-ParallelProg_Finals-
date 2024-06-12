using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{

    internal class MySQLMethods
    {
        public void InitializeDataGridView(DataGridView Grid, Color HeaderColor)
        {
            Grid.ColumnHeadersDefaultCellStyle.BackColor = HeaderColor;
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Grid.ColumnHeadersHeight = 70;
            Grid.EnableHeadersVisualStyles = false;
            Grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid.RowTemplate.Height = 50;
            Grid.ClearSelection();
            Grid.ScrollBars = ScrollBars.None;
            Grid.SelectionChanged += (s, e) => { Grid.ClearSelection(); };
            Grid.MouseWheel += DataGridView_MouseWheel;
        }
        private void DataGridView_MouseWheel(object sender, MouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView != null)
            {
                // Determine if scrolling up or down
                int rowIndex = dataGridView.FirstDisplayedScrollingRowIndex - e.Delta / 120;
                if (rowIndex >= 0 && rowIndex < dataGridView.RowCount)
                {
                    dataGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                }
            }
        }
        public void LoadAllData(String Table, DataGridView Grid)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "Select * From " + Table;
            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;

                foreach (DataGridViewColumn column in Grid.Columns)
                {
                    if (column.Name != "Price" && column.Name != "Date" && column.Name != "Title")
                    {
                        column.Visible = false;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: " + ex.Message);
            }

        }

        public void SearchTitle(String Table, String Title, DataGridView Grid)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "Select * From " + Table + " Where LOWER(Title) LIKE LOWER(@Title)";
            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Title", Title);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;

                foreach (DataGridViewColumn column in Grid.Columns)
                {
                    if (column.Name != "Price" && column.Name != "Date" && column.Name != "Title")
                    {
                        column.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: " + ex.Message);
            }
        }
        public void SearchDate(String Table, String Date, DataGridView Grid)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "Select * From " + Table + " Where Date = @Date";
            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Date", Date);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;

                foreach (DataGridViewColumn column in Grid.Columns)
                {
                    if (column.Name != "Price" && column.Name != "Date" && column.Name != "Title")
                    {
                        column.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: " + ex.Message);
            }
        }
        public void OrderedData(String Query, DataGridView Grid)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;

                foreach (DataGridViewColumn column in Grid.Columns)
                {
                    if (column.Name != "Price" && column.Name != "Date" && column.Name != "Title")
                    {
                        column.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: " + ex.Message);
            }
        }

        
      
        public void OrderedDataWithTitleByDate(String Table, String Title, DataGridView Grid, String Order)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "Select * From " + Table + " WHERE Title = @Title Order By Date "+Order;
            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Title", Title);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;

                foreach (DataGridViewColumn column in Grid.Columns)
                {
                    if (column.Name != "Price" && column.Name != "Date" && column.Name != "Title")
                    {
                        column.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: " + ex.Message);
            }
        }
        public void OrderedDataWithTitleByPrice(String Table, String Title, DataGridView Grid, String Order)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "Select * From " + Table + " WHERE Title = @Title Order By Price " + Order;
            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Title", Title);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;

                foreach (DataGridViewColumn column in Grid.Columns)
                {
                    if (column.Name != "Price" && column.Name != "Date" && column.Name != "Title")
                    {
                        column.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: " + ex.Message);
            }
        }
        public void OrderedDataWithDateByPrice(String Table, String Date, DataGridView Grid, String Order)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "Select * From " + Table + " WHERE Date = @Date Order By Title "+Order;

            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Date", Date);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;

                foreach (DataGridViewColumn column in Grid.Columns)
                {
                    if (column.Name != "Price" && column.Name != "Date" && column.Name != "Title")
                    {
                        column.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: " + ex.Message);
            }
        }
        public void OrderedDataWithDateByTitle(String Table, String Date, DataGridView Grid, String Order)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "Select * From " + Table + " WHERE Date = @Date Order By Title " + Order;

            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Date", Date);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;

                foreach (DataGridViewColumn column in Grid.Columns)
                {
                    if (column.Name != "Price" && column.Name != "Date" && column.Name != "Title")
                    {
                        column.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: " + ex.Message);
            }
        }
        public void OrderedDateAndTitleByPrice(String Table, String Title, String Date, DataGridView Grid, String Order)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "Select * From " + Table + " WHERE Date = @Date AND Title = @Title Order By Price " + Order;
            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Date", Date);
                CMD.Parameters.AddWithValue("@Title",Title);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;

                foreach (DataGridViewColumn column in Grid.Columns)
                {
                    if (column.Name != "Price" && column.Name != "Date" && column.Name != "Title")
                    {
                        column.Visible = false;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: " + ex.Message);
            }
        }
    }
}


