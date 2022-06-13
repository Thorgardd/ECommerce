import styled from "styled-components"
import React from 'react';

const Specifications = ({ product }) => {

    const SpecsSelector = (prod) => {
        if (prod.computer?.hasOwnProperty("os")){
            return(
                <>
                    <SpecContainerOne>
                        <SpecTitle>Processeur : </SpecTitle><SpecInfo>{prod.computer.cpu.model}</SpecInfo>
                        <SpecTitle>Système d'exploitation : </SpecTitle><SpecInfo>{prod.computer.os.name} {prod.computer.os.version}</SpecInfo>
                        <SpecTitle>Alimentation : </SpecTitle><SpecInfo>{prod.computer.powerSupply.power}</SpecInfo>
                    </SpecContainerOne>
                    <SpecContainerTwo>
                        <SpecTitle>Stockage : </SpecTitle><SpecInfo>{prod.computer.hardDisks[0].capacity}Go - {prod.computer.hardDisks[0].type}</SpecInfo>
                        <SpecTitle>Ram : </SpecTitle><SpecInfo>LES ORDINATEURS N'ONT PAS DE RAM DANS LA TABLE</SpecInfo>
                        <SpecTitle>Ecran : </SpecTitle><SpecInfo>{prod.computer.screen.quality} - {prod.computer.screen.size}</SpecInfo>
                    </SpecContainerTwo>
                </>
            )
        }
    }

    return(
        <>
            {SpecsSelector(product)}
        </>
    )
}

export default Specifications


// ALL STYLED COMPONENTS FOR SPECIFICATIONS
//
//
// MAIN CONTAINER FOR SPECIFICATIONS
export const SpecsMC = styled.div`
  width: 80%;
  height: 30vh;
  margin-left: 10%;
  border-top-width: 2px;
  border-radius: 10px;
  border-top-color: lightgray;
  padding-top: 20px;
  display: flex;
  flex-direction: row;
  border-bottom-width: 2px;
  border-bottom-color: lightgray;
  margin-bottom: 30px;
  align-items: center;
`;

const SpecContainerOne = styled.div`
  height: 100%;
  width: 50%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  padding-left: 20px;
`;

const SpecContainerTwo = styled.div`
  height: 100%;
  width: 50%;
  display: flex;
  justify-content: center;
  flex-direction: column;
`;

const SpecTitle = styled.p`
  font-weight: bold;
  font-size: 16px;
`;

const SpecInfo = styled.p`
  font-weight: normal;
  font-size: 14px;
  margin-bottom: 10px;
`;