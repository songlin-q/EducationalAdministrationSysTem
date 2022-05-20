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
              <el-form-item label="验证码" class="colors">
                <el-input v-model="code" placeholder="请输入验证码" />
                <span @click.stop="refreshCode" style="cursor: pointer">
                  <s-identify :identifyCode="identifyCode"></s-identify>
                </span>
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
          <!-- <router-link to="/Reedit">首页</router-link>
          <router-view></router-view> -->
        </div></el-col
      >
    </el-row>
    <el-dialog
      v-model="dialogVisible"
      title="注册"
      width="30%"
      :before-close="handleClose"
    >
      <span>
        <el-form :model="userInfo">
          <el-form-item label="用户名" class="colors">
            <el-input v-model="userInfo.username" placeholder="Please input" />
          </el-form-item>
          <el-form-item label="密&nbsp;&nbsp;&nbsp;&nbsp;码" class="colors">
            <el-input
              v-model="userInfo.userPassword"
              placeholder="Please input"
              show-password
            />
          </el-form-item>
          <el-form-item label="邮&nbsp;&nbsp;&nbsp;&nbsp;箱" class="colors">
            <el-input v-model="userInfo.userEmail" placeholder="Please input" />
          </el-form-item>
          <el-form-item label="手机号" class="colors">
            <el-input v-model="userInfo.userTel" placeholder="Please input" />
          </el-form-item>
          <el-form-item label="验证码" class="colors">
            <el-input v-model="userInfo.userCode" placeholder="请输入验证码" />
            <span @click.stop="refreshCode2" style="cursor: pointer">
              <SIdentify2 :identifyCode="regeditidentifyCode"></SIdentify2>
            </span>
          </el-form-item>
        </el-form>
      </span>
      <template #footer>
        <span class="dialog-footer">
          <el-button @click="dialogVisible = false">取消</el-button>
          <el-button type="primary" @click="regeditsFun">注册</el-button>
        </span>
      </template>
    </el-dialog>
  </div>
</template>

<script>
import logoUrl from "../assets/Head.jpg";
import { ref } from "vue";
import { useRoute, useRouter } from "vue-router";
//这里验证码的组件使用的最笨的方法，后续优化的话可以只使用一个组件，将ID传入到父组件中就可以了
import SIdentify from "../components/Identity/IdentityCode.vue";
import SIdentify2 from "../components/Identity/IdentityCode2.vue";
export default {
  data() {
    return {
      longname: "张三",
      password: "123456",
      email: "442534979@qq.com",
      code: "",
      regeditcode: "",
      circleUrl: logoUrl,
      phone: "15356479454",
      dialogVisible: ref(false), //弹出层的使用
      // 图片验证码

      identifyCode: "8Hy0", //默认值
      regeditidentifyCode: "u8y7", //注册验证码
      // 验证码规则
      identifyCodes: "3456789ABCDEFGHGKMNPQRSTUVWXY",
      //创建一个用户类
      userInfo: {
        username: "李四",
        userTel: "18737890098",
        userEmail: "18737890098@q63.com",
        userCode: "",
        userPassword: "lisi",
      },
    };
  },
  setup() {
    const route = useRoute();
    const router = useRouter();
    let cilec=function(){
       router.push({
        path:"/Reedit"

       })

    }
    return {
      msg,
      
    }
  },
  components: {
    SIdentify,
    SIdentify2,
  },
  methods: {
    //登录方法
    login() {
      if (this.identifyCode.toLowerCase() == this.code.toLowerCase()) {
        this.$router.push({
          path: "/Reedit",
        });
      } else {
        alert("你输入的验证码不正确!");
      }
    },
    //取消方法
    cancel() {
      alert("你已经取消登录!");
    },
    // 切换验证码
    refreshCode() {
      this.identifyCode = "";

      this.makeCode(this.identifyCodes, 4);
    },
    refreshCode2() {
      this.regeditidentifyCode = "";

      this.makeCode2(this.identifyCodes, 4);
    },
    // 生成随机验证码
    makeCode(o, l) {
      for (let i = 0; i < l; i++) {
        this.identifyCode +=
          this.identifyCodes[
            Math.floor(Math.random() * (this.identifyCodes.length - 0) + 0)
          ];
      }
    },
    makeCode2(o, l) {
      for (let i = 0; i < l; i++) {
        this.regeditidentifyCode +=
          this.identifyCodes[
            Math.floor(Math.random() * (this.identifyCodes.length - 0) + 0)
          ];
      }
    },

    //注册方法
    regeditsFun() {
      alert("你已经在注册了");
      this.dialogVisible = false;
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
  border-radius: 0.25rem;
  /* background-color: antiquewhite; */
}

.bg-purple {
  height: 34.375rem;
}
.grid-content {
  border-radius: 0.25rem;
  min-height: 2.25rem;
}
</style>
