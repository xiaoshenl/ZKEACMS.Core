/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.MetaData;
using Easy.Models;
using Easy.RepositoryPattern;
using System.ComponentModel.DataAnnotations;

namespace Easy.Modules.Role
{
    [DataTable("Roles")]
    public class RoleEntity : EditorEntity
    {
        [Key]
        public int ID { get; set; }
        public void CopyTo(RoleEntity role)
        {
            role.Title = Title;
            role.Description = Description;
        }
    }

    class RoleMetaData : ViewMetaData<RoleEntity>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.ID).AsHidden();
            ViewConfig(m => m.Title).AsTextBox().Required().ShowInGrid();
        }
    }
}
