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
    
    public partial class Character_Table
    {
        public Character_Table()
        {
            this.Player_Information = new HashSet<Player_Information>();
        }
    
        public int CharacterIdNum { get; set; }
        public string CharacterName { get; set; }
        public string Race { get; set; }
        public int SPtotal { get; set; }
        public int Age { get; set; }
        public int Deaths { get; set; }
        public int WeaponDots { get; set; }
        public int StealthDots { get; set; }
        public int MagicDots { get; set; }
        public int FaithDots { get; set; }
        public int GeneralDots { get; set; }
    
        public virtual SkillsPurchased_Faith_Table SkillsPurchased_Faith_Table { get; set; }
        public virtual SkillsPurchased_General_Table SkillsPurchased_General_Table { get; set; }
        public virtual SkillsPurchased_Magic_Table SkillsPurchased_Magic_Table { get; set; }
        public virtual SkillsPurchased_Stealth_Table SkillsPurchased_Stealth_Table { get; set; }
        public virtual SkillsPurchased_Weapon_Table SkillsPurchased_Weapon_Table { get; set; }
        public virtual ICollection<Player_Information> Player_Information { get; set; }
        public virtual PresteigeClass_RaceList_Table PresteigeClass_RaceList_Table { get; set; }
    }
}
