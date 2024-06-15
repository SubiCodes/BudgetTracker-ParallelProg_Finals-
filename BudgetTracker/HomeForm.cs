using MySql.Data.MySqlClient;
using System;
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

        private string Connection = "server=localhost;user id=root;password=;database=budget_tracker";
        private Timer Update;
        AboutUs contactForm = new AboutUs();

        private async void UpdateLabels(object sender, EventArgs e)
        {
            // Run all tasks in parallel
            var todayExpenseTask = GetTodayExpenseAsync();
            var monthExpenseTask = GetThisMonthExpenseAsync();
            var billsMonthlyTask = GetBillsTotalAsync();
            var foodTodayTask = FoodTodayAsync();
            var onlineTodayTask = OnlineTodayAsync();
            var transpoTodayTask = TranspoTodayAsync();
            var otherExpenseToday = OtherExpenseToday();
            var savingsThisYear = SavingsTotal();

            await Task.WhenAll(todayExpenseTask, monthExpenseTask, billsMonthlyTask, foodTodayTask, onlineTodayTask, transpoTodayTask,otherExpenseToday, savingsThisYear);

            // Update labels once all tasks are completed
            UpdateLabel(lbl_TodayTotal, "₱ " + todayExpenseTask.Result.ToString("F2"));
            UpdateLabel(lbl_MonthTotal, "₱ " + monthExpenseTask.Result.ToString("F2"));
            UpdateLabel(lbl_MonthBills, "₱ " + billsMonthlyTask.Result.ToString("F2"));
            UpdateLabel(lbl_FoodToday, "₱ " + foodTodayTask.Result.ToString("F2"));
            UpdateLabel(lbl_OnlineToday, "₱ " + onlineTodayTask.Result.ToString("F2"));
            UpdateLabel(lbl_TranspoToday, "₱ " + transpoTodayTask.Result.ToString("F2"));
            UpdateLabel(lbl_OtherToday, "₱ " + otherExpenseToday.Result.ToString("F2"));
            UpdateLabel(lbl_Savings, "₱ " + savingsThisYear.Result.ToString("F2"));
        }

        public void UpdateLabel(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke((MethodInvoker)(() => label.Text = text));
            }
            else
            {
                label.Text = text;
            }
        }

        public async Task<double> ExecuteSumAsync(string query)
        {
            using (var conn = new MySqlConnection(Connection))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    object result = await cmd.ExecuteScalarAsync();
                    return result != DBNull.Value ? Convert.ToDouble(result) : 0.0;
                }
            }
        }

        public async Task<double> GetTodayExpenseAsync()
        {
            var query1Task = ExecuteSumAsync("SELECT SUM(Price) FROM food_expense WHERE DATE(Date) = CURDATE()");
            var query2Task = ExecuteSumAsync("SELECT SUM(Price) FROM bills WHERE DATE(Date) = CURDATE()");
            var query3Task = ExecuteSumAsync("SELECT SUM(Price) FROM online_payment WHERE DATE(Date) = CURDATE()");
            var query4Task = ExecuteSumAsync("SELECT SUM(Price) FROM other_expense WHERE DATE(Date) = CURDATE()");
            var query5Task = ExecuteSumAsync("SELECT SUM(Price) FROM savings WHERE DATE(Date) = CURDATE()");
            var query6Task = ExecuteSumAsync("SELECT SUM(Price) FROM transpo_expense WHERE DATE(Date) = CURDATE()");

            await Task.WhenAll(query1Task, query2Task, query3Task, query4Task, query5Task, query6Task);

            double todayExpense = query1Task.Result + query2Task.Result + query3Task.Result + query4Task.Result + query5Task.Result + query6Task.Result;
            return todayExpense;
        }

        public async Task<double> GetThisMonthExpenseAsync()
        {
            var query1Task = ExecuteSumAsync("SELECT SUM(Price) FROM food_expense WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query2Task = ExecuteSumAsync("SELECT SUM(Price) FROM bills WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query3Task = ExecuteSumAsync("SELECT SUM(Price) FROM online_payment WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query4Task = ExecuteSumAsync("SELECT SUM(Price) FROM other_expense WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query5Task = ExecuteSumAsync("SELECT SUM(Price) FROM savings WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query6Task = ExecuteSumAsync("SELECT SUM(Price) FROM transpo_expense WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");

            await Task.WhenAll(query1Task, query2Task, query3Task, query4Task, query5Task, query6Task);

            double monthlyExpense = query1Task.Result + query2Task.Result + query3Task.Result + query4Task.Result + query5Task.Result + query6Task.Result;
            return monthlyExpense;
        }

        public Task<double> GetBillsTotalAsync()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM bills WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
        }

        public Task<double> FoodTodayAsync()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM food_expense WHERE DATE(Date) = CURDATE()");
        }

        public Task<double> OnlineTodayAsync()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM online_payment WHERE DATE(Date) = CURDATE()");
        }

        public Task<double> TranspoTodayAsync()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM transpo_expense WHERE DATE(Date) = CURDATE()");
        }

        public Task<double> OtherExpenseToday()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM other_expense WHERE DATE(Date) = CURDATE()");
        }
        public Task<double> SavingsTotal()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM savings WHERE YEAR(Date) = YEAR(CURDATE())");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (!contactForm.Visible)
            {
                contactForm.Show();
            }
            else
            {
                contactForm.BringToFront();
            }
        }
    }
}
