namespace ilaso;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string emailCorreto = "Silas";
        string senhaCorreta = "123";
        
        string emailDigitado = textBox2.Text;
        string senhaDigitada = textBox1.Text;
        
        if (emailDigitado == emailCorreto && senhaDigitada == senhaCorreta)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("E-mail ou senha incorretos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}