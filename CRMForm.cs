using System;
using SD = System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace Practika
{
    public partial class CRMForm : Form
    {
        public CRMForm()
        {
            InitializeComponent();
        }

        int rowIndex;
        ConnectionClass connectionClass = new ConnectionClass();

        private void CRMForm_Load(object sender, EventArgs e)
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Applications_for_the_operator", connectionClass.GetConnection());

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            CRMDataGridView.DataSource = db.Tables[0];

            connectionClass.closeConnection();

            for (int i = 0; i < CRMDataGridView.Rows.Count - 1; i++)
            {
                DataGridViewRow row = CRMDataGridView.Rows[i];

                if (CRMDataGridView[7, i].Value == DBNull.Value)
                {
                    row.ReadOnly = false;
                }
                else
                {
                    row.ReadOnly = true;
                }
            }

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {

            if (CRMDataGridView[7, rowIndex].Value == DBNull.Value)
            {
                Insert();
            }
            else if(CRMDataGridView[7, rowIndex].Value != DBNull.Value)
            {
               
                DialogResult dr = MessageBox.Show("Вы уверены, что установили верную закрытия дату? ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    Insert();

                    for (int i = 0; i < CRMDataGridView.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = CRMDataGridView.Rows[i];

                        if (CRMDataGridView[7, i].Value == DBNull.Value)
                        {
                            row.ReadOnly = false;
                        }
                        else
                        {
                            row.ReadOnly = true;
                        }
                    }
                }
                else if (dr == DialogResult.Cancel)
                {

                }
            }
        }

        private void CRMDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
        
        private void Insert()
        {
            string input = CRMDataGridView.Rows[rowIndex].Cells[6].Value.ToString();  

            input = Regex.Replace(input, @"\bSELECT\b|\bINSERT\b|\bUPDATE\b|\bDELETE\b|\bDROP\b|\bCREATE\b", "", RegexOptions.IgnoreCase);

            CRMDataGridView.Rows[rowIndex].Cells[6].Value = input;

            DataTable changes = ((DataTable)CRMDataGridView.DataSource).GetChanges();

            if (changes == null || changes.Rows.Count == 0)
            {
                MessageBox.Show("Нет изменений для сохранения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tableName = "Applications_for_the_operator";

            using (var adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connectionClass.GetConnection()))
            using (var commandBuilder = new SqlCommandBuilder(adapter))
            {
                adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                adapter.InsertCommand = commandBuilder.GetInsertCommand();

                try
                {

                    connectionClass.openConnection();
                    adapter.Update(changes);
                    ((DataTable)CRMDataGridView.DataSource).AcceptChanges();
                    MessageBox.Show("Изменения сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            
    }
}
