<template>
  <h2 @click="clickPage">登录选项</h2>
</template>
<script>

export default {
  setup() {
    //在vue3中没有this
   
    let clickPage = () => {
      console.log(proxy.$router);
      vuethis.$router.push({
        path: "/HelloWorld",
      });
    };
    return {
      clickPage,
    };
  },
};
</script>
