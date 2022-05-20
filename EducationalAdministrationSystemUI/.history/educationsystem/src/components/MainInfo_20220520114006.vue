<template>
  <h2 @click="clickPage">登录选项</h2>
</template>
<script>
export default {
  setup() {
    let clickPage = () => {
      const that = this;
      console.log(that.$router);
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
