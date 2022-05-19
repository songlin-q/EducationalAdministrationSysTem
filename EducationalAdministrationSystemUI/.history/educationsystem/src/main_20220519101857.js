
import { createApp } from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'
import './assets/css/global.css'

var app=createApp(App);
app.mount('#app')
app.use(ElementPlus);
