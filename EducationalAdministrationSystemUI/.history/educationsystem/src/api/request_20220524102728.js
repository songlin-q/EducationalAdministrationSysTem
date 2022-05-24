
import { Axios } from "axios"
//获取jwt权限认证字符串
export const GetJwtStr=params=>{
    return Axios.http.post('/api/Login/GetTokenInfo',params).then(res=>res.data)
}