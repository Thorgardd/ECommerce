import {CatalogMC, CatalogDisplay} from "../assets/styled/DivStyled";
import {useLocation} from "react-router-dom";
import {URL_COMPUTER_REF, URL_PROD_MOUSE} from "../shared/constants/urls/urlBackEnd";
import axios from "axios";
import {useEffect, useState} from "react";
import Card from "../components/components/Card";
import Dropdown from "../components/layouts/icon-button/Dropdown";
import {TriageDropdown} from "../assets/styled/DivStyled";
import React from 'react'

const CatalogView = () => {

    const [computers, setComputers] = useState([]);
    const [devices, setDevices] = useState([]);
    const location = useLocation();

    useEffect(() => {
        axios.get(URL_COMPUTER_REF)
            .then((res) => setComputers(res.data))
            .catch((err) => console.log(err))

        axios.get(URL_PROD_MOUSE)
            .then((res) => setDevices(res.data))
            .catch((err) => console.log(err))
    }, [])

    const CatalogSelector = (routeValue) => {
        if (routeValue === "/catalog"){
            return(
                <>
                    <TriageDropdown>Trier par : <Dropdown/></TriageDropdown>
                    <CatalogDisplay>
                        {computers.map((computer, index) => {
                            if (computer.category.name.toLowerCase() === "portable" || computer.category.name.toLowerCase() === "bureau"){
                                return <Card product={computer} key={index}/>
                            }
                        })}
                    </CatalogDisplay>
                </>

            )
        } else if (routeValue === "/gaming"){
            return(
                <>
                <TriageDropdown><p>Trier par : </p><Dropdown/></TriageDropdown>
                    <CatalogDisplay>
                        {computers.map((computer, index) => {
                            if (computer.category.name.toLowerCase() === "gaming"){
                                return <Card product={computer} key={index}/>
                            }
                        })}
                    </CatalogDisplay>
                </>

            )
        } else if (routeValue === "/device"){
          return(
              <>
                  <TriageDropdown>Trier par : <Dropdown/></TriageDropdown>
                  <CatalogDisplay>
                      {devices.map((device, index) => {
                          return <Card product={device} key={index}/>
                      })}
                  </CatalogDisplay>
              </>
          )
        }
    }

    return(
        <CatalogMC>
            {CatalogSelector(location.pathname)}
        </CatalogMC>
    )
}

export default CatalogView;