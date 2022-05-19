<template>
  <el-form>
    <el-form-item label="用户名" class="colors">
      <el-input v-model="longname" placeholder="Please input" />
    </el-form-item>
    <el-form-item label="密&nbsp;&nbsp;&nbsp;&nbsp;码" class="colors">
      <el-input v-model="password" placeholder="Please input" show-password />
    </el-form-item>
    <el-form-item label="邮&nbsp;&nbsp;&nbsp;&nbsp;箱" class="colors">
      <el-input v-model="email" placeholder="Please input" />
    </el-form-item>
    <el-form-item label="手机号" class="colors">
      <el-input v-model="phone" placeholder="Please input" />
    </el-form-item>
    <el-form-item label="验证码" class="colors">
      <el-input v-model="regeditcode" placeholder="请输入验证码" />
      <span @click.stop="refreshCode" style="cursor: pointer">
        <SIdentify :identifyCode="identifyCode"></SIdentify>
      </span>
    </el-form-item>
  </el-form>
</template>
<script>
import logoUrl from "../assets/Head.jpg";
import { ref } from "vue";
import SIdentify from "../components/Identity/IdentityCode.vue";

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

      // 验证码规则
      identifyCodes: "3456789ABCDEFGHGKMNPQRSTUVWXY",
    };
  },
  components: {
    SIdentify,
  },
  methods: {
    //登录方法
    login() {
      if (this.identifyCode == this.code) {
        confirm("你需要进行登陆吗?");
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

    // 生成随机验证码
    makeCode(o, l) {
      for (let i = 0; i < l; i++) {
        this.identifyCode +=
          this.identifyCodes[
            Math.floor(Math.random() * (this.identifyCodes.length - 0) + 0)
          ];
      }
    },
  },
};
</script>
