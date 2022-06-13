using hightqual_it_backend.Interfaces;
using hightqual_it_backend.Models;
using hightqual_it_backend.Models.Logistic;
using hightqual_it_backend.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace hightqual_it_backend.Repositories.Logistic
{
    public class CartRepository : BaseRepository, IRepository<Cart>
    {
        string ShoppingCartId { get; set; }
        public const string CartSessionKey = "Reference";
        public HttpContext HttpContext { get; set; }
        //Random random = new Random();

        public CartRepository(DataContext dataContext) : base(dataContext)
        {
            // TODO
            // NEED TO CATCH SESSION COOKIE IN ORDER TO KEEP THE SAME CART AS LONG AS USER STAY ON THE WEBSITE

            //string i = (random.Next(0, 9999999) + (random.Next(0, 9999999))).ToString();

            string i = "2862339";
            ShoppingCartId = i;

        }
        public bool Delete(Cart element)
        {
            throw new NotImplementedException();
        }

        public Cart FindById(int id)
        {
            return _dataContext.Carts.Find(id);
        }

        public IEnumerable<Cart> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save(Cart element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> Search(Expression<Func<Cart, bool>> predicate)
        {
            return _dataContext.Carts.Where(predicate).Include(c => c.Item).ThenInclude(i => i.Brand).Include(c => c.Item)
                .Include(c => c.Item).ThenInclude(i => i.Os).Include(c => c.Item).ThenInclude(i => i.Cpu).Include(c => c.Item).ThenInclude(i => i.Screen)
                .Include(c => c.Item).ThenInclude(i => i.Category).Include(c => c.Item).ThenInclude(i => i.HardDisks).Include(c => c.Item).ThenInclude(i => i.GraphProds)
                .Include(c => c.Item).ThenInclude(i => i.Memories);
        }

        public Cart SearchOne(Expression<Func<Cart, bool>> searchMethod)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cart element)
        {
            throw new NotImplementedException();
        }

        public void AddToCart(Computer computer)
        {
            var cartItem = _dataContext.Carts.SingleOrDefault(
                c => c.Reference == ShoppingCartId && c.ProductRef == computer.Reference);
            if (cartItem == null)
            {
                Computer computerClone = _dataContext.Computers.SingleOrDefault(c => c.Id == computer.Id);
                cartItem = new Cart
                {
                    ProductRef = computer.Reference,
                    Reference = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now,
                    Item = computerClone
                };
                _dataContext.Carts.Add(cartItem);
            }
            else
            {
                cartItem.Count++;
            }
            _dataContext.SaveChanges();
        }

        public void RemoveFromCart(string reference)
        {
            var cartItem = _dataContext.Carts.SingleOrDefault(
                cart => cart.Reference == ShoppingCartId
                && cart.ProductRef == reference);

            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else
                {
                    _dataContext.Carts.Remove(cartItem);
                }
                _dataContext.SaveChanges();
            }
        }

        public void EmptyCart()
        {
            var cartItems = _dataContext.Carts.Where(
                cart => cart.Reference == ShoppingCartId);

            foreach (var cartItem in cartItems)
            {
                _dataContext.Carts.Remove(cartItem);
            }
            _dataContext.SaveChanges();
        }

        public List<Cart> GetCartItems()
        {
            return _dataContext.Carts.Where(cart => cart.Reference == ShoppingCartId).ToList();
        }

        public int GetCount()
        {
            int? count = (from cartItems in _dataContext.Carts where cartItems.Reference == ShoppingCartId 
                          select (int?)cartItems.Count).Sum();
            return count ?? 0;
        }

        public decimal GetTotal()
        {
            decimal? total = (from cartItems in _dataContext.Carts where cartItems.Reference == ShoppingCartId
                             select (int?)cartItems.Count * cartItems.Item.Price).Sum();
            return total ?? decimal.Zero;
        }

        public string CreateOrder(Order order)
        {
            decimal orderTotal = 0;
            var cartItems = GetCartItems();
            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    ProductRef = item.ProductRef,
                    OrderRef = order.OrderRef,
                    UnitPrice = item.Item.Price,
                    Quantity = item.Count
                };
                orderTotal += (item.Count * item.Item.Price);
                _dataContext.OrderDetails.Add(orderDetail);
            }
            order.Total = orderTotal;
            _dataContext.SaveChanges();
            EmptyCart();
            return order.OrderRef;
        }

        public Cart FindByRef(string reference)
        {
            throw new NotImplementedException();
        }

        public Cart FindByBestDeal(int nbVente)
        {
            throw new NotImplementedException();
        }

        public Cart AvgByRef(string reference)
        {
            throw new NotImplementedException();
        }
    }
}
