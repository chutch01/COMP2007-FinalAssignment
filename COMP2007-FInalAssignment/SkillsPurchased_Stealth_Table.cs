//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COMP2007_FInalAssignment
{
    using System;
    using System.Collections.Generic;
    
    public partial class SkillsPurchased_Stealth_Table
    {
        public int CharacterIdNum { get; set; }
        public int SkillId { get; set; }
        public int TotalSpentSP { get; set; }
    
        public virtual Character_Table Character_Table { get; set; }
        public virtual SkillChart_Stealth_Table SkillChart_Stealth_Table { get; set; }
    }
}
