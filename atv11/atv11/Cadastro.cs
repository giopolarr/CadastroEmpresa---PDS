using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv11
{
    public partial class Cadastro : Form
    {


        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CNPJ = Cnpj.Text;
                string Razaosocial = RazaoSocial.Text;
                string Nomefantasia = NomeFantasia.Text;
                string Situacaocadastral = SituacaoCadastral.Text;
                string Regimetributario;
                string Datainicio = DataInicio.Text;
                string Telefone = maskedTextBox3.Text;
                string Capitalsocial = CapitalSocial.Text;
                string Rua = Ruaa.Text;
                string Bairro = Bairroo.Text;
                string Cidade = Cidadee.Text;
                string Numero = Numeroo.Text;
                string Cep = Cepp.Text;
                string Estado = Estadoo.Text;
                string Tipo;
                string PorteEmpresa;
                string Naturezapolitica = NaturezaPolitica.Text;
                string Nomeproprietario = NomeProprietario.Text;
                string Cpfproprietario = CpfProprietario.Text;

                if (SimplesNacional.Checked == true)
                {
                    Regimetributario = SimplesNacional.Text;
                }
                else if (LucroPresumido.Checked == true)
                {
                    Regimetributario = LucroPresumido.Text;
                }
                else if (LucroReal.Checked == true)
                {
                    Regimetributario = LucroReal.Text;
                }

                if (Pequeno.Checked == true)
                {
                    PorteEmpresa = Pequeno.Text;
                }
                else if (Medio.Checked == true)
                {
                    PorteEmpresa = Medio.Text;
                }
                else if (Grande.Checked == true)
                {
                    PorteEmpresa = Grande.Text;
                }


                MessageBox.Show($"{CNPJ} {Razaosocial} {Nomefantasia} {Situacaocadastral}  {Datainicio} {Telefone}{Capitalsocial}{Rua} {Bairro} {Cidade} {Numero} {Cep}{Estado}  {Naturezapolitica} {Nomeproprietario} {Cpfproprietario}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
