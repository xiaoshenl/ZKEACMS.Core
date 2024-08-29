/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Collections;

namespace Easy.Mvc.Controllers
{
    public class TableData
    {
        public TableData(IEnumerable data, int recordsTotal, int draw)
        {
            Draw = draw;
            RecordsTotal = recordsTotal;
            RecordsFiltered = recordsTotal;
            Data = data;
        }
        public int Draw { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
        public IEnumerable Data { get; set; }
    }
}
