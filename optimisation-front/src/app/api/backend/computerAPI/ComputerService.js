import axios from "axios";

const baseUrl = 'http://localhost:27933/qual_it/api/v1';

export const getComputerByRef = (reference) => {
    return axios.get(baseUrl + '/computer/' + reference, {mode: 'cors'})
}

