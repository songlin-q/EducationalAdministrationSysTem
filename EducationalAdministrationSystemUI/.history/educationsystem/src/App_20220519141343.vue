<template>
 <span @click="refreshCode" style="cursor: pointer;">
  <s-identify :identifyCode="identifyCode" ></s-identify>
 </span>
</template>
 
<script>
// 引入图片验证码组件
import SIdentify from '@/components/identify'
export default {
 components: { SIdentify },
 data() {
  return {
   // 图片验证码
   identifyCode: '',
   // 验证码规则
   identifyCodes: '3456789ABCDEFGHGKMNPQRSTUVWXY',
  }
 },
 methods: {
  // 切换验证码
     refreshCode() {
   this.identifyCode = ''
   this.makeCode(this.identifyCodes, 4)
     },
  // 生成随机验证码
  makeCode(o, l) {
    for (let i = 0; i &lt; l; i++) {
      this.identifyCode += this.identifyCodes[
        Math.floor(Math.random() * (this.identifyCodes.length - 0) + 0)
      ]
    }
  },
 }
}
</script>