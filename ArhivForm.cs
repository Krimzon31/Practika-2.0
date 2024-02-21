using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practika
{
    public partial class ArhivForm : Form
    {
        public ArhivForm()
        {
            InitializeComponent();
        }

        ConnectionClass connectionClass = new ConnectionClass();

        private void ArhivForm_Load(object sender, EventArgs e)
        {
            connectionClass.openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Arhiv", connectionClass.GetConnection());

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            ArhivDataGridView.DataSource = db.Tables[0];

            connectionClass.closeConnection();
        }

        private void Apply_Filter()
        {
            var Abonent_loginFilter = (ArhivDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Abonent_login LIKE '%{LoginTextBox.Text}%'";
            var ServicesFilter = (ArhivDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Services LIKE '%{Abonent_NumberTextBox.Text}%'";
            var Personal_AccountFilter = (ArhivDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Personal_Account LIKE '%{Personal_AccountTextBox.Text}%'";

            var combinedFilter = $"{Abonent_loginFilter} AND {ServicesFilter} AND {Personal_AccountFilter}";
            (ArhivDataGridView.DataSource as DataTable).DefaultView.RowFilter = combinedFilter;

        }

        private void FIOTextBox_TextChanged(object sender, EventArgs e)
        {
            Apply_Filter();
        }

        private void Abonent_NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            Apply_Filter();
        }

        private void Personal_AccountTextBox_TextChanged(object sender, EventArgs e)
        {
            Apply_Filter();
        }
    }
}
