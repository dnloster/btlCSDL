using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btlCSDL.DAL;
using btlCSDL.DTO;

namespace btlCSDL.BUS
{
     class BUS_PHIEUKTSK
     {
          DAL_PHIEUKTSK dal;
          public BUS_PHIEUKTSK()
          {
               dal = new DAL_PHIEUKTSK();
          }
          public DataTable getAllPhieuKTSK()
          {
               return dal.getAllPhieuKTSK();
          }
          public bool Add_PHIEUKTSK(DTO_PHIEUKTSK ktsk)
          {
               return dal.Add_PHIEUKTSK(ktsk);
          }
          public bool Update_PHIEUKTSK(DTO_PHIEUKTSK ktsk)
          {
               return dal.Update_PHIEUKTSK(ktsk);
          }
     }
}
