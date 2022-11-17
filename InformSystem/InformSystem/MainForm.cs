using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace InformSystem
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm

    {
        DB db = new DB();
        int id = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        public void executeMyQuery(string query)
        {
            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                command.Parameters.Add("@id",MySqlDbType.Int32).Value=id;
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Query Executed");
                refresh();             } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void refresh ()
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            // populate the datagridview
            string selectQuery = "SELECT * FROM main";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.GetConnection());
            adapter.Fill(table);

            dataGridView.DataSource = table;
        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtAdress_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            try 
            {
                string insertQuery = "INSERT INTO main(pib, phonenumber, gmail, adress, pos, searchr) VALUES('" + txtName.Text + "', '" + txtPhoneNumber.Text + "', '" + txtGmail.Text + "', '" + txtAdress.Text + "', '" + txtpos.Text + "', '" + Convert.ToByte(insearchpos.Checked) + "')";

                executeMyQuery(insertQuery);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            // populate the datagridview
            string selectQuery = "SELECT * FROM main";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.GetConnection());
            adapter.Fill(table);

            dataGridView.DataSource = table;
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtPhoneNumber.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtGmail.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txtAdress.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txtpos.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            insearchpos.Checked = Convert.ToBoolean(dataGridView.CurrentRow.Cells[6].Value.ToString());

        }

        private void insearchpos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtGmail.Text = "";
            txtAdress.Text = "";
            txtpos.Text = "";
            insearchpos.Checked = false;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM main WHERE id = '"+id+"'";

                executeMyQuery(deleteQuery);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "UPDATE main SET pib = '" + txtName.Text + "', phonenumber = '" + txtPhoneNumber.Text + "' , gmail = '" + txtGmail.Text + "', adress = '" + txtAdress.Text + "' , pos = '" + txtpos.Text + "', searchr = '" + Convert.ToByte(insearchpos.Checked) + "' WHERE id = @id ";

                executeMyQuery(insertQuery);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtpos_Click(object sender, EventArgs e)
        {

        }
    }
}
