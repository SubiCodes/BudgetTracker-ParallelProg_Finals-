using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        //Initialize the Methods Class
        MySQLMethods Methods = new MySQLMethods();

        //Upon load set the page to have Hints and Setup border on button
        private void Add_Expense_Load(object sender, EventArgs e)
        {
            SetBorderColorButton(btn_AddExpense, ColorTranslator.FromHtml("#6A0DAD"));
            SetBorderColorButton(btn_Cancel, ColorTranslator.FromHtml("#4E2A84"));

            txt_Title.ForeColor = Color.DarkGray;
            txt_Price.ForeColor = Color.DarkGray;
            txt_Date.ForeColor = Color.DarkGray;
            txt_Description.ForeColor = Color.DarkGray;

            txt_Title.Text = "(e.g. \"Title\")";
            txt_Price.Text = "(e.g. \"123.45\")";
            txt_Date.Text = "YYYY-MM-DD";
            txt_Description.Text = "(e.g. \"This is an example of a description\")";
        }

        //Set the border method
        private void SetBorderColorButton(Button button, Color color)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 3;
            button.FlatAppearance.BorderColor = color;
        }

        //when the cancel is clicked close the form and set the set the text box to empty
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Date.Text = "";
            txt_Title.Text = "";
            txt_Price.Text = "";
            txt_Description.Text = "";
            Visible = false;
        }

        //checks if the date format is valid
        private bool DateChecker(String Date)
        {
            DateTime ParsedDate;
            return DateTime.TryParseExact(Date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out ParsedDate);
        }

        //Add the expense to the Database based on the user input
        private void btn_AddExpense_Click(object sender, EventArgs e)
        {
            String Title = txt_Title.Text;
            Double Price;
            String Date = txt_Date.Text;
            String Description = txt_Description.Text;
            String Type = null;

          
            //set the type depending on the user option
            if (rb_Food.Checked) { Type = "food_expense";}
            if (rb_Transpo.Checked) { Type = "transpo_expense";}
            if (rb_Savings.Checked) { Type = "savings";}
            if (rb_Online.Checked) { Type = "online_payment";}
            if (rb_Bills.Checked) { Type = "bills";}
            if (rb_Others.Checked) { Type = "other_expense";}

            //check if all inputs are valid
            if (!Double.TryParse(txt_Price.Text, out Price))
            {
                MessageBox.Show("Input an Integer or a Double for the Price!","Reading Price Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateChecker(Date))
            {
                MessageBox.Show("Invalid Date Format! Please enter the date in the format yyyy-MM-dd", "Date Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((string.IsNullOrWhiteSpace(Title) || Title.Equals("(e.g. \"Title\")")) || string.IsNullOrWhiteSpace(Date) || (string.IsNullOrWhiteSpace(Description) || Description.Equals("(e.g. \"This is an example of a description\")"))  || string.IsNullOrWhiteSpace(Type))
            {
                MessageBox.Show("Missing Inputs!", "Inputs Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Methods.CheckExist(Type, Title, Date) == false)
            {
                MessageBox.Show("Title Already Exist", "Title existing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //start adding it to the database if all match the requirements
            String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
            string Query = $"INSERT INTO `{Type}` (`Title`, `Price`, `Date`, `Description`) VALUES (@Title, @Price, @Date, @Description)";

            try
            {
                MySqlConnection conn = new MySqlConnection(Connection);
                conn.Open();
                MySqlCommand CMD = new MySqlCommand(Query, conn);
                CMD.Parameters.AddWithValue("@Type", Type);
                CMD.Parameters.AddWithValue("@Title", Title);
                CMD.Parameters.AddWithValue("@Price", Price);
                CMD.Parameters.AddWithValue("@Date", Date);
                CMD.Parameters.AddWithValue("@Description", Description);
                CMD.ExecuteNonQuery();

                MessageBox.Show("Successfully added the expense!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //after adding everything set it all back to empty and close the form
            txt_Date.Text = "";
            txt_Title.Text = "";
            txt_Price.Text = "";
            txt_Description.Text = "";
            Visible = false;
        }

        //remove hint if the textbox is pressed
        private void txt_Title_Enter(object sender, EventArgs e)
        {
            if (txt_Title.Text == "(e.g. \"Title\")")
            {
                txt_Title.Text = "";
                txt_Title.ForeColor = Color.Black;
            }
        }

        //if user leave the textbox and there is no input show the hint
        private void txt_Title_Leave(object sender, EventArgs e)
        {
            if (txt_Title.Text == "")
            {
                txt_Title.ForeColor = Color.DarkGray;
                txt_Title.Text = "(e.g. \"Title\")";
            }
        }

        //remove hint if the textbox is pressed
        private void txt_Price_Enter(object sender, EventArgs e)
        {
            if (txt_Price.Text == "(e.g. \"123.45\")")
            {
                txt_Price.Text = "";
                txt_Price.ForeColor = Color.Black;
            }
        }

        //if user leave the textbox and there is no input show the hint
        private void txt_Price_Leave(object sender, EventArgs e)
        {
            if (txt_Price.Text == "")
            {
                txt_Price.ForeColor = Color.DarkGray;
                txt_Price.Text = "(e.g. \"123.45\")";
            }
        }

        //remove hint if the textbox is pressed
        private void txt_Date_Enter(object sender, EventArgs e)
        {
            if (txt_Date.Text == "YYYY-MM-DD")
            {
                txt_Date.Text = "";
                txt_Date.ForeColor = Color.Black;
            }
        }

        //if user leave the textbox and there is no input show the hint
        private void txt_Date_Leave(object sender, EventArgs e)
        {
            if (txt_Date.Text == "")
            {
                txt_Date.ForeColor = Color.DarkGray;
                txt_Date.Text = "YYYY-MM-DD";
            }
        }

        //remove hint if the textbox is pressed
        private void txt_Description_Enter(object sender, EventArgs e)
        {
            if (txt_Description.Text == "(e.g. \"This is an example of a description\")")
            {
                txt_Description.Text = "";
                txt_Description.ForeColor = Color.Black;
            }
        }

        //if user leave the textbox and there is no input show the hint
        private void txt_Description_Leave(object sender, EventArgs e)
        {
            if (txt_Description.Text == "")
            {
                txt_Description.ForeColor = Color.DarkGray;
                txt_Description.Text = "(e.g. \"This is an example of a description\")";
            }
        }
    }
}
