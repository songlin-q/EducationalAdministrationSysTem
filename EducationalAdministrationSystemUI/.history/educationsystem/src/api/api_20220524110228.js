
import {doPost} from './commonRequest'

export function doGet(url, params) {
    return request({
      url: url,
      method: 'get',
      params
    })
  }