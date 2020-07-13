import Vue from "vue"
import VueRouter from "vue-router"
import Home from "../views/Home.vue"
import Admin from "../views/Admin.vue"
import Submit from "../views/Submit.vue"

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home
  },
  {
    path: "/about",
    name: "About",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: function() {
      return import(/* webpackChunkName: "about" */ "../views/About.vue");
    }
  },
  {
    path: "/admin",
    name: "Admin",
    component: Admin
  },
  {
    path:"/submit",
    name: "Submit",
    component: Submit
  }
];

const router = new VueRouter({
  routes
});

export default router;
