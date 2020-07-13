<template>
  <div >
      <AdminTop />
    <h1>This is the Admin page (the view)</h1>
    <Projects v-if="projectListActive" />
    <Edit v-if="editModeActive" />
    <Add v-if="addModeActive" />
  </div>
</template>

<script>
import AdminTop from "@/components/adminComponents/AdminTopPanel.vue"
import Projects from "@/components/adminComponents/AdminProjectList.vue"
import Edit from "@/components/adminComponents/AdminEditProject.vue"
import Add from "@/components/adminComponents/AdminAddProject.vue"


export default {
  name: "Admin",
  components: {
    AdminTop,
    Projects,
    Edit,
    Add
  },
  data() {
      return {
          projectListActive: true,
          editModeActive: false,
          addModeActive: false
      }
  },
};
</script>