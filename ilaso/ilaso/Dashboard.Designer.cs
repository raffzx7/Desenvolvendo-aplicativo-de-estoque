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
        tabControl1 = new System.Windows.Forms.TabControl();
        tabPage1 = new System.Windows.Forms.TabPage();
        button1 = new System.Windows.Forms.Button();
        label6 = new System.Windows.Forms.Label();
        numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        label5 = new System.Windows.Forms.Label();
        numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        label4 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        tabPage2 = new System.Windows.Forms.TabPage();
        dgvEstoque = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(-2, -2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(1136, 684);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new System.Drawing.Point(7, 69);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(1117, 599);
        tabControl1.TabIndex = 1;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(button1);
        tabPage1.Controls.Add(label6);
        tabPage1.Controls.Add(numericUpDown2);
        tabPage1.Controls.Add(label5);
        tabPage1.Controls.Add(numericUpDown1);
        tabPage1.Controls.Add(label4);
        tabPage1.Controls.Add(textBox3);
        tabPage1.Controls.Add(dateTimePicker1);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(textBox2);
        tabPage1.Controls.Add(label1);
        tabPage1.Controls.Add(textBox1);
        tabPage1.Location = new System.Drawing.Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(3);
        tabPage1.Size = new System.Drawing.Size(1109, 571);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.White;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        button1.Location = new System.Drawing.Point(69, 309);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(86, 23);
        button1.TabIndex = 12;
        button1.Text = "Salvar>>";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button3_Click;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(330, 88);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(136, 23);
        label6.TabIndex = 11;
        label6.Text = "Quantidade Máxima";
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new System.Drawing.Point(330, 115);
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new System.Drawing.Size(120, 23);
        numericUpDown2.TabIndex = 10;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(330, 140);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(136, 23);
        label5.TabIndex = 9;
        label5.Text = "Quantidade Mínima:";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new System.Drawing.Point(330, 166);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(120, 23);
        numericUpDown1.TabIndex = 8;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(69, 240);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(63, 23);
        label4.TabIndex = 7;
        label4.Text = "Modelo:";
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(69, 266);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(182, 23);
        textBox3.TabIndex = 6;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CustomFormat = "yyyy";
        dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dateTimePicker1.Location = new System.Drawing.Point(69, 217);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new System.Drawing.Size(182, 23);
        dateTimePicker1.TabIndex = 5;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(69, 191);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(130, 23);
        label3.TabIndex = 4;
        label3.Text = "Ano De Fabricação:";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(69, 139);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 3;
        label2.Text = "Categoria:";
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(69, 165);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(182, 23);
        textBox2.TabIndex = 2;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(69, 88);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 1;
        label1.Text = "Nome da Peça:";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(69, 114);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(182, 23);
        textBox1.TabIndex = 0;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(dgvEstoque);
        tabPage2.Location = new System.Drawing.Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new System.Windows.Forms.Padding(3);
        tabPage2.Size = new System.Drawing.Size(1109, 571);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // dgvEstoque
        // 
        dgvEstoque.Location = new System.Drawing.Point(240, 113);
        dgvEstoque.Name = "dgvEstoque";
        dgvEstoque.Size = new System.Drawing.Size(609, 293);
        dgvEstoque.TabIndex = 0;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1134, 680);
        Controls.Add(tabControl1);
        Controls.Add(pictureBox1);
        Text = "Dasboard";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        tabPage2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgvEstoque;

    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}