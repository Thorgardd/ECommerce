import axios from "axios";

const baseUrl = 'http://localhost:27933/qual_it/api/v1';

export const getDeviceByRef = (reference) => {
    return axios.get(`${baseUrl}/mouse/${reference}`, {mode: 'cors'})
}

