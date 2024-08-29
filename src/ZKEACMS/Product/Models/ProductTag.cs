/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using System.ComponentModel.DataAnnotations;

namespace ZKEACMS.Product.Models
{
    [DataTable("ProductTag")]
    public class ProductTag
    {
        [Key]
        public int ID { get; set; }
        public int ProductId { get; set; }
        public int TagId { get; set; }
        public string Title { get; set; }
    }
}
