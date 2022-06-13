import ordi from "../../../assets/images/ordi1.jpg";
import {useState} from "react";

const LineCart = ({price, isOnSale, reference, product, AddToCart, RemoveFromCart}) => {

    const [quantity, setQuantity] = useState(1)

    const PriceUnit = (price, reduction) => {
        const solde = 1 - (reduction/100)
        return Math.round((price*solde) * 100) / 100
    }

    return(
        <div className="m-2">
            <div className="flex items-center">
                <div className="border-solid border-2 w-[50px] h-[50px] flex justify-center items-center">
                    {/* eslint-disable-next-line jsx-a11y/img-redundant-alt */}
                    <img className="w-1/2 h-1/2 object-cover" src={ordi} alt="ordiPourPanier" />
                </div>
                <div className="flex items-center">
                    <div className="flex flex-col text-start pl-4 pr-8">
                        <div>
                            {reference}
                        </div>
                        <div className="flex-auto">
                            {isOnSale}
                        </div>
                    </div>
                    <div className="flex-auto pl-4 pr-32">
                        {/* {this.props.item.price} € */}
                        {PriceUnit(price,20)}€
                    </div>
                    <div className="absolute right-4 flex text-center items-center">
                        <div onClick={() => RemoveFromCart(product)} className="rounded-full border-red-600 hover:bg-red-600 hover:text-white border-2 w-8 h-8 mr-2 cursor-pointer">-</div>
                            {quantity}
                        <div onClick={() => AddToCart(product)} className="rounded-full border-green-600 hover:bg-green-600 hover:text-white border-2 w-8 h-8 ml-2 cursor-pointer">+</div>
                    </div>
                </div>
            </div>
        </div>
    )
}

LineCart.defaultProps = {
    price: null,
    isOnSale: false,
    reference: "",
    quantity: 1,
    product: {}
}

export default
LineCart