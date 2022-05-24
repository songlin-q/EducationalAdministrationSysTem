
import { createApp } from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import axios from 'axios'
import App from './App.vue'
import './assets/css/global.css'//引入全局样式表
import Router from './router/index'

axios.defaults.

var app=createApp(App);
app.use(ElementPlus);
app.use(Router);
app.mount('#app')


