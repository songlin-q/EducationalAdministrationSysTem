
import { createApp } from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'
import './assets/css/global.css'//引入全局样式表
import { createWebHistory, createRouter } from 'vue-router'//导入路由

//定义路由
const routes = [{
    path: '../src',//组件一，path和component可以乱写，
                       //只要保持path与前面to，component和import两处相同即可
    component: Home
}
]


const router = createRouter({
    history: createWebHistory(),
    routes
  })
var app=createApp(App);
app.mount('#app')
app.use(ElementPlus);
app.use(router);
