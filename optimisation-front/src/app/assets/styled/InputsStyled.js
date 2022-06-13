import styled from "styled-components";

export const Input = styled.input`
  position: absolute;
  height: 100%;
  width: 100%;
  background-color: #FFFFFF;
  border: 1px solid #E0E0E0;
  border-radius: 10px;
  padding-left: 20px;
  
  &::placeholder {
    font-family: 'Open Sans', sans-serif;
    font-style: normal;
    font-weight: 400;
    font-size: 13px;
    line-height: 16px;
    color: #9E9E9E;
  }
`;