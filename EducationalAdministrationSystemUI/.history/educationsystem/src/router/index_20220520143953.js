import vue from 'vue'
import router, { RouterLink } from 'vue-router'
import MainInfo from '../components/MainInfo.vue';
import Mainone from '../components/MainOne.vue';

vue.use(router);
const createRouter=()=>new Router({
    mode:'history',
    routes: [
        {
            path:'/'
        }
    ]
})