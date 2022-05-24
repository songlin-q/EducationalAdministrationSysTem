

//获取jwt权限认证字符串
export const GetJwtStr=params=>{
    return this.$http.post('/api/Login/GetTokenInfo',params).then(res=>res.data)
}