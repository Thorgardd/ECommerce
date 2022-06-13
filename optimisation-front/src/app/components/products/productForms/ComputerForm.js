import React from "react";
import Inputs from "../../components/Inputs";

const ComputerForm = ({ onChange }) => {
    return(
        <div className="container w-full flex-col">
            <div className="wrapperForm justify-center">
                <p className="font-light text-[11px]" >DETAILS</p>
                <div className="justify-start">
                    <Inputs
                        type="text"
                        className="w-2/5"
                        labelText="Référence"
                        placeholder="X5F-4D3C"
                        name="reference"
                        id="reference"
                        onChange={onChange}
                    />
                    <br/>
                    <Inputs
                        type="text"
                        placeholder="999€"
                        labelText="Prix"
                        name="price"
                        id="price"
                        onChange={onChange}
                        className="w-2/5"
                    />
                </div>
            </div>
        </div>
    )
}

export default ComputerForm