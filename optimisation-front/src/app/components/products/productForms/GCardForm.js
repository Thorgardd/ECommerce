import axios from "axios";
import React, {useEffect, useState} from "react";
import Inputs from "../../components/Inputs";
import {URL_BRAND_GET,
        URL_PROD_GCARD,
        URL_PROD_MEMORY
} from "../../../shared/constants/urls/urlBackEnd";


const GCardForm = ({ onChange }) => {

    const [memoryList, setMemoryList] = useState([]);
    const [brandList, setBrandList] = useState([]);
    const [brand, setBrand] = useState("");
    const [memory, setMemory] = useState("");
    const [type, setType] = useState("");

    useEffect(() => {
        axios.get(URL_BRAND_GET)
            .then((res) => setBrandList(res?.data))
            .catch((err) => console.log(err?.response.data))
        axios.get(URL_PROD_MEMORY)
            .then((res) => setMemoryList(res?.data))
            .catch((err) => console.log(err?.response.data))
    }, [])

    const SendData = (e) => {
        e.preventDefault();
        let state = {
            "type" : type,
            "brand" : {"name" : brand},
            "memory" : {"model" : memory}
        }
        axios.post(URL_PROD_GCARD, state)
            .then((res) => console.log(res?.data))
            .catch((err) => console.log(err?.response.data))
    }

    const DeleteData = (e) => {
        e.preventDefault();
        axios.delete(URL_PROD_GCARD + "/"+ type)
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
                        setMemory(e?.target.value)
                        onChange(e);
                    }}>
                <option value="">Choisissez votre mémoire</option>
                {memoryList.map((memory, index) => (
                    <option value={memory.value} key={index}>{memory.model}</option>
                ))}
            </select>
            <br/>
            <h6 className="text-[11px] font-light">Pour supprimer, renseignez le champ [Modèle]</h6>
            <Inputs type="text"
                    className="typeInput"
                    onChange={(e) => setType(e?.target.value)}
                    labelText="Modèle"
                    placeholder="GTX 1070 Ti"
                    name="type"
            />
            <div className="flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData()}>Ajouter produit</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => DeleteData()}>Supprimer produit</button>
            </div>
        </div>
    )
}

export default GCardForm