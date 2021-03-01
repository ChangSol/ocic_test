using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    // 전투디테일 
    [Table("BattleDetail")]
    public class BattleDetail
    {
        // 순번 
        [Key, Column("Seq", Order = 0), Required(ErrorMessage = "Seq is required")]
        public int Seq { get; set; }

        // 전투코드 
        [ForeignKey("BattleMaster"), Key, Column("BattleCode", Order = 1), Required(ErrorMessage = "BattleCode is required")]
        public string BattleCode { get; set; }

        // 승패여부 
        [Column("Result"), Required(ErrorMessage = "Result is required")]
        public bool Result { get; set; }

        // 종족코드
        [ForeignKey("Tribe"), Column("TribeCode"), Required(ErrorMessage = "TribeCode is required")]
        public int TribeCode { get; set; }


        //FK 부모객체 참조
        public virtual BattleMaster BattleMaster { get; set; }

        public virtual Tribe Tribe { get; set; }

        //자식 컬렉션
        public virtual ICollection<BattleDetailSub> BattleDetailSub { get; set; }
    }
}
