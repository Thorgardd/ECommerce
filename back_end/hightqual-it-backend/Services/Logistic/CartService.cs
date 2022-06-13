using AutoMapper;
using hightqual_it_backend.Dtos;
using hightqual_it_backend.Dtos.Logistic;
using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models;

using hightqual_it_backend.Repositories.Logistic;

using System.Collections.Generic;

namespace hightqual_it_backend.Services.Logistic
{
    public class CartService
    {
        private CartRepository _cartRepository;
        private IRepository<Computer> _computerRepository;
        private readonly IMapper _mapper;
        public CartService(CartRepository cartRepository, IRepository<Computer> computerRepository, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _computerRepository = computerRepository;
            _mapper = mapper;
        }
        public List<CartDto> GetByReference(string reference)
        {
            var carts = _cartRepository.Search(c => c.Reference == reference);
            var newCart = _mapper.Map<List<CartDto>>(carts);
            return newCart;
        }
        public ComputerDto AddToCart(string reference)
        {
            var product = _computerRepository.SearchOne(c => c.Reference == reference);
            var newProduct = _mapper.Map<ComputerDto>(product);
            _cartRepository.AddToCart(product);
            return newProduct;
        }

        public string RemoveFromCart(string reference)
        {
            var product = _computerRepository.SearchOne(c => c.Reference == reference);
            var productToRemove = _mapper.Map<Computer>(product);
            _cartRepository.RemoveFromCart(productToRemove.Reference);
            return reference;
        }

        public void EmptyTheCart()
        {
            _cartRepository.EmptyCart();
        }

    }
}
