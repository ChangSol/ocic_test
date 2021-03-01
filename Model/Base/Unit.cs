using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    // 유닛기준정보 
    [Table("Unit")]
    public class Unit
    {
        // 유닛코드 
        [Key, Column("UnitCode"), Required(ErrorMessage = "UnitCode is required")]
        public string UnitCode { get; set; }

        // 종족코드 
        [ForeignKey("Tribe"), Column("TribeCode"), Required(ErrorMessage = "TribeCode is required")]
        public int TribeCode { get; set; }

        // 유닛명 
        [Column("UnitName"), Required(ErrorMessage = "UnitName is required")]
        public string UnitName { get; set; }

        // 체력 
        [Column("HP"), Required(ErrorMessage = "HP is required")]
        public int HP { get; set; }

        // 비용 
        [Column("Cost"), Required(ErrorMessage = "Cost is required")]
        public int Cost { get; set; }

        // 공격속도 
        [Column("AttackSpeed"), Required(ErrorMessage = "AttackSpeed is required")]
        public int AttackSpeed { get; set; }

        // 공격력 
        [Column("Power"), Required(ErrorMessage = "Power is required")]
        public int Power { get; set; }

        // 이동속도 
        [Column("MoveSpeed"), Required(ErrorMessage = "MoveSpeed is required")]
        public int MoveSpeed { get; set; }

        // 사이즈 
        [Column("UnitSize")]
        public double? UnitSize { get; set; }

        // 공격범위코드 
        [ForeignKey("AttackRange"), Column("AttackRangeCode"), Required(ErrorMessage = "AttackRangeCode is required")]
        public int AttackRangeCode { get; set; }

        // 공중여부 
        [Column("FlyFlag"), Required(ErrorMessage = "FlyFlag is required")]
        public bool FlyFlag { get; set; }

        //FK 부모객체 참조
        public virtual Tribe Tribe { get; set; }

        public virtual AttackRange AttackRange { get; set; }

        //자식 컬렉션
        public virtual ICollection<BattleDetailSub> BattleDetailSub { get; set; }
    }
}
