import axios from 'axios';
import { getToken } from '../../shared/services/tokenServices';
import handleHttpError from './../../shared/components/form-and-error-components/HandleHttpError';

const apiBackEnd = axios.create({
    baseURL: "http://localhost:8080/api",
});
export default apiBackEnd;

apiBackEnd.interceptors.request.use((request) => {
    request.headers['Authorization'] = `Bearer ${getToken()}`;
    return request;
});

apiBackEnd.interceptors.response.use(
    (response) => {
        console.log(response.status);
        return response;
    },
    (error) => {
        handleHttpError(error);
        return error;
    },
);
