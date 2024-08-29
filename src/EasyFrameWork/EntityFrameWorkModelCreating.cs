/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Modules.MutiLanguage;
using Easy.Modules.Role;
using Easy.RepositoryPattern;
using Microsoft.EntityFrameworkCore;

namespace Easy
{
    class EntityFrameWorkModelCreating : IOnModelCreating
    {
        public void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().HasKey(m => new { m.PermissionKey, m.RoleId });
            modelBuilder.Entity<LanguageEntity>().HasKey(m => new { m.LanKey, m.CultureName });
        }
    }
}
