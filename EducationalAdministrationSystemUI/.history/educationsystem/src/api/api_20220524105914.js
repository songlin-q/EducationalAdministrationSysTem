
import request from '../utils/request'

export function doGet(url, params) {
    return request({
      url: url,
      method: 'get',
      params
    })
  }