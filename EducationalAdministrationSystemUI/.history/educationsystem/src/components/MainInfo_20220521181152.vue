<template>
  <h2 @click="clickPage">登录选项</h2>
</template>
<script>
import { getCurrentInstance } from "vue";
export default {
  methods: {
    clickpage() {
      let { proxy } = getCurrentInstance();
      console.log(proxy.$router);
      proxy.$router.push({
        path: "/HelloWorld",
      });
    },
  },
};
</script>
