/*
 * Created by SharpDevelop.
 * User: Silas
 * Date: 19/02/2025
 * Time: 16:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Damle_peças
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
            string emailCorreto = "Silas"; //definir um e-mail para entrar
            string senhaCorreta = "123";   //definir uma senha para entrar
            
            string emailDigitado = textBox1.Text;
            string senhaDigitada = textBox2.Text;
            
            
            if (emailDigitado == emailCorreto && senhaDigitada == senhaCorreta)	//verificar se a senha e o codigo estão corretos
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();	//se a senha e o email estiverem corretos a pagina inicial(dasboard irá abrir
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //se a senha ou email estiverem incorretos exibe uma notificação de erro
            }
      }
      
		}
  
	}
