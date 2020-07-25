using GraphLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GraphDrawing
{
	/// <summary>
	/// Interaction logic for Main.xaml
	/// </summary>
	public partial class Main : Window
	{
		private string[] oprArray = new string[] { "+", "-", "*", "/", "^", "(", ")" };

		public Main()
		{
			InitializeComponent();
			GenerateFuncMenu();
			GenerateOprMenu();
		}

		private void GenerateOprMenu()
		{
			foreach (var opr in oprArray)
			{
				MenuItem item = new MenuItem();
				item.Header = opr;
				menuOprs.Items.Add(item);
			}
		}

		private void GenerateFuncMenu()
		{
			foreach (var func in Enum.GetValues(typeof(EnumFuncs)))
			{
				MenuItem item = new MenuItem();
				item.Header = Enum.GetName(typeof(EnumFuncs), func);
				menuFuncs.Items.Add(item);
			}
		}

		private void menuFuncs_Click(object sender, RoutedEventArgs e)
		{

		}

		private void menuOprs_Click(object sender, RoutedEventArgs e)
		{

		}

		private void MenuIntro_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Chương trình này được viết lại từ chương trình VietGraph 1.2\r\nLa Quốc Thắng", "Thông tin chương trình", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnDeleteExp_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnDeleteAll_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnDraw_Click(object sender, RoutedEventArgs e)
		{

		}

		private void cbxGraphMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

	}
}
