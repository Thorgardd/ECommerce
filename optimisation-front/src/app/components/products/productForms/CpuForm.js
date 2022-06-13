import React, {useEffect, useState} from "react";
import Inputs from "../../components/Inputs";
import axios from "axios";
import {
    URL_BRAND_GET,
    URL_PROD_MEMORY,
    URL_PROD_CPU
} from "../../../shared/constants/urls/urlBackEnd";


const CpuForm = ({ onChange }) => {

    const [memoryList, setMemoryList] = useState([]);
    const [brandList, setBrandList] = useState([]);
    const [brand, setBrand] = useState("");
    const [memory, setMemory] = useState("");
    const [core, setCore] = useState(0);
    const [frequency, setFrequency] = useState(0);
    const [model, setModel] = useState("");

    useEffect(() => {
        axios.get(URL_BRAND_GET)
            .then((res) => {
                setBrandList(res.data)
            }).catch(err => {
                console.log(err.response.data)
        })
        axios.get(URL_PROD_MEMORY)
            .then((res) => {
                setMemoryList(res.data)
            })
            .catch(err => {
                console.log(err.response.data)
            })
    }, [])

    const SendData = (e) => {
        e.preventDefault();
        let state = {
            "brand" : {"name" : brand},
            "cpuMemory" : {"model" : memory},
            "nbCore" : core,
            "frequency" : frequency,
            "model" : model
        }
        axios.post(URL_PROD_CPU, state)
            .then((res) => console.log(res.data))
            .catch(err => console.log(err.response.data))
    }

    const DeleteData = (e) => {
        e.preventDefault();
        axios.delete(URL_PROD_CPU + "/"+ model)
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
            <Inputs labelText="Coeurs" placeholder="8" name="core" id="core" onChange={(e) => setCore(e?.target.value)} type="text"
            />
            <br/>
            <Inputs
                type="text"
                placeholder="2.9 GHz"
                labelText="Fréquence"
                id="frequency"
                name="frequency"
                onChange={(e) => setFrequency(e?.target.value)}
            />
            <br/>
            <h6 className="text-[11px] font-light">Pour supprimer, renseignez le champ [Modèle]</h6>
            <Inputs type="text"
                        placeholder="HTX-GT-43"
                        labelText="Modèle"
                        name="model"
                        id="model"
                        onChange={(e) => setModel(e?.target.value)}
                />
            <br/>
            <div className="flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData()}>Ajouter produit</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => DeleteData()}>Supprimer produit</button>
            </div>
        </div>
    )
}

export default CpuForm