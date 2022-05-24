
import {doPost} from './commonRequest'

export function GetStore_List(query) {
    return doPost('/api/GetStaticData_List/GetStore_List', query)
}
