<template>
  <div >
     <b-button variant="warning" to="/">Home</b-button>
    <h1>Submit Your Project</h1>
    <SubmitP />
  </div>
</template>

<script>
import SubmitP from "@/components/SubmitProject.vue"
//thanks for your submission hadde vært nice!

export default {
  name: "Submit",
  components: {
    SubmitP,
  },

};
</script>