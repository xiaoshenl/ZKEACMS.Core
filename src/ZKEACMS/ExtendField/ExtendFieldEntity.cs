/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.MetaData;
using Easy.Models;
using Easy.RepositoryPattern;
using System.ComponentModel.DataAnnotations;

namespace ZKEACMS.ExtendField
{
    [DataTable("ExtendField")]
    public class ExtendFieldEntity : EditorEntity
    {
        [Key]
        public int? ID { get; set; }
        public string OwnerModule { get; set; }
        public string OwnerID { get; set; }
        public string Value { get; set; }
    }

    class ExtendFieldEntityMetaData : ViewMetaData<ExtendFieldEntity>
    {


        protected override void ViewConfigure()
        {
            ViewConfig(m => m.ID).AsHidden();
            ViewConfig(m => m.OwnerModule).AsHidden();
            ViewConfig(m => m.OwnerID).AsHidden();
            ViewConfig(m => m.Description).AsTextBox();
        }
    }
}