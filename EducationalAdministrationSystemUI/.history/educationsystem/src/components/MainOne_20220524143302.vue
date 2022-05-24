<template>
  <div class="main" style="height: 100vh">
    <el-container>
      <el-header> yy </el-header>
      <el-container>
        <el-aside width="200px">
          <el-menu
            :default-active="$route.path"
            class="el-menu-vertical-demo"
            @open="handleOpen"
            @close="handleClose"
            @select="handleSelect_2"
            router
          >
            <el-submenu index="1">
              <template #title>
                <i class="el-icon-menu"></i>
                <span>问卷管理</span>
              </template>
              <el-menu-item-group>
                <el-menu-item index="/main/wenjuanlist">
                  <i class="el-icon-menu"></i>
                  问卷设计
                </el-menu-item>
                <el-menu-item index="/main/wenjuanlist">
                  <i class="el-icon-menu"></i>
                  问卷分配
                </el-menu-item>
              </el-menu-item-group>
            </el-submenu>
            <el-submenu index="2">
              <template #title>
                <i class="el-icon-menu"></i>
                <span>我的问卷</span>
              </template>
              <el-menu-item-group>
                <el-menu-item index="/main/RenList">
                  <i class="el-icon-menu"></i>
                  自测问卷
                </el-menu-item>
                <el-menu-item index="/main/RenLists">
                  <i class="el-icon-menu"></i>
                  互评问卷
                </el-menu-item>
              </el-menu-item-group>
            </el-submenu>
            <el-menu-item index="">
              <i class="el-icon-menu"></i>
              <span title>问卷设计</span>
            </el-menu-item>
            <el-menu-item index="2">
              <i class="el-icon-menu"></i>
              <span title> 人才库</span>
            </el-menu-item>
            <el-menu-item index="3">
              <i class="el-icon-document"></i>
              <span title>代理招聘</span>
            </el-menu-item>
            <el-menu-item index="/main/home">
              <i class="el-icon-setting"></i>
              <span title>手机版主页</span>
            </el-menu-item>
            <el-menu-item index="5">
              <i class="el-icon-setting"></i>
              <span title>企业账户</span>
            </el-menu-item>
          </el-menu>
        </el-aside>
        <el-main>
          <router-view></router-view>
        </el-main>
      </el-container>
    </el-container>
  </div>
</template>

<script>
export default {
  name: "main",
  data() {
    return {};
  },

  methods: {},
};
</script>

<style scoped>
.el-header,
.el-footer {
  background-color: #409eff;
  color: #333;
  text-align: center;
  line-height: 80px;
}

.el-aside {
  background-color: #d3dce6;
  color: #333;
  text-align: left;
  line-height: 200px;
}

.el-main {
  background-color: #e9eef3;
  color: #333;
  /* text-align: center;
        line-height: 160px; */
}
</style>