import axios from 'axios'

export default {
  namespaced: true,
  
  state: {
    user: {
      FuserId: null,
      FidNumber: null,
      FfullName: null,
      FcompanyNumber: null,
      Femail: null,
      FphoneNumber: null,
      Faddress: null,
      Fbirthday: null,
      Fgender: null,
      FprofileImageUrl: null,
      FisEmailVerified: null,
      FcreatedAt: null,
      FloginType: null
    }
  },

  mutations: {
    SET_USER(state, user) {
      state.user = user
    },
    UPDATE_USER(state, userData) {
      state.user = { ...state.user, ...userData }
    }
  },

  actions: {
    async fetchUser({ commit }) {
      try {
        const response = await axios.get("/ProfileManage/GetUser")
        if (response.data.User) {
          commit('SET_USER', {
            FuserId: response.data.User.FuserId || null,
            FidNumber: response.data.User.FidNumber || null,
            FfullName: response.data.User.FfullName || null,
            FcompanyNumber: response.data.User.FcompanyNumber || null,
            Femail: response.data.User.Femail || null,
            FphoneNumber: response.data.User.FphoneNumber || null,
            Faddress: response.data.User.Faddress || null,
            Fbirthday: response.data.User.Fbirthday || null,
            Fgender: response.data.User.Fgender || null,
            FprofileImageUrl: getProfileImageUrl(response.data.User),
            FisEmailVerified: response.data.User.FisEmailVerified || null,
            FcreatedAt: response.data.User.FcreatedAt || null,
            FloginType: response.data.User.FloginType || null
          })
        }
      } catch (error) {
        console.error("獲取會員資料失敗:", error)
      }
    },

    async updateUser({ commit }, userData) {
      try {
        const response = await axios.put("/ProfileManage/UpdateUser", userData)
        if (response.data.success) {
          commit('UPDATE_USER', userData)
          return { success: true }
        }
        return { success: false, message: response.data.message }
      } catch (error) {
        console.error("更新會員資料失敗:", error)
        return { success: false, message: error.response?.data?.message || "更新失敗" }
      }
    },

    async uploadImage({ commit }, formData) {
      try {
        const response = await axios.post("/ProfileManage/UploadImage", formData)
        if (response.data.imageUrl) {
          commit('UPDATE_USER', {
            FprofileImageUrl: getProfileImageUrl({ 
              FuserId: state.user.FuserId,
              FprofileImageUrl: response.data.imageUrl
            })
          })
          return { success: true }
        }
        return { success: false }
      } catch (error) {
        console.error("上傳圖片失敗:", error)
        return { success: false }
      }
    }
  },

  getters: {
    user: state => state.user,
    formattedDate: state => {
      if (!state.user.FcreatedAt) return "未提供"
      return dayjs(state.user.FcreatedAt).format("YYYY-MM-DD")
    }
  }
}

// 輔助函數
function getProfileImageUrl(user) {
  if (!user || !user.FprofileImageUrl) {
    return null
  }
  return `/uploads/Profile/${user.FprofileImageUrl}`
} 