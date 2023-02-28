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

    enum SortKind
    {
        Name,
        Type,
        Date
    }

    public partial class Form1 : Form
    {

        private List<File> currenttable = new List<File>();

        private List<File> Currenttable
        {
            get
            {
                return currenttable;
            }
            set
            {
                switch (sortkind)
                { 
                    case SortKind.Name:
                        if (sortside)
                            currenttable = value.OrderBy(s => s.Name).ToList();
                        else
                            currenttable = value.OrderByDescending(s => s.Name).ToList();
                        break;
                    case SortKind.Type:
                        if (sortside)
                            currenttable = value.OrderBy(s => s.Type).ToList();
                        else
                            currenttable = value.OrderByDescending(s => s.Type).ToList();
                        break;
                    case SortKind.Date:
                        if (sortside)
                            currenttable = value.OrderBy(s => s.Time).ToList();
                        else
                            currenttable = value.OrderByDescending(s => s.Time).ToList();
                        break;
                }
                dataGridView.DataSource = currenttable;
            }
        }
        private SortKind sortkind;

        //true = по возрастанию, false = по убыванию
        private bool sortside;
        public Form1()
        {
            
            InitializeComponent();
            AllFiles.init();
            sortkind = SortKind.Name;
            sortside = true;         
            Currenttable = AllFiles.allfiles;          
            TypecomboBox.Items.Add("нет");
            TypecomboBox.Items.AddRange(FileTypes.types);
            TypecomboBox.SelectedIndex = 0;
            BaseTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BaseTable()
        {
            dataGridView.DataSource = AllFiles.allfiles;
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            var tx = AllFiles.allfiles.Where(s => s.Name.ToLower().Contains(NametextBox.Text.ToLower())).ToList();
            Currenttable = tx;
        }

        private void TypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypecomboBox.SelectedIndex == 0)
            {
                BaseTable();
                return;
            }
            var typ = AllFiles.allfiles.Where(s => s.Type == TypecomboBox.SelectedItem.ToString()).ToList();
            Currenttable = typ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NametextBox.Clear();
            TypecomboBox.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
            sortkind = SortKind.Name;
            sortside = true;
            BaseTable();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime tim = dateTimePicker.Value;
            var tims = AllFiles.allfiles.Where(s => s.Time.CompareTo(tim) < 0).ToList();
            Currenttable = tims;
        }

        private void возрастаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortside = true;
            sortkind = SortKind.Name;
            Currenttable = Currenttable;
        }

        private void убываниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortside = false;
            sortkind = SortKind.Name;
            Currenttable = Currenttable;
        }

        private void возрастаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sortside = true;
            sortkind = SortKind.Type;
            Currenttable = Currenttable;
        }

        private void убываниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sortside = false;
            sortkind = SortKind.Type;
            Currenttable = Currenttable;
        }

        private void возрастаниеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sortside = true;
            sortkind = SortKind.Date;
            Currenttable = Currenttable;
        }

        private void убываниеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sortside = false;
            sortkind = SortKind.Date;
            Currenttable = Currenttable;
        }
    }
}
