namespace atv11
{
    public partial class Form1 : Form
    {
        //private List<Empresa> empresa = new List<Empresa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.ShowDialog();
        }

       
        }
    }