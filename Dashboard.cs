/*
 * Created by SharpDevelop.
 * User: Silas
 * Date: 19/02/2025
 * Time: 16:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Damle_peças
{
	/// <summary>
	/// </summary>
	public partial class Dashboard : Form
	{

		public Dashboard()
		{
			InitializeComponent();
			panel1.Visible = false; //para abrir a tela inicial e estar com o painel fechado
		}
		void Button1Click(object sender, EventArgs e)
		{
		panel1.Visible = true; //para abrir a tela de painel ao clicar em "Cadastrar Peça"
		}
		void Button3Click(object sender, EventArgs e)
		{
		panel1.Visible = false; //para fechar a tela de painel ao clicar em "<<Voltar"
		}
		
	}
		
}
	
