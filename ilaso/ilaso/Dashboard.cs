namespace ilaso;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
        panel1.Visible = false; //para abrir a tela inicial e estar com o painel fechado
        ConfigurarDataGridView();    
    }
    private void button1_Click(object sender, EventArgs e)
    {
        panel1.Visible = true; //para abrir a tela de painel ao clicar em "Cadastrar Peça"
    }
    private void button2_Click(object sender, EventArgs e)
    {
        panel1.Visible = false; //para fechar a tela de painel ao clicar em "<<Voltar"
    }
    private void ConfigurarDataGridView()
    {
        dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEstoque.AllowUserToAddRows = false;
        
        dgvEstoque.ColumnCount = 5;
        
        dgvEstoque.Columns[0].Name = "Nome da Peça";
        dgvEstoque.Columns[1].Name = "Categoria";
        dgvEstoque.Columns[2].Name = "Ano de Fabricação";
        dgvEstoque.Columns[3].Name = "Modelo";
        dgvEstoque.Columns[4].Name = "Quantidade";
    }
    private void button3_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text) ||  // Nome da peça
            string.IsNullOrWhiteSpace(textBox4.Text) ||  // Categoria
            string.IsNullOrWhiteSpace(textBox2.Text) ||  // Modelo
            numericUpDown1.Value == 0)                  // Quantidade
        {
            MessageBox.Show("Preencha todos os campos antes de salvar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; // Sai do método sem adicionar ao DataGridView
        }

        // Capturar os valores preenchidos
        string nomePeca = textBox1.Text;
        string categoria = textBox4.Text;
        string anoFabricacao = dateTimePicker1.Value.Year.ToString(); 
        string modelo = textBox2.Text;
        string quantidade = numericUpDown1.Value.ToString();

        // Adicionar os dados à tabela
        dgvEstoque.Rows.Add(nomePeca, categoria, anoFabricacao, modelo, quantidade);

        // Limpar os campos após salvar
        textBox1.Clear();
        textBox4.Clear();
        dateTimePicker1.Value = DateTime.Now; 
        textBox2.Clear();
        numericUpDown1.Value = 1;
    }
}


