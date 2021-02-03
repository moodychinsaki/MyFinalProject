﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{//Dal=DATA access layer -- Java için Dao gibi Data Access Object
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
