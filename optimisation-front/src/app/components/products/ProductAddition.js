import React from "react";
import AddProductForm from "./AddProductForm";

const ProductAddition = () => {
    return(
        <div className="mainWindow w-full flex mt-8 justify-center min-h-screen">
            <div className="w-3/6 flex flex-col">
                <AddProductForm />
            </div>
        </div>
    )
}

export default ProductAddition