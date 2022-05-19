<template>
  <div
    style="width: 100%; height: 800px; background-color: black"
    id="backdiv"
  ></div>
</template>

<script>
export default {
  data() {
    return {
      loginname: "张三",
      password: "123456",
    };
  },
};
</script>
<style scoped>
#backdiv{
  background-image: url(../);
}
</style>
