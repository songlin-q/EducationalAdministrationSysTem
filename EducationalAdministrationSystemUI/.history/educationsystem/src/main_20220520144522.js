import Vue from 'vue'
import { createApp } from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'
import MainInfo from './components/MainInfo.vue'
import './assets/css/global.css'//引入全局样式表
import router from './router/index'


Vue.use(ElementUI, {
    size: Cookies.get('size') || 'medium', // set element-ui default size
    i18n: (key, value) => i18n.t(key, value)
});

router.beforeEach((to, from, next) => {
    /* 路由发生变化修改页面title */
    if (to.meta.title) {
        document.title = to.meta.title
    }
    next()
})


var app=createApp(MainInfo);
app.use(ElementPlus);
app.use(router);
app.mount('#app')


