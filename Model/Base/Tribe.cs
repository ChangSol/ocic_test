using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    //종족 데이터
    public enum TribeCodeEnum
    {
        Terran = 1,
        Zerg = 2,
        Protoss = 3
    }

    // 종족 기준정보
    [Table("Tribe")]
    public class Tribe
    {
        // 종족코드 
        [Key]
        public int TribeCode { get; set; }

        // 종족명 
        public string TribeName { get; set; }

        //자식 컬렉션
        public virtual ICollection<Unit> UnitList { get; set; }
    }
}
