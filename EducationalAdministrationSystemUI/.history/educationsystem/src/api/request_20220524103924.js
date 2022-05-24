
import { Axios } from "axios"
//获取jwt权限认证字符串
export const GetJwtStr=()=>{
    return Axios.get('/api/Login/GetTokenInfo')
}