<template>
  <h2 @click="clickPage">登录选项</h2>
</template>
<script>
import { useRoute, useRouter } from "vue-router";
export default {
  setup() {
    let clickPage = function () {
      this.$router.push({
        path: "/MainOne",
      });
    };
    return {
      clickPage,
    };
  },
};
</script>
