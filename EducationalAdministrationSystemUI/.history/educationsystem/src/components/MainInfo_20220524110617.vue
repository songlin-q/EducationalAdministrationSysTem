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
      GetJwtStr().then((res) => {
        alert(res.data);
      });
    },
  },
};
</script>
