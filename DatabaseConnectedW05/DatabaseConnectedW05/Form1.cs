using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseConnectedW05
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection();
        private string conString= "Server=(local); Database=netClass; User=JimGordon; Password=batman";
        private SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAirplane.SelectedIndex = 0;
            refreshData();

        }
        private void handleException(Exception ex)
        {
             string msg = ex.Message.ToString();
            string caption = "Error";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void refreshData() {

            conn.ConnectionString = conString;
            cmd = conn.CreateCommand();

            try
            {
                string query = "select * from FlightInfo;";
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);



                dataGridView1.DataSource = dt;
                cmbSelect.DisplayMember = "FlightNum";
                cmbSelect.ValueMember = "ID";
                cmbSelect.DataSource = dt;
                cmbUserFlight.DisplayMember = "FlightNum";
                cmbUserFlight.ValueMember = "ID";
                cmbUserFlight.DataSource = dt;
                

                query = "select * from userInfo;";
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);

                dataGridView2.DataSource = dt;
                cmbUser.DisplayMember = "Name";
                cmbUser.ValueMember = "ID";
                cmbUser.DataSource = dt;
                


                reader.Close();
              


            }
            catch (Exception ex)
            {
                handleException(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }



        }
            


        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string airline = tbAirline.Text;
            string flight = tbFlightNum.Text;
            string destination = tbDestination.Text;
            string airplane = cmbAirplane.SelectedItem.ToString();
            if ((airline == "") || (flight == "") || (destination == "") || (airplane == ""))
            {
                string msg = "No Textbox Can Be Empty";
                string caption = "Error!";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                conn.ConnectionString = conString;
                cmd = conn.CreateCommand();

                try
                {
                    string query = "Insert into FlightInfo values ('" + airline + "','" + flight + "','" + destination + "','" + airplane + "');";
                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteScalar();
                    MessageBox.Show("New Flight added successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    handleException(ex);
                   
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();

                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int flID = Convert.ToInt32(cmbSelect.SelectedValue);
            conn.ConnectionString = conString;
            cmd = conn.CreateCommand();

            try
            {
                string query = "Delete from FlightInfo where ID="+flID;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteScalar();
                MessageBox.Show("New Flight deleted successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int flId = Convert.ToInt32(cmbSelect.SelectedValue);
            string airline = tbAirline.Text;
            string flight = tbFlightNum.Text;
            string destination = tbDestination.Text;
            string airplane = cmbAirplane.SelectedItem.ToString();
            if ((airline == "") || (flight == "") || (destination == "") || (airplane == ""))
            {
                string msg = "No Textbox Can Be Empty";
                string caption = "Error!";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else
            {
                string query = "Update FlightInfo Set Airline='" + airline + "', FlightNum='" + flight + "', Destination='" + destination + "', AirplaneType='" + airplane + "' Where ID="+flId;
                conn.ConnectionString = conString;
                cmd = conn.CreateCommand();


                try
                {
                   
                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteScalar();
                    MessageBox.Show("Flight Updated successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    handleException(ex);
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }





            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string age = tbAge.Text;
            int flightnum = Convert.ToInt32(cmbUserFlight.SelectedValue);

            conn.ConnectionString = conString;
            cmd = conn.CreateCommand();


            if ((name == "") || (email == "") || (address == "") || (age == ""))
            {
                string msg = "No Textbox Can Be Empty";
                string caption = "Error!";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                conn.ConnectionString = conString;
                cmd = conn.CreateCommand();

                try
                {
                    string query = "Insert into userInfo values ('" + name + "','" + email + "','" + address + "','" + age + "','" + flightnum + "');";
                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteScalar();
                    MessageBox.Show("New user added successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    handleException(ex);

                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                    refreshData();

                }

            }
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {

            int flightnum = Convert.ToInt32(cmbUserFlight.SelectedValue);
            int uId= Convert.ToInt32(cmbUser.SelectedValue);
            string name = tbName.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            string age = tbAge.Text;
            string userflight = cmbUserFlight.SelectedItem.ToString();
            if ((name == "") || (email == "") || (address == "") || (age == ""))
            {
                string msg = "No Textbox Can Be Empty";
                string caption = "Error!";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else
            {
                string query = "Update userInfo Set Name='" + name + "', Email='" + email + "', Address='" +address + "', Age='" + age +"', FlightNum='"+flightnum+ "' Where ID=" + uId;
                conn.ConnectionString = conString;
                cmd = conn.CreateCommand();


                try
                {

                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteScalar();
                    MessageBox.Show("Flight Updated successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    handleException(ex);
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                    refreshData();

                }





            }







        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            int uId = Convert.ToInt32(cmbUser.SelectedValue);
            conn.ConnectionString = conString;
            cmd = conn.CreateCommand();


            try
            {
                string query = "Delete from userInfo Where ID=" + uId;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteScalar();
                MessageBox.Show("Deleted successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                handleException(ex);

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                refreshData();
            }



        }

        private void btnUserRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
