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
    public partial class EditBus : Form
    {
        public Bus currentBus { get; set; }

        public EditBus(Bus bus)
        {
            InitializeComponent();
            
            textPlate.Text = bus.Plate;
            textMake.Text = bus.Make;
            var result = Program.app.busTypeService.GetAll();
            comboType.DataSource = result;
            comboType.SelectedItem = bus.Type;
            currentBus = bus;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditBus_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            currentBus.Make = textMake.Text;
            currentBus.Plate = textPlate.Text;
            currentBus.Type = (BusType)comboType.SelectedItem;
            Program.app.busService.Update(currentBus);
            this.Close();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
