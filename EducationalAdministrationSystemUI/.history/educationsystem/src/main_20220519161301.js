
import { createApp } from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'
import './assets/css/global.css'//引入全局样式表
import { createWebHistory, createRouter } from 'vue-router'//导入路由

//定义路由
const routes = [{
    path: '/about_',//组件一，path和component可以乱写，
                       只要保持path与前面to，component和import两处相同即可
    component: Home
},
{
    path: '/about_us',
    component: About_us
},
]

————————————————
版权声明：本文为CSDN博主「愚且憨」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
原文链接：https://blog.csdn.net/weixin_61197471/article/details/122757896

const router = createRouter({
    history: createWebHistory(),
  })
var app=createApp(App);
app.mount('#app')
app.use(ElementPlus);
app.use(router);
