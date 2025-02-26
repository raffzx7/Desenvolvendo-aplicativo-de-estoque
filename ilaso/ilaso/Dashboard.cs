namespace ilaso;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
        ConfigurarDataGridView();    
    }
    
    private void ConfigurarDataGridView()
    {
        dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEstoque.AllowUserToAddRows = false;
        
        dgvEstoque.ColumnCount = 7;
        
        dgvEstoque.Columns[0].Name = "Nome da Peça";
        dgvEstoque.Columns[1].Name = "Categoria";
        dgvEstoque.Columns[2].Name = "Ano de Fabricação";
        dgvEstoque.Columns[3].Name = "Modelo";
        dgvEstoque.Columns[4].Name = "Quantidade";
        dgvEstoque.Columns[5].Name = "QuantidadeMax";
        dgvEstoque.Columns[6].Name = "QuantidadeMin";
    }
    private void button3_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text) ||  // Nome da peça
            string.IsNullOrWhiteSpace(textBox2.Text) ||  // Categoria
            string.IsNullOrWhiteSpace(textBox3.Text) ||  // Modelo
            numericUpDown1.Value == 0)                  // Quantidade max
        {
            MessageBox.Show("Preencha todos os campos antes de salvar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; // Sai do método sem adicionar ao DataGridView
        }

        // Capturar os valores preenchidos
        string nomePeca = textBox1.Text;
        string categoria = textBox2.Text;
        string anoFabricacao = dateTimePicker1.Value.Year.ToString(); 
        string modelo = textBox3.Text;
        string quantidademax = numericUpDown1.Value.ToString();
        string quantidademin = numericUpDown2.Value.ToString();

        // Adicionar os dados à tabela
        dgvEstoque.Rows.Add(nomePeca, categoria, anoFabricacao, modelo, quantidademax, quantidademin);

        // Limpar os campos após salvar
        textBox1.Clear();
        textBox2.Clear();
        dateTimePicker1.Value = DateTime.Now; 
        textBox3.Clear();
        numericUpDown1.Value = 0;
        numericUpDown2.Value = 0;
    }

}
