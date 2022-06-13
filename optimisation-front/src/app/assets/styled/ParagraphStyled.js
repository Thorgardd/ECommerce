import styled from "styled-components";

export const SubTitle = styled.p`
  font-family: 'Open Sans', sans-serif;
  font-style: normal;
  font-weight: ${({ isBold }) => isBold ? "600" : "400"};
  font-size: 14px;
  line-height: 19px;
  color: #41416E;
`;

export const ProductTitle = styled(SubTitle)`
  font-size: 12px;
`;

export const DetailsProduct = styled.p`
  font-size: 12px;
  font-weight: lighter;
`;

export const StrikedPrice = styled.p`
  margin-top: 10px;
  text-decoration: line-through;
`;

export const SalePrice = styled(StrikedPrice)`
  text-decoration: none;
`;

export const SaleRate = styled.p`
  color: red;
  margin-top: 6px;
  font-size: 18px;
`;

export const SaledPrice = styled.p`
  font-size: 18px;
  margin-top: 10px;
`;

export const BasicBaliseP = styled.p`
  font-size: 16px;
  margin-left: 50px;
  margin-top: 30px;
`;
