﻿//   **************************************************************************
//   *                                                                        *
//   *  This program is free software: you can redistribute it and/or modify  *
//   *  it under the terms of the GNU General Public License as published by  *
//   *  the Free Software Foundation, either version 3 of the License, or     *
//   *  (at your option) any later version.                                   *
//   *                                                                        *
//   *  This program is distributed in the hope that it will be useful,       *
//   *  but WITHOUT ANY WARRANTY; without even the implied warranty of        *
//   *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
//   *  GNU General Public License for more details.                          *
//   *                                                                        *
//   *  You should have received a copy of the GNU General Public License     *
//   *  along with this program.  If not, see <http://www.gnu.org/licenses/>. *
//   *                                                                        *
//   **************************************************************************

using System;
namespace U413.Domain.Enums
{
    /// <summary>
    /// Represents the available display options for some text.
    /// </summary>
    [Flags]
    public enum DisplayMode
    {
        None =      0,
        Dim =       1 << 0,
        Inverted =  1 << 1,
        Parse =     1 << 2,
        Italics =   1 << 3,
        Bold =      1 << 4,
        DontType =  1 << 5,
        Mute =      1 << 6,
        DontWrap =  1 << 7
    }
}
