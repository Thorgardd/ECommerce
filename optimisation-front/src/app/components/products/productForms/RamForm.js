import React, {useEffect, useState} from "react";
import Inputs from "../../components/Inputs";
import axios from "axios";
import {URL_BRAND_GET, URL_PROD_MEMORY} from "../../../shared/constants/urls/urlBackEnd";

const RamForm = ({ onChange }) => {

    const [brandList, setBrandList] = useState([]);
    const [brand, setBrand] = useState();
    const [frequency, setFrequency] = useState();
    const [model, setModel] = useState();
    const [type, setType] = useState();
    const [capacity, setCapacity] = useState();

    useEffect(() => {
        axios.get(URL_BRAND_GET)
            .then(res => setBrandList(res.data))
    }, []);

    const SendData = (e) => {
        e.preventDefault()
        let state = {
            "brand" : {"name" : brand},
            "frequency" : frequency,
            "model" : model,
            "type" : type,
            "capacity" : capacity
        }
        axios.post(URL_PROD_MEMORY, state)
            .then(res => console.log(res.data))
            .catch(err => console.log(err.response.data))
    }

    const DeleteData = (e) => {
        e.preventDefault()
        axios.delete(URL_PROD_MEMORY + "/" + model)
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
            <h6 className="text-[11px] font-light">Pour supprimer, renseignez le champ [Modèle]</h6>
            <Inputs
                type="text"
                labelText="Modèle"
                placeholder="Samsung - SSD 970 EVO Plus 250 Go "
                name="model"
                id="model"
                onChange={(e) => setModel(e?.target.value)}
                className="w-2/5"
            />
            <br/>
            <Inputs
                type="text"
                name="type"
                placeholder="DDR4"
                labelText="Type"
                onChange={(e) => setType(e?.target.value)}
                className="w-2/5"
                id="type"
            />
            <br/>
            <Inputs
                type="text"
                name="frequency"
                placeholder="2400 MHz"
                labelText="Fréquence"
                className="w-2/5"
                id="frequency"
                onChange={(e) => setFrequency(e?.target.value)}
            />
            <br/>
            <Inputs type="text"
                    name="capacity"
                    placeholder="32Gb"
                    labelText="Capacité"
                    className="w-2/5"
                    id="capacity"
                    onChange={(e) => setCapacity(e?.target.value)}
            />
            <br/>
            <div className="flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData()}>Ajouter produit</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => DeleteData()}>Supprimer produit</button>
            </div>
        </div>
    )
}

export default RamForm