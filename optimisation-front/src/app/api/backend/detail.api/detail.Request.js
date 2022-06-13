import axios from 'axios';
import { URL_BACK_API_BASIS } from '../../../shared/constants/urls/urlBackEnd';

export const getAllBrandsByRequest = () => {
    return axios.get((URL_BACK_API_BASIS + '/brand'), {mode: "cors"});
}
