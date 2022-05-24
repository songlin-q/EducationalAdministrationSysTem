
import request from '../'

Axios.defaults.baseURL="http://localhost:5072/";//基本路径
//获取jwt权限认证字符串
export const GetJwtStr=()=>{
    return Axios.get('/api/Login/GetTokenInfo')
}