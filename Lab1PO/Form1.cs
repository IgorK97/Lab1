using System.Configuration;
using System.Collections.Specialized;
using Npgsql;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace Lab1PO
{
    public partial class Form1 : Form
    {
        private string connectionString;

        private NpgsqlDataAdapter clientsAdapter;
        private NpgsqlDataAdapter ordersAdapter;
        private NpgsqlDataAdapter couriersAdapter;

        private NpgsqlCommandBuilder clientsBuilder = new NpgsqlCommandBuilder();
        private NpgsqlCommandBuilder ordersBuilder = new NpgsqlCommandBuilder();

        private DataSet dataSet = new DataSet();


        public Form1()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            clientsAdapter = new NpgsqlDataAdapter("SELECT * FROM public.clients\r\nORDER BY id ASC", connectionString);
            ordersAdapter = new NpgsqlDataAdapter("SELECT * FROM public.orders\r\nORDER BY id ASC ", connectionString);
            couriersAdapter = new NpgsqlDataAdapter("SELECT * FROM public.couriers\r\nORDER BY id ASC ", connectionString);

            // Автоматическая генерация команд SQL.
            clientsBuilder = new NpgsqlCommandBuilder(clientsAdapter);
            ordersBuilder = new NpgsqlCommandBuilder(ordersAdapter);

            // Заполнение таблиц в DataSet.
            clientsAdapter.Fill(dataSet, "clients");
            ordersAdapter.Fill(dataSet, "orders");
            couriersAdapter.Fill(dataSet, "couriers");

            dataGridViewClients.DataSource = dataSet.Tables["clients"]; ;
            dataGridViewOrders.DataSource = dataSet.Tables["orders"];

            // Заполнение комбобокса "Курьеры" в таблице "Заказы".
            FillCourierCombobox();

            // Заполнение комбобокса "Курьеры" для отчета1.
            FillReport1Combobox();
        }

        private void FillReport1Combobox()
        {
            using (var sqlConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlDataAdapter sqlAdapter = new NpgsqlDataAdapter("SELECT * FROM public.ingredients\r\nORDER BY id ASC ", sqlConnection);

                // Заполнение dataSet данными из sqlAdapter.
                DataSet dataSet = new DataSet();
                sqlAdapter.Fill(dataSet, "ingredients");

                // Связывание комбобокса cbCouriers с таблицей couriers из dataSet.
                comboBoxIngredients.DataSource = dataSet.Tables["ingredients"];
                comboBoxIngredients.DisplayMember = "_name";
                comboBoxIngredients.ValueMember = "id";
            }
        }

        /// <summary>
        /// Заполнить комбобокс "Курьеры" в таблице "Заказы".
        /// </summary>
        private void FillCourierCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["IdCourier"]).DataSource =
                dataSet.Tables["couriers"];
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["IdCourier"]).DisplayMember =
                "first_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["IdCourier"]).ValueMember =
                "id";
        }

        /// <summary>
        /// Сохранить изменения в таблице clients.
        /// </summary>
        private void buttonSaveClients_Click(object sender, EventArgs e)
        {
            clientsAdapter.Update(dataSet, "clients");
        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                //NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
                sqlConnection.Open();
                NpgsqlCommand sqlCommand =
                    new NpgsqlCommand("SELECT p._name, p.description" +
                                  " FROM pizza p inner join pizza_composition c on p.id = c.\"pizzaId\"" +
                                  " inner join ingredients i on i.id = c.\"ingredientsId\" where i._name = \'" 
                                  + comboBoxIngredients.Text+"\'"
                                  , sqlConnection);
                NpgsqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable("report1");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Description");
                while (sqlDataReader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["Name"] = sqlDataReader["_name"];
                    row["Description"] = sqlDataReader["description"];
                    dataTable.Rows.Add(row);
                }
                sqlDataReader.Close();
                dataGridViewReport1.DataSource = dataTable;
            }
        }

        /// <summary>
        /// нажатие кнопки вызова хранимой процедуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport2_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand("select * from get_orders_by_month_year($1,$2)", sqlConnection)
                {
                    Parameters =
                    {
                        new NpgsqlParameter(){Value = (int)numericUpDown1.Value},
                        new NpgsqlParameter(){Value= (int)numericUpDown2.Value},
                    }
                };
                sqlConnection.Open();
                sqlCommand.Prepare();
                DataTable dataTable = new DataTable("report2");
                var sqlAdapter = new NpgsqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataTable);

                dataGridViewReport2.DataSource = dataTable;
            }
        }

        private void buttonSaveOrders_Click(object sender, EventArgs e)
        {
            
            ordersAdapter.Update(dataSet, "orders");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
