// <copyright file="Menu.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BookService.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SysMenu
    {
        /// <summary>
        /// Gets or sets 流水号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets 菜单
        /// </summary>
        [Required]
        [MaxLength(20, ErrorMessage ="超过最大长度（20）。")]
        public string MenuName { get; set; }

        /// <summary>
        /// Gets or sets 上级Id
        /// </summary>
        public int SupId { get; set; }

        /// <summary>
        /// Gets or sets 同级序号
        /// </summary>
        public int SortId { get; set; }

        /// <summary>
        /// Gets or sets 删除标记
        /// </summary>
        public int FlagDel { get; set; }

        /// <summary>
        /// Gets or sets 操作人
        /// </summary>
        public string OperaName { get; set; }

        /// <summary>
        /// Gets or sets 操作时间
        /// </summary>
        public DateTime OperaTime { get; set; }
    }
}