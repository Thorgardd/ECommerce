import {useParams} from "react-router-dom";
import { useLayoutEffect, useState} from "react";
import axios from "axios";
import {URL_COMPUTER_REF, URL_PROD_MOUSE} from "../shared/constants/urls/urlBackEnd";
import {
    PriceAddBtn,
    ProdDetailMC,
    ProdDetails,
    ProdDetailView,
    ProdInfos,
    ProductDetailsInfos
} from "../assets/styled/DivStyled";
import {ProdTitle} from "../assets/styled/TitlesStyled";
import {ImageSwitch, SaleRateCalc, TitleSwitch} from "../shared/utils";
import mouseFil from "../assets/images/sourisFilaireFraise.jpeg"
import mouseWireless from "../assets/images/fraiseSansFil.jpg";
import {Spin} from "antd";
import {ImageDetailProduct} from "../assets/styled/ImageStyled";
import {BasicBaliseP, SaledPrice, SaleRate, SubTitle} from "../assets/styled/ParagraphStyled";
import {ButtonAddCart} from "../assets/styled/ButtonStyled";
import {FontAwesomeIcon} from "@fortawesome/react-fontawesome";
import {faCheck} from "@fortawesome/free-solid-svg-icons";
import {AddToCart} from "../helpers/Functions";
import ordi from "../assets/images/ordi1.jpg";
import Commentary from "../components/components/Commentary"
import Specifications, {SpecsMC} from "../components/components/Specifications";
import React from 'react';


const DetailView = () => {

    const [product, setProduct] = useState({});
    const [loading, setLoading] = useState(true)
    const { reference } = useParams();

    useLayoutEffect(() => {
        if (reference.startsWith("DEVICE")){
            axios.get(URL_PROD_MOUSE + "/" + reference)
                .then(res => {
                    setProduct(res.data)
                    setLoading(false)
                })
                .catch(err => console.log(err));
        }
        else {
            axios.get(URL_COMPUTER_REF + "/" + reference)
                .then(res => {
                    setProduct(res.data)
                    setLoading(false)
                })
                .catch(err => console.log(err));
        }

    }, [reference])

    const ProductViewSelector = (prod) => {
        console.log("Product : ", prod)
        if (reference.startsWith("DEVICE")){
            return(
                <>
                    <ProdDetailView>
                        <ProdInfos>
                            <ProdTitle>{TitleSwitch(prod.mouse.isWireless)} - {prod.mouse.brand.name}</ProdTitle>
                            <SubTitle> Référence : {reference}</SubTitle>
                            <ImageDetailProduct src={ImageSwitch(prod.mouse.isWireless, mouseWireless, mouseFil)}/>
                        </ProdInfos>
                        <ProdDetails>
                            <PriceAddBtn>
                                <SaleRate>-30%</SaleRate>
                                <SaledPrice>{SaleRateCalc(prod.mouse.price, 0.7)}€</SaledPrice>
                                <ButtonAddCart onClick={() => AddToCart(product)}>Ajouter au panier</ButtonAddCart>
                            </PriceAddBtn>
                            <ProductDetailsInfos>
                                <BasicBaliseP><FontAwesomeIcon icon={faCheck} className="text-green-600"/> {prod.mouse.stock} (pcs) en stock</BasicBaliseP>
                                <BasicBaliseP><FontAwesomeIcon icon={faCheck} className="text-green-600"/> Livraison à votre domicile dès demain </BasicBaliseP>
                                <BasicBaliseP><FontAwesomeIcon icon={faCheck} className="text-green-600"/> Garantie satisfait ou remboursé</BasicBaliseP>
                                <BasicBaliseP><FontAwesomeIcon icon={faCheck} className="text-green-600"/> Produit garanti 2 ans</BasicBaliseP>
                            </ProductDetailsInfos>
                        </ProdDetails>
                    </ProdDetailView>
                </>
            )
        }
        else {
            return(
                <>
                    <ProdDetailView>
                        <ProdInfos>
                            <ProdTitle>Ordinateur {prod.computer.category.name} - {prod.computer.brand.name}</ProdTitle>
                            <SubTitle> Référence : {reference}</SubTitle>
                            <ImageDetailProduct src={ordi}/>
                        </ProdInfos>
                        <ProdDetails>
                            <PriceAddBtn>
                                <SaleRate>-30%</SaleRate>
                                <SaledPrice>{SaleRateCalc(prod.computer.price, 0.7)}€</SaledPrice>
                                <ButtonAddCart onClick={() => AddToCart(product)}>Ajouter au panier</ButtonAddCart>
                            </PriceAddBtn>
                            <ProductDetailsInfos>
                                <BasicBaliseP><FontAwesomeIcon icon={faCheck} className="text-green-600"/> {prod.computer.stock.quantity} (pcs) en stock</BasicBaliseP>
                                <BasicBaliseP><FontAwesomeIcon icon={faCheck} className="text-green-600"/> Livraison à votre domicile dès demain </BasicBaliseP>
                                <BasicBaliseP><FontAwesomeIcon icon={faCheck} className="text-green-600"/> Garantie satisfait ou remboursé</BasicBaliseP>
                                <BasicBaliseP><FontAwesomeIcon icon={faCheck} className="text-green-600"/> Produit garanti 2 ans</BasicBaliseP>
                            </ProductDetailsInfos>
                        </ProdDetails>
                    </ProdDetailView>
                </>
            )
        }
    }

    if (loading) return <Spin/>;

    return(
        <>
            <ProdDetailMC>
                {ProductViewSelector(product)}
            </ProdDetailMC>
            {reference.startsWith("DEVICE") ?
                <>
                </> :
                <SpecsMC>
                    <Specifications product={product}/>
                </SpecsMC>
            }
            <Commentary/>
        </>
    )
}

export default DetailView;