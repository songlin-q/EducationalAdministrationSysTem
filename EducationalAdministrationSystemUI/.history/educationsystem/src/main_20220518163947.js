/*
 * @Author: 松 覃 442534979@qq.com
 * @Date: 2022-05-18 16:23:14
 * @LastEditors: 松 覃 442534979@qq.com
 * @LastEditTime: 2022-05-18 16:39:47
 * @FilePath: \EducationalAdministrationSystemUI\educationsystem\src\main.js
 * @Description: 这是默认设置,请设置`customMade`, 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 */
import { createApp } from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'

var app=createApp(App);
app.mount('#app')
app.use(ElementPlus);
