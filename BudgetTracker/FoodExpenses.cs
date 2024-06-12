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
    public partial class FoodExpenses : Form
    {
        public FoodExpenses()
        {
            InitializeComponent();
            SQLMethods.InitializeDataGridView(dg_FoodExpense,ColorTranslator.FromHtml("#4e2a84"));
        }

        MySQLMethods SQLMethods = new MySQLMethods();

        private void FoodExpenses_Load(object sender, EventArgs e)
        {
            SQLMethods.LoadAllData("food_expense",dg_FoodExpense);
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
                MessageBox.Show("Input title","No title",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            SQLMethods.SearchTitle("food_expense", SearchedTitle, dg_FoodExpense);
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

            SQLMethods.SearchDate("food_expense", Date.ToString("yyyy-MM-dd"),dg_FoodExpense);
        }

        private void txt_DateSearch_Enter(object sender, EventArgs e)
        {
            if(txt_DateSearch.Text == "YYYY-MM-DD")
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
    }
}
