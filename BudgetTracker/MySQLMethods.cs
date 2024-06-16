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
        //sets up the preferred design on the table
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

        //allow scrolling without the scrollbar
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

        //load all the data from the table input and save it to the datagrid input
        public void LoadAllData(String Table, DataGridView Grid)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker;Convert Zero Datetime=True";
            String Query = "Select * From " + Table + " Order by Date DESC";
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

        //selects all from the specific table where the user input match the title
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

        //selects all from the specific table where the user input match the date
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

        //order the data specifically depending on the parameter
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

        
      //if there is a search and the user want to arrange them you go here
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

        //if there is a search and the user want to arrange them by price you go here
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

        //if there is a date and the user want to arrange them by price you go here
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

        //if there is a date and the user want to arrange them by letter you go here
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

        //when there is both title and date searches use this method
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

        //allows deletion of selected expense
        public void Delete(String Table, String Title, String Date)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "DELETE FROM "+ Table +" WHERE Title = @Title AND DATE(Date) = DATE(@Date)";
            MySqlConnection Conn = new MySqlConnection( Connection );
            Conn.Open() ;
            MySqlCommand CMD = new MySqlCommand(Query, Conn);
            CMD.Parameters.AddWithValue("@Title", Title);
            CMD.Parameters.AddWithValue("@Date", Date);
            CMD.ExecuteNonQuery();
        }

        //checks if the title with the same date already exist
        public bool CheckExist(String Table, String Title, String Date)
        {
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            String Query = "SELECT Title FROM " + Table +" WHERE Title = @Title AND DATE(Date) = DATE(@Date)";
            MySqlConnection Conn = new MySqlConnection(Connection);
            Conn.Open();
            MySqlCommand CMD = new MySqlCommand(Query, Conn);
            CMD.Parameters.AddWithValue("@Title", Title);
            CMD.Parameters.AddWithValue("@Date", Date);
            object result = CMD.ExecuteScalar();

            if(result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}


