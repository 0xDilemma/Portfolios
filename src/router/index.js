import { createRouter, createWebHistory } from 'vue-router'
import PersonalPage from '@/views/PersonalPage.vue'
import Home from '@/components/Home.vue'
import Profile from '@/components/Profile.vue'
import Freelancer from '@/components/Freelancer.vue'
import FreelancerProfile from '@/components/FreelancerProfile.vue'
import Poster from '@/components/Poster.vue'
import ChangePassword from '@/components/ChangePassword.vue'
import Message from '@/components/Message.vue'

const routes = [
  {
    path: '/',
    component: PersonalPage,
    children: [
      {
        path: '',
        name: 'Home',
        component: Home
      },
      {
        path: 'profile',
        name: 'Profile',
        component: Profile
      },
      {
        path: 'freelancer',
        name: 'Freelancer',
        component: Freelancer
      },
      {
        path: 'freelancerprofile',
        name: 'FreelancerProfile',
        component: FreelancerProfile
      },
      {
        path: 'poster',
        name: 'Poster',
        component: Poster
      },
      {
        path: 'change-password',
        name: 'ChangePassword',
        component: ChangePassword
      },
      {
        path: 'message',
        name: 'Message',
        component: Message
      }
    ]
  }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router 