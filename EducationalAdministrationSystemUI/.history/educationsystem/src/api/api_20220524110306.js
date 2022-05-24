
import {doPost} from './commonRequest'

export function GetStore_List(query) {
    return doPost('/api/Login/GetTokenInfo', query)
}
