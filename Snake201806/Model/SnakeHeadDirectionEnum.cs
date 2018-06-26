namespace Snake201806.Model
{
	/// <summary>
	/// Az ir'nyított kígyót leíó osztály
	/// </summary>
	enum SnakeHeadDirectionEnum
	{
		///felsoroljuk a lehetséges űllapotait
		Up,
		Down,
		Left,
		Right,
		
		/// <summary>
		/// A játék kezdetének definiálása, amikor a kígyó még egyhelyben áll
		/// </summary>
		InPlace
	}

}