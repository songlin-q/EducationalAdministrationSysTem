<template>
  <h2 @click="clickPage">登录选项</h2>
</template>
<script>
import { getCurrentInstance } from "vue";
export default {
  setup() {
    let { proxy } = getCurrentInstance();
    let clickPage = () => {
      console.log(proxy);
      proxy.$router.push({
        path: "/MainOne",
      });
    };
    return {
      clickPage,
    };
  },
};
</script>
