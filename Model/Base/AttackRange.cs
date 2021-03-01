using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Base
{
    //공격범위 데이터
    public enum AttackRangeCodeEnum : int
    {
        Ground = 1,//지상공격
        Air = 2, //공중공격
        All = 3, //지상및공중공격
        Cure = 4, //힐        
    }

    // 공격범위 기준정보
    [Table("AttackRange")]
    public class AttackRange
    {
        // 공격범위코드 
        [Key, Column("AttackRangeCode"), Required(ErrorMessage = "AttackRangeCode is required")]
        public int AttackRangeCode { get; set; }

        // 공격범위명 
        [Column("AttackRangeName"), Required(ErrorMessage = "AttackRangeName is required")]
        public string AttackRangeName { get; set; }

        //자식 컬렉션
        public virtual ICollection<Unit> UnitList { get; set; }

    }
}
