
import request from '../utils/a'

export function doGet(url, params) {
    return request({
      url: url,
      method: 'get',
      params
    })
  }