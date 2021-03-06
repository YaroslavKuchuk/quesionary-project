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
    
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            this.MultichoiceAnswers = new HashSet<MultichoiceAnswer>();
            this.TextAnswers = new HashSet<TextAnswer>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string Text { get; set; }
        public Nullable<int> ThemeId { get; set; }
        public Nullable<int> QuestionTypeId { get; set; }
        public Nullable<int> TestId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Module Module { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MultichoiceAnswer> MultichoiceAnswers { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual Test Test { get; set; }
        public virtual Theme Theme { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TextAnswer> TextAnswers { get; set; }
    }
}
