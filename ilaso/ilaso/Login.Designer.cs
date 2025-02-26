namespace ilaso;

partial class Login
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
        pictureBox1 = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        button1 = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(1, -3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(707, 798);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.ErrorImage = ((System.Drawing.Image)resources.GetObject("pictureBox2.ErrorImage"));
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(800, 12);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(431, 422);
        pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // button1
        // 
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(962, 595);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(92, 26);
        button1.TabIndex = 2;
        button1.Text = "Entrar>>";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        textBox1.Location = new System.Drawing.Point(962, 545);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(134, 22);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        textBox2.Location = new System.Drawing.Point(962, 496);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(134, 22);
        textBox2.TabIndex = 4;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(909, 496);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(47, 20);
        label2.TabIndex = 6;
        label2.Text = "Email:";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(906, 545);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(50, 20);
        label1.TabIndex = 7;
        label1.Text = "Senha:";
        // 
        // Login
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(1307, 778);
        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Controls.Add(pictureBox2);
        Controls.Add(pictureBox1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MaximizeBox = false;
        Text = "DAMLE PEÇAS";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.PictureBox pictureBox1;
    
}