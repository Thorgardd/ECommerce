import React, { PureComponent } from "react";
import { useParams } from "react-router-dom";

import { getComputerByRef } from "../../api/backend/computerAPI/ComputerService";
import { dateFormat } from "../../shared/services/formatDateService";

import ProductButton from "../layouts/icon-button/ProductButton";
import chevronIcon from "../../assets/images/icons/products/chevron.svg";

import Box from "@mui/material/Box";
import Rating from "@mui/material/Rating";
import Typography from "@mui/material/Typography";


class CustomerReview extends PureComponent {
    constructor(props) {
        super(props)
        this.state = {
            ranks: [],
            average: 0
        }
    }

    componentDidMount() {
        getComputerByRef(this.props.computerReference).then(response => {
            this.setState({
                ranks: response.data.computer.ranks,
                average: response.data.average
            })
            console.log(this.state.ranks)
        }).catch(error => {
            console.log(error)
        })
    }
    render() {
        return (
            <div className="mx-auto px-8 grid grid-cols-4">
                <div className="col-start-4 col-end-5 mt-10">
                    <a href="/" className="text-green-blue ml-5">Voir tout les avis</a><br/>
                    <button href="/" className="bg-secondary-light text-black font-semibold hover:text-white py-2 px-4 border border-secondary-light">Déposer un avis</button>
                </div>
                {this.state.ranks.map(r =>
                    <div className="md:border-b border-primary/[.4] pb-5 col-start-1 col-end-4" key={r.index}>
                        <span className="grid grid-cols-3 pt-5 content-start">
                            <Box className="mt-0" sx={{ '& > legend': { mt: 2 }, }} >
                                <Typography component="legend"></Typography>
                                <Rating name="half-rating" precision={0.5} value={r.score} readOnly />
                            </Box>
                            <p className="">{dateFormat(r.date)}</p>
                            <p className="flex justify-end"><b>{r.firstName} {r.lastName[0].toUpperCase()}.</b></p>
                        </span>
                        <p>{r.commentary}</p><br />
                        <p className="text-gray-400">Cet avis vous a-t-il était utile ?</p>
                        <button href="/" className="bg-transparent text-black font-semibold hover:text-green-blue py-2 px-4 border border-green-blue rounded">Oui</button>
                        <a href="/" className="text-green-blue ml-5">Signaler un abus</a>
                    </div>
                )}
                <ProductButton linkTo="/" imageSrc={chevronIcon} imageAlt="Chevron Icon" />
            </div>
        )
    }
}

export default function GetRef() {
    const { reference } = useParams()
    return (
        <CustomerReview computerReference={reference} />
    )
}