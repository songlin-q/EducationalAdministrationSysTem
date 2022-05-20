
import { createApp } from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'
import MainInfo from './components/MainInfo.vue'
import './assets/css/global.css'//引入全局样式表
import router from './routers'//导入路由
var app=createApp(MainInfo);
app.mount('#app')
app.use(ElementPlus);
app.use(router);
