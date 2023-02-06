using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alejandro
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double precio, cantidad, subtp;
            precio = Convert.ToDouble(maskedTextBox1.Text);
            cantidad = Convert.ToDouble(maskedTextBox2.Text);
            subtp = precio * cantidad;
            textBox1.Text=subtp.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double stf = 0, tf;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = comboBox1.Text;
            row.Cells[1].Value = maskedTextBox1.Text;
            row.Cells[2].Value = maskedTextBox2.Text;
            row.Cells[3].Value = textBox1.Text;
            
            dataGridView1.Rows.Add(row);

            int i = 0;

            for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                stf=stf+Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            tf = stf * 1.15;
            textBox2.Text=stf.ToString();
            textBox3.Text=tf.ToString();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

        }

        
    }
}
