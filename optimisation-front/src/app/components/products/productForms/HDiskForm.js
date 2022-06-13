import React, {useEffect, useState} from "react";
import Inputs from "../../components/Inputs";
import axios from "axios";
import {URL_BRAND_GET, URL_PROD_HDISK} from "../../../shared/constants/urls/urlBackEnd";

const HDiskForm = ({ onChange }) => {

    const [brandList, setBrandList] = useState([]);
    const [brand, setBrand] = useState("");
    const [capacity, setCapacity] = useState(0)
    const [type, setType] = useState("")
    const [isExternal, setIsExternal] = useState(false)
    const [data, setData] = useState([])
    const [supp, setSupp] = useState([])

    useEffect(() => {
        axios.get(URL_BRAND_GET)
            .then(res => setBrandList(res.data))
            .catch(err => console.log(err.response.data))
        axios.get(URL_PROD_HDISK)
            .then(res => setData(res.data))
            .catch(err => console.log(err.response.data))
    }, []);

    const SendData = (e) => {
        e.preventDefault();
        let state = {
            "brand" : {"name" : brand},
            "capacity" : capacity,
            "type" : type,
            "isExternal" : Boolean(isExternal)
        }
        axios.post(URL_PROD_HDISK, state)
            .then(res => console.log(res.data))
            .catch(err => console.log(err.response.data))
    }

    const DeleteData = (e) => {
        e.preventDefault()
        axios.delete(URL_PROD_HDISK + "/" + supp)
            .then((res) => {
                console.log(res.data)
            })
            .catch(err => console.log(err));

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
                    name="objSelect"
                    onChange={(e) => {
                        setSupp(e?.target.value)
                        onChange(e);
                    }}>
                <option value="">Choisissez votre produit à supprimer</option>
                {data.map((data, index) => {
                    console.log(data)
                    return(<option value={data.value} key={index}>{data.name}</option>)
                }
                )}
            </select>
            <br/>
            <Inputs
                type="text"
                placeholder="1 Go"
                labelText="Capacité (Go)"
                name="capacity"
                onChange={(e) => setCapacity(e?.target.value)}
                className="w-2/5"
                id="cap"
            />
            <br/>
            <Inputs
                type="text"
                placeholder="SSD"
                labelText="Type"
                name="type"
                onChange={(e) => setType(e?.target.value)}
                className="w-2/5"
                id="type"
            />
            <br/>
            <Inputs
                type="radio"
                name="internal"
                onChange={(e) => setIsExternal(e?.target.value)}
                className="gap-8"
                config={[
                    {text : "Interne", id: "intern", value: true}, {text : "Externe", id: "extern", value: false}
                ]}
            />
            <br/>
            <div className="flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData()}>Ajouter produit</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => DeleteData()}>Supprimer produit</button>
            </div>
        </div>
    )
}

export default HDiskForm