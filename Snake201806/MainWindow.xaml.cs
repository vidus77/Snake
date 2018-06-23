using Snake201806.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Snake201806
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Arena arena;

		public MainWindow()
		{
			// 1.	Ctrl . az Arena szón felajánlja betöltésre a "using Snake201806.Model;" névteret,
			//		mert alapból a C# nem lát bele az alkönyvtárakba, az Arena.CS osztályunk viszont a "Model" 
			//		mappában van. 

			// 2.	létre kell hozni az arena változót is. (Ctrl . a kisnbetűs arena szón) 
			//		ezután a MainWindow  { } kpcsai között el kezd működni, azaz a főblakban létrehozunk egy példányt.
			InitializeComponent();
			arena = new Arena();

		}

		private void Window_KeyDown(object sender, KeyEventArgs e)
		{
			//	létrehozunk egy függvényt, ami ekapja a billentyűleütéseket
			//	1.	bepötyögtük az arena.KeyDown(e); 
			//	2.	Ctrl . a Keydown szón legenrálja az eseményelkapót
			//	3.	KeyDown fletti F12 - vel ét lehet menni az automatikusan generált függvény definícióhoz az Arena.cs-ben 
			arena.KeyDown(e);
		}
	}
}
