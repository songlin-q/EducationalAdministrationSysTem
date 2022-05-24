//公共模板方法
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
  // 导出Excel公用方法
export function exportMethod(url, data, filename) {
    return request({
        method: 'post',
        url: url,
        data,
        responseType: 'blob'
    }).then((res) => {
      console.log('文件开始处理')
      console.log(res)
  
        const link = document.createElement('a')
        const blob = new Blob([res], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' })// { type: 'application/vnd.ms-excel' })
        link.style.display = 'none'
        link.href = URL.createObjectURL(blob)
  
        // link.download = res.headers['content-disposition'] //下载后文件名
        link.download = filename // 下载的文件名
        document.body.appendChild(link)
        link.click()
        document.body.removeChild(link)
    }).catch(error => {
        this.$Notice.error({
            title: '错误',
            desc: '网络连接错误'
        })
        console.log(error)
    })
  }
  