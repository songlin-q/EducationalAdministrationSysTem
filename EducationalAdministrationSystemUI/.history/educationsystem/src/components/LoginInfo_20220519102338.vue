<template>
  <div style="width: 100%; height: 100%; background-color: black" id="backdiv">
    <el-row class="row-bg">
      <el-col :span="6"><div class="grid-content bg-purple" /></el-col>
      <el-col :span="6"><div class="grid-content bg-purple-light" /></el-col>
      <el-col :span="6"><div class="grid-content bg-purple" /></el-col>
    </el-row>
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
