using MySql.Data.MySqlClient;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            Update = new Timer();
            Update.Interval = 1000;
            Update.Tick += UpdateLabels;
            Update.Start();
        }

        private String Connection = "server=localhost;user id =root;password=;database=budget_tracker";
        private Timer Update;


      

        private void UpdateLabels(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Double todayExpense = GetTodayExpense();
                UpdateLabel(lbl_TodayTotal, "₱ " + todayExpense.ToString("F2"));
            });

            Task.Run(() =>
            {
                Double monthExpense = GetThisMonthExpense();
                UpdateLabel(lbl_MonthTotal, "₱ " + monthExpense.ToString("F2"));
            });

            Task.Run(() =>
            {
                Double billsMonthly = GetBillsTotal();
                UpdateLabel(lbl_MonthBills, "₱ " + billsMonthly.ToString("F2"));
            });

            Task.Run(() =>
            {
                Double foodToday = FoodToday();
                UpdateLabel(lbl_FoodToday, "₱ " + foodToday.ToString("F2"));
            });

            Task.Run(() =>
            {
                Double onlineToday = OnlineToday();
                UpdateLabel(lbl_OnlineToday, "₱ " + onlineToday.ToString("F2"));
            });

        }


        public void UpdateLabel(Label label, String Text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke((MethodInvoker)(() => label.Text = Text));
            }
            else
            {
                label.Text = Text;
            }
        }
        

        public Double ExecuteSum(MySqlConnection Conn, String Query)
        {
            MySqlCommand CMD = new MySqlCommand(Query, Conn);
            object Result = CMD.ExecuteScalar();

            if (Result != DBNull.Value) { return (Double)Result;}
            else { return 0.00;}
        }


        public Double GetTodayExpense()
        {

            Double TodayExpense = 0;

            MySqlConnection Conn = new MySqlConnection(Connection);
            Conn.Open();
            MySqlCommand CMD = new MySqlCommand();

            string query1 = "SELECT SUM(Price) FROM food_expense WHERE DATE(Date) = CURDATE()";
            string query2 = "SELECT SUM(Price) FROM bills WHERE DATE(Date) = CURDATE()";
            string query3 = "SELECT SUM(Price) FROM online_payment WHERE DATE(Date) = CURDATE()";
            string query4 = "SELECT SUM(Price) FROM other_expense WHERE DATE(Date) = CURDATE()";
            string query5 = "SELECT SUM(Price) FROM savings WHERE DATE(Date) = CURDATE()";
            string query6 = "SELECT SUM(Price) FROM transpo_expense WHERE DATE(Date) = CURDATE()";

            TodayExpense += ExecuteSum(Conn,query1);
            TodayExpense += ExecuteSum(Conn, query2);
            TodayExpense += ExecuteSum(Conn, query3);
            TodayExpense += ExecuteSum(Conn, query4);
            TodayExpense += ExecuteSum(Conn, query5);
            TodayExpense += ExecuteSum(Conn, query6);

            return TodayExpense;
        }

        public Double GetThisMonthExpense()
        {

            Double MonthlyExpense = 0;

            MySqlConnection Conn = new MySqlConnection(Connection);
            Conn.Open();
            MySqlCommand CMD = new MySqlCommand();

            string query1 = "SELECT SUM(Price) FROM `food_expense` WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)";
            string query2 = "SELECT SUM(Price) FROM `bills` WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)";
            string query3 = "SELECT SUM(Price) FROM `online_payment` WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)";
            string query4 = "SELECT SUM(Price) FROM `other_expense` WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)";
            string query5 = "SELECT SUM(Price) FROM `savings` WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)";
            string query6 = "SELECT SUM(Price) FROM `transpo_expense` WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)";

            MonthlyExpense += ExecuteSum(Conn, query1);
            MonthlyExpense += ExecuteSum(Conn, query2);
            MonthlyExpense += ExecuteSum(Conn, query3);
            MonthlyExpense += ExecuteSum(Conn, query4);
            MonthlyExpense += ExecuteSum(Conn, query5);
            MonthlyExpense += ExecuteSum(Conn, query6);

            return MonthlyExpense;
        }

        public Double GetBillsTotal()
        {
            Double BillsTotal = 0;

            MySqlConnection Conn = new MySqlConnection(Connection);
            Conn.Open();
            MySqlCommand CMD = new MySqlCommand();

            String query = "Select SUM(Price) FROM `bills` WHERE MONTH(DATE) = MONTH(CURRENT_DATE) AND YEAR(Date) =  YEAR(CURRENT_DATE)";

            BillsTotal += ExecuteSum(Conn, query);

            return BillsTotal;
        }

        public Double FoodToday()
        {
            Double FoodToday = 0;

            MySqlConnection Conn = new MySqlConnection(Connection);
            Conn.Open();
            MySqlCommand CMD = new MySqlCommand();

            String query = "Select SUM(Price) FROM `food_expense` WHERE DATE(Date) = CURDATE()";

            FoodToday += ExecuteSum(Conn, query);

            return FoodToday;
        }

        public Double OnlineToday()
        {
            Double OnlineToday = 0;

            MySqlConnection Conn = new MySqlConnection(Connection);
            Conn.Open();
            MySqlCommand CMD = new MySqlCommand();

            String query = "Select SUM(Price) FROM `online_payment` WHERE DATE(Date) = CURDATE()";

            OnlineToday += ExecuteSum(Conn, query);

            return OnlineToday;
        }

    }
}
