<template>
  <h2 @click="requestHttp">登录选项</h2>
</template>
<script>
import { getCurrentInstance } from "vue";
import { GetJwtStr } from "../api/request";
export default {
  setup() {
    //在vue3中没有this
    let { proxy } = getCurrentInstance();
    let clickPage = () => {
      console.log(proxy.$router);
      proxy.$router.push({
        path: "/HelloWorld",
      });
    };
    return {
      clickPage,
    };
  },
  data() {
    return {
      values: "",
    };
  },
  methods: {
    requestHttp() {
      alert("测试");
      const jwtstr = GetJwtStr();
      GetJwtStr().then((res) => {
        alert(res.data);
      });
    },
  },
};
</script>
