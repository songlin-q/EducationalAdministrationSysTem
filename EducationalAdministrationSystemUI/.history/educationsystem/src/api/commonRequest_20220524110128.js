
import request from '../utils/request'

export function doPost(url, data) {
    return request({
      url: url,
      method: 'post',
      data
    })
  }
  export function doGet(url, params) {
    return request({
      url: url,
      method: 'get',
      params
    })
  }