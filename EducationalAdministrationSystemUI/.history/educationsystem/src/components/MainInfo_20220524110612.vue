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
      // this.$http
      //   .post("/api/Login/GetTokenInfo")
      //   .then((result) => {
      //     alert(result.data);
      //     console.log(result);
      //   })
      //   .catch((err) => {});

      GetStore_List().then((res) => {
        alert(res.data);
      });
    },
  },
};
</script>
