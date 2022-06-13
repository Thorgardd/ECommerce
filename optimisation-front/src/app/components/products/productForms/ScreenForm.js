import React, {useEffect, useState} from "react";
import Inputs from "../../components/Inputs";
import axios from "axios";
import {URL_BRAND_GET, URL_PROD_SCREEN} from "../../../shared/constants/urls/urlBackEnd";

const ScreenForm = ({ onChange }) => {

    const [brandList, setBrandList] = useState([]);
    const [brand, setBrand] = useState();
    const [screenReso, setScreenReso] = useState();
    const [size, setSize] = useState();
    const [ref, setRef] = useState()

    useEffect(() => {
        axios.get(URL_BRAND_GET)
            .then(res => setBrandList(res.data))
    }, []);

    const SendData = (e) => {
        e.preventDefault();
        let state = {
            "brand" : {"name" : brand},
            "quality" : screenReso,
            "size" : size,
            "reference" : ref
        }
        axios.post(URL_PROD_SCREEN, state)
            .then(res => console.log(res))
            .catch(err => console.log(err.response.data))
    }

    const DeleteData = (e) => {
        e.preventDefault()
        axios.delete(URL_PROD_SCREEN + "/" + ref)
            .then(res => console.log(res.data))
            .catch(err => console.log(err.response.data))
    }

    return(
        <div className="container w-full flex-col">
                <select className="form-select form-select-sm
                                   appearance-none
                                   block
                                   w-full
                                   px-2
                                   py-1
                                   text-sm
                                   font-normal
                                   text-gray-700
                                   bg-white bg-clip-padding bg-no-repeat
                                   border border-solid border-gray-300
                                   rounded
                                   transition
                                   ease-in-out
                                   m-0
                                   focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none"
                        aria-label=".form-select-sm example"
                        name="brandSelect"
                        onChange={(e) => {
                            setBrand(e?.target.value)
                            onChange(e);
                        }}>
                    <option value="">Choisissez votre marque</option>
                    {brandList.map((brand, index) => (
                        <option value={brand.value} key={index}>{brand.name}</option>
                    ))}
                </select>
            <br/>
            <Inputs labelText="Référence"
                    placeholder="HADA-1-X0"
                    name="reference"
                    id="reference"
                    onChange={(e) => setRef(e?.target.value)}
                    type="text"
                />
                <br/>
                <Inputs
                    labelText="Résolution"
                    placeholder="HD / 4K"
                    name="screenReso"
                    id="screenReso"
                    onChange={(e) => setScreenReso(e?.target.value)}
                    type="text"
                />
                <br/>
                <Inputs
                    labelText="Taille"
                    placeholder="26'"
                    name="size"
                    id="size"
                    onChange={(e) => setSize(e?.target.value)}
                    type="text"
                />
                <br/>
            <div className="flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData()}>Ajouter produit</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => DeleteData()}>Supprimer produit</button>
            </div>
        </div>
    )
}

export default ScreenForm