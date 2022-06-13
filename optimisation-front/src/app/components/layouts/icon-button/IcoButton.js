import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export default class IcoButton extends Component {

    static defaultProps() {
        return {
            isLink: true,
        };
    }

    render() {
        return this.props.isLink ? (
            <Link to={this.props.linkTo}>
                <button
                    type="button"
                    className={`btn p-0 h-12 w-12  md:h-10 md:w-10 rounded-lg md:rounded-xl bg-primary hover:bg-primary/[.6] group ${this.props.btnClasses}`}
                    onClick={this.props.onClick}
                >
                    <img
                        className="h-6 w-6 md:h-5 md:w-5 group-hover:mb-1"
                        src={this.props.imageSrc}
                        alt={this.props.imageAlt}
                    />
                </button>
            </Link>
        ) : (
            <button
                type="button"
                className={`btn p-0 h-12 w-12  md:h-10 md:w-10 rounded-lg md:rounded-xl bg-primary hover:bg-primary/[.6] group ${this.props.btnClasses}`}
                onClick={this.props.onClick}
            >
                <img
                    className="h-6 w-6 md:h-5 md:w-5 group-hover:mb-1"
                    src={this.props.imageSrc}
                    alt={this.props.imageAlt}
                />
            </button>
        )
    }
}
