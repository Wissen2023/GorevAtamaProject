using GorevAtamaProject.Data.Abstract;
using GorevAtamaProject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtamaProject.Data.Concrete
{
    public class PersonelRepository : GenericRepository<Personel, GorevAtamaProjectContext>, IPersonelRepository
    {
        public List<Personel> GetListAll()
        {
            using (var context = new GorevAtamaProjectContext())
            {
                return context.Personels.Include(i => i.Islem).ToList();
            }
        }
    }
}
