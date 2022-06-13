import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export default class IcoButton extends Component {
    render() {
        return (
            <Link to={this.props.linkTo}>
                <button
                    type="button"
                    className={`btn p-0 h-12 w-12  md:h-10 md:w-10 rounded-full md:rounded-full bg-secondary hover:bg-secondary/[.6] group ${this.props.btnClasses}`}
                    onClick={this.props.onClick}
                >
                    <img
                        className="h-10 w-10 md:h-7 md:w-7 group-hover:mb-1"
                        src={this.props.imageSrc}
                        alt={this.props.imageAlt}
                    />
                </button>
            </Link>
        );
    }
}