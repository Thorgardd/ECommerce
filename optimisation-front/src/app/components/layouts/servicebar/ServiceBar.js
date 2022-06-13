import React from "react";

import ProductButton from '../icon-button/ProductButton';

import discountIcon from "../../../assets/images/icons/products/discount.svg";
import packageIcon from "../../../assets/images/icons/products/package.svg";
import phoneIcon from "../../../assets/images/icons/products/phone.svg";
import checkIcon from "../../../assets/images/icons/products/check.svg";

const ServiceBar = () => {
    return (
        <div className="bg-white mt-30 md:mt-20">
            <div className="flex justify-evenly mt-50">
            <div className="grid place-items-center">
                <ProductButton linkTo="/" imageSrc={packageIcon} imageAlt="Package Icon" />
                <p className="flex invisible md:visible"><b>Livraison offerte</b></p>
            </div>
            <div className="grid place-items-center">
                <ProductButton linkTo="/" imageSrc={discountIcon} imageAlt="Discount Icon" />
                <p className="flex invisible md:visible"><b>Des promotions régulières</b></p>
            </div>
            <div className="grid place-items-center">
                <ProductButton linkTo="/" imageSrc={phoneIcon} imageAlt="Phone Icon" />
                <p className="flex invisible md:visible"><b>Assistance 7j/7 et 24h/24</b></p>
            </div>
            <div className="grid place-items-center">
                <ProductButton linkTo="/" imageSrc={checkIcon} imageAlt="Check Icon" />
                <p className="flex invisible md:visible"><b>Garantie 2 ans</b></p>
            </div>
        </div>
        </div>
        
    )
}

export default ServiceBar;