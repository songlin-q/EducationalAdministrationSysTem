
import request from '../utils/'

export function doGet(url, params) {
    return request({
      url: url,
      method: 'get',
      params
    })
  }