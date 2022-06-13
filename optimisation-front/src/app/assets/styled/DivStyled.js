import styled from "styled-components";


// MainContainer de la vue CartView
export const MainContainer = styled.div`
  width: 100%;
  height: auto;
  display: flex;
  justify-content: center;
  min-height: 100vh;
`;

// Container du panier de la vue CartView
export const CartContainer = styled.div`
    width: 80%;
    height: 100px;
    margin-top: 80px;
`;

// Div pour le Button et Input du code promo
export const InputSaleContainer = styled.div`
  position: relative;
  width: 100%;
  margin-top: 40px;
  height: 40px;
  border-radius: 10px;
  background-color: green;
`;

export const CardContainer = styled.div`
  background-color: transparent;
  width: 200px;
  height: 200px;
  display: block;
`;

export const Product = styled.div`
  width: 100%;
  height: auto;
  padding-top: 10px;
  display: flex;
  justify-content: center;
  flex-direction: column;
`

export const DeviceCard = styled.div`
  width: 100%;
  height: 100%;
  border: white;
  box-shadow: 0 3px 8px #e5e7eb;
  border-radius: 0.5rem;
  display: flex;
  flex-direction: column;
  justify-content: center;
  
  &:hover{
    animation-delay: 1s;
    box-shadow: 0 3px 8px #6b7280;
  }
`;

export const SaleContainer = styled.div`
  display: flex;
  flex-direction: row;
  justify-content: space-evenly;
  margin-top: 10px;
  margin-bottom: 10px;
`;

export const SpecsContainer = styled.div`
  display: block;
  flex-direction: row;
  justify-content: space-evenly;
  margin: 7px 0 10px 0;
`;

export const ComputerCard = styled(DeviceCard)`
  background-color: inherit;
`;

export const ProdDetailMC = styled.div`
  width: 100%;
  min-height: 50vh;
  display: flex;
  justify-content: center;
  margin-top: 25px;
`;

export const ProdInfos = styled.div`
  width: 55%;
  height: auto;
`;

export const ProdDetailView = styled(ProdDetailMC)`
  width: 80%;
  height: 65vh;
  justify-content: start;
`;

export const ProdDetails = styled.div`
  width: 100%;
  height: auto;
  display: flex;
  flex-direction: column;
`;

export const PriceAddBtn = styled(ProdDetails)`
  margin-top: 10px;
  height: 15vh;
  flex-direction: row;
  align-items: center;
  justify-content: space-evenly;
  border-bottom-color: lightgray;
  border-bottom-width: 2px;
  border-radius: 10px;
  border-top-color: turquoise;
  border-top-width: 2px;
`;

export const ProductDetailsInfos = styled(ProdDetails)`
  height: auto;
`;

export const CatalogMC = styled.div`
  width: 100%;
  min-height: 50vh;
  height: auto;
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
  /*justify-content: center;*/
`;


export const CatalogDisplay = styled(CatalogMC)`
  padding-top: 20px;
  width: 100%;
  padding-left: 10%;
  padding-right: 10%;
  align-self: center;
  justify-content: center;
`;

export const TriageDropdown = styled.div`
  display: flex;
  flex-direction: row;
  align-items: center;
  margin-left: 7rem;
  padding: 1rem;
  gap: 10px;
`;


