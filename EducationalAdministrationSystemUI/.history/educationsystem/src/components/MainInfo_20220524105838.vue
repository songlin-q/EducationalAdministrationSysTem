<template>
  <h2 @click="requestHttp">登录选项</h2>
</template>
<script>
import { GetJwtStr } from "../api/api";
export default {
  data() {
    return {
      values: "",
    };
  },
  methods: {
    requestHttp() {
      alert("测试");

      // this.$http
      //   .post("/api/Login/GetTokenInfo")
      //   .then((result) => {
      //     alert(result.data);
      //     console.log(result);
      //   })
      //   .catch((err) => {});

      GetJwtStr().then((res) => {
        alert(res);
      });
    },
  },
};
</script>
