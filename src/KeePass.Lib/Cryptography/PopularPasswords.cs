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
using System.Diagnostics;
using System.Text;

using KeePass.Lib.Utility;

namespace KeePass.Lib.Cryptography
{
    public static class PopularPasswords
    {
        private static Dictionary<int, Dictionary<char[], bool>> m_dicts =
            new();

        internal static int MaxLength
        {
            get
            {
                Debug.Assert(m_dicts.Count > 0); // Should be initialized

                int iMaxLen = 0;
                foreach (int iLen in m_dicts.Keys)
                {
                    if (iLen > iMaxLen)
                    {
                        iMaxLen = iLen;
                    }
                }

                return iMaxLen;
            }
        }

        internal static bool ContainsLength(int nLength)
        {
            return m_dicts.TryGetValue(nLength, out Dictionary<char[], bool> dDummy);
        }

        public static bool IsPopularPassword(char[] vPassword)
        {
            return IsPopularPassword(vPassword, out ulong uDummy);
        }

        public static bool IsPopularPassword(char[] vPassword, out ulong uDictSize)
        {
            if (vPassword == null)
            {
                throw new ArgumentNullException(nameof(vPassword));
            }

            if (vPassword.Length == 0) { uDictSize = 0; return false; }

#if DEBUG
            Array.ForEach(vPassword, ch => Debug.Assert(ch == char.ToLower(ch)));
#endif

            try { return IsPopularPasswordPriv(vPassword, out uDictSize); }
            catch (Exception) { Debug.Assert(false); }

            uDictSize = 0;
            return false;
        }

        private static bool IsPopularPasswordPriv(char[] vPassword, out ulong uDictSize)
        {
            Debug.Assert(m_dicts.Count > 0); // Should be initialized with data

            if (!m_dicts.TryGetValue(vPassword.Length, out Dictionary<char[], bool> d))
            {
                uDictSize = 0;
                return false;
            }

            uDictSize = (ulong)d.Count;
            return d.ContainsKey(vPassword);
        }

        public static void Add(byte[] pbData, bool bGZipped)
        {
            try
            {
                if (bGZipped)
                {
                    pbData = MemUtil.Decompress(pbData);
                }

                string strData = StrUtil.Utf8.GetString(pbData, 0, pbData.Length);
                if (string.IsNullOrEmpty(strData)) { Debug.Assert(false); return; }

                StringBuilder sb = new();
                for (int i = 0; i <= strData.Length; ++i)
                {
                    char ch = (i == strData.Length) ? ' ' : strData[i];

                    if (char.IsWhiteSpace(ch))
                    {
                        int cc = sb.Length;
                        if (cc > 0)
                        {
                            char[] vWord = new char[cc];
                            sb.CopyTo(0, vWord, 0, cc);

                            if (!m_dicts.TryGetValue(cc, out Dictionary<char[], bool> d))
                            {
                                d = new Dictionary<char[], bool>(MemUtil.ArrayHelperExOfChar);
                                m_dicts[cc] = d;
                            }

                            d[vWord] = true;
                            sb.Remove(0, cc);
                        }
                    }
                    else
                    {
                        sb.Append(char.ToLower(ch));
                    }
                }
            }
            catch (Exception) { Debug.Assert(false); }
        }
    }
}
