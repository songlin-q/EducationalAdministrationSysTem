<!--
 * @Author: 松 覃 442534979@qq.com
 * @Date: 2022-05-18 16:41:38
 * @LastEditors: 松 覃 442534979@qq.com
 * @LastEditTime: 2022-05-18 16:43:47
 * @FilePath: \EducationalAdministrationSystemUI\educationsystem\src\components\LoginInfo.vue
 * @Description: 这是默认设置,请设置`customMade`, 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
-->
<template>
  <el-button :plain="true" @click="open">Show message</el-button>

  <el-button :plain="true" @click="openVn">VNode</el-button>
</template>

<script setup>
import { h } from "vue";
import { ElMessage } from "element-plus";

const open = () => {
  ElMessage("直接测试数据");
};

const openVn = () => {
  ElMessage({
    message: h("p", null, [
      h("span", null, "确实要进行测试的数据"),
      h("i", { style: "color: teal" }, "VNode"),
    ]),
  });
};
</script>