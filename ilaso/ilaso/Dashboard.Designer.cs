using System.ComponentModel;

namespace ilaso;

partial class Dashboard
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
        pictureBox1 = new System.Windows.Forms.PictureBox();
        button1 = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        dgvEstoque = new System.Windows.Forms.DataGridView();
        numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        button3 = new System.Windows.Forms.Button();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        textBox4 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
      
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(-4, -2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(1285, 786);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.DarkGray;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ForeColor = System.Drawing.Color.White;
        button1.Location = new System.Drawing.Point(209, 32);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(127, 33);
        button1.TabIndex = 1;
        button1.Text = "Cadastrar Peça";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(dgvEstoque);
        panel1.Controls.Add(numericUpDown1);
        panel1.Controls.Add(dateTimePicker1);
        panel1.Controls.Add(button3);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(textBox4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(textBox1);
        panel1.Location = new System.Drawing.Point(287, 80);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(983, 695);
        panel1.TabIndex = 2;
        // 
        // dgvEstoque
        // 
        dgvEstoque.AllowUserToAddRows = false;
        dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvEstoque.BackgroundColor = System.Drawing.Color.White;
        dgvEstoque.GridColor = System.Drawing.Color.White;
        dgvEstoque.Location = new System.Drawing.Point(178, 111);
        dgvEstoque.Name = "dgvEstoque";
        dgvEstoque.ReadOnly = true;
        dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvEstoque.Size = new System.Drawing.Size(788, 394);
        dgvEstoque.TabIndex = 14;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new System.Drawing.Point(23, 390);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(120, 23);
        numericUpDown1.TabIndex = 16;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CustomFormat = "yyyy";
        dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dateTimePicker1.Location = new System.Drawing.Point(23, 283);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(70, 23);
        dateTimePicker1.TabIndex = 15;
        // 
        // button3
        // 
        button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button3.Location = new System.Drawing.Point(25, 433);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(100, 29);
        button3.TabIndex = 12;
        button3.Text = "Salvar>>";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(23, 364);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(89, 23);
        label5.TabIndex = 11;
        label5.Text = "Quantidade:";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(23, 200);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(70, 23);
        label4.TabIndex = 8;
        label4.Text = "Categoria:";
        // 
        // textBox4
        // 
        textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        textBox4.Location = new System.Drawing.Point(23, 226);
        textBox4.Multiline = true;
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(149, 26);
        textBox4.TabIndex = 7;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(23, 255);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(131, 23);
        label3.TabIndex = 6;
        label3.Text = "Data de Fabricação:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(23, 309);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(102, 23);
        label2.TabIndex = 4;
        label2.Text = "Modelo:";
        // 
        // textBox2
        // 
        textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        textBox2.Location = new System.Drawing.Point(23, 335);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(149, 26);
        textBox2.TabIndex = 3;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(23, 141);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(102, 23);
        label1.TabIndex = 2;
        label1.Text = "Nome da Peça:\r\n";
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.Location = new System.Drawing.Point(25, 15);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(100, 29);
        button2.TabIndex = 1;
        button2.Text = "<<Voltar\r\n";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // textBox1
        // 
        textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        textBox1.Location = new System.Drawing.Point(23, 167);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(149, 26);
        textBox1.TabIndex = 0;
        // 
    
        // Dashboard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(1280, 782);
        Controls.Add(panel1);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }


    private System.Windows.Forms.NumericUpDown numericUpDown1;

    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.DataGridView dgvEstoque;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}