
import request from '/'

export function doGet(url, params) {
    return request({
      url: url,
      method: 'get',
      params
    })
  }