
import { createApp } from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'
import './assets/css/global.css'//引入全局样式表
import { createWebHistory, createRouter } from 'vue-router'//导入路由

var app=createApp(App);
app.mount('#app')
app.use(ElementPlus);
app.
