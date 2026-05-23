/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 25/05/2026
* Autores do Projeto: Ryan Nicolas
*                     Thales Biondi
* Turma: 2H
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* problema_aula.cs
* ************************************************************/
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto_2bim_PVB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
			int n = caixa.LineCount;

			double soma = 0;
			double somaQuadrados = 0;
			double somaDesvio = 0;

			double maior = double.Parse(caixa.GetLineText(0));
			double menor = double.Parse(caixa.GetLineText(0));

			for (int i = 0; i < n; i++)
			{
				double numero = double.Parse(caixa.GetLineText(i));

				soma += numero;
				somaQuadrados += numero * numero;

				if (numero > maior)
					maior = numero;
				
				if (numero < menor)
					menor = numero;
				
			}

			double media = soma / n;

			double variancia = (somaQuadrados - ((soma * soma) / n)) / (n - 1);

			double desvioPadrao = Math.Sqrt(variancia);

			respo1.Content = "Quantidade de elementos: " + n.ToString("0");

			respo2.Content = "Valor Mínimo: " + menor.ToString("0.00");

			respo3.Content = "Valor Máximo: " + maior.ToString("0.00");

			respo4.Content = "Média Aritmética: " + media.ToString("0.00");

			respo5.Content = "Variância Amostral: " + variancia.ToString("0.00");

			respo6.Content = "Desvio Padrão Amostral: " + desvioPadrao.ToString("0.00");

		}
    }
}