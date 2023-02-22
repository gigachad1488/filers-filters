using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllFiles.init();
            comboBox1.Items.Add("нет");
            comboBox1.Items.AddRange(FileTypes.types);
            BaseTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BaseTable()
        {
            dataGridView1.DataSource = AllFiles.allfiles;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var tx = AllFiles.allfiles.Where(s => s.Name.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            dataGridView1.DataSource = tx;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                BaseTable();
                return;
            }
            var typ = AllFiles.allfiles.Where(s => s.Type == comboBox1.SelectedItem.ToString()).ToList();
            dataGridView1.DataSource = typ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            BaseTable();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tim = dateTimePicker1.Value;
            var tims = AllFiles.allfiles.Where(s => s.Time.CompareTo(tim) < 0).ToList();
            dataGridView1.DataSource = tims;
        }
    }
}
