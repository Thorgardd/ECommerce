import React, {useEffect, useState} from "react";
import Inputs from "../../components/Inputs";
import {URL_BRAND_GET, URL_PROD_SOUND} from "../../../shared/constants/urls/urlBackEnd";
import axios from "axios";

const SoundForm = ({ onChange }) => {

    const [brandList, setBrandList] = useState([]);
    const [brand, setBrand] = useState();
    const [power, setPower] = useState();
    const [format, setFormat] = useState();

    useEffect(() => {
        axios.get(URL_BRAND_GET)
            .then(res => setBrandList(res.data))
    }, []);

    const SendData = (e) => {
        e.preventDefault();
        let state = {
            "brand" : {"name" : brand},
            "power" : power,
            "format" : format
        }
        axios.post(URL_PROD_SOUND, state)
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
            <Inputs
                labelText="Puissance"
                placeholder="95 dB"
                name="power"
                id="power"
                onChange={(e) => setPower(e?.target.value)}
                type="text"
            />
            <br/>
            <Inputs
                type="text"
                placeholder="Bluetooth"
                labelText="Format"
                id="format"
                name="format"
                onChange={(e) => setFormat(e?.target.value)}
            />
            <br/>
            <div className="flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData}>Ajouter</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => console.log("TODO - DELETE DATA / SOUND")}>Supprimer</button>
            </div>
        </div>
    )
}

export default SoundForm