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
        }
    }
}
