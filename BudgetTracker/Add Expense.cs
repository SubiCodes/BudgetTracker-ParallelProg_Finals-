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
    public partial class Add_Expense : Form
    {
        public Add_Expense()
        {
            InitializeComponent();
        }

        private void Add_Expense_Load(object sender, EventArgs e)
        {
            SetBorderColorButton(btn_AddExpense, ColorTranslator.FromHtml("#6A0DAD"));
            SetBorderColorButton(btn_Cancel, ColorTranslator.FromHtml("#4E2A84"));
        }
        private void SetBorderColorButton(Button button, Color color)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 3;
            button.FlatAppearance.BorderColor = color;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_title.Text = "";
            txt_Date.Text = "";
            txt_Total.Text = "";
            Visible = false;
        }
    }
}
