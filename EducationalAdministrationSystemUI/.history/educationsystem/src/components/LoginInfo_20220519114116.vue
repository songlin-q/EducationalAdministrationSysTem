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
          <el-row style="width: 100%" justify="space-evenly">
            <h1>教务管理后台系统</h1>
          </el-row>
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
              <el-form-item>
                <span>
                  <span style="color: red">用户名</span>
                  <span style="color: red">*</span>
                </span>
                <el-input v-model="longname" placeholder="Please input" />
              </el-form-item>
              <el-form-item label="密&nbsp;&nbsp;&nbsp;&nbsp;码">
                <el-input
                  v-model="password"
                  placeholder="Please input"
                  show-password
                />
              </el-form-item>
              <!-- 按钮 -->
              <el-form-item>
                <el-button type="primary">登录</el-button>

                <el-button>取消</el-button>
              </el-form-item>
              <el-form-item>
                如果你还没有账号请先<a href="#">注册</a>
              </el-form-item>
            </el-form>
          </el-row>
        </div></el-col
      >
    </el-row>
  </div>
</template>

<script>
import logoUrl from "../assets/Head.jpg";
export default {
  data() {
    return {
      longname: "张三",
      password: "123456",
      circleUrl: logoUrl,
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
  /* background-color: antiquewhite; */
}
.bg-purple {
  height: 550px;
}
.el-form-item {
  color: black;
}
.grid-content {
  border-radius: 4px;
  min-height: 36px;
}
</style>
