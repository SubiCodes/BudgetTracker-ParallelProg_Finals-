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
                CurrentPanel.BackColor = Color.MediumPurple;
            }
            panel.BackColor = ColorTranslator.FromHtml("#D9D9D9");
            CurrentPanel = panel;
        }

        private void pnl_Home_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_Home,sender);
        }

        private void pnl_FoodExpense_Click(object sender, EventArgs e)
        {
            ChangePanelColor(pnl_FoodExpense,sender);
        }
    }
}
