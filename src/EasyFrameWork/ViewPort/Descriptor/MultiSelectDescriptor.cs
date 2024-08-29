/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;

namespace Easy.ViewPort.Descriptor
{
    public class MultiSelectDescriptor : SelectDescriptor<MultiSelectDescriptor>
    {
        public MultiSelectDescriptor(Type modelType, string property)
            : base(modelType, property)
        {
        }

        public override HTMLEnumerate.HTMLTagTypes GetTagType()
        {
            return HTMLEnumerate.HTMLTagTypes.MultiSelect;
        }
    }
}
