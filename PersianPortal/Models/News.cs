﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PersianPortal.Models
{
    public class News
    {
        [Key]
        public int id { get; set; }

        [MaxLength(300, ErrorMessage = "حداکثر طول مجاز برای تگ 300 کاراکتر است."), Display(Name = "تگ ها")]
        public string Tags { get; set; }

        [MaxLength(200)]
        public IEnumerable<string> Attachments { get; set; }

        [Required]
        [Display(Name = "تاریخ انتشار")]
        public DateTime PublishDate { get; set; }

        [Required]
        [Display(Name = "گروه خبر")]
        public NewsType Type { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual ApplicationUser Author { get; set; }
    }

    public class NewsType
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Display(Name = "گروه")]
        public string Type { get; set; }
    }
}