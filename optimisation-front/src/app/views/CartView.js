import {useEffect, useState} from "react";
import ProdLineCart from "../components/components/ProdLineCart";
import { Row } from 'antd';
import {TitleCart, TotalPrice} from "../assets/styled/TitlesStyled";
import {SubTitle} from "../assets/styled/ParagraphStyled";
import {Input} from "../assets/styled/InputsStyled";
import {StyledButton,
        StyledCol,
        StyledSubButton
} from "../assets/styled/HeritageStyled";
import {
    MainContainer,
    CartContainer, InputSaleContainer
} from "../assets/styled/DivStyled";
import {useHistory} from "react-router-dom";
import React from 'react';


const CartView = () => {

    const [cart, setCart] = useState([])
    const history = useHistory()

    useEffect(() => {
        let cartLS = JSON.parse(localStorage.getItem("cart"))
        setCart(cartLS)
        console.log(cart.length)
    }, [])

    const SubTotal = () => {
        let subTotal = 0
        /*cart.forEach(p => subTotal += (p.price * 0.8))*/
        /*cart.forEach(p => console.log(p.mouse?.price))*/
        return Math.round((subTotal * 100)) / 100
    }

    const DisplaySelector = (cartArray) => {
        if (cartArray != null){
            return(
                <CartContainer>
                    <TitleCart>Mon panier</TitleCart>
                    <SubTitle>{cart.length} {cart.length >= 2 ? "articles" : "article"} dans le panier</SubTitle>
                    <Row justify="space-between">
                        <StyledCol width="60%">
                            <ProdLineCart cart={cart}/>
                        </StyledCol>
                        <StyledCol width="30%">
                            <SubTitle>Total (ttc) :</SubTitle>
                            <TotalPrice>{SubTotal()} €</TotalPrice>
                            <StyledButton color="#FFE790" htmlType="button" type="primary">Validation</StyledButton>
                            <SubTitle isBold={true}>Promotion :</SubTitle>
                            <InputSaleContainer>
                                <Input placeholder="Saississez le coupon" />
                                <StyledSubButton color="#0C969F" htmlType="button" type="primary">Appliquer</StyledSubButton>
                            </InputSaleContainer>
                        </StyledCol>
                    </Row>
                </CartContainer>
            )
        } else if (cartArray == null) {
            history.push("/")
        }

    }

    return(
        <MainContainer>
            {DisplaySelector(cart)}
        </MainContainer>
    )
}

export default CartView;
