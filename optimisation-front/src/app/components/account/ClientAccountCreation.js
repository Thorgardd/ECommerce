import React, {useState} from "react";
import BackImage from "../assets/backbluepng.png";
import FrontImage from "../assets/fronbluepng.png";
import ClientAccountForm from "./ClientAccountForm";

const ClientAccountCreation = () => {

    const [state, setState] = useState({
        civ: undefined,
        country: undefined,
        lastname: undefined,
        firstname: undefined,
        phone: undefined,
        email: undefined,
        password: undefined,
        notRobot: undefined,
        cgvu: undefined
    });

    const onSubmit = (e) => {
        e.preventDefault();

        console.log(state);
    }

    const onChange = (e) => {

        let name = e.target.name;
        let value = e.target.value;
        let checked = e.target.checked;

        if (e.target.type === "checkbox")
        {
            setState((prevState) => ({
                ...prevState,
                [name]: checked
            }));
        }
        else
        {
            setState((prevState) => ({
                ...prevState,
                [name]: value
            }));
        }
    }

    return(
        <div className="mainWindow w-full flex justify-center min-h-screen">
            <div className="w-3/6 flex flex-col">
                <h1 className="text-base text-center w-full my-5">Créez un compte chez nous</h1>
                <ClientAccountForm onChange={onChange} onSubmit={onSubmit}/>
            </div>
            <div className="absolute bottom-0 flex w-full">
                <div className="relative w-full h-full flex flex-col gap-5 pb-5">
                    <img className="h-96 absolute right-0 bottom-20 w-10/12" src={BackImage}/>
                    <img className="h-96 absolute left-0 bottom-0 w-full" src={FrontImage}/>
                    <div className="w-full relative text-white z-20 text-center mb-5 text-4xl">Mes avantages clients</div>
                    <div className="w-full relative z-20 justify-center mb-5 flex flex-row gap-5 mt-5">
                        <div className="flex flex-row h-20 w-96 gap-8">
                            <div className="h-6 w-6 rounded-full bg-yellowCustom mt-2"></div>
                            <p className="text-white h-full w-80">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquet tellus lorem tristique bibendum dictum duis.
                            </p>
                        </div>
                        <div className="flex flex-row h-20 w-96 gap-8">
                            <div className="h-6 w-6 rounded-full bg-yellowCustom mt-2"></div>
                            <p className="text-white h-full w-80">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquet tellus lorem tristique bibendum dictum duis.
                            </p>
                        </div>
                        <div className="flex flex-row h-20 w-96 gap-8">
                            <div className="h-6 w-6 rounded-full bg-yellowCustom mt-2"></div>
                            <p className="text-white h-full w-80">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquet tellus lorem tristique bibendum dictum duis.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default ClientAccountCreation