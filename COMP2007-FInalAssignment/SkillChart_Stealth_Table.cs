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
    
    public partial class SkillChart_Stealth_Table
    {
        public SkillChart_Stealth_Table()
        {
            this.SkillsPurchased_Stealth_Table = new HashSet<SkillsPurchased_Stealth_Table>();
        }
    
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int SkillCost { get; set; }
        public bool MultiPurchase { get; set; }
    
        public virtual ICollection<SkillsPurchased_Stealth_Table> SkillsPurchased_Stealth_Table { get; set; }
    }
}
