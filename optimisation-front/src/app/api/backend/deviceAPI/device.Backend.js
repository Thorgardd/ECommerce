import axios from 'axios';
import { URL_BACK_API_BASIS } from '../../../shared/constants/urls/urlBackEnd';



export const getAllMouseByRequest = () => {
    return axios.get((URL_BACK_API_BASIS + '/mouse'), { mode: 'cors' });
}

export const getAllScreenByRequest = () => {
    return axios.get((URL_BACK_API_BASIS + '/screen'), { mode: 'cors' });
}



// export const getComputersGamingByRequest = () => {
//     const formData = new FormData();
    
//     formData.append("SearchCateg", "Gaming")
//     // formData.get("SearchCateg")
//     // console.log(formData.get("SearchCateg"))
//     return axios.post('http://localhost:27933/qual_it/api/v1/computer/byCateg', formData);    
// }