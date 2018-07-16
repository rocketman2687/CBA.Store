using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using CBA.Store.Data.Enum;
using CBA.Store.Data.Interface;
using CBA.Store.Domain;
using CBA.Store.Api.Models;

namespace CBA.Store.Api.Controllers
{
    public class ProductController : ApiController
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public ProductApiModel[] Get()
        {
            var products = _productRepository.GetAll();
            return _mapper.Map<List<ProductApiModel>>(products).ToArray();
        }

        public ProductApiModel Get(long id)
        {
            var product = _productRepository.Get(id);
            return _mapper.Map<ProductApiModel>(product);
        }
    }
}