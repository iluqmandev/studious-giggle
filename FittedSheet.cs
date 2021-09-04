using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMCalculatorBedFittedPc
{
    public partial class FittedSheet : Form
    {
        public FittedSheet()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int rowIndex;
        int indexRow;
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            txtSMV.Visible = true;
            txtTML.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            bunifuFlatButton2.Visible = true;
            tmc.Visible = true;
            txmc.Visible = true;
            bunifuImageButton3.Visible = true;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            txtSMV.Visible = false;
            txtTML.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            bunifuFlatButton2.Visible = false;
            tmc.Visible = false;
            txmc.Visible = false;
            bunifuImageButton3.Visible = false;
        }

        private void FittedSheet_Load(object sender, EventArgs e)
        {
            // populate dgv from datatable

            // add columns
            table.Columns.Add("No.", typeof(int));
            table.Columns.Add("Operation", typeof(string));
            table.Columns.Add("SMV", typeof(double));
            table.Columns.Add("TGT", typeof(double));
            table.Columns.Add("AML", typeof(double));
            table.Columns.Add("TML", typeof(double));

            table.Columns.Add("DAYS", typeof(int));
            //   table.Columns.Add("TGT per Hours", typeof(int));
            // table.Columns.Add("TGT Per Day at 100% (8 Hours)", typeof(int));
            //table.Columns.Add("TGT Per Day at 700% (8 Hours)", typeof(int));

            // add rows
            table.Rows.Add(1, "Drop O/L ", 0.449, 134, 2.34, 3, 3307);
            table.Rows.Add(2, "Elastic attachment 4 side+LABLE ", 0.790, 76, 4.12, 4, 2430);
            table.Rows.Add(3, "Hem 1 cm 4 side + reinforcement ", 1.600, 38, 8.34, 8, 2400);
            table.Rows.Add(4, "Trimming", 1.00, 60, 5.21, 5, 2400);



            dataGridView1.DataSource = table;
            // bunifuCustomDataGrid1.DataSource = table;
            dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dataGridView1.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);


            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rowIndex = dataGridView1.SelectedCells[0].OwningRow.Index;
            DataRow row = table.NewRow();

            row[0] = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            row[1] = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            row[2] = double.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
            row[3] = double.Parse(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
            row[4] = double.Parse(dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
            row[5] = double.Parse(dataGridView1.Rows[rowIndex].Cells[5].Value.ToString());
            row[6] = int.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());


            if (rowIndex < dataGridView1.Rows.Count - 2)
            {
                table.Rows.RemoveAt(rowIndex);
                table.Rows.InsertAt(row, rowIndex + 1);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex + 1].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get selected row index
            rowIndex = dataGridView1.SelectedCells[0].OwningRow.Index;

            // create a new row
            DataRow row = table.NewRow();

            // add values to the new row
            row[0] = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            row[1] = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            row[2] = double.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
            row[3] = double.Parse(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
            row[4] = double.Parse(dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
            row[5] = double.Parse(dataGridView1.Rows[rowIndex].Cells[5].Value.ToString());
            row[6] = int.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());


            if (rowIndex > 0)
            {
                // delete the selected row
                table.Rows.RemoveAt(rowIndex);
                // add the new row 
                table.Rows.InsertAt(row, rowIndex - 1);
                dataGridView1.ClearSelection();
                // select the new row
                dataGridView1.Rows[rowIndex - 1].Selected = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            rowIndex = dataGridView1.SelectedCells[0].OwningRow.Index;
            DataRow row = table.NewRow();

            row[0] = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            row[1] = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            row[2] = double.Parse(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
            row[3] = double.Parse(dataGridView1.Rows[rowIndex].Cells[3].Value.ToString());
            row[4] = double.Parse(dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
            row[5] = double.Parse(dataGridView1.Rows[rowIndex].Cells[5].Value.ToString());
            row[6] = int.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());


            if (rowIndex < dataGridView1.Rows.Count - 2)
            {
                table.Rows.RemoveAt(rowIndex);
                table.Rows.InsertAt(row, rowIndex + 1);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex + 1].Selected = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtSMV.Text = row.Cells[2].Value.ToString();
            txtTGT.Text = row.Cells[3].Value.ToString();
            txtML.Text = row.Cells[4].Value.ToString();
            txtTML.Text = row.Cells[5].Value.ToString();
            txtDays.Text = row.Cells[6].Value.ToString();
            txmc.Text = txtMC.Text;

            //Calculate total SMV
            double Tsmv = double.Parse(dataGridView1.Rows[0].Cells[2].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[1].Cells[2].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[2].Cells[2].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[3].Cells[2].EditedFormattedValue.ToString());
            toltalSMV.Text = Tsmv.ToString();
            //Calculate total TGT
            double mc = double.Parse(txtMC.Text);
            double Ttgt = Tsmv / mc;
            totalTGT.Text = Ttgt.ToString();
            //Calculate total AML
            double Taml = double.Parse(dataGridView1.Rows[0].Cells[4].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[1].Cells[4].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[2].Cells[4].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[3].Cells[4].EditedFormattedValue.ToString());
            totalAML.Text = Taml.ToString();
            //Calculate total TML
            double Ttml = double.Parse(dataGridView1.Rows[0].Cells[5].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[1].Cells[5].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[2].Cells[5].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[3].Cells[5].EditedFormattedValue.ToString());
            totalTML.Text = Ttml.ToString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            double Tsmv = double.Parse(dataGridView1.Rows[0].Cells[2].EditedFormattedValue.ToString()) +
 double.Parse(dataGridView1.Rows[1].Cells[2].EditedFormattedValue.ToString()) +
 double.Parse(dataGridView1.Rows[2].Cells[2].EditedFormattedValue.ToString()) +
 double.Parse(dataGridView1.Rows[3].Cells[2].EditedFormattedValue.ToString());
            toltalSMV.Text = Tsmv.ToString();
            //Calculate total TGT
            double mc1 = double.Parse(txtMC.Text);
            double Ttgt = Tsmv / mc1;
            totalTGT.Text = Ttgt.ToString();
            //Calculate total AML
            double Taml = double.Parse(dataGridView1.Rows[0].Cells[4].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[1].Cells[4].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[2].Cells[4].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[3].Cells[4].EditedFormattedValue.ToString());
            totalAML.Text = Taml.ToString();
            //Calculate total TML
            double Ttml = double.Parse(dataGridView1.Rows[0].Cells[5].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[1].Cells[5].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[2].Cells[5].EditedFormattedValue.ToString()) +
           double.Parse(dataGridView1.Rows[3].Cells[5].EditedFormattedValue.ToString());
            totalTML.Text = Ttml.ToString();

            double smv;
            smv = double.Parse(txtSMV.Text);

            double TGT = 60 / smv;

            txtTGT.Text = TGT.ToString();
            //AML
            double aml, Total_TGT;

            Total_TGT = double.Parse(totalTGT.Text);
            aml = smv / Total_TGT;
            txtML.Text = aml.ToString();
            //days
            double tml = double.Parse(txtTML.Text);
            double days;
            days = TGT * 8 * tml;
            int res = Convert.ToInt32(days);
            txtDays.Text = res.ToString();
            //TGT per day at 100%
            double mc, TotalSMV, tgt100;
            mc = double.Parse(txtMC.Text);
            TotalSMV = double.Parse(toltalSMV.Text);
            tgt100 = mc * 480 / TotalSMV;
            int res1 = Convert.ToInt32(tgt100);
            txtTGT100.Text = res1.ToString();
            //per hour
            double perHour;
            perHour = tgt100 / 8;
            int res2 = Convert.ToInt32(perHour);
            txtHours.Text = res2.ToString();
            //tgt per day at 70%
            double tgt70 = tgt100 * 0.7;
            int res3 = Convert.ToInt32(tgt70);
            textBox70.Text = res3.ToString();


            newDataRow.Cells[2].Value = txtSMV.Text;
            newDataRow.Cells[3].Value = txtTGT.Text;
            newDataRow.Cells[4].Value = txtML.Text;
            newDataRow.Cells[5].Value = txtTML.Text;

            newDataRow.Cells[6].Value = txtDays.Text;

            txtTGTperHr.Text = txtHours.Text;
            txtTGTperDay100.Text = txtTGT100.Text;
            txtTGTperDay70.Text = textBox70.Text;
            txtMC.Text = txmc.Text;
        }
        Bitmap bitmap;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            bunifuFlatButton1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
