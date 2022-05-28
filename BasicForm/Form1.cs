using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string selectedCity=
            MessageBox.Show(CityList.GetItemText(CityList.SelectedItem));

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string address=AddressBox.Text;
            MessageBox.Show(name + " " + address);
        }

     
    }
}
