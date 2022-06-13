import React, {useEffect, useState} from "react";
import Inputs from "../../components/Inputs";
import axios from "axios";
import {URL_BRAND_GET, URL_PROD_MOUSE} from "../../../shared/constants/urls/urlBackEnd";

const MouseForm = ({ onChange }) => {

    const [brandList, setBrandList] = useState([]);
    const [brand, setBrand] = useState(0)
    const [isWireless, setIsWireless] = useState(false)
    const [ref, setRef] = useState("")
    const [price, setPrice] = useState(0)
    const [stock, setStock] = useState(0)

    useEffect(() => {
        axios.get(URL_BRAND_GET)
            .then(res => setBrandList(res.data))
    }, []);

    const SendData = (e) => {
        e.preventDefault()
        let state = {
            "brand" : {"name" : brand},
            "isWireless" : Boolean(isWireless),
            "reference" : ref,
            "price" : price,
            "stock" : stock
        }
        axios.post(URL_PROD_MOUSE, state)
            .then((res) => console.log(res.data))
            .catch((err) => console.log(err.response.data))
    }

    const DeleteData = (e) => {
        e.preventDefault();
        axios.delete(URL_PROD_MOUSE + "/" + ref)
            .then(res =>  console.log(res.data))
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
            <Inputs
                type="radio"
                name="isWireless"
                onChange={(e) => setIsWireless(e?.target.value)}
                className="w-2/5"
                config={[
                    {text : "Sans Fil", id: "wireless", value: true},
                    {text: "Filaire", id: "wirefull", value: false}
                ]}
            />
            <br/>
            <h6 className="font-light text-[11px]">Pour supprimer, renseignez le champ [Référence]</h6>
            <Inputs
                type="text"
                name="reference"
                onChange={(e) => setRef(e?.target.value)}
                labelText="Référence"
                placeholder="DFL-01-SWS"
            />
            <br/>
            <Inputs
                type="text"
                name="price"
                labelText="Prix"
                placeholder="99.99€"
                onChange={(e) => setPrice(e?.target.value)}
            />
            <br/>
            <Inputs
                type="text"
                name="stock"
                labelText="Stock"
                placeholder="80"
                onChange={(e) => setStock(e?.target.value)}
            />
            <br/>
            <div className="flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData()}>Ajouter produit</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => DeleteData()}>Supprimer produit</button>
            </div>
        </div>
    )
}

export default MouseForm