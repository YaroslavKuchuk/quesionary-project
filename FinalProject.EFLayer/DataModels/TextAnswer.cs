//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.EFLayer.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class TextAnswer
    {
        public int Id { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public string Textbox { get; set; }
        public Nullable<int> IsCorrect { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string TextBox { get; set; }
    
        public virtual Question Question { get; set; }
    }
}
