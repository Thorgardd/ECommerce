import axios from "axios";
import React, { useState } from "react";
import Inputs from "../../components/Inputs";
import {URL_PROD_CONNECTOR} from "../../../shared/constants/urls/urlBackEnd";


const ConnectForm = () => {

    const [name, setName] = useState("");
    const [version, setVersion] = useState("");

    const SendData = (e) => {
        e.preventDefault();
        let state = {
            "version" : version,
            "name" : name,
            "computer" : null
        }
        axios.post(URL_PROD_CONNECTOR, state)
            .then((res) => console.log(res.data))
            .catch((err) => console.log(err.response.data))
    }

    const DeleteData = (e) => {
        e.preventDefault();
        axios.delete(URL_PROD_CONNECTOR + "/"+ name)
            .then(res => console.log(res.data))
            .catch(err => console.log(err.response.data))
    }

    return(
        <div className="container w-full flex-col">
            <h6 className="font-light text-[14px]">Pour supprimer un produit, renseigner le champ [Nom]</h6>
                <Inputs
                    type="text"
                    name="name"
                    labelText="Nom"
                    placeholder="Display Port"
                    onChange={(e) => setName(e?.target.value)}
                />
                <br/>
                <Inputs
                    type="text"
                    name="version"
                    labelText="Version"
                    placeholder="C"
                    onChange={(e) => setVersion(e?.target.value)}
                />
            <br/>
            <div className="buttons flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData}>Ajouter</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => DeleteData}>Supprimer</button>
            </div>
        </div>
    )
}

export default ConnectForm