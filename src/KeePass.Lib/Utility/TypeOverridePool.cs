/*
  KeePass Password Safe - The Open-Source Password Manager
  Copyright (C) 2003-2022 Dominik Reichl <dominik.reichl@t-online.de>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using System.Text;

using KeePass.Lib.Delegates;

namespace KeePass.Lib.Utility
{
    public static class TypeOverridePool
    {
        private static Dictionary<Type, GFunc<object>> g_d = new();

        public static void Register(Type t, GFunc<object> f)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            if (f == null)
            {
                throw new ArgumentNullException(nameof(f));
            }

            g_d[t] = f;
        }

        public static void Unregister(Type t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            g_d.Remove(t);
        }

        public static bool IsRegistered(Type t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }

            return g_d.ContainsKey(t);
        }

        public static T CreateInstance<T>()
            where T : new()
        {
            if (g_d.TryGetValue(typeof(T), out GFunc<object> f))
            {
                return (T)f();
            }

            return new T();
        }
    }
}
