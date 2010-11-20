using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIS
{
    public partial class SelectAddress : Form
    {
        public String DireccionSelected { get; set; }
        protected BindingList<String> Direcciones { get; set; }

        public SelectAddress()
        {
            InitializeComponent();
            Direcciones = new BindingList<string>();
            lstAddress.DataSource = Direcciones;
        }

        public void loadAddress(BindingList<String> direcciones){
            this.Direcciones.Clear();
            direcciones.ToList().ForEach((String direccion) => this.Direcciones.Add(direccion));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DireccionSelected = lstAddress.SelectedValue.ToString();
            this.Hide();
        }

        private void lstAddress_DoubleClick(object sender, EventArgs e)
        {
            DireccionSelected = lstAddress.SelectedValue.ToString();
            this.Hide();
        }
    }
}
