import React from 'react';
import { Link } from 'react-router-dom';
import {URL_ADD_PRODUCT} from "../../../shared/constants/urls/urlConstants";

const Navbar = () => {
    return (
        <ul>
            <li className="promo-li md:hidden mx-auto lg:mx-20 px-8">
                <Link to="/">Meilleurs plans</Link>
            </li>
            <li>
                <Link to="/">Pc &amp; sur mesure</Link>
            </li>
            <li>
                <Link to="/catalog">PC portable</Link>
            </li>
            <li>
                <Link to="/gaming">Gaming</Link>
            </li>
            <li>
                <Link to="/device">Accessoires</Link>
            </li>
            <li className="promo-li hidden md:block">
                <Link to="/">Meilleurs plans</Link>
            </li>
            <li>
               <Link to={URL_ADD_PRODUCT}>Ajouter / Supprimer un produit</Link>
            </li>
        </ul>
    );
};

export default Navbar;
