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
            Update.Interval = 1000; //set interval to 1000miliseconds to get update every second that past
            Update.Tick += UpdateLabels;
            Update.Start();
        }

        private string Connection = "server=localhost;user id=root;password=;database=budget_tracker";
        private Timer Update; //nitialize the timer to allow Parallelism
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

            //wait to finish all task running in background before continuing 
            await Task.WhenAll(todayExpenseTask, monthExpenseTask, billsMonthlyTask, foodTodayTask, onlineTodayTask, transpoTodayTask,otherExpenseToday, savingsThisYear);

            //update the labels and change font size if ever the number is too big 
            if (todayExpenseTask.Result >= 10000000) 
            {
                UpdateLabel(lbl_TodayTotal, "₱ " + todayExpenseTask.Result.ToString("F2"));
                lbl_TodayTotal.Font = new System.Drawing.Font(lbl_TodayTotal.Font.FontFamily, 16);
            }
            else
            {
                UpdateLabel(lbl_TodayTotal, "₱ " + todayExpenseTask.Result.ToString("F2"));
            }
            if (monthExpenseTask.Result >= 10000000)
            {
                UpdateLabel(lbl_MonthTotal, "₱ " + monthExpenseTask.Result.ToString("F2"));
                lbl_MonthTotal.Font = new System.Drawing.Font(lbl_TodayTotal.Font.FontFamily, 16);
            }
            else
            {
                UpdateLabel(lbl_MonthTotal, "₱ " + monthExpenseTask.Result.ToString("F2"));
            }
            if (billsMonthlyTask.Result >= 10000000)
            {
                UpdateLabel(lbl_MonthBills, "₱ " + billsMonthlyTask.Result.ToString("F2"));
                lbl_MonthBills.Font = new System.Drawing.Font(lbl_MonthBills.Font.FontFamily, 16);
            }
            else
            {
                UpdateLabel(lbl_MonthBills, "₱ " + billsMonthlyTask.Result.ToString("F2"));
            }


            if (foodTodayTask.Result >= 10000)
            {
                UpdateLabel(lbl_FoodToday, "₱ " + foodTodayTask.Result.ToString("F2"));
                lbl_FoodToday.Font = new System.Drawing.Font(lbl_MonthBills.Font.FontFamily, 12);
            }
            else
            {
                if(foodTodayTask.Result >= 100000)
                {
                    UpdateLabel(lbl_FoodToday, "₱ " + foodTodayTask.Result.ToString("F2"));
                    lbl_FoodToday.Font = new System.Drawing.Font(lbl_MonthBills.Font.FontFamily, 10);
                }
                else
                {
                    UpdateLabel(lbl_FoodToday, "₱ " + foodTodayTask.Result.ToString("F2"));
                }
            }


            if (onlineTodayTask.Result >= 10000)
            {
                UpdateLabel(lbl_OnlineToday, "₱ " + onlineTodayTask.Result.ToString("F2"));
                lbl_OnlineToday.Font = new System.Drawing.Font(lbl_MonthBills.Font.FontFamily, 12);
            }
            else
            {
                if (onlineTodayTask.Result >= 100000)
                {
                    UpdateLabel(lbl_OnlineToday, "₱ " + onlineTodayTask.Result.ToString("F2"));
                    lbl_OnlineToday.Font = new System.Drawing.Font(lbl_MonthBills.Font.FontFamily, 10);
                }
                else
                {
                    UpdateLabel(lbl_OnlineToday, "₱ " + onlineTodayTask.Result.ToString("F2"));
                }
            }


            if (transpoTodayTask.Result >= 10000)
            {
                UpdateLabel(lbl_TranspoToday, "₱ " + transpoTodayTask.Result.ToString("F2"));
                lbl_TranspoToday.Font = new System.Drawing.Font(lbl_MonthBills.Font.FontFamily, 12);
            }
            else
            {
                if (transpoTodayTask.Result >= 100000)
                {
                    UpdateLabel(lbl_TranspoToday, "₱ " + transpoTodayTask.Result.ToString("F2"));
                    lbl_TranspoToday.Font = new System.Drawing.Font(lbl_MonthBills.Font.FontFamily, 10);
                }
                else
                {
                    UpdateLabel(lbl_TranspoToday, "₱ " + transpoTodayTask.Result.ToString("F2"));
                }
            }

            if(otherExpenseToday.Result >= 10000)
            {
                UpdateLabel(lbl_OtherToday, "₱ " + otherExpenseToday.Result.ToString("F2"));
                lbl_OtherToday.Font = new System.Drawing.Font(lbl_OtherToday.Font.FontFamily, 12);
            }
            else
            {
                if (otherExpenseToday.Result >= 100000)
                {
                    UpdateLabel(lbl_OtherToday, "₱ " + otherExpenseToday.Result.ToString("F2"));
                    lbl_OtherToday.Font = new System.Drawing.Font(lbl_OtherToday.Font.FontFamily, 10);
                }
                else
                {
                    UpdateLabel(lbl_OtherToday, "₱ " + otherExpenseToday.Result.ToString("F2"));
                }
            }

            if (savingsThisYear.Result >= 100000)
            {
                UpdateLabel(lbl_Savings, "₱ " + savingsThisYear.Result.ToString("F2"));
                lbl_Savings.Font = new System.Drawing.Font(lbl_MonthBills.Font.FontFamily, 27);
            }
            else
            {
                UpdateLabel(lbl_Savings, "₱ " + savingsThisYear.Result.ToString("F2"));
            }
        }

        //This method is used to Update the label based on the parameter
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

        //This code is used to summ all the values on the table depending on the Query parameter
        public async Task<double> ExecuteSumAsync(string query)
        {
            using (var conn = new MySqlConnection(Connection))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    object result = await cmd.ExecuteScalarAsync();
                    // use ternary operator for readability
                    return result != DBNull.Value ? Convert.ToDouble(result) : 0.0;
                }
            }
        }

        //this task is used to get the total value of Prices from different tables where Date equals today
        public async Task<double> GetTodayExpenseAsync()
        {
            //this tasks are created and started but not awaited allowing them to run concurently
            //var means Task<Double>
            var query1Task = ExecuteSumAsync("SELECT SUM(Price) FROM food_expense WHERE DATE(Date) = CURDATE()");
            var query2Task = ExecuteSumAsync("SELECT SUM(Price) FROM bills WHERE DATE(Date) = CURDATE()");
            var query3Task = ExecuteSumAsync("SELECT SUM(Price) FROM online_payment WHERE DATE(Date) = CURDATE()");
            var query4Task = ExecuteSumAsync("SELECT SUM(Price) FROM other_expense WHERE DATE(Date) = CURDATE()");
            var query5Task = ExecuteSumAsync("SELECT SUM(Price) FROM savings WHERE DATE(Date) = CURDATE()");
            var query6Task = ExecuteSumAsync("SELECT SUM(Price) FROM transpo_expense WHERE DATE(Date) = CURDATE()");

            //wait till all the task is done
            await Task.WhenAll(query1Task, query2Task, query3Task, query4Task, query5Task, query6Task);

            //add the values to get total for today
            double todayExpense = query1Task.Result + query2Task.Result + query3Task.Result + query4Task.Result + query5Task.Result + query6Task.Result;
            return todayExpense;
        }

        //this task is used to get the total value of Prices from different tables where Month equals This month
        public async Task<double> GetThisMonthExpenseAsync()
        {
            //this tasks are created and started but not awaited allowing them to run concurently
            //var means Task<Double>
            var query1Task = ExecuteSumAsync("SELECT SUM(Price) FROM food_expense WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query2Task = ExecuteSumAsync("SELECT SUM(Price) FROM bills WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query3Task = ExecuteSumAsync("SELECT SUM(Price) FROM online_payment WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query4Task = ExecuteSumAsync("SELECT SUM(Price) FROM other_expense WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query5Task = ExecuteSumAsync("SELECT SUM(Price) FROM savings WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
            var query6Task = ExecuteSumAsync("SELECT SUM(Price) FROM transpo_expense WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");

            //wait till all the task is done
            await Task.WhenAll(query1Task, query2Task, query3Task, query4Task, query5Task, query6Task);

            //add the values to get total for today
            double monthlyExpense = query1Task.Result + query2Task.Result + query3Task.Result + query4Task.Result + query5Task.Result + query6Task.Result;
            return monthlyExpense;
        }

        //solves the bills total this month
        public Task<double> GetBillsTotalAsync()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM bills WHERE MONTH(Date) = MONTH(CURRENT_DATE) AND YEAR(Date) = YEAR(CURRENT_DATE)");
        }

        //solves the Food total today
        public Task<double> FoodTodayAsync()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM food_expense WHERE DATE(Date) = CURDATE()");
        }

        //solves the Online Payment today
        public Task<double> OnlineTodayAsync()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM online_payment WHERE DATE(Date) = CURDATE()");
        }

        //solves the Transportation total today
        public Task<double> TranspoTodayAsync()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM transpo_expense WHERE DATE(Date) = CURDATE()");
        }

        //solves the Other expenses total today
        public Task<double> OtherExpenseToday()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM other_expense WHERE DATE(Date) = CURDATE()");
        }

        //solves the Savings total This year
        public Task<double> SavingsTotal()
        {
            return ExecuteSumAsync("SELECT SUM(Price) FROM savings WHERE YEAR(Date) = YEAR(CURDATE())");
        }

        //opens the about us form
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
