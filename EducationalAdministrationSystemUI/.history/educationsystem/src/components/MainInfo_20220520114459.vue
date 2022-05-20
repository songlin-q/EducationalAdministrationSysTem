<template>
  <h2 @click="clickPage">登录选项</h2>
</template>
<script>
import { useRoute, useRouter } from "vue-router";
export default {
  setup() {
    let clickPage = () => {
      const route = useRoute();
      const router = useRouter();
      console.log(that);
      that.$router.push({
        path: "/MainOne",
      });
    };
    return {
      clickPage,
    };
  },
};
</script>
