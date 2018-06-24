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

		private MainWindow mainWindow;

		/// <summary>
		/// (Autamtikusan generált) Konstruktorfüggvény, ő hozza létre az osztály egy-egy példányát.
		/// </summary>
		/// <param name="mainWindow">az ablak, ami létrehozta az Arena példányát vagy más nevén objektumát</param>
		public Arena(MainWindow mainWindow)
		{
			this.mainWindow = mainWindow;
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
					Console.WriteLine(e.Key); // cw +Tab + Tab ~Console.WriteLine~ kiírjuk debugban mit ütöttünk le. 
					break;
			}
		}
	}
}
