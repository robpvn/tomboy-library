// 
//  NoteCreator.cs
//  
//  Author:
//       Jared Jennings <jaredljennings@gmail.com>
//  
//  Copyright (c) 2012 Jared L Jennings
// 
// This library is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation; either version 2.1 of the
// License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.IO;

namespace Tomboy
{
	/// <summary>
	/// Note creator.
	/// </summary>
	public class NoteCreator
	{
		public NoteCreator ()
		{
		}
		
		public static Note NewNote ()
		{
			return NewNote (null, null);
		}
		
		public static Note NewNote (string title)
		{
			return NewNote (title, null);
		}
		
		public static Note NewNote (string title, string body)
		{
			Note note = new Note ("tomboy://" + Guid.NewGuid ().ToString ());
			
			if (title != null)
				note.Title = title;
			
			if (body != null)
				note.Text = body;
			return note;
		}
	}
}

