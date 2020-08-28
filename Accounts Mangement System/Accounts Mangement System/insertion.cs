using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Accounts_Mangement_System
{
    class insertion
    {
        reterival r = new reterival();
        updation u = new updation();
        int saleCount = 0; Int64 salesID;
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

        public void insertProjects(string name, string city)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProjects", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@city", city);
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

        public void insertPlots(string size, int no, Int64 projectID, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPlots", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@size", size);
                cmd.Parameters.AddWithValue("@no", no);
                cmd.Parameters.AddWithValue("@id", projectID);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.show_msg(no + " added to the system successfully.", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void insertPlan(float price_per_marla, float total_price, int no, Int64 plotID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPlan", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ppm", price_per_marla);
                cmd.Parameters.AddWithValue("@total_price", total_price);
                cmd.Parameters.AddWithValue("@no", no);
                cmd.Parameters.AddWithValue("@PlotID", plotID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                //MainClass.show_msg(no + " added to the system successfully.", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void insertClients(string name, string address, string phone)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertClient", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@num", phone);
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

        public void insertSales(float payment, float paid, DateTime date_, Int64 clientID, Int64 plotID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amount_payment", payment);
                cmd.Parameters.AddWithValue("@paid_amount", paid);
                cmd.Parameters.AddWithValue("@date", date_);
                cmd.Parameters.AddWithValue("@clientID", clientID);
                cmd.Parameters.AddWithValue("@plotID", plotID);
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

        public void insertSalesDetails(int no, DateTime date_, Int64 saleID, Int64 clientID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSaleDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;;
                cmd.Parameters.AddWithValue("@no", no);
                cmd.Parameters.AddWithValue("@date", date_);
                cmd.Parameters.AddWithValue("@saleID", saleID);
                cmd.Parameters.AddWithValue("@clientID", clientID);
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

        public void insertSale(DataGridView gv, Int64 userID, DateTime dt, float tAmount, float aGiven, Int64 custID, string sizeGV)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    int stockQuantityItem = 0;
                    SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@amount_payment", tAmount);
                    cmd.Parameters.AddWithValue("@paid_amount", aGiven);
                    cmd.Parameters.AddWithValue("@clientID", custID);
                    MainClass.con.Open();
                    saleCount = cmd.ExecuteNonQuery();
                    if (saleCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSaleID", MainClass.con);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        salesID = Convert.ToInt64(cmd2.ExecuteScalar());

                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSaleDetails", MainClass.con);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@saleID", salesID);
                            cmd3.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDgv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[proQuangv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@sp", Convert.ToSingle(row.Cells[spgv].Value.ToString()));

                            object output = Regex.Replace(row.Cells[sizeGV].Value.ToString(), "[^0-9]+", string.Empty);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                    MainClass.con.Close();
                    MainClass.show_msg("Sales Successfull", "Success", "Success");
                    sc.Complete();
                }
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }
    }
}
