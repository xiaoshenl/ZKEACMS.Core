/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;

namespace Easy.DataTransfer
{
    public interface IValueTypeConvert
    {
        Type SupportType { get; }
        object Convert(string value);
    }
}
