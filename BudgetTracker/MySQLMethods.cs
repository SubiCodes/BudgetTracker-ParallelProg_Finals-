using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System;
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
            Grid.RowTemplate.Height =50;
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
            String Query = "Select Title, Price, Date From " + Table;
            try
            {
                MySqlConnection Conn = new MySqlConnection(Connection);
                Conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query,Conn);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(CMD);
                DataTable Datatable = new DataTable();
                Adapter.Fill(Datatable);
                Grid.DataSource = Datatable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Loading the data: "+ex.Message);
            }

        }

    }
}
