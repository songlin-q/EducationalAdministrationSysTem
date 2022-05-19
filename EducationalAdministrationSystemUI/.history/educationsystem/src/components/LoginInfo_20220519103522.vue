<template>
  <div style="width: 100%; height: 100%; background-color: black" id="backdiv">
    <el-row
      class="row-bg"
      justify="space-evenly"
      align="middle"
      style="height: 100%"
    >
      <el-col :span="8"><div class="grid-content bg-purple">
        <!-- 头像显示 -->
        </div></el-col>
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
.el-row {
  margin-bottom: 20px;
}
.el-row:last-child {
  margin-bottom: 0;
}
.el-col {
  border-radius: 4px;
  background-color: antiquewhite;
}
.bg-purple {
  height: 500px;
}
.grid-content {
  border-radius: 4px;
  min-height: 36px;
}
</style>
