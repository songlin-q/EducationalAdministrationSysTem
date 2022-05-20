import Vue from 'vue'
import ElementPlus from 'element-plus'
import 'element-plus/dist/index.css'
import App from './App.vue'
import MainInfo from './components/MainInfo.vue'
import './assets/css/global.css'//引入全局样式表
import router from './router/index'

router.beforeEach((to, from, next) => {
    /* 路由发生变化修改页面title */
    if (to.meta.title) {
        document.title = to.meta.title
    }
    next()
})

Vue.config.productionTip = false

new Vue({
    router,
    render: h => h(MainInfo)
}).$mount('#app')



