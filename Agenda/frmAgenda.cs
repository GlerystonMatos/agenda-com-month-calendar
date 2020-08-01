using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
            this.Text = "Agenda de Compromissos Versão 3.0";
            icone.Text = this.Text;
        }

        private void NovoCompromisso_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;
            
            frmCompromisso frmCompromisso = new frmCompromisso();
            frmCompromisso.ShowDialog();

            relogio.Enabled = true;

            Calendario_DateChanged(sender, null);
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            List<Compromissos> compromissos = Compromissos.Listar(Calendario.SelectionRange.Start);
            CompromissosDoDia.Items.Clear();

            foreach (Compromissos lista in compromissos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = lista.Id.ToString();
                item.SubItems.Add(lista.Hora.ToString());
                item.SubItems.Add(lista.Descricao);
                CompromissosDoDia.Items.Add(item);
            }
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            Calendario_DateChanged(sender, null);
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            Compromissos.VerificaCompromissos();            
        }

        private void icone_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            icone.Visible = false;
        }

        private void frmAgenda_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                icone.Visible = true;
            }
        }
    }
}
