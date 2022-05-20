import Vue from 'vue'
import Router from 'vue-router'
import MainInfo from '../components/MainInfo.vue';
import Mainone from '../components/MainOne.vue';
import Login from '../components/LoginInfo.vue';

Vue.use(MainInfo);
const createRouter=()=>new Router({
    mode:'history',
    routes: [
        {
            path:'/',
            component:Login,
            name:Login
        },
        {
            path:'/MainInfo',
            component:MainInfo,
            name:MainInfo
        },
        {
            path:'/Mainone',
            component:Mainone,
            name:Mainone
        }

    ]
})

const router=createRouter();

export default router;