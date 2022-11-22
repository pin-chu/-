using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStore.Models.ViewModels
{
    public class BookCategoryIndexVM
    {
        //public int Id { get; set; }
        [DisplayName("類別名稱")]
        public string CategoryName { get; set; }
        //public string FictionName { get; set; }
        [DisplayName("類別id")]
        public int CategoryId { get; set; }
    }
    public class BookCategoryVM
    {
        [DisplayName("類別id")]
        public string CategoryId { get; set; }
        [DisplayName("類別名稱")]
        public string CategoryName { get; set; }
    }
    //public class FictionCategoryVM
    //{
    //    public int Id { get; set; }
    //    public string FictionName { get; set; }
    //    public int DisplayOrder { get; set; }
    //    public int FictionId { get; set; }
    //}

}
