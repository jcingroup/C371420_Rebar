using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;


namespace ProcCore.Business.DB0
{
    public partial class C36A0_JCIYPEntities : DbContext
    {
        public C36A0_JCIYPEntities(string connectionstring)
            : base(connectionstring)
        {
        }

        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                Log.Write(ex.Message, ex.StackTrace);
                foreach (var err_Items in ex.EntityValidationErrors)
                {
                    foreach (var err_Item in err_Items.ValidationErrors)
                    {
                        Log.Write("欄位驗證錯誤", err_Item.PropertyName, err_Item.ErrorMessage);
                    }
                }

                throw ex;
            }
            catch (DbUpdateException ex)
            {
                Log.Write("DbUpdateException", ex.InnerException.Message);
                throw ex;
            }
            catch (EntityException ex)
            {
                Log.Write("EntityException", ex.Message);
                throw ex;
            }
            catch (UpdateException ex)
            {
                Log.Write("UpdateException", ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                 Log.Write("Exception", ex.Message);
                throw ex;
            }
        }

    }

    #region Model Expand
    public partial class m_Apply : BaseEntityTable
    {
        public IList<m_Apply_Detail> apply_detail { get; set; }
    }
    public partial class Apply_Detail : BaseEntityTable
    {
        public string equipment_sn { get; set; }
    }
    public partial class m_Apply_Detail : BaseEntityTable {
        public string equipment_sn { get; set; }
        
    }
    public partial class m_Equipment : BaseEntityTable
    {
        public string category_name { get; set; }
    }
    public partial class m_Apply_MonthAverage : BaseEntityTable {
        public string equipment_sn { get; set; }
    }
    #endregion

    #region q_Model_Define
    public class q_AspNetRoles : QueryBase
    {
        public string Name { set; get; }

    }
    public class q_AspNetUsers : QueryBase
    {
        public string UserName { set; get; }

    }
    public class q_Equipment : QueryBase
    {
        public string user_id { set; get; }

    }
    public class q_Apply : QueryBase
    {
        public string user_id { set; get; }
        public int Y { get; set; }

    }
    public class q_Apply_Detail : QueryBase
    {
        public string user_id { set; get; }
        public int apply_id { set; get; }

    }
    public class q_Fuel_Apply : QueryBase
    {
        public string user_id { set; get; }
        public int apply_detail_id { set; get; }

    }
    public class q_Apply_User : QueryBase
    {
        public string user_id { set; get; }

    }
    public class q_Month_Average
    {
        public string user_id { get; set; }
        public int Y { get; set; }
        public int equipment_id { get; set; }
        public int query_use_type { get; set; }
    }
    public class q_Year_Average
    {
        public string user_id { get; set; }
        public int equipment_id { get; set; }
        public int query_use_type { get; set; }
    }
    #endregion

    #region c_Model_Define
    public class c_Equipment
    {
        public q_Equipment q { get; set; }

    }

    public class c_Apply {
        public q_Apply q { get; set; }

        public q_Apply_Detail qs { get; set; }
        public Apply_Detail ms { get; set; }
    }
    public class c_Apply_User {
        public q_Apply_User q { get; set; }
    }
    public class c_AspNetRoles
    {
        public q_AspNetRoles q { get; set; }
        public AspNetRoles m { get; set; }
    }
    public partial class c_AspNetUsers
    {
        public q_AspNetUsers q { get; set; }
        public AspNetUsers m { get; set; }
    }

    #endregion
}
