import React from 'react';
import styled from 'styled-components';
import ordi from "./../../assets/images/ordi1.jpg";
import mouseFil from "../../assets/images/sourisFilaireFraise.jpeg";
import mouseWireless from "../../assets/images/fraiseSansFil.jpg";
import { Col } from 'antd';
import {ImageSwitch, TitleSwitch} from "../../shared/utils";
import {SubTitle} from "../../assets/styled/ParagraphStyled";

const ProdLineCart = ({ cart }) => {

    const ComputerLineRender = (product) => {
        return(
            <>
                <Image src={ordi}/>
                <StyledCol>
                    <Infos>
                        <Title>Ordinateur {product.computer.category.name} - {product.computer.brand.name}</Title>
                        <SubTitle>Référence : {product.computer.reference}</SubTitle>
                        <SubTitle>{product.computer.price}€</SubTitle>
                    </Infos>
                </StyledCol>
            </>
        )
    }

    const DeviceLineRender = (product) => {
        return(
            <>
                <Image src={ImageSwitch(product.isWireless, mouseWireless, mouseFil)}/>
                <StyledCol>
                    <Infos>
                        <Title>{TitleSwitch(product.mouse.isWireless)} - {product.mouse.brand.name}</Title>
                        <SubTitle>Référence : {product.mouse.reference}</SubTitle>
                        <SubTitle>{product.mouse.price}€</SubTitle>
                    </Infos>
                </StyledCol>
            </>
        )
    }

    return (
        <>
            {cart.map((product, index) => {
                return(
                    <Container>
                        {product.mouse ? DeviceLineRender(product) : ComputerLineRender(product)}
                    </Container>
                )
            })}
        </>
    );
}

export default ProdLineCart;

const Container = styled.div`
  width: 100%;
  height: 129px;
  display: flex;
  justify-content: space-evenly;
  align-items: center;
  border: 1px solid #E0E0E0;
  border-radius: 3px;
  padding: 0px 20px;
`;

const Image = styled.img`
  height: 70%;
  object-fit: cover;
`;

const StyledCol = styled(Col)`
  width: 40%;
`;

const Infos = styled.div`
  width: 100%;
`;

const Title = styled.h3`
  font-family: 'Open Sans', sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 16px;
  line-height: 16px;
  color: #000000;
`;