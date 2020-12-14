using System;
using System.Collections.Generic;

#nullable disable

namespace DantunkuraGallery.Server.Models
{
    public partial class UserPermission
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MenuName { get; set; }
    }
}
