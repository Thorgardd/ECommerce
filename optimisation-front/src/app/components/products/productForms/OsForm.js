import React, {useState} from "react";
import Inputs from "../../components/Inputs";
import {URL_PROD_OS} from "../../../shared/constants/urls/urlBackEnd";
import axios from "axios";

const OsForm = ({ onChange }) => {

    const [version, setVersion] = useState();
    const [name, setName] = useState();

    const SendData = (e) => {
        e.preventDefault();
        let sendObject = new FormData()
        sendObject.append("name", name)
        sendObject.append("version", version)
        axios.post(URL_PROD_OS, sendObject)
            .then((res) => console.log(res))
            .catch((err) => console.log(err))
    }

    const DeleteData = (e) => {
        e.preventDefault();
        axios.delete(URL_PROD_OS + "/" + version)
            .then(res => console.log(res.data))
            .catch(err => console.log(err.response.data))
    }

    return(
        <div className="container w-full flex-col">
            <p className="text-[11px] font-light">Pour supprimer, renseignez le champ [Version]</p>
                <Inputs
                        type="text"
                        placeholder="Windows / Linux / MacOS"
                        labelText="OS"
                        name="name"
                        id="os"
                        onChange={(e) => setName(e?.target.value)}
                        className="w-2/5"
                />
                <br/>
                <Inputs
                    type="text"
                    className="w-2/5"
                    labelText="Version"
                    placeholder="0.1"
                    name="version"
                    id="version"
                    onChange={(e) => setVersion(e?.target.value)}
                />
            <br/>
            <div className="flex justify-center">
                <button className="btn w-2/5" style={{ backgroundColor : "#8dcc00" }} onClick={() => SendData()}>Ajouter produit</button>
                <button className="btn w-2/5 ml-5" style={{ backgroundColor : "#f44336" }} onClick={() => DeleteData()}>Supprimer produit</button>
            </div>
        </div>
    )
}

export default OsForm