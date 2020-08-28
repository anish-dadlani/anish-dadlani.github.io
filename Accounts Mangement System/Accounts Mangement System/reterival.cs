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
        private string[] plotData = new string[8];

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

        public void show_projects(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn NameGV, DataGridViewColumn cityGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_viewProjects", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_viewProjectsSearch", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["Project ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Project Name"].ToString();
                cityGV.DataPropertyName = dt.Columns["Project City"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void show_plots(DataGridView gv, DataGridViewColumn plotIDGV, DataGridViewColumn projectIDGV, DataGridViewColumn nameGV, DataGridViewColumn cityGV, DataGridViewColumn sizeGV, DataGridViewColumn noGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_viewPlots", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_viewPlotsSeacrh", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                plotIDGV.DataPropertyName = dt.Columns["Plot ID"].ToString();
                projectIDGV.DataPropertyName = dt.Columns["Project ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Project Name"].ToString();
                cityGV.DataPropertyName = dt.Columns["City"].ToString();
                sizeGV.DataPropertyName = dt.Columns["Plot Size"].ToString();
                noGV.DataPropertyName = dt.Columns["Plot No"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        object projectID;
        public object getProjectID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProjectID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                projectID = cmd.ExecuteScalar();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return projectID;
        }

        object plotID;
        public object getPlottID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPlotID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                plotID = cmd.ExecuteScalar();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return plotID;
        }

        public void show_plansWRTProjectID(Int64 projectID, DataGridView gv, DataGridViewColumn planIDGV, DataGridViewColumn plotIDGV, DataGridViewColumn projectIDGV, DataGridViewColumn nameGV, DataGridViewColumn cityGV, DataGridViewColumn sizeGV, DataGridViewColumn ppmGV, DataGridViewColumn totalPriceGV, DataGridViewColumn no_instGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getinstallmentPlan", MainClass.con);
                    cmd.Parameters.AddWithValue("@projectID", projectID);
                }
                else
                {
                    cmd = new SqlCommand("st_getinstallmentPlan", MainClass.con);
                    cmd.Parameters.AddWithValue("@projectID", projectID);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                planIDGV.DataPropertyName = dt.Columns["Plan ID"].ToString();
                projectIDGV.DataPropertyName = dt.Columns["Project ID"].ToString();
                plotIDGV.DataPropertyName = dt.Columns["Plot ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Project Name"].ToString();
                cityGV.DataPropertyName = dt.Columns["Project City"].ToString();
                sizeGV.DataPropertyName = dt.Columns["Plot Size"].ToString();
                //noGV.DataPropertyName = dt.Columns["Plot No"].ToString();
                ppmGV.DataPropertyName = dt.Columns["Price Per Marla"].ToString();
                totalPriceGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                no_instGV.DataPropertyName = dt.Columns["No of Installments"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public void show_clients(DataGridView gv, DataGridViewColumn clientIDGV, DataGridViewColumn NameGV, DataGridViewColumn addressGV, DataGridViewColumn PhoneGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getClients", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getClientsSearch", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clientIDGV.DataPropertyName = dt.Columns["Client ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Client Name"].ToString();
                addressGV.DataPropertyName = dt.Columns["Client Address"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["Client Number"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
        }

        public string[] show_plotsWRTNO(int plotNo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getplotDataWRTPlotno", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@plotNo", plotNo);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        plotData[0] = dr[0].ToString(); // ID
                        plotData[1] = dr[1].ToString(); // Name
                        plotData[2] = dr[2].ToString(); // City
                        plotData[3] = dr[3].ToString(); // Size
                        plotData[4] = dr[4].ToString(); // No
                        plotData[5] = dr[5].ToString(); // Installments
                        plotData[6] = dr[6].ToString(); // PPM
                        plotData[7] = dr[7].ToString(); // TP
                    }
                }
                else
                {
                    Array.Clear(plotData, 0, plotData.Length);
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return plotData;
        }

        object saleID;
        public object getsaleID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSaleID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                saleID = cmd.ExecuteScalar();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return saleID;
        }

        object clientID;
        public object getclientID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getclientID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                clientID = cmd.ExecuteScalar();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.show_msg(ex.Message, "Error", "Error");
            }
            return clientID;
        }
    }
}
