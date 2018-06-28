using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake201806.Model
{
	/// <summary>
	/// 
	/// 
	/// Ebben az osztálydefinícióban írjuk le, hogy ha ebből az osztályhból 
	/// készítönk egy új példányt (new kulcsszóval) akkor ez az osztálypéldány 
	/// (azaz objektum) milyen tuljdonságokkal rendelkezik és hogyan viselkedjen. 
	/// 
	/// a property hasonlít egy síma változóhoz, de ennél többet tud, mert 
	/// van neve és típusa, és tartozik hozzá egy Getter (olvasás) és egy szetter (írás)
	/// tulajdonság, amiknek különböző a láthatósága, tehát a program egyes részeiből mondjuk 
	/// csak olvasható, aa másikból csak írható, vagy mindkettő együtt. (ez az default viselkedés)
	/// </summary>
	class ArenaPosition
	{
		public ArenaPosition(int rowPosition, int columnPosition)
		{
			RowPosition = rowPosition;
			ColumnPosition = columnPosition;
		}

		/// <summary>
		/// A sor pozíc prpoerty
		/// </summary>
		public int RowPosition { get; set; }

		/// <summary>
		/// az oszlop pozíció property
		/// </summary>
		public int ColumnPosition { get; set; }
	}
}
