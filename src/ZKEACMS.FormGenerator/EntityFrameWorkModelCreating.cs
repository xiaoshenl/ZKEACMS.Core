/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using Microsoft.EntityFrameworkCore;
using ZKEACMS.FormGenerator.Models;

namespace ZKEACMS.FormGenerator
{
    public class EntityFrameWorkModelCreating : IOnModelCreating
    {
        public void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>();
            modelBuilder.Entity<FormData>();
            modelBuilder.Entity<FormDataItem>();
        }
    }
}
