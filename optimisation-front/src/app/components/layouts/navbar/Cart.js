import {useEffect, useState} from "react";
import LineCart from "./LineCart";
import {URL_MANAGE_CART} from "../../../shared/constants/urls/urlConstants";
import {Link} from "react-router-dom";
import {AddToCart} from "../../../helpers/Functions";
import {toast} from "react-toastify";
import React from 'react';

const Cart = () => {

    // States
    const [productsInCart, setProductsInCart] = useState([])

    // Effet composants
    useEffect(() => {
        let cart = JSON.parse(localStorage.getItem("cart"))
        if (cart){
            setProductsInCart(cart)
        }
    }, [])

    const EmptyCart = () => {
        localStorage.removeItem("cart")
        setProductsInCart([])
    }

    const SubTotal = () => {
        let subTotal = 0
        productsInCart.forEach(p => subTotal += (p.price * 0.8))
        return Math.round((subTotal * 100)) / 100
    }

    const NotificationEmptyCart = () => toast.error("Le panier est vide");

    const RemoveFromCart = (product) => {
        let index = productsInCart.indexOf(product);
        localStorage.setItem('cart', JSON.stringify(productsInCart.splice(index, 1)))
        setProductsInCart(prevState => prevState?.slice(index, 1));
    }

    return (
        <div className="border-solid border-2 bg-white">
            {productsInCart.length > 0 ?
                    <div>
                        {/*<div className="absolute top-0 right-0 border-solid border-2 w-8 h-8 items-center text-center hover:bg-primary/[.6]">X</div>*/}
                        {productsInCart.map(p =>
                            <div className="m-4 mt-8" key={p?.reference}>
                                <LineCart
                                    isOnSale={true}
                                    reference={p?.reference}
                                    price={p?.price}
                                    product={p}
                                    AddToCart={AddToCart(p, productsInCart, setProductsInCart(null))}
                                    RemoveFromCart={RemoveFromCart}
                                />
                                <hr/>
                            </div>
                        )}
                        <div className="text-center m-2">
                            <Link to={URL_MANAGE_CART}>Voir mon panier</Link>
                        </div>
                        <div className="text-center m-2">
                            <button onClick={() => EmptyCart()}>Vider mon panier</button>
                        </div>

                        <div className="m-4 p-4 bg-gray-100">
                            Sous-total : {SubTotal()}
                        </div>
                    </div> : NotificationEmptyCart()}
        </div>
    );
}

export default Cart;