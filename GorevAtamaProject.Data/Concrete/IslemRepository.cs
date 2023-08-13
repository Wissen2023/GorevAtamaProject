using GorevAtamaProject.Data.Abstract;
using GorevAtamaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtamaProject.Data.Concrete
{
    public class IslemRepository : GenericRepository<Islem, GorevAtamaProjectContext>, IIslemRepository
    {
        public List<Islem> GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
