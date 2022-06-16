using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace exam411031246.Models
{
    [MetadataType(typeof(NewsMetadata))]

    public partial class News
    {


    }

    public class NewsMetada
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "姓名")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "欄位標題必須是最大長度為50的字串。")]



        public string Title { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "內容")]
        public string Content { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "發佈日期")]
        public Nullable<System.DateTime> PublishDate { get; set; }
      
    }
}

