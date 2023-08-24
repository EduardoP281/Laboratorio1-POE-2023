using bibliotecaEventos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2_Laboratorio_1.OrganizadorEventos
{
    public partial class PantallaInicial : Form
    {
        public PantallaInicial()
        {
            InitializeComponent();
            InitializeStatusEstadoComboBox();
        }

        private void InitializeStatusEstadoComboBox()
        {
            estadoComboBox.Items.AddRange(Enum.GetNames(typeof(Estado)));
            estadoComboBox.SelectedIndex = 0;
        }

        private void addEventsButtom_Click(object sender, EventArgs e)
        {
            Eventos eventos = new Eventos();

            eventos.ocasionEvento = AddEventosTextBox.Text;

            eventos.Status = (Estado)estadoComboBox.SelectedIndex;

            Cliente cliente = new Cliente();

            cliente.clienteEvento = clienteTextBox.Text;

            eventosListBox.Items.Add(eventos.ocasionEvento);
            eventosListBox.Items.Add(eventos.Status);
            eventosListBox.Items.Add(cliente.clienteEvento); 

            if (string.IsNullOrEmpty(AddEventosTextBox.Text) || string.IsNullOrWhiteSpace(AddEventosTextBox.Text))
            {
                MessageBox.Show("Ingresa un evento.");
            }
            if (string.IsNullOrEmpty(clienteTextBox.Text) || string.IsNullOrWhiteSpace(clienteTextBox.Text))
            {
                MessageBox.Show("Ingresa nombre del cliente.");
            }
        }

        private void deleteEventsButtom_Click(object sender, EventArgs e)
        {
            eventosListBox.Items.Remove(eventosListBox.SelectedItem);
        }

        private void editEventsButtom_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(eventModTxtBox.Text) || string.IsNullOrWhiteSpace(eventModTxtBox.Text)) 
            { 
                MessageBox.Show("Ingresa el nuevo valor para modificar."); 
                return; 
            } 
            int indice = eventosListBox.SelectedIndex; 
            if (indice >= 0 && indice < eventosListBox.Items.Count) 
            { 
                eventosListBox.Items[indice] = eventModTxtBox.Text;
            }
            else 
            { MessageBox.Show("Selecciona un evento para modificar.");
            }
        }
    }
}
