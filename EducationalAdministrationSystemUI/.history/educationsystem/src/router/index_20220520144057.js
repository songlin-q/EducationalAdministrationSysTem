import vue from 'vue'
import router, { RouterLink } from 'vue-router'
import MainInfo from '../components/MainInfo.vue';
import Mainone from '../components/MainOne.vue';
import Login from '../components/LoginInfo.vue';

vue.use(router);
const createRouter=()=>new Router({
    mode:'history',
    routes: [
        {
            path:'/',
            component:Login,
            name:Login
        },
        
    ]
})