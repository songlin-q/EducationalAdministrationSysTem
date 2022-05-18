<template>
  <div v-loading="loading" element-loading-text="登录中..." element-loading-spinner="el-icon-loading" element-loading-background="rgba(0, 0, 0, 0.6)" class="login-container">
 
    <el-form ref="loginForm" :model="loginForm" :rules="loginRules" class="login-form" auto-complete="on" label-position="left">
      <!-- 头像区域 -->
      <div v-if="TxStatus" class="avatar-box">
        <img src="../../assets/background.jpg" alt="">
      </div>
 
      <div class="title-container">
        <h3 class="title">后台管理系统</h3>
      </div>
 
      <el-form-item prop="username">
        <span class="svg-container">
          <svg-icon icon-class="user" />
        </span>
        <el-input ref="username" v-model="loginForm.username" placeholder="Username" name="username" type="text" tabindex="1" auto-complete="on" />
      </el-form-item>
 
      <el-form-item prop="password">
        <span class="svg-container">
          <svg-icon icon-class="password" />
        </span>
        <el-input :key="passwordType" ref="password" v-model="loginForm.password" :type="passwordType" placeholder="Password" name="password" tabindex="2" auto-complete="on" @keyup.enter.native="handleLogin" />
        <span class="show-pwd" @click="showPwd">
          <svg-icon :icon-class="passwordType === 'password' ? 'eye' : 'eye-open'" />
        </span>
      </el-form-item>
      <div>
        <el-button type="primary" style="width:100%;margin-bottom:20px;" @click.native.prevent="handleLogin">登录</el-button>
      </div>
      <div class="tips">
        <span style="margin-right:20px;">如果您还没有账号请先 <span style="color:#409EFF;cursor:pointer" @click="register">注册</span></span>
      </div>
 
    </el-form>
  </div>
</template>
 
<script>
// 引入去除空格工具
import { validUsername } from '@/utils/validate'
 
export default {
  name: 'Login',
  data() {
    const validateUsername = (rule, value, callback) => {
      if (!validUsername(value)) {
        callback(new Error('用户名不能为空！'))
      } else {
        callback()
      }
    }
    const validatePassword = (rule, value, callback) => {
      if (value.length < 6) {
        callback(new Error('密码最少为6位字符！'))
      } else {
        callback()
      }
    }
    return {
      // 头像状态
      TxStatus: true,
      loginForm: {
        username: '',
        password: ''
      },
      // 登录规则
      loginRules: {
        username: [{ required: true, trigger: 'blur', validator: validateUsername }],
        password: [{ required: true, trigger: 'blur', validator: validatePassword }]
      },
      loading: false,
      passwordType: 'password',
      redirect: undefined
    }
  },
  watch: {
    $route: {
      handler: function(route) {
        this.redirect = route.query && route.query.redirect
      },
      immediate: true
    }
  },
  methods: {
    showPwd() {
      if (this.passwordType === 'password') {
        this.passwordType = ''
      } else {
        this.passwordType = 'password'
      }
      this.$nextTick(() => {
        this.$refs.password.focus()
      })
    },
    // 登录业务
    handleLogin() {
      this.$refs.loginForm.validate((valid) => {
        // 如果符合验证规则
        if (valid) {
          this.loading = true
          setTimeout(() => {
            this.$store.dispatch('user/login', this.loginForm).then(() => {
              this.$router.push({ path: this.redirect || '/' })
              this.loading = false
            }).catch(() => {
              this.loading = false
            })
          }, 1500)
        } else {
          console.log('error submit!!')
          return false
        }
      })
    },
    // 注册业务
    register() {
      console.log('123')
      this.$router.push({ name: 'register' })
    }
  }
}
</script>
 
