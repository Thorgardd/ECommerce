import React from "react";

const Inputs = ({ type, placeholder, labelText, onChange, className, id, name, config }) => {

    if (type === "radio" || type === "checkbox") {
        return (
            <div className={className + " flex flex-row items-center"}>
                {labelText !== "" &&
                    <label className="w-auto mr-1 text-sm" htmlFor={id}>{labelText}</label>
                }
                {config.map((element, index) => (
                    <div key={index} className={(element.inverse ? "flex-row-reverse" : "flex-row") + " flex items-center gap-1"}>
                        <label htmlFor={element.id}>{element.text}</label>
                        <input type={type} onChange={onChange} className="mt-1" name={name} id={element.id} value={element.value} />
                    </div>
                ))}
            </div>
        )
    } else {
        return (
            <div className={className + " flex flex-row rounded-lg items-center border border-gray py-1 px-2"}>
                <label className="w-auto mr-1 text-sm" htmlFor={id}>{labelText}</label>
                <input name={name} className="w-auto focus:outline-none" id={id} type={type} onChange={onChange}
                       placeholder={placeholder}/>
            </div>
        )
    }
};

Inputs.defaultProps = {
    type: "text",
    placeholder: "",
    labelText: "",
    onChange: () => {},
    className: "",
    id: "",
    name: "",
    config: []
};

export default Inputs;