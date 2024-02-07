
namespace MeyawoPortfolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblAdminSidebar
    {
        public int AdminSideBarId { get; set; }
        public string SidebarTitle { get; set; }
        public string CoverImageUrl { get; set; }
        public string ProfileImageUrl { get; set; }
    }
}
