using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cory_Deuschle_Software1
{
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
        }

        private void btnAddPartSave_Click(object sender, EventArgs e)
        {
            
            if (AddPartMaxBoxText < AddPartMinBoxText)
            {
                MessageBox.Show("Minimum cannot be greate than the Maximum.");
                return;
            }

            if (radioAddInHouse.Checked)
            {
                InHousePart inHouse = new InHousePart((Inventory.Parts.Count + 1), AddPartNameBoxText, AddPartInvBoxText, AddPartPriceBoxText, AddPartMaxBoxText, AddPartMinBoxText, int.Parse(AddPartMachComBoxText));
                Inventory.AddPart(inHouse);
            }
            else
            {
                OutsourcedPart outsourced = new OutsourcedPart((Inventory.Parts.Count + 1), AddPartNameBoxText, AddPartInvBoxText, AddPartPriceBoxText, AddPartMaxBoxText, AddPartMinBoxText, AddPartMachComBoxText);
                Inventory.AddPart(outsourced);
            }
            this.Close();
        }

        
        private void radioAddOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Company Name";
            addPartMachComBox.Text = "Comp Nm";
        }
        private void radioAddInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Machine ID";
            addPartMachComBox.Text = "Mach ID";
        }

        private void btnAddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}