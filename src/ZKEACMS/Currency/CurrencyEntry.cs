/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.MetaData;
using Easy.Models;
using Easy.RepositoryPattern;
using System.ComponentModel.DataAnnotations;

namespace ZKEACMS.Currency
{
    [DataTable("Currency")]
    public class CurrencyEntry : EditorEntity
    {
        [Key]
        public int ID { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
    }
    class CurrencyEntryMetaData : ViewMetaData<CurrencyEntry>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.ID).AsHidden();
        }
    }
}
