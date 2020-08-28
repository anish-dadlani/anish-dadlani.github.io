using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts_Mangement_System
{
    class insertion
    {
        reterival r = new reterival();
        updation u = new updation();
        public void insertUsers(string name, string username, string password, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.show_msg(name + " added to the system successfully.", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void insertClients(string name, string address=null, Int16? status=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertClients", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                if (address==null)
                    cmd.Parameters.AddWithValue("@address", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@address", address);
                if (status==null)
                    cmd.Parameters.AddWithValue("@status", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void insertIncomeDetails(float amount, string description, DateTime date, Int64 client_ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertIncome", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@client_id", client_ID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.show_msg(amount + " added successfully.", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void insertExpenseDetails(float amount, string description, DateTime date, Int64 client_ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertExpenditure", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@client_id", client_ID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.show_msg(description + " added successfully.", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void insertIncomeDaily(float amount, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insert_daily_income", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@date", date);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void insertExpenseDaily(float amount, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insert_daily_expense", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@date", date);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void insertClientAccount(DateTime date, Int64 clientID, string desc, float? credit = null, float? debit = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertClientAccounts", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (credit == null)
                    cmd.Parameters.AddWithValue("@credit", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@credit", credit);

                if (debit==null)
                    cmd.Parameters.AddWithValue("@debit", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@debit", debit);

                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@clientID", clientID);
                cmd.Parameters.AddWithValue("@desc", desc);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }
    }
}
