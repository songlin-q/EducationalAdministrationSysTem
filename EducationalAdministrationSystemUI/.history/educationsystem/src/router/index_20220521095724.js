import { createWebHistory, createRouter,RootRecordRaw } from 'vue-router'//导入路由
import HelloWorld from '../components/HelloWorld.vue'
import MainInfo from '../components/MainInfo.vue'
import LoginInfo from '../components/LoginInfo.vue'
import MainOne from '../components/MainOne.vue'
//定义路由
const routes = [{
    path: '/',//组件一，path和component可以乱写，
                       //只要保持path与前面to，component和import两处相同即可
    component: LoginInfo,
    name:LoginInfo


},
{
    path: '/Reedit',//组件一，path和component可以乱写，
                       //只要保持path与前面to，component和import两处相同即可
    component: MainInfo,
    name:MainInfo,

},
{
    path: '/MainOne',//组件一，path和component可以乱写，
                       //只要保持path与前面to，component和import两处相同即可
    component: MainOne,
    name:MainOne,

}
]
const router = createRouter({
    history: createWebHistory(),
    routes
  })

  export default router