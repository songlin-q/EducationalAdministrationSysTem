<template>
  <h2 @click="clickPage">登录选项</h2>
</template>
<script>

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
};
</script>
