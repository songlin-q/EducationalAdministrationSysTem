
import {doPost} from './commonRequest'

export function GetJwtStr(query) {
    return doPost('/api/Login/GetTokenInfo', query)
}
