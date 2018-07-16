using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AutoMapper.Configuration;
using CBA.Store.Domain;
using CBA.Store.Api.Models;

namespace CBA.Store.Api.Mapping
{
    public class MapperFactory
    {
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductApiModel>();
                cfg.CreateMap<ProductApiModel, Product>();
            });
            return config.CreateMapper();
        }
    }
}