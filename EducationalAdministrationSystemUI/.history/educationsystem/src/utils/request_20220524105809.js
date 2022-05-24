import axios from 'axios'


// create an axios instance
const service = axios.create({
    baseURL: "http://localhost:5072/",
    // withCredentials: true, // send cookies when cross-domain requests
    timeout: 60000 // request timeout
})

// request interceptor
export default service