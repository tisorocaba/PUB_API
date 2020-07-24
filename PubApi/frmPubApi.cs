using Newtonsoft.Json;
using PubApi.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubApi
{
    public partial class frmPubApi : Form
    {
        public frmPubApi()
        {
            InitializeComponent();
        }

        private ApiWeb CriarApi()
        {
            int idUs = Convert.ToInt32(edtUsuario.Text);
            string senha = edtChave.Text;
            string url = edtUrl.Text;

            ApiWeb api = new ApiWeb(idUs, senha, url);

            return api;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(edtNumero.Text);
            int ano = Convert.ToInt32(edtAno.Text);

            ApiWeb api = CriarApi();

            var lista = api.ConsultarPublicacao(numero, ano);

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(edtNumero.Text);
            int ano = Convert.ToInt32(edtAno.Text);

            ApiWeb api = CriarApi();

            var lista = api.ConsultarItens(numero, ano);

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            ApiWeb api = CriarApi();

            var lista = api.ConsultarStatusPublicacao();

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);
        }

        private void btnModalidade_Click(object sender, EventArgs e)
        {
            ApiWeb api = CriarApi();

            var lista = api.ConsultarModalidade();

            if (!api.httpResult.Erro)
                dgvDados.DataSource = lista;
            else
                MessageBox.Show(api.httpResult.MensagemErro);

        }

    }
}
