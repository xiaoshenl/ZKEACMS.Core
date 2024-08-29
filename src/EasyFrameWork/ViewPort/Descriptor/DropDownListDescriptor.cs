/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;

namespace Easy.ViewPort.Descriptor
{
    public class DropDownListDescriptor : SelectDescriptor<DropDownListDescriptor>
    {
        public DropDownListDescriptor(Type modelType, string property)
            : base(modelType, property)
        {
        }

        public override HTMLEnumerate.HTMLTagTypes GetTagType()
        {
            return HTMLEnumerate.HTMLTagTypes.DropDownList;
        }
    }
}
