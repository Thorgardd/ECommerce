import React from "react";
import {Link} from "react-router-dom";
import mouse from "../../assets/images/sourisFilaireFraise.jpeg"
import mouseWireless from "../../assets/images/fraiseSansFil.jpg"
import ordi from "../../assets/images/ordi1.jpg"
import {ImageContainer, ImageStyled} from "../../assets/styled/ImageStyled";
import {
    CardContainer,
    ComputerCard,
    DeviceCard,
    Product,
    SaleContainer,
    SpecsContainer
} from "../../assets/styled/DivStyled";
import {
    DetailsProduct,
    ProductTitle,
    SalePrice,
    SaleRate,
    StrikedPrice
} from "../../assets/styled/ParagraphStyled";
import {ImageSwitch, SaleRateCalc, TitleSwitch} from "../../shared/utils";

const Card = ({ product }) => {

    const CardSelector = (prod) => {
        if (prod.hasOwnProperty("isWireless"))
        {
            return(
                <DeviceCard>
                    <ImageContainer>
                        <ImageStyled src={ImageSwitch(prod.isWireless, mouseWireless, mouse)} alt="souris"/>
                    </ImageContainer>
                    <Product>
                        <ProductTitle isBold={false}>Accessoire : {TitleSwitch(prod.isWireless)}</ProductTitle>
                        <DetailsProduct>Marque : {prod.brand.name}</DetailsProduct>
                        {/*TODO - IF ISONSALE*/}
                        <SaleContainer>
                            <StrikedPrice>{product.price}€</StrikedPrice>
                            <SalePrice>{SaleRateCalc(prod.price, 0.7)}€</SalePrice>
                            <SaleRate>- 30%</SaleRate>
                        </SaleContainer>
                    </Product>
                </DeviceCard>
            )
        }
        else {
            return(
                <ComputerCard>
                    <ImageContainer>
                        <ImageStyled src={ordi} alt="ordinateur"/>
                    </ImageContainer>
                    <Product>
                        <ProductTitle>Ordinateur {prod.category?.name} {prod.brand.name} {prod.screen.size}"</ProductTitle>
                        <SpecsContainer>
                            <DetailsProduct>{prod.cpu.model}</DetailsProduct>
                            <DetailsProduct>{prod.os.name} {prod.os.version}</DetailsProduct>
                            <SaleContainer>
                                <StrikedPrice>{prod.price}€</StrikedPrice>
                                <SalePrice>{SaleRateCalc(prod.price, 0.8)}€</SalePrice>
                                <SaleRate>- 20%</SaleRate>
                            </SaleContainer>
                        </SpecsContainer>
                    </Product>
                </ComputerCard>
            )
        }
    }

    return(
        <Link to={`/details/${product.reference}`} key={product.reference}>
            <button>
                <CardContainer>
                    {CardSelector(product)}
                </CardContainer>
            </button>
        </Link>
    )
}

Card.defaultProps = {
    product: {},
    onClick : () => {}
}

export default Card