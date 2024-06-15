using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Octokit;
using System.Net.Http.Headers;

namespace EldenPizza
{
    public partial class Cliente : Form
    {
        private readonly HttpClient _apiClient;
        public Cliente()
        {
            InitializeComponent();
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri("http://localhost:5271/api/");
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCliente editarCliente = new EditarCliente();
            editarCliente.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string nombre = Nombretxt.Text;
            string telefono = telefonotxt.Text;
            string direccion = Direcciontxt.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EditarCliente editarCliente = new EditarCliente();
            editarCliente.Show();
        }
    }
}
