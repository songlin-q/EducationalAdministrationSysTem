import {axios} from 'axios' //引入axios

export const GetJwtStr=params=>{
    return axios.post('/api/Login/GetTokenInfo')
}