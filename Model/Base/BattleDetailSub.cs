using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    // 전투디테일 서브
    [Table("BattleDetailSub")]
    public class BattleDetailSub
    {
        // 순번 
        [Key, Column("Seq", Order = 0), Required(ErrorMessage = "Seq is required")]
        public string Seq { get; set; }

        // 전투디테일순번 
        [ForeignKey("BattleDetail"), Key, Column("BattleDetailSeq", Order = 1), Required(ErrorMessage = "BattleDetailSeq is required")]
        public int BattleDetailSeq { get; set; }

        // 전투코드 
        [ForeignKey("BattleDetail"), Key, Column("BattleCode", Order = 2), Required(ErrorMessage = "BattleCode is required")]
        public string BattleCode { get; set; }

        // 유닛코드
        [ForeignKey("Unit"), Column("UnitCode"), Required(ErrorMessage = "UnitCode is required")]
        public string UnitCode { get; set; }

        //남은HP
        [Column("RemainHP"), Required(ErrorMessage = "RemainHP is required")]
        public int RemainHP { get; set; }


        //FK 부모객체 참조
        public virtual BattleDetail BattleDetail { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
