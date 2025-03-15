
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalcApenasCodigo
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			txt1.KeyPress += new KeyPressEventHandler(textbox1); // adiciona o evento KeyPress
			this.Controls.Add(txt1);
			
			txt2.KeyPress += new KeyPressEventHandler(textbox2); // adiciona o evento KeyPress
			this.Controls.Add(txt1);
			
			txt3.KeyPress += new KeyPressEventHandler(textbox3); // adiciona o evento KeyPress
			this.Controls.Add(txt1);
		}
			TextBox txt1 = new TextBox(); // primeiro valor
			TextBox txt2 = new TextBox(); // segundo valor
			TextBox txt3 = new TextBox(); // resultado
			
			Button soma = new Button();// label adi
			Button subtrair = new Button(); //label sub
			Button multiplicar = new Button();//label mul
			Button dividir = new Button();//label div
			Button resultado = new Button();
			
			Label titulo = new Label();
			Label num1 = new Label();
			Label num2 = new Label();
			Label num3 = new Label();
			Label num4 = new Label();
			
			
			int a,b,c,d,s,m;
			
		void MainFormLoad(object sender, EventArgs e)
		{
			//primeirotxt
			txt1.Parent = this;
			txt1.Left = 20;
			txt1.Top = 60;
			
			
			//segundotxt
			txt2.Parent = this;
			txt2.Left = 230;
			txt2.Top = 60;
			
			//terceirotxt
			txt3.Parent = this;
			txt3.Left = 125;
			txt3.Top = 120;
			
			//Botão somar
			soma.Parent = this;
			soma.Click += somaClick;
			soma.Left = 30;
			soma.Top = 200;
			soma.Text = "Somar";
			soma.AutoSize = true;
			
			//Botão subtrair
			subtrair.Parent = this;
			subtrair.Click += subtrairClick;
			subtrair.Left = 30;
			subtrair.Top = 230;
			subtrair.Text = "Subtrair";
			subtrair.AutoSize = true;
			
			//Botão multiplicação
			multiplicar.Parent = this;
			multiplicar.Click += multiplicarClick;
			multiplicar.Left = 230;
			multiplicar.Top = 200;
			multiplicar.Text = "Multiplicar";
			multiplicar.AutoSize = true;
			
			//Botão divisão
			dividir.Parent = this;
			dividir.Click += dividirClick;
			dividir.Left = 230;
			dividir.Top = 230;
			dividir.Text = "Divisão";
			dividir.AutoSize = true;
			
			//Label titulo
			titulo.Parent = this;
			titulo.Text = ("Bem-Vindo a Calculadora C#");
			titulo.AutoSize = true;
			titulo.Left = 105;
			
			//Label numero 1
			num1.Parent = this;
			num1.Text = ("Primeiro Numero");
			num1.AutoSize = true;
			num1.Left = 25;
			num1.Top = 45;
			
			//label numero 2
			num2.Parent = this;
			num2.Text = ("Segundo Numero");
			num2.AutoSize = true;
			num2.Left = 235;
			num2.Top = 45;
			
			//label numero 3
			num3.Parent = this;
			num3.Text = ("Resultado");
			num3.AutoSize = true;
			num3.Left = 150;
			num3.Top = 105;
		
		}
		//somar pega o valor que está dentro
		void somaClick(object sender, EventArgs e) {
		txt3.Text = (int.Parse(txt1.Text) + int.Parse(txt2.Text)).ToString();
		}
		
		//subtrair variaveis: A,B,S
		void subtrairClick(object sender, EventArgs e){
			a = int.Parse(txt1.Text);
			b = int.Parse(txt2.Text);
			s = a - b;
			txt3.Text = s.ToString();
		}
		
		//multiplicar variaveis: C,D,M
		void multiplicarClick(object sender, EventArgs e){
			c = int.Parse(txt1.Text);
			d = int.Parse(txt2.Text);
			m = c * d;
			txt3.Text = m.ToString();
		}
		
		//divisão variaveis: H,I,R
		void dividirClick(object sender, EventArgs e){
			float h = float.Parse(txt1.Text);
			float i = float.Parse(txt2.Text);
			float r = h/i;
			txt3.Text = r.ToString();
		}
		
		void textbox1(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //Verifica se a tecla pressionada não é um número e não é a tecla backspace
			{
				e.Handled = true; //// Cancela o evento, ou seja, impede a entrada de qualquer caractere que não seja numérico
			}
		}
		
		void textbox2(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //Verifica se a tecla pressionada não é um número e não é a tecla backspace
			{
				e.Handled = true; //// Cancela o evento, ou seja, impede a entrada de qualquer caractere que não seja numérico
			}
		}
		
		void textbox3(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //Verifica se a tecla pressionada não é um número e não é a tecla backspace
			{
				e.Handled = true; //// Cancela o evento, ou seja, impede a entrada de qualquer caractere que não seja numérico
			}
		}
	}
}
