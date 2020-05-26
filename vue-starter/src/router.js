import Vue from "vue";
import Router from "vue-router";
import Home from "./views/Home.vue";
import Database from "./views/Database.vue";
import Storage from "./views/Storage.vue";
import Vm from "./views/Vm.vue";

Vue.use(Router);

export default new Router({
  mode: "history",
  base: process.env.BASE_URL,
  routes: [
    {
      path: "/",
      name: "home",
      component: Vm
    },
    {
      path: "/vm",
      name: "vm",
      component: Vm
    },
    {
      path: "/database",
      name: "database",
      component: Database
    },
    {
      path: "/storage",
      name: "storage",
      component: Storage
    },
    {
      path: "/about",
      name: "about",
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () =>
        import(/* webpackChunkName: "about" */ "./views/About.vue")
    }
  ]
});




