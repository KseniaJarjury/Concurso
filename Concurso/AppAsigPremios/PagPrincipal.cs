using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Concurso;

namespace AppAsigPremios
{
    public partial class PagPrincipal : Form
    {
        public PagPrincipal()
        {
            InitializeComponent();
        }

        private void comenzar_Click(object sender, EventArgs e)
        {
            Ruleta ruleta = new Ruleta();
            Sorteo sorteo = new Sorteo();
            Distribucion distri = new Distribucion();
            DataTable dt = new DataTable();

            try
            {
                if (tipoSorteoCmb.SelectedItem.ToString() == "Ruleta")
                {
                    dt = ruleta.Asignacion();
                }
                else if (tipoSorteoCmb.SelectedItem.ToString() == "Sorteo")
                {
                    dt = sorteo.Asignacion();
                }
                else if (tipoSorteoCmb.SelectedItem.ToString() == "Distribución")
                {
                    dt = distri.Asignacion();
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message.ToString();
                label1.Visible = true;
            }
        }

        private void tipoSorteoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Visible = false;
                if(tipoSorteoCmb.SelectedItem.ToString() == "")
                {
                    comenzarBtn.Enabled = false;
                }
                else
                {
                    comenzarBtn.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message.ToString();
                label1.Visible = true;
            }
        }
    }
}
