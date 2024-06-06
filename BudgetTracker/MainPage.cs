using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private Form CurrentForm;
        private Panel CurrentPanel;
 
        private void MainPage_Load(object sender, EventArgs e)
        {
            OpenFormOnPress(new HomeForm(), sender);
            ChangePanelColor(pnl_Home, sender);
            CurrentPanel = pnl_Home;
        }

        private void EditBorderColorButton(Button button, object sender)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.Black;
        }
        private void OpenFormOnPress(Form form, object sender)
        {
            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }
            CurrentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.DisplayPanel.Controls.Add(form);
            this.DisplayPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void ChangePanelColor(Panel panel, object sender)
        {
            if (CurrentPanel != null && CurrentPanel != panel)
            {
                CurrentPanel.BackColor = ColorTranslator.FromHtml("#0C0404");
            }
            panel.BackColor = ColorTranslator.FromHtml("#600080");
            CurrentPanel = panel;
        }

        private void pnl_Home_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Home,sender);
            OpenFormOnPress(new HomeForm(), sender);
        }
        private void pb_Home_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Home, sender);
            OpenFormOnPress(new HomeForm(), sender);
        }
        private void lbl_Home_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Home, sender);
            OpenFormOnPress(new HomeForm(), sender);
        }

        private void pnl_FoodExpense_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_FoodExpense, sender);
            OpenFormOnPress(new FoodExpenses(), sender);
        }

        private void pb_FoodExpense_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_FoodExpense, sender);
            OpenFormOnPress(new FoodExpenses(), sender);
        }

        private void lbl__FoodExpense_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_FoodExpense, sender);
            OpenFormOnPress(new FoodExpenses(), sender);
        }
        private void pnl_TranspoExpenses_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_TranspoExpenses, sender);
        }
        private void pb_TranspoExpense_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_TranspoExpenses, sender);
        }

        private void lbl_TranspoExpense_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_TranspoExpenses, sender);
        }
        private void pnl_OnlinePayments_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_OnlinePayments, sender);
        }

        private void pb_OnlinePayments_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_OnlinePayments, sender);
        }

        private void lbl_OnlinePayments_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_OnlinePayments, sender);
        }
        private void pnl_Bills_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Bills, sender);
        }
        private void pb_Bills_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Bills, sender);
        }

        private void lbl_Bills_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Bills, sender);
        }
        private void pnl_Savings_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Savings, sender);
        }
        private void pb_Savings_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Savings, sender);
        }

        private void lbl_Savings_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Savings, sender);
        }
        private void pnl_OtherExpenses_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_OtherExpenses, sender);
        }
        private void pb_OtherExpenses_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_OtherExpenses, sender);
        }

        private void lbl_OtherExpenses_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_OtherExpenses, sender);
        }
        private void pnl_AddExpense_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_AddExpense, sender);
        }
        private void pb_AddExpense_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_AddExpense, sender);
        }

        private void lbl_AddExpense_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_AddExpense, sender);
        }

        
    }
}
