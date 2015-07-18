/*
 * Copyright © 2013-2015, Andrew Nagle.
 * All rights reserved.
 * 
 * This file is part of Oracle of Secrets.
 *
 * Oracle of Secrets is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Oracle of Secrets is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with Oracle of Secrets.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using Gtk;

namespace Zyrenth.OracleHack.GtkUI
{
	public static class MessageBox
	{
		public static void Show(Gtk.Window parent_window, DialogFlags flags, MessageType msgtype, ButtonsType btntype, string msg)
		{
			MessageDialog md = new MessageDialog (parent_window, flags, msgtype, btntype, msg);
			md.Run ();
			md.Destroy();
		}
		
		public static void Show(string msg)
		{
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, msg);
			md.Run ();
			md.Destroy();
		}
		
		public static void Show(string msg, string title, ButtonsType buttons, MessageType type)
		{
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, type, buttons, msg);
			md.Title = title;
			md.Run ();
			md.Destroy();
		}
	} 
}

