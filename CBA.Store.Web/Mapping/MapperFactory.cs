using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AutoMapper.Configuration;
using CBA.Store.Api.Models;
using CBA.Store.Web.Models;

namespace CBA.Store.Web.Mapping
{
    public class MapperFactory
    {
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductViewModel, ProductModel>();
                cfg.CreateMap<ProductModel, ProductViewModel>();
            });
            return config.CreateMapper();
        }
    }
}