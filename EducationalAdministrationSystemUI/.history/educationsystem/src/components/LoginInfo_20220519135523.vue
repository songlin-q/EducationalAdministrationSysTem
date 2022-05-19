<template>
  <div style="width: 100%; height: 100%" id="bcdiv">
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
              <el-form-item label="用户名" class="colors">
                <el-input v-model="longname" placeholder="Please input" />
              </el-form-item>
              <el-form-item label="密&nbsp;&nbsp;&nbsp;&nbsp;码" class="colors">
                <el-input
                  v-model="password"
                  placeholder="Please input"
                  show-password
                />
              </el-form-item>
              <!-- 按钮 -->
              <el-form-item>
                <el-button type="primary" @click="login">登录</el-button>

                <el-button @click="cancel">取消</el-button>
              </el-form-item>
              <el-form-item>
                如果你还没有账号请先<a href="#" @click="dialogVisible = true"
                  >注册</a
                >
              </el-form-item>
            </el-form>
          </el-row>
        </div></el-col
      >
    </el-row>
    <el-dialog
      v-model="dialogVisible"
      title="Tips"
      width="30%"
      :before-close="handleClose"
    >
      <span>This is a message</span>
      <template #footer>
        <span class="dialog-footer">
          <el-button @click="dialogVisible = false">Cancel</el-button>
          <el-button type="primary" @click="dialogVisible = false"
            >Confirm</el-button
          >
        </span>
      </template>
    </el-dialog>
  </div>
</template>

<script>
import logoUrl from "../assets/Head.jpg";
import { ref } from "vue";
export default {
  data() {
    return {
      longname: "张三",
      password: "123456",
      circleUrl: logoUrl,
      dialogVisible: ref(false),
    };
  },
  methods: {
    //登录方法
    login() {
      confirm("Are you sure to close this dialog?");
    },
    //取消方法
    cancel() {
      alert("你已经取消登录!");
    },
  },
};
</script>
<style>
#bcdiv {
  /* background-image: url(../assets/background.jpeg); */
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
.colors .el-form-item__label {
  color: black;
}
.demo-basic {
  text-align: center;
}
.el-row {
  margin-bottom: 1.25rem;
}
.el-row:last-child {
  margin-bottom: 0;
}
.el-col {
  border-radius: .25rem;
  /* background-color: antiquewhite; */
}

.bg-purple {
  height: 34.375rem;
}
.grid-content {
  border-radius: .25rem;
  min-height: 2.25rem;
}
</style>
