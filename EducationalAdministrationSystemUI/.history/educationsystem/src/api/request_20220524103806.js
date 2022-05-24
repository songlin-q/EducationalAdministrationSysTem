
import { Axios } from "axios"
//获取jwt权限认证字符串
export const GetJwtStr=params=>{
    return this.Axios.get('/api/Login/GetTokenInfo',params)
}