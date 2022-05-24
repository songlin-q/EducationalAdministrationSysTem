
import {doPost,doGet} from './commonRequest'

export function GetJwtStr(query) {
    return doPost('/api/Login/GetTokenInfo', query)
}
