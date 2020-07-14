<template>
  <div >
    <router-link to="/">Back Home</router-link>
    <h1>This is the Submit Project page (the view)</h1>
    <SubmitP />
  </div>
</template>

<script>
import SubmitP from "@/components/SubmitProject.vue"


export default {
  name: "Submit",
  components: {
    SubmitP,
  },

};
</script>