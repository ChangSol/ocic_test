using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    //추상클래스 
    abstract class BaseService
    {
        public List<Unit> UnitList = new List<Unit>();

        public List<Unit> GetAllUnitList() //사용자의 모든 유닛 가져오기
        {
            try
            {
                return UnitList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "경고");
                return null;
            }
        }

        public List<Unit> GetUnitList(Expression<Func<Unit, bool>> condition) //람다 조건으로 가져오기
        {
            return UnitList.Where(condition.Compile()).ToList();
        }

        public abstract void AddUnit(string p_UnitName); //생성할 유닛이 다르기에 파라미터로 유닛명을 가져갈 것  
    }
}
