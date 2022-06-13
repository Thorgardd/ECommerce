import React, { PureComponent } from "react";
import { useParams } from "react-router-dom";

import { getComputerByRef } from "../../api/backend/computerAPI/ComputerService";

import parse from 'html-react-parser';

class Description extends PureComponent {

    constructor(props) {
        super(props)
        this.state = {
            category: []
        }
    }

    componentDidMount() {
        getComputerByRef(this.props.computerReference).then(response => {
            this.setState({
                category: response.data.computer.category
            })
            console.log(this.state.category)
        }).catch(error => {
            console.log(error)
        })
    }

    render () {
        return (
            <div className="mx-auto lg:mx-20 px-8">
                <p>{parse(`${this.state.category.description}`)}</p>
            </div>
        )
    }
    
}

export default function GetRef() {
    const { reference } = useParams();
    return (
        <Description computerReference={reference} />
    )
} 
