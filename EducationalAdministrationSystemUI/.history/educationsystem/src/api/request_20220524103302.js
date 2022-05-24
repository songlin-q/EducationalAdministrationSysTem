
import { Axios } from "axios"
axios.defaults.baseURL="http://localhost:5072/";//基本路径
//获取jwt权限认证字符串
export const GetJwtStr=params=>{
    return Axios.get('/api/Login/GetTokenInfo',params)
}