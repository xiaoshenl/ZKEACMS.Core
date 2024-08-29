/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using System.ComponentModel.DataAnnotations;

namespace ZKEACMS.Updater.Models
{
    [DataTable("DBVersion")]
    public class DBVersion : Easy.Version
    {
        [Key]
        public int ID { get; set; }
    }
}
