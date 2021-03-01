using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    // 전투마스터 
    [Table("BattleMaster")]
    public class BattleMaster
    {
        // 전투코드 
        [Key, Column("BattleCode"), Required(ErrorMessage = "BattleCode is required")]
        public string BattleCode { get; set; }

        // 전투일시 
        [Column("BattleDate"), Required(ErrorMessage = "BattleDate is required")]
        public DateTime BattleDate { get; set; }

        //자식 컬렉션
        public virtual ICollection<BattleDetail> BattleDetail { get; set; }
    }
}
