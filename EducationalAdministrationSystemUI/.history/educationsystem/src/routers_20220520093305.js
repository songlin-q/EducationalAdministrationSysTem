import { createWebHistory, createRouter } from 'vue-router'//导入路由
import HelloWorld from '@/components/HelloWorld.vue'
imp
//定义路由
const routes = [{
    path: '/Home',//组件一，path和component可以乱写，
                       //只要保持path与前面to，component和import两处相同即可
    component: HelloWorld
}
]
const router = createRouter({
    history: createWebHistory(),
    routes
  })

  export default router