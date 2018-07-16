using System;
using System.Collections.Generic;
using System.Linq;
using CBA.Store.Data.Context;
using CBA.Store.Domain;
using CBA.Store.Data.Enum;
using CBA.Store.Data.Interface;

namespace CBA.Store.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(EntityContext context) : base(context)
        {

        }
    }
}
