<template>
  <el-row>
    <el-col :span="24"
      ><div
        class="grid-content bg-purple-dark"
        id="header"
    /></el-col>
  </el-row>
  <el-row class="tac">
    <el-col :span="3">
      <h5 class="mb-2">教务管理后台系统</h5>
      <el-menu
        default-active="2"
        class="el-menu-vertical-demo"
        @open="handleOpen"
        @close="handleClose"
      >
        <el-sub-menu index="1">
          <template #title>
            <el-icon><location /></el-icon>
            <span>个人管理</span>
          </template>
        </el-sub-menu>
        <el-sub-menu index="2">
          <template #title>
            <el-icon><icon-menu /></el-icon>
            <span>权限管理</span>
          </template>
          <el-menu-item index="1-1">角色管理</el-menu-item>
          <el-menu-item index="1-2">用户管理</el-menu-item>
        </el-sub-menu>
        <el-menu-item index="3">
          <el-icon><document /></el-icon>
          <span>成绩管理</span>
        </el-menu-item>
        <el-menu-item index="4">
          <el-icon><setting /></el-icon>
          <span>公共管理</span>
        </el-menu-item>
      </el-menu>
    </el-col>
  </el-row>
</template>
<script>
import {
  Document,
  Menu as IconMenu,
  Location,
  Setting,
} from "@element-plus/icons-vue";
import { GetJwtStr } from "../api/api";
export default {
  data() {
    return {
      values: "",
    };
  },
  methods: {
    requestHttp() {
      GetJwtStr().then((res) => {
        alert(res.data);
      });
    },
  },
};
</script>
<style scoped>
* {
  margin: 0;
  padding: 0;
}
#header {
  background-color: aquamarine;
  height: 50px;
}
</style>