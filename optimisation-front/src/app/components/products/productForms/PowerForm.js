import React, {useEffect, useState} from "react";
import Inputs from "../../components/Inputs";
import axios from "axios";
import {
    URL_BRAND_GET,
    URL_CATEGORY_GET,
    URL_PROD_POWER
} from "../../../shared/constants/urls/urlBackEnd";

const PowerForm = ({onChange}) => {

    const [brandList, setBrandList] = useState([]);
    const [categories, setCategList] = useState([]);
    const [brand, setBrand] = useState("");
    const [categ, setCateg] = useState({});
    const [alim, setAlim] = useState("");

    useEffect(() => {
        axios.get(URL_BRAND_GET)
            .then((res) => {
               setBrandList(res.data);
            })
        axios.get(URL_CATEGORY_GET)
            .then((res) => {
                setCategList(res.data);
            })
    }, []);

    const SendData = (e) => {
        e.preventDefault();
        let state = {
            "brand" : {"name" : brand},
            "power" : alim,
            "category" : {"name" : categ}
        }
        axios.post(URL_PROD_POWER, state)
            .then((res) => {
                console.log(res);
            })
            .catch((err) => {
                console.log(err.response.data)
            });
    }

    const DeleteData = (e) => {
        e.preventDefault();
        axios.delete(URL_PROD_POWER + "/" + alim)
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
                        setCateg(e?.target.value)
                        onChange(e);
                    }}>
                <option value="">Choisissez votre catégorie</option>
                {categories.map((categ, index) => (
                    <option value={categ.value} key={index}>{categ.model}</option>
                ))}
            </select>
            <br/>
            <h6 className="font-light text-[11px]">Pour supprimer, renseignez le champ [Alimentation]</h6>
            <Inputs
                labelText="Alimentation"
                placeholder="90V"
                name="power"
                id="power"
                type="text"
                onChange={(e) => {setAlim(e?.target.value)}}
            />
            <br/>
            <div className="flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData()}>Ajouter produit</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => DeleteData()}>Supprimer produit</button>
            </div>
        </div>
    )
}

export default PowerForm