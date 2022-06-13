import styled from "styled-components";
import {Button, Col, Input} from "antd";

export const {TextArea} = Input

export const StyledButton = styled(Button)`
  background-color: ${({ color }) => color};
  width: 100%;
  height: 50px;
  display: flex;
  justify-content: center;
  align-items: center;
  color: #41416E;
  font-family: 'Open Sans', sans-serif;
  font-style: normal;
  font-weight: 600;
  font-size: 18px;
  line-height: 25px;
  border-color: ${({ color }) => color};
  border-radius: 10px;
  margin-bottom: 50px;
  margin-top: 5px;
  
  &:hover, &:focus {
    background-color: ${({ color }) => color};
    border-color: ${({ color }) => color};
    color: #41416E;
  }
`;

export const StyledSubButton = styled(StyledButton)`
  position: absolute;
  right: 0;
  top: -5px;
  width: 40%;
  height: 100%;
  color: #FFFFFF;
  font-family: 'Open Sans', sans-serif;
  font-style: normal;
  font-weight: 600;
  font-size: 13px;
  line-height: 16px;
  border-top-left-radius: 0px;
  border-bottom-left-radius: 0px;
  
  &:focus, &:hover {
    color: #FFFFFF;
  }
`;

export const StyledCol = styled(Col)`
  width: ${({ width }) => width};
  height: auto;
`;
