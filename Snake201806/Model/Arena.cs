using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

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
		private DispatcherTimer pendulum;
		private bool isStarted;

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

			//VZ feltehetően innen indítjuk az órát 
			pendulum = new DispatcherTimer(TimeSpan.FromMilliseconds(500), DispatcherPriority.
											Normal, ItsTimeForDisplay, Application.Current.Dispatcher);

			isStarted = false;



		}

		private void ItsTimeForDisplay(object sender, EventArgs e)
		{
			if (!isStarted)
			{// ha még nem indult el a játék akor ne csináljon semmit
				return;
			}

			// meg kell jehyezni hol van a kígyó feje, ez lesz a "neck"

			//új példányt hozunk létre, mert nem egyszerűen egy létező helyzetet kell megjelníteni
			var neck = new ArenaPosition(snake.HeadPosition.RowPosition, snake.HeadPosition.ColumnPosition);

			// a kígyó magától mozog, a HeadDirection irányban ez alapján ki kell számolni a következő (fej)pozíciót
			switch (snake.HeadDirection)
			{
				case SnakeHeadDirectionEnum.Up:
					snake.HeadPosition.RowPosition = snake.HeadPosition.RowPosition - 1;
					break;
				case SnakeHeadDirectionEnum.Down:
					snake.HeadPosition.RowPosition = snake.HeadPosition.RowPosition + 1;
					break;
				case SnakeHeadDirectionEnum.Left:
					snake.HeadPosition.ColumnPosition = snake.HeadPosition.ColumnPosition - 1;
					break;
				case SnakeHeadDirectionEnum.Right:
					snake.HeadPosition.ColumnPosition = snake.HeadPosition.ColumnPosition + 1;
					break;
				case SnakeHeadDirectionEnum.InPlace:
					break;
				default:
					break;
			}
			ShowSnakeHead(snake.HeadPosition.RowPosition, snake.HeadPosition.ColumnPosition);

			////a kígyó fejéből nyak lesz 
			
			//cell = View.ArenaGrid.Children[neck.RowPosition * 20 + snake.HeadPosition.ColumnPosition];
			//image = (FontAwesome.WPF.ImageAwesome)cell;
			//image.Icon = FontAwesome.WPF.FontAwesomeIcon.SquareOutline;

		}

		private void ShowSnakeHead(int rowPosition, int columnPosition)
		{
			//Kigyofej mejelenitese "Circle" Ikonnal
			//
			//A grid a tartalmazott elemeit egy gyüjteményen keresztül teszi elérhetővé
			//	ez a gyűjtemény egy felsorolás, ahol az első elem a 0. indexű, a 2. elem az 1-es stb.
			//	tehát a tizedik sor tizedik elemét így tudjuk elérni [10 * 20 + 10]
			var cell = View.ArenaGrid.Children[rowPosition * 20 + columnPosition];

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
					if (!isStarted)
					{ //m;g nem fut, ezert indir=tani kell
						StartNewGame();
					}
					//most már nézni kell a leütések tényleges jelentését
					switch (e.Key)
					{
						case Key.Left:
							snake.HeadDirection = SnakeHeadDirectionEnum.Left;
							break; //egyelőre nem külön nézzük a leütéseket helyesebben már igen
						case Key.Up:
							snake.HeadDirection = SnakeHeadDirectionEnum.Up;
							break;
						case Key.Right:
							snake.HeadDirection = SnakeHeadDirectionEnum.Right;
							break;
						case Key.Down:
							snake.HeadDirection = SnakeHeadDirectionEnum.Down;
							break;
					}


					//az Output ablak kontrolja
					Console.WriteLine(e.Key); // cw +Tab + Tab ~Console.WriteLine~ kiírjuk debugban mit ütöttünk le. 

					break;
			}
		}

		/// <summary>
		/// A játék indításának memtete
		/// </summary>
		private void StartNewGame()
		{
			/// elindítjuk a játékot
			/// 
			//A játék indulásával eltűntetjük a szabályokat
			View.GamePlayBorder.Visibility = System.Windows.Visibility.Hidden;
			View.NumberOfMealsTextBlock.Visibility = System.Windows.Visibility.Visible;
			View.ArenaGrid.Visibility = System.Windows.Visibility.Visible;
			// jelezzük, hogy elindulunk
			isStarted = true;
		}
	}
}
