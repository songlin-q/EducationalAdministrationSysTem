
import { createApp } from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'

var app=createApp(App);
app.mount('#app')
app.use(ElementPlus);
