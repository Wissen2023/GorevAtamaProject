﻿using GorevAtamaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtamaProject.Data.Abstract
{
    public interface IIslemRepository : IRepository<Islem>
    {
        List<Islem> GetListAll();
    }
}
