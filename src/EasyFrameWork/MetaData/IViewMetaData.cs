/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.ViewPort.Descriptor;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Easy.MetaData
{
    public interface IViewMetaData
    {
        Dictionary<string, BaseDescriptor> ViewPortDescriptors { get; }
        Dictionary<string, PropertyInfo> Properties { get; }

        Type TargetType { get; }
    }
}
