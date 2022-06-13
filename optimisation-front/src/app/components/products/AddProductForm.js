import React, { useState } from "react";
import {Options} from "../../shared/constants/selectProductConstant";
import ComputerForm from "./productForms/ComputerForm";
import ScreenForm from "./productForms/ScreenForm";
import HDiskForm from "./productForms/HDiskForm";
import SoundForm from "./productForms/SoundForm";
import OsForm from "./productForms/OsForm";
import CpuForm from "./productForms/CpuForm";
import GCardForm from "./productForms/GCardForm";
import RamForm from "./productForms/RamForm";
import MouseForm from "./productForms/MouseForm";
import PowerForm from "./productForms/PowerForm";
import ConnectForm from "./productForms/ConnectForm";

const AddProductForm = ({ onChange }) => {

    const [display, setDisplay] = useState();

    return(
        <form method="POST" className="flex flex-col gap-5">
            <h3 className="font-semibold text-center">CREATION D'UN PRODUIT</h3>
            <div className="flex flex-row justify">
                <select className="form-select form-select-lg mb-3
                                   appearance-none
                                   block
                                   w-full
                                   px-4
                                   py-2
                                   text-xl
                                   font-normal
                                   text-gray-700
                                   bg-white bg-clip-padding bg-no-repeat
                                   border border-solid border-gray-300
                                   rounded
                                   transition
                                   ease-in-out
                                   m-0
                                   focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none"
                        aria-label=".form-select-lg example"
                        onChange={(e) => {
                            setDisplay(e?.target?.value);
                            onChange(e)
                        }}>
                    <option value="">Choisissez votre produit</option>
                    {Options.map((option, index) => (
                        <option value={option.value} key={index}>{option.label}</option>
                    ))}
                </select>
            </div>
            {display === "COMPUTER_CREATE" && (
                <ComputerForm onChange={onChange} />
            )}
            {display === "SCREEN_CREATE" && (
                <ScreenForm onChange={onChange} />
            )}
            {display === "SOUND_CREATE" && (
                <SoundForm onChange={onChange}/>
            )}
            {display === "OS_CREATE" && (
                <OsForm onChange={onChange} />
            )}
            {display === "CPU_CREATE" && (
                <CpuForm onChange={onChange}/>
            )}
            {display === "GCARD_CREATE" && (
                <GCardForm onChange={onChange}/>
            )}
            {display === "RAM_CREATE" && (
                <RamForm onChange={onChange}/>
            )}
            {display === "HDISK_CREATE" && (
                <HDiskForm onChange={onChange}/>
            )}
            {display === "MOUSE_CREATE" && (
                <MouseForm onChange={onChange}/>
            )}
            {display === "POWER_CREATE" && (
                <PowerForm onChange={onChange}/>
            )}
            {display === "CONNECT_CREATE" && (
                <ConnectForm onChange={onChange}/>
            )}
        </form>
    )
}

AddProductForm.defaultProps = {
    onChange: () => {}
}

export default AddProductForm