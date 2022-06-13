import { Carousel } from 'antd';
import ordi from "../assets/images/ordi1.jpg";
import SourisFilaire from "../assets/images/sourisFilaireFraise.jpeg";
import SourisWireless from "../assets/images/fraiseSansFil.jpg";
import React from "react";

const contentStyle = {
    height: '300px',
    width: "auto",
    objectFit: "cover",
    color: '#fff',
    lineHeight: '160px',
    textAlign: 'center',
    background: '#364d79',
};


const HomeView = () => (
    <Carousel autoplay>
        <div>
            <img style={contentStyle} src={ordi} alt="ordinateur" />
        </div>
        <div>
            <img style={contentStyle} src={SourisFilaire} alt="souris filaire" />
        </div>
        <div>
            <img style={contentStyle} src={SourisWireless} alt="souris sans fil" />
        </div>
    </Carousel>
);

export default HomeView