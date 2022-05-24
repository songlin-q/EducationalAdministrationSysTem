<template>
  <div id="main">
    <el-container>
      <el-header> 教务管理后台系统 </el-header>
      <el-container>
        <el-aside style="width: 13%; height: 100%">
          <el-menu
            default-active="2"
            class="el-menu-vertical-demo"
            @open="handleOpen"
            @close="handleClose"
          >
            <el-sub-menu index="1">
              <template #title>
                <el-icon></el-icon>
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
              <el-icon></el-icon>
              <span>成绩管理</span>
            </el-menu-item>
            <el-menu-item index="4">
              <el-icon></el-icon>
              <span>公共管理</span>
            </el-menu-item>
          </el-menu>
        </el-aside>
        <el-main style="width:87%;height:100%">
          <router-view></router-view>
        </el-main>
      </el-container>
    </el-container>
  </div>
</template>
<script>
import {
  Document,
  Menu as IconMenu,
  Location,
  Setting,
} from "@element-plus/icons-vue";
export default {
  setup() {},
};
</script>
<style  scoped>
#main {
  width: 100%;

  height: 100%;

  position: absolute;
}
</style>
