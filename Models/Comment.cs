//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AquaReminder.Models
{
    using System;
   // using System.Web.Mvc;
    using System.Collections.Generic;
    //using System.ComponentModel.DataAnnotations;
    
    public partial class Comment
    {
        public int Id { get; set; }
       // [Required]
       // [AllowHtml]
        public string text { get; set; }
        public string author { get; set; }
        public int PostId { get; set; }
    
        public virtual Post Post { get; set; }
    }
}
