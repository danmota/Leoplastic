using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Reference for Database http://www.c-sharpcorner.com/article/read-microsoft-access-database-in-C-Sharp/

namespace Leoplastic
{
    public partial class Form1 : Form
    {
        //private int contaLinhas = 0;
        //private int RowId = 0;
        //private int _id = 0;
        private string _processo;
        private string _equipamento;
        private string _data_apontamento;
        private string _produto;
        private string _peso;
        private string _inicio_operacao;
        private string _termino_operacao;
        private string _ordem;
        private string _operador;
        private string _densidade1;
        private string _densidade2;

        //String connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Daniel Mota\\Documents\\GitHub\\Leoplastic\\Leoplastic.mdb;Persist Security Info=False";
        
        String connection = Properties.Settings.Default.leoplasticConnectionString_access;

        LeoplasticDataContext db = new LeoplasticDataContext();

        public Form1()
        {
            InitializeComponent();

        }

        private void lbl_inicio_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Now;
            txt_inicio.Text = thisDay.ToString();
        }

        private void btn_termino_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Now;
            txt_termino.Text = thisDay.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is DataGridView) this.Controls[ix].Dispose();
            }

            btn_export_Excel.Visible = false;
            panel3.Show();
            
    }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string value = "";
            if (rbt_extrusora.Checked)
                value = rbt_extrusora.Text;
            else if (rbt_rebobinadeira.Checked)
                value = rbt_rebobinadeira.Text;
            else if (rbt_corte.Checked)
                value = rbt_corte.Text;
            else if (rbt_expedicao.Checked)
                value = rbt_expedicao.Text;
            _processo = value;

            value = "";
             if (rbt_extrusora1.Checked)
                value = rbt_extrusora1.Text;
            else if (rbt_extrusora2.Checked)
                value = rbt_extrusora2.Text;
            else if (rbt_extrusora3.Checked)
                value = rbt_extrusora3.Text;
            else if (rbt_rebobinadeira1.Checked)
                value = rbt_rebobinadeira1.Text;
            else if (rbt_rebobinadeira2.Checked)
                value = rbt_rebobinadeira2.Text;
            else if (rbt_corte1.Checked)
                value = rbt_corte1.Text;
            else if (rbt_corte2.Checked)
                value = rbt_corte2.Text;
            _equipamento = value;


            _data_apontamento = dtp_apontamento.Value.ToString();
            _produto = txt_produto.Text;
            _peso = txt_peso.Text;
            _inicio_operacao = txt_inicio.Text;
            _termino_operacao = txt_termino.Text;
            _ordem = cbx_ordem.Text;
            _operador = cbx_operador.Text;
            _densidade1 = txt_densidade1.Text;
            _densidade2 = txt_densidade2.Text;
            String _densidade = _densidade1.ToString() + " x " + _densidade2.ToString();


            
            try
            {
                if (_processo != null && _equipamento != null && _data_apontamento != null && _produto != null && _peso != null && _inicio_operacao != null && _termino_operacao != null)
                {
                    // Add a new row  
                    String sql = "INSERT INTO producao(processo,equipamento,data_apontamento,produto,peso,inicio_operacao,termino_operacao,ordem,operador,densidade) VALUES ('"+
                        _processo + "', '" +
                        _equipamento + "', '" +
                        _data_apontamento + "', '"+
                        _produto + "', '" +
                        _peso + "', '" +
                        _inicio_operacao + "', '" +
                        _termino_operacao + "', '" +
                        _ordem + "', '" +
                        _operador + "', '" +
                        _densidade + "')";
                    using (OleDbConnection conn = new OleDbConnection(connection))
                    {
                        conn.Open();
                        OleDbCommand command = new OleDbCommand(sql, conn);
                        command = new OleDbCommand(sql, conn);
                        command.ExecuteReader();
                    }
            
                MessageBox.Show("Informação cadastrada com sucesso!");

                txt_produto.Text = "";
                txt_peso.Text = "";
                txt_inicio.Text = "";
                txt_termino.Text = "";
                cbx_ordem.Text = "";
                cbx_operador.Text = "";
                txt_densidade1.Text = "";
                txt_densidade2.Text = "";

                }
                else
                {
                    MessageBox.Show("Informe os valores para inclusão...");
                }
            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void BindDataGridView()
        {
            /*
            var getData = from c in db.producao
                          select c;

            //dgvClientes.DataSource = getData;
            //dgvClientes.Columns[0].ReadOnly = true;
            //contaLinhas = dgvClientes.RowCount - 1;
            */
        }



        private void btn_listagem_Click(object sender, EventArgs e)
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is DataGridView) this.Controls[ix].Dispose();
            }
            panel3.Hide();
            btn_export_Excel.Visible = true;
            DataGridView dgv = new DataGridView();

            int x_loc = panel2.Width;
            int y_loc = panel1.Height;

            dgv.Location = new System.Drawing.Point(x_loc, y_loc);
            dgv.Name = "DataGridView1";
            //dgv.Size = new System.Drawing.Size(this.Width - 2 * x_loc, this.Height - 2 * y_loc);
            dgv.Size = new System.Drawing.Size(1366, 856);
            dgv.ForeColor = System.Drawing.Color.Black;
            Controls.Add(dgv);

            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string sql = "SELECT * FROM producao";
            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(sql, conn);
                conn.Open();
                
                DataSet ds = new DataSet();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                {
                    adapter.Fill(ds);
                    dgv.DataSource = ds.Tables[0];
                }
            }


            

        }

        private void btn_extrusora_Click(object sender, EventArgs e)
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is DataGridView) this.Controls[ix].Dispose();
            }
            panel3.Hide();
            DataGridView dgv = new DataGridView();

            int x_loc = panel2.Width;
            int y_loc = panel1.Height;

            dgv.Location = new System.Drawing.Point(x_loc, y_loc);
            dgv.Name = "DataGridView1";
            //dgv.Size = new System.Drawing.Size(this.Width - 2 * x_loc, this.Height - 2 * y_loc);
            dgv.Size = new System.Drawing.Size(1366, 856);
            dgv.ForeColor = System.Drawing.Color.Black;
            Controls.Add(dgv);

            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string sql = "SELECT * FROM producao WHERE processo='Extrusora' ";
            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(sql, conn);
                conn.Open();

                DataSet ds = new DataSet();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                {
                    adapter.Fill(ds);
                    dgv.DataSource = ds.Tables[0];
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is DataGridView) this.Controls[ix].Dispose();
            }
            panel3.Hide();
            DataGridView dgv = new DataGridView();

            int x_loc = panel2.Width;
            int y_loc = panel1.Height;

            dgv.Location = new System.Drawing.Point(x_loc, y_loc);
            dgv.Name = "DataGridView1";
            //dgv.Size = new System.Drawing.Size(this.Width - 2 * x_loc, this.Height - 2 * y_loc);
            dgv.Size = new System.Drawing.Size(1366, 856);
            dgv.ForeColor = System.Drawing.Color.Black;
            Controls.Add(dgv);

            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string sql = "SELECT * FROM producao WHERE processo='Rebobinadeira' ";
            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(sql, conn);
                conn.Open();

                DataSet ds = new DataSet();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                {
                    adapter.Fill(ds);
                    dgv.DataSource = ds.Tables[0];
                }
            }
        }

        private void btn_corte_Click(object sender, EventArgs e)
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is DataGridView) this.Controls[ix].Dispose();
            }
            panel3.Hide();
            DataGridView dgv = new DataGridView();

            int x_loc = panel2.Width;
            int y_loc = panel1.Height;

            dgv.Location = new System.Drawing.Point(x_loc, y_loc);
            dgv.Name = "DataGridView1";
            //dgv.Size = new System.Drawing.Size(this.Width - 2 * x_loc, this.Height - 2 * y_loc);
            dgv.Size = new System.Drawing.Size(1366, 856);
            dgv.ForeColor = System.Drawing.Color.Black;
            Controls.Add(dgv);

            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string sql = "SELECT * FROM producao WHERE processo='Corte' ";
            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(sql, conn);
                conn.Open();

                DataSet ds = new DataSet();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                {
                    adapter.Fill(ds);
                    dgv.DataSource = ds.Tables[0];
                }
            }
        }

        private void btn_expedicao_Click(object sender, EventArgs e)
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is DataGridView) this.Controls[ix].Dispose();
            }
            panel3.Hide();
            DataGridView dgv = new DataGridView();

            int x_loc = panel2.Width;
            int y_loc = panel1.Height;

            dgv.Location = new System.Drawing.Point(x_loc, y_loc);
            dgv.Name = "DataGridView1";
            //dgv.Size = new System.Drawing.Size(this.Width - 2 * x_loc, this.Height - 2 * y_loc);
            dgv.Size = new System.Drawing.Size(1366, 856);
            dgv.ForeColor = System.Drawing.Color.Black;
            Controls.Add(dgv);

            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string sql = "SELECT * FROM producao WHERE processo='Expedição' ";
            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(sql, conn);
                conn.Open();

                DataSet ds = new DataSet();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                {
                    adapter.Fill(ds);
                    dgv.DataSource = ds.Tables[0];
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_gantt_Click(object sender, EventArgs e)
        {
            btn_export_Excel.Visible = false;
            


            Form_Gantt_Chart gc = new Form_Gantt_Chart();
            gc.Show();

            Graphics g = gc.CreateGraphics();




            // Create solid brush.
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            // Create rectangle.
            Rectangle rect = new Rectangle(0, 0, 200, 200);


            g.FillRectangle(blueBrush, 10, 10, 50, 50);


            g.Dispose();

        }

        private void btn_export_Excel_Click(object sender, EventArgs e)
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
            {
                if (this.Controls[ix] is DataGridView) this.Controls[ix].Dispose();
            }
            panel3.Hide();
            DataGridView dgv = new DataGridView();

            int x_loc = panel2.Width;
            int y_loc = panel1.Height;

            dgv.Location = new System.Drawing.Point(x_loc, y_loc);
            dgv.Name = "DataGridView1";
            //dgv.Size = new System.Drawing.Size(this.Width - 2 * x_loc, this.Height - 2 * y_loc);
            dgv.Size = new System.Drawing.Size(1366, 856);
            dgv.ForeColor = System.Drawing.Color.Black;
            Controls.Add(dgv);

            string sql = "SELECT * FROM producao";
            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(sql, conn);
                conn.Open();

                DataSet ds = new DataSet();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                {
                    adapter.Fill(ds);
                    dgv.DataSource = ds.Tables[0];
                }
            }

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Planilha1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    try
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                    catch
                    {
                    }
                }
            }
            // save the application  
            //workbook.SaveAs("C:\\Users\\Daniel Mota\\Documents\\GitHub\\Leoplastic\\Leoplastic\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //panel1.Width = Form1.ActiveForm.Width;
            //panel2.Height = Form1.ActiveForm.Height;
            //panel3.Width = Form1.ActiveForm.Width;
            //panel3.Height = Form1.ActiveForm.Height;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
