using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Data.OleDb;
using System.Data;

namespace egg61_63
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter = new();
        DataTable table;
        //string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=PersonsDB.mdb";
        string connectionString = "Server=(localdb)\\mssqllocaldb;Database=adonetdb;Trusted_Connection=True;";
        string selectionString = "select * from Users";
        public Form1()
        {
            InitializeComponent();
            connection = new(connectionString);
            connection.Open();
            command = new(selectionString, connection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            
            dataAdapter = new SqlDataAdapter(selectionString, connectionString);
            
            table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };
            ShowData();
            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);

            dataGridView1.Columns[^1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void DeleteRows()
        {
            while (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
        }

        void ShowData()
        {
            DeleteRows();
            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            command.CommandText = "EXEC Clear";
            command.ExecuteNonQuery();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                command.CommandText = $"INSERT INTO Users (Age, Name) Values ({dataGridView1.Rows[i].Cells[1].Value}, '{dataGridView1.Rows[i].Cells[2].Value}');";
                command.ExecuteNonQuery();
            }
            ShowData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            dataAdapter.Fill(table);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            connection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            command.CommandText = $"DELETE FROM Users Where Id={dataGridView1.SelectedRows[0].Cells[0].Value}";
            command.ExecuteNonQuery();
            ShowData();
        }
    }
}