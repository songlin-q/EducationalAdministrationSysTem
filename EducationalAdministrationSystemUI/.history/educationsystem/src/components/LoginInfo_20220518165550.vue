
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