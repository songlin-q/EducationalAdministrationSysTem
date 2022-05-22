<template>
  <h2 @click="clickpage">登录选项</h2>
</template>
<script>
import { getCurrentInstance } from "vue";
export default {
  methods: {
          let { proxy } = getCurrentInstance();
    clickpage() {

      console.log(proxy.$router);
      proxy.$router.push({
        path: "/HelloWorld",
      });
    },
  },
};
</script>
