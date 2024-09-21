using System.Configuration;
using System.Collections.Specialized;
using Npgsql;
using System.Data;

namespace Lab1PO
{
    public partial class Form1 : Form
    {
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
