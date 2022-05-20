<template>
  <h2 @click="">登录选项</h2>
</template>
<script>
import { useRoute, useRouter } from "vue-router";
export default {
  setup() {
    const route = useRoute();
    const router = useRouter();
    let clickPage = function () {
      router.push({
        path: "/Reedit",
      });
    };
    return {
      clickPage,
    };
  },
};
</script>
