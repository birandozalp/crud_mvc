using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoyagerYBusiness;

namespace VoyagerY
{
    public partial class MainBus : Form
    {
       

        

        public MainBus()
        {
            InitializeComponent();
            Program.app.busService.ListChanged += new ListChangeHandler(RefreshList);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.app.busService.GetAll();
            comboBox_Type.DataSource = Program.app.busTypeService.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            bus.Make = textBox_Make.Text;
            bus.Plate = textBox_Plate.Text;
            bus.Type = (BusType)comboBox_Type.SelectedItem;
            Program.app.busService.Add(bus);
        }

   

        private void removeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Program.app.busService.Remove((Bus)dataGridView1.SelectedRows[0].DataBoundItem);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.app.busService.GetAll();
        }

        private void RefreshList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.app.busService.GetAll();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBus editBus = new EditBus((Bus)dataGridView1.SelectedRows[0].DataBoundItem);
            editBus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
        }
    }
}
