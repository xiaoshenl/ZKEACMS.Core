﻿/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using IdGen;
using System.Collections.Generic;

namespace Easy
{
    public class IDGenerator
    {
        private static IdGenerator idGenerator = new IdGenerator(0);
        public long CreateId()
        {
            return idGenerator.CreateId();
        }
        public string CreateStringId()
        {
            long id = CreateId();
            return ToShorter(id);
        }

        private string ToShorter(long num)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyz";

            LinkedList<char> newNumber = new LinkedList<char>();
            while (num >= chars.Length)
            {
                int r = (int)(num % chars.Length);
                newNumber.AddFirst(chars[r]);
                num = num / chars.Length;
            }
            newNumber.AddFirst(chars[(int)num]);
            return string.Join("", newNumber);
        }
    }
}
