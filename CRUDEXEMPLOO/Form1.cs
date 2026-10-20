namespace CRUDEXEMPLOO
{
    public partial class Form1 : Form
    {
        String NOME, SOBRENOME, CURSO, RM;
            int IDADE, ANO;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

            NOME = TEXTBOXNOME.Text;
            SOBRENOME = TEXTBOXSOBRENOME.Text;
            CURSO = TEXTBOXCURSO.Text;
            IDADE = int.Parse(TEXBOXIDADE.Text);
            RM = TEXTBOXRM.Text;
            ANO = int.Parse(TEXTBOXANO.Text);


        }
    }
}
