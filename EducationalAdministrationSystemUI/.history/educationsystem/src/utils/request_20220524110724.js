import axios from 'axios'


// 配置访问接口
const service = axios.create({
    baseURL: "http://localhost:5072/",
    // withCredentials: true, // send cookies when cross-domain requests
    timeout: 60000 // request timeout
})

// request interceptor
export default service