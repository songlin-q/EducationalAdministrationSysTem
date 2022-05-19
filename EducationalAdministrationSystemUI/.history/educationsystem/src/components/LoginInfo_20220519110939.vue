<template>
  <div style="width: 100%; height: 100%; background-color: black" id="bcdiv">
    <el-row
      class="row-bg"
      justify="space-evenly"
      align="middle"
      style="height: 100%"
    >
      <el-col :span="8"
        ><div class="grid-content bg-purple">
          <!-- 头像显示 -->
          <el-row>
            <el-col justify="space-evenly" style="width: 100%">
              <div class="demo-basic--circle">
                <div class="block">
                  <el-avatar :size="200" :src="circleUrl" />
                </div>
              </div>
            </el-col>
          </el-row>
          <!-- 用户名、密码输入框 -->
          <el-row style="width: 100%" justify="space-evenly">
            <el-form>
              <el-form-item label="用户名">
                <el-input placeholder="Please input" />
              </el-form-item>
              <el-form-item label="密码">
                <el-input placeholder="Please input" />
              </el-form-item>
            </el-form>
          </el-row>
          <!-- 按钮 -->
        </div></el-col
      >
    </el-row>
  </div>
</template>

<script>
export default {
  data() {
    return {
      longname: "张三",
      password: "123456",
    };
  },
};
</script>
<style scoped>
#bcdiv {
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
.demo-basic {
  text-align: center;
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
