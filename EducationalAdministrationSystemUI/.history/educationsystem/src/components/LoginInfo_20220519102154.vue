<template>
  <div style="width: 100%; height: 100%; background-color: black" id="backdiv">
    <div id="LoginMainDiv"></div>
  </div>
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
#backdiv {
  background-image: url(../assets/background.jpeg);
  width: 100%;
  height: 100%;
  position: fixed;
  background-size: 100% 100%;
}
#LoginMainDiv {
  width: 30%;
  height: 50%;
  background-color: aqua;
}
</style>
