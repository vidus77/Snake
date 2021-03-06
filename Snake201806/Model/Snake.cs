﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake201806.Model
{
	/// <summary>
	/// Az irányított kígyót reprezentáló osztály
	/// 
	/// Kívülről látszó változókat használunk!
	/// </summary>
	class Snake
	{
		public Snake(int rowPosition, int columnPosition)
		{
			HeadPosition = new ArenaPosition(rowPosition, columnPosition);
			HeadDirection = SnakeHeadDirectionEnum.InPlace;

		}

		//Tudnia kell, hogy hol a feje
		public ArenaPosition HeadPosition { get; set; }

		//tudnia kell, hogy merre megy éppen
		public SnakeHeadDirectionEnum HeadDirection { get; set; }

		//tudnia kell, hogy milyen hosszú

		/// <summary>
		/// a kigyó testének pontjait itt tartjuk nyilván 
		/// </summary>
		public List<ArenaPosition> Tail { get; set; }



	}
}
