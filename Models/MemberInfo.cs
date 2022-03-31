//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GNT_server.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class MemberInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MemberInfo()
        {
            //this.MemberFavorite = new HashSet<MemberFavorite>();
            //this.Route = new HashSet<Route>();
            //this.ShopReview = new HashSet<ShopReview>();
            //this.WebsiteReview = new HashSet<WebsiteReview>();
        }
    
        public int MemberID { get; set; }
        [Required(ErrorMessage = "姓名不能為空")]
        public string Name { get; set; }
        [RegularExpression(@"^09[0-9]{8}$", ErrorMessage = "請輸入09開頭電話號碼格式")]
        public string Phone { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "性別不能為空")]
        public string Gender { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        [EmailAddress(ErrorMessage = "請輸入信箱正確格式")]
        [Required(ErrorMessage = "信箱不能為空")]
        public string Email { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public Nullable<bool> BlackList { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "帳號不能為空")]
        public string Account { get; set; }
        [Required(ErrorMessage = "密碼不能為空")]
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<MemberFavorite> MemberFavorite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Route> Route { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<ShopReview> ShopReview { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<WebsiteReview> WebsiteReview { get; set; }
    }
}
