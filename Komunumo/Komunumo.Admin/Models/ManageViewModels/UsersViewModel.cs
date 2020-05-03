using System.Collections.Generic;
using Komunumo.Admin.Entities;

namespace Komunumo.Admin.Models.ManageViewModels
{
    public class UsersViewModel
    {
        /// <summary>
        /// 最大一頁的項目數量
        /// </summary>
        private const int MaxPageSize = 20;

        /// <summary>
        /// 總項目數量
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 目前頁數
        /// </summary>
        public int CurrentPageNumber { get; set; } = 1;

        /// <summary>
        /// 一頁的項目數量
        /// </summary>
        private int _pageSize;

        public int PageSize
        {
            get => _pageSize = 5;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value; // 如果超過 MaxPageSize，取 MaxPageSize，否則取原本的
        }

        public List<ApplicationUser> Users { get; set; }
    }
}