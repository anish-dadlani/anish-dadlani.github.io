using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts_Mangement_System
{
    class reterival
    {
        public static int USER_ID
        {
            get;
            private set;
        }

        public static string EMP_NAME
        {
            get;
            private set;
        }

        public static string USER_NAME
        {
            get;
            private set;
        }

        private static string user_name = null, pass_word = null, user_email = null;
        private static bool checkLogin, checkEmail;

        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        USER_NAME = dr["Username"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word == password)
                        {
                            MainClass.show_msg("Invalid Username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.show_msg("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.show_msg("Invalid Username and Password", "Error", "Error");
                        }
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return checkLogin;
        }

        public static bool getUserEmail(string useremail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getEmail", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", useremail);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkEmail = true;
                    while (dr.Read())
                    {
                        user_email = dr["EMAIL"].ToString();
                    }
                }
                else
                {
                    checkEmail = false;
                    if (useremail != null)
                    {
                        if (user_email != useremail)
                            MainClass.show_msg("Email Address not Found.", "Error", "Error");
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return checkEmail;
        }

        public void show_users(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn NameGV, DataGridViewColumn UserNameGV, DataGridViewColumn PassGV, DataGridViewColumn PhoneGV, DataGridViewColumn EmailGV, DataGridViewColumn StatusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUserData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUserDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["NAME"].ToString();
                UserNameGV.DataPropertyName = dt.Columns["USERNAME"].ToString();
                PassGV.DataPropertyName = dt.Columns["PASSWORD"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["PHONE"].ToString();
                EmailGV.DataPropertyName = dt.Columns["Email"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void showClients(DataGridView gv, DataGridViewColumn clientIDGV, DataGridViewColumn NameGV, DataGridViewColumn AddressGV, DataGridViewColumn StatusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getClientData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getClientDataSearch", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clientIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Client Name"].ToString();
                AddressGV.DataPropertyName = dt.Columns["Client Address"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void showIncomeDetails(DataGridView gv, DataGridViewColumn clientIDGV, DataGridViewColumn incomeIDGV, DataGridViewColumn descriptionGV, DataGridViewColumn amountGV, DataGridViewColumn dateGV, DataGridViewColumn nameGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getIncomeDetails", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getIncomeDetails", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clientIDGV.DataPropertyName = dt.Columns["Client ID"].ToString();
                incomeIDGV.DataPropertyName = dt.Columns["Income ID"].ToString();
                descriptionGV.DataPropertyName = dt.Columns["Description"].ToString();
                amountGV.DataPropertyName = dt.Columns["Income"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                nameGV.DataPropertyName = dt.Columns["Client Name"].ToString();
                               
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void showIncomeExpeneseBalance(DataGridView gv, DataGridViewColumn dateGV, DataGridViewColumn incomeGV, DataGridViewColumn expenseGV, DataGridViewColumn balanceGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getIncomeExpenseBalance", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getIncomeExpenseBalance", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                incomeGV.DataPropertyName = dt.Columns["TotalInc"].ToString();
                expenseGV.DataPropertyName = dt.Columns["TotalExp"].ToString();
                balanceGV.DataPropertyName = dt.Columns["ProfitNLoss"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void showExpenseDetails(DataGridView gv, DataGridViewColumn clientIDGV,DataGridViewColumn expenseIDGV, DataGridViewColumn descriptionGV, DataGridViewColumn amountGV, DataGridViewColumn dateGV, DataGridViewColumn nameGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                    cmd = new SqlCommand("st_getExpenditureDetails", MainClass.con);
                else
                {
                    cmd = new SqlCommand("st_getExpenditureDetails", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clientIDGV.DataPropertyName = dt.Columns["Client ID"].ToString();
                expenseIDGV.DataPropertyName = dt.Columns["Expense ID"].ToString();
                descriptionGV.DataPropertyName = dt.Columns["Description"].ToString();
                amountGV.DataPropertyName = dt.Columns["Expense"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                nameGV.DataPropertyName = dt.Columns["Client Name"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        object expAmount;
        public object getExpAmount(DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getExpenseByDate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                MainClass.con.Open();
                expAmount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return expAmount;
        }

        object incomeAmount;
        public object getIncomeAmount(DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getIncomeByDate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                MainClass.con.Open();
                incomeAmount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return incomeAmount;
        }

        public void showClientAccount(DataGridView gv, Int64 clientID, DataGridViewColumn caIDGV, DataGridViewColumn descGV, DataGridViewColumn creditGV, DataGridViewColumn debitGV, DataGridViewColumn dateGV, DataGridViewColumn balanceGV = null, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getClientAccountData", MainClass.con);
                    cmd.Parameters.AddWithValue("@id", clientID);
                }
                else
                {
                    cmd = new SqlCommand("st_getClientAccountDataSearch", MainClass.con);
                    //cmd.Parameters.AddWithValue("@id", clientID);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                caIDGV.DataPropertyName = dt.Columns["Client Account ID"].ToString();
                descGV.DataPropertyName = dt.Columns["Description"].ToString();
                creditGV.DataPropertyName = dt.Columns["Credit"].ToString();
                debitGV.DataPropertyName = dt.Columns["Debit"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                balanceGV.DataPropertyName = dt.Columns["Balance"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        object clientID;
        public object getClientID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getClientID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                clientID = Convert.ToInt64(cmd.ExecuteScalar());
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return clientID;
        }

        public void showClientAccountSearch(DataGridView gv, DataGridViewColumn caIDGV, DataGridViewColumn descGV, DataGridViewColumn creditGV, DataGridViewColumn debitGV, DataGridViewColumn dateGV, string data, DataGridViewColumn balanceGV = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getClientAccountDataSearch", MainClass.con);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                caIDGV.DataPropertyName = dt.Columns["Client Account ID"].ToString();
                descGV.DataPropertyName = dt.Columns["Description"].ToString();
                creditGV.DataPropertyName = dt.Columns["Credit"].ToString();
                debitGV.DataPropertyName = dt.Columns["Debit"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                balanceGV.DataPropertyName = dt.Columns["Balance"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void showSurmail(DataGridView gv, DateTime dateFrom, DateTime DateTo, DataGridViewColumn caIDGV, DataGridViewColumn descGV, DataGridViewColumn creditGV, DataGridViewColumn debitGV, DataGridViewColumn dateGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSurmail", MainClass.con);
                cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
                cmd.Parameters.AddWithValue("@dateTo", DateTo);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                caIDGV.DataPropertyName = dt.Columns["Client Account ID"].ToString();
                creditGV.DataPropertyName = dt.Columns["Credit"].ToString();
                debitGV.DataPropertyName = dt.Columns["Debit"].ToString();
                descGV.DataPropertyName = dt.Columns["Description"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                dt.Rows.Add();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }
    }
}
