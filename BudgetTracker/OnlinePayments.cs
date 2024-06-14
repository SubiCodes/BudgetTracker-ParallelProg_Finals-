using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class OnlinePayment : Form
    {
        public OnlinePayment()
        {
            InitializeComponent();
            SQLMethods.InitializeDataGridView(dg_OnlinePayment, ColorTranslator.FromHtml("#4e2a84"));
        }
        
        MySQLMethods SQLMethods = new MySQLMethods();
        private String Table = "online_payment";

        private void OnlinePayments_Load(object sender, EventArgs e)
        {
            SQLMethods.LoadAllData("online_payment", dg_OnlinePayment);
            txt_DateSearch.ForeColor = Color.WhiteSmoke;
            txt_DateSearch.Text = "YYYY-MM-DD";
            txt_TitleSearch.ForeColor = Color.WhiteSmoke;
            txt_TitleSearch.Text = "(e.g. \"Title\")";
        }

        private void pb_TitleSearch_Click(object sender, EventArgs e)
        {
            String SearchedTitle = txt_TitleSearch.Text;
            if (txt_TitleSearch.Text == "(e.g. \"Title\")" || txt_TitleSearch.Text.Equals(""))
            {
                MessageBox.Show("Input title", "No title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SQLMethods.SearchTitle(Table, SearchedTitle, dg_OnlinePayment);
        }

        private void txt_TitleSearch_Enter(object sender, EventArgs e)
        {
            if (txt_TitleSearch.Text == "(e.g. \"Title\")")
            {
                txt_TitleSearch.Text = "";
                txt_TitleSearch.ForeColor = Color.Black;
            }
        }

        private void txt_TitleSearch_Leave(object sender, EventArgs e)
        {
            if (txt_TitleSearch.Text == "")
            {
                txt_TitleSearch.ForeColor = Color.WhiteSmoke;
                txt_TitleSearch.Text = "(e.g. \"Title\")";
            }
        }

        private void pb_DateSearch_Click(object sender, EventArgs e)
        {
            String SearchedDate = txt_DateSearch.Text;
            DateTime Date;
            if (!DateTime.TryParse(SearchedDate, out Date))
            {
                MessageBox.Show("Invalid Date Format", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            SQLMethods.SearchDate(Table, Date.ToString("yyyy-MM-dd"), dg_OnlinePayment);
        }

        private void txt_DateSearch_Enter(object sender, EventArgs e)
        {
            if (txt_DateSearch.Text == "YYYY-MM-DD")
            {
                txt_DateSearch.Text = "";
                txt_DateSearch.ForeColor = Color.Black;
            }
        }

        private void txt_DateSearch_Leave(object sender, EventArgs e)
        {
            if (txt_DateSearch.Text == "")
            {
                txt_DateSearch.ForeColor = Color.WhiteSmoke;
                txt_DateSearch.Text = "YYYY-MM-DD";
            }
        }

        private void rb_LatestFirst_CheckedChanged(object sender, EventArgs e)
        {
            String Table = "online_payment";
            String Title = txt_TitleSearch.Text;
            //If Both Title and Date has no input
            if ((Title.Equals("(e.g. \"Title\")") || Title.Equals("")))
            {
                String Query = "Select * FROM online_payment ORDER BY Date DESC";
                SQLMethods.OrderedData(Query, dg_OnlinePayment);
                return;
            }
            //If Title has input
            if (!(Title.Equals("(e.g. \"Title\")") || Title.Equals("")))
            {
                String SearchedTitle = txt_TitleSearch.Text.Trim();
                SQLMethods.OrderedDataWithTitleByDate(Table, SearchedTitle, dg_OnlinePayment, "DESC");
                return;
            }
        }// this function doesnt read the date for it arranges them by date

        private void rb_EarliestFirst_CheckedChanged(object sender, EventArgs e)
        {
            String Table = "online_payment";
            String Title = txt_TitleSearch.Text;

            //If Both Title and Date has no input
            if ((Title.Equals("(e.g. \"Title\")") || Title.Equals("")))
            {
                String Query = "Select * FROM online_payment ORDER BY Date ASC";
                SQLMethods.OrderedData(Query, dg_OnlinePayment);
                return;
            }
            //If Title has input
            if (!(Title.Equals("(e.g. \"Title\")") || Title.Equals("")))
            {
                String Searched = txt_TitleSearch.Text.Trim();
                SQLMethods.OrderedDataWithTitleByDate(Table, Searched, dg_OnlinePayment, "ASC");
                return;
            }
        }

        private void rb_AtoZ_CheckedChanged(object sender, EventArgs e)
        {
            String Date = txt_DateSearch.Text.Trim();
            if (Date.Equals("YYYY-MM-DD") || Date.Equals(""))
            {
                String Query = "Select * FROM online_payment Order By Title ASC";
                SQLMethods.OrderedData(Query, dg_OnlinePayment);
                return;
            }
            SQLMethods.OrderedDataWithDateByTitle("online_payment", Date, dg_OnlinePayment, "ASC");
        }

        private void rb_ZtoA_CheckedChanged(object sender, EventArgs e)
        {
            String Date = txt_DateSearch.Text.Trim();
            if (Date.Equals("YYYY-MM-DD") || Date.Equals(""))
            {
                String Query = "Select * FROM online_payment Order By Title DESC";
                SQLMethods.OrderedData(Query, dg_OnlinePayment);
                return;
            }
            SQLMethods.OrderedDataWithDateByTitle("online_payment", Date, dg_OnlinePayment, "DESC");
        }

        private void rb_HighestPrice_CheckedChanged(object sender, EventArgs e)
        {
            String Title = txt_TitleSearch.Text.Trim();
            String Date = txt_DateSearch.Text.Trim();
            //if both Date and Title is empty
            if ((Date.Equals("YYYY-MM-DD") || Date.Equals("")) && (Title.Equals("") || Title.Equals("(e.g. \"Title\")")))
            {
                String Query = "Select * FROM online_payment Order By Price DESC";
                SQLMethods.OrderedData(Query, dg_OnlinePayment);
                return;
            }
            // if title is empty
            if ((Title.Equals("") || Title.Equals("(e.g. \"Title\")")) && !(Date.Equals("YYYY-MM-DD") || Date.Equals("")))
            {
                SQLMethods.OrderedDataWithDateByPrice("online_payment", Date, dg_OnlinePayment, "DESC");
            }
            // if Date is empty
            if (!(Title.Equals("") || Title.Equals("(e.g. \"Title\")")) && (Date.Equals("YYYY-MM-DD") || Date.Equals("")))
            {
                SQLMethods.OrderedDataWithTitleByPrice("online_payment", Title, dg_OnlinePayment, "DESC");
            }
            // if both is not empty
            if (!(Title.Equals("") || Title.Equals("(e.g. \"Title\")")) && !(Date.Equals("YYYY-MM-DD") || Date.Equals("")))
            {
                SQLMethods.OrderedDateAndTitleByPrice("online_payment", Title, Date, dg_OnlinePayment, "DESC");
            }
        }

        private void rb_LowestPrice_CheckedChanged(object sender, EventArgs e)
        {
            String Title = txt_TitleSearch.Text.Trim();
            String Date = txt_DateSearch.Text.Trim();
            //if both Date and Title is empty
            if ((Date.Equals("YYYY-MM-DD") || Date.Equals("")) && (Title.Equals("") || Title.Equals("(e.g. \"Title\")")))
            {
                String Query = "Select * FROM online_payment Order By Price ASC";
                SQLMethods.OrderedData(Query, dg_OnlinePayment);
                return;
            }
            // if title is empty
            if ((Title.Equals("") || Title.Equals("(e.g. \"Title\")")) && !(Date.Equals("YYYY-MM-DD") || Date.Equals("")))
            {
                SQLMethods.OrderedDataWithDateByPrice("online_payment", Date, dg_OnlinePayment, "ASC");
            }
            // if Date is empty
            if (!(Title.Equals("") || Title.Equals("(e.g. \"Title\")")) && (Date.Equals("YYYY-MM-DD") || Date.Equals("")))
            {
                SQLMethods.OrderedDataWithTitleByPrice("online_payment", Title, dg_OnlinePayment, "ASC");
            }
            // if both is not empty
            if (!(Title.Equals("") || Title.Equals("(e.g. \"Title\")")) && !(Date.Equals("YYYY-MM-DD") || Date.Equals("")))
            {
                SQLMethods.OrderedDateAndTitleByPrice("online_payment", Title, Date, dg_OnlinePayment, "ASC");
            }
        }

        private void dg_OnlinePayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Description = dg_OnlinePayment.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            string Date = dg_OnlinePayment.Rows[e.RowIndex].Cells["Date"].Value.ToString();
            string Title = dg_OnlinePayment.Rows[e.RowIndex].Cells["Title"].Value.ToString();

            DateTime Format;

            DateTime.TryParse(Date, out Format);

            DialogResult result = MessageBox.Show(Description, "Do you want to delete this?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SQLMethods.Delete("online_payment", Title, Format.ToString("yyyy-MM-dd"));
                SQLMethods.LoadAllData("online_payment", dg_OnlinePayment);
            }
        }
    }
}
