using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Snake201806.Model
{
	/// <summary>
	/// A játékmenet logikáját alkalmazza 
	/// 
	/// Osztálydefinició  Az osztály egy leírás
	/// leírja, hogy ha létrehozunk egy példányt, (példányosítjuk), 
	/// akkor minden létrehozott példány hogyan működjön. 
	/// 
	/// Ez olyan, mint egy tervrajz, 
	/// </summary>
	class Arena
	{

		private MainWindow View;
		private Snake snake;

		/// <summary>
		/// (Autamtikusan generált) Konstruktorfüggvény, ő hozza létre az osztály egy-egy példányát.
		/// </summary>
		/// <param name="view"> (néhai name="mainWindow") az ablak, ami létrehozta az Arena példányát vagy más nevén objektumát</param>

		/// Átnevezzük a "mainWinow" változót "view" névre (a kisbetűst)
		/// Átnevezzük a "MainWindow" _osztályon_belüli_változót_ "View" névre
		public Arena(MainWindow view)
		{
			//hivatkozva az osztálypéldányra - amiben vagyunk {...} - így is el érhetjük
			// az osztálypéldány classlevel változóját. 
			this.View = view;   //Automatikus a this.View hivatkozást hozta létre, 
								//hogy megkölönböztesse az osztályon belüli változót
								//egyébként erre nem feltétlenül volt szükség

			// A játék kezdetén megjelenítjük a játékszabályokat
			// mint az a következő sorból is látszik, az osztályon belül a this használata nem kötelező
			View.GamePlayBorder.Visibility = System.Windows.Visibility.Visible;
			View.NumberOfMealsTextBlock.Visibility = System.Windows.Visibility.Hidden;
			View.ArenaGrid.Visibility = System.Windows.Visibility.Visible;

			snake = new Snake(10,10);

			//Kigyofej mejelenitese "Circle" Ikonnal
			//
			//A grid a tartalmazott elemeit egy gyüjteményen keresztül teszi elérhetővé
			//	ez a gyűjtemény egy felsorolás, ahol az első elem a 0. indexű, a 2. elem az 1-es stb.
			//	tehát a tizedik sor tizedik elemét így tudjuk elérni [10 * 20 + 10]
			var cell = View.ArenaGrid.Children[10 * 20 + 10];

			//viszont a gridnek tükmindegy mi van ott, egy általános IUElement típust ad vissza
			//	ez lehet bármi, ami éppen belekerült
			var image = (FontAwesome.WPF.ImageAwesome)cell;
			//és ha már így megtaláltuk a gridben, akkor meg is tudjuk változtatni a tlajdonságát
			// adott esetben módosítjuk az Icont 
			image.Icon = FontAwesome.WPF.FontAwesomeIcon.Circle;
		}

		internal void KeyDown(KeyEventArgs e)
		{
			//	milyen eseményeket kezelünk, nem mindet
			//	csak a nyíl leütéseket,ezért kell nekönk a switch 
			switch (e.Key)
			{
				case Key.Left:
				//	break; //egyelőre nem külön nézzük a leütéseket
				case Key.Up:
				//	break;
				case Key.Right:
				//	break;
				case Key.Down:
					// A játék indulásával eltűntetjük a szabályokat
					View.GamePlayBorder.Visibility = System.Windows.Visibility.Hidden;
					View.NumberOfMealsTextBlock.Visibility = System.Windows.Visibility.Visible;
					View.ArenaGrid.Visibility = System.Windows.Visibility.Visible;

					
					//az Output ablak kontrolja
					Console.WriteLine(e.Key); // cw +Tab + Tab ~Console.WriteLine~ kiírjuk debugban mit ütöttünk le. 

					break;
			}
		}
	}
}
