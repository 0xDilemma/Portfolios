<template>
  <section class="talent-sidebar-container">
    <div class="card">
      <div class="card-header">會員編號：{{ user.FuserId }}</div>
      <div class="member-avatar">
        <!-- 頭貼為空值顯示預設Icon -->
        <div class="avatar-icon" v-if="!user.FprofileImageUrl">
          <i class="bi bi-person"></i>
          <div class="overlay">更換頭貼</div>
          <input 
            type="file" 
            class="file-input" 
            @change="handleImageUpdate" 
            accept="image/png, image/jpeg, image/jpg, image/gif"
          >
        </div>
        <!-- 顯示自己本身Icon -->
        <div class="avatar-icon" v-else>
          <img :src="user.FprofileImageUrl" />
          <div class="overlay">更換頭貼</div>
          <input 
            type="file" 
            class="file-input" 
            @change="handleImageUpdate" 
            accept="image/png, image/jpeg, image/jpg, image/gif"
          >
        </div>
        <div class="member-name">{{ user.FfullName }}</div>
      </div>
      <ul class="sidebar-nav list-group list-group-flush">
        <router-link to="/">
          <li class="list-group-item">主頁</li>
        </router-link>
        <router-link to="/profile">
          <li class="list-group-item">個人資料</li>
        </router-link>
        <router-link to="/freelancerprofile">
          <li class="list-group-item">工作坊</li>
        </router-link>
        <router-link to="/freelancer">
          <li class="list-group-item">接案管理</li>
        </router-link>
        <router-link to="/poster">
          <li class="list-group-item">提案管理</li>
        </router-link>
        <router-link to="/message">
          <li class="list-group-item">訊息管理</li>
        </router-link>
        <router-link to="/change-password" v-if="user.FloginType === 'Local'">
          <li class="list-group-item">修改信箱/密碼</li>
        </router-link>
      </ul>
    </div>
  </section>
</template>

<script>
import { computed } from 'vue'
import { useStore } from 'vuex'

export default {
  name: 'Sidebar',
  setup() {
    const store = useStore()
    const user = computed(() => store.getters['user/user'])

    const handleImageUpdate = async (event) => {
      const file = event.target.files[0]
      if (!file) return

      // 允許的檔案類型
      const allowedTypes = ["image/png", "image/jpeg", "image/jpg", "image/gif"]
      const allowedExtensions = [".png", ".jpeg", ".jpg", ".gif"]

      // 檢查 MIME 類型
      if (!allowedTypes.includes(file.type)) {
        alert("請選擇正確的圖片格式（PNG, JPG, JPEG, GIF）")
        return
      }

      // 檢查副檔名
      const fileExtension = file.name.slice(file.name.lastIndexOf(".")).toLowerCase()
      if (!allowedExtensions.includes(fileExtension)) {
        alert("檔案格式錯誤！請上傳 PNG, JPG, JPEG, GIF")
        return
      }

      const formData = new FormData()
      formData.append("file", file)

      // 傳遞舊的圖片路徑給後端
      if (user.value.FprofileImageUrl) {
        formData.append("oldImageUrl", user.value.FprofileImageUrl)
      }

      const result = await store.dispatch('user/uploadImage', formData)
      if (!result.success) {
        alert("頭像上傳失敗")
      }
    }

    return {
      user,
      handleImageUpdate
    }
  }
}
</script> 