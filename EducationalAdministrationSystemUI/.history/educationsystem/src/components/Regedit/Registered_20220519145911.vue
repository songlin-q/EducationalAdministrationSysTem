<template>
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
import { defineComponent } from '@vue/composition-api'

export default defineComponent({
    setup() {
        
    },
})
</script>
