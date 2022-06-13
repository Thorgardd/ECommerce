import styled from "styled-components";
import {Avatar, Button, Comment, Form} from "antd";
import TextArea from "antd/es/input/TextArea";
import React from "react"

const Commentary = () => {

    const Editor = ({ onChange, onSubmit, value, loader }) => (
        <>
            <Form.Item>
                <InputText row={4} onChange={onChange} value={value}/>
            </Form.Item>
            <Form.Item>
                <SendButton htmlType="submit" loading={loader} onClick={onSubmit} type="primary">Envoyer</SendButton>
            </Form.Item>
        </>
    )

    return(
        <CommentarySection>
            <Comment avatar={<Avatar src="https://joeschmoe.io/api/v1/random" alt="Anakin Skywalker"/>}
                     content={
                        <Editor

                        />
                     }/>
        </CommentarySection>
    )
}

export default Commentary;


// ALL STYLED COMPONENTS FOR COMMENTARY
//
//
// MAIN CONTAINER FOR COMMENTARY
const CommentarySection = styled.div`
  width: 80%;
  height: auto;
  min-height: 50px;
  margin-left: 10%;
  border-top-width: 2px;
  border-radius: 10px;
  border-top-color: lightgray;
  padding-top: 20px;
  border-bottom-width: 2px;
  border-bottom-color: turquoise;
`;

// INPUT FOR COMMENTARY
const InputText = styled(TextArea)`
  border-radius: 10px;
`;

// ADD BUTTON FOR COMMENTARY
const SendButton = styled(Button)`
  color: white;
  background-color: turquoise;
  border-radius: 10px;
  
  &:hover{
    background-color: turquoise;
    border-radius: 10px;
    color: white;
  }
`;