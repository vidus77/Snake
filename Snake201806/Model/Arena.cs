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
			View.GamePlayTextBlock.Visibility = System.Windows.Visibility.Visible;
			View.NumberOfMealsTextBlock.Visibility = System.Windows.Visibility.Visible;
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
					View.GamePlayTextBlock.Visibility = System.Windows.Visibility.Hidden;

					//az Output ablak kontrolja
					Console.WriteLine(e.Key); // cw +Tab + Tab ~Console.WriteLine~ kiírjuk debugban mit ütöttünk le. 

					break;
			}
		}
	}
}
