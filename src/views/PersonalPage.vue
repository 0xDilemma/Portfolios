<template>
<section id="app">
<div class="container-lg">
    <div class="row">
    <!-- Sidebar -->
    <div class="col-2">
        <Sidebar />
    </div>

    <!-- 內容區塊 -->
    <div class="col-10">
        <section id="talent-info-container">
        <router-view></router-view>
        </section>
    </div>
    </div>
</div>
</section>
</template>

<script>
import { onMounted } from 'vue'
import { useStore } from 'vuex'
import Sidebar from '@/components/Sidebar.vue'

export default {
name: 'PersonalPage',
components: {
Sidebar
},
setup() {
const store = useStore()

onMounted(async () => {
    await store.dispatch('user/fetchUser')
})

return {}
}
}
</script>

<style>
@import '@/assets/styles/profile/sidebar.css';
@import '@/assets/styles/profile/main.css';
@import '@/assets/styles/profile/profile.css';
@import '@/assets/styles/profile/freelancer.css';
@import '@/assets/styles/profile/freelancerProfile.css';
@import '@/assets/styles/profile/poster.css';
@import '@/assets/styles/profile/case-management.css';
@import '@/assets/styles/profile/message-interface.css';
@import '@/assets/styles/profile/changePassword.css';
</style> 