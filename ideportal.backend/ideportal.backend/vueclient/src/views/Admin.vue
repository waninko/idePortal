<template>
  <div >
      <AdminTop /> <button @click="subsOrCurrent()">See submissions / current projects</button>
    <h1>This is the Admin page (the view)</h1>
    <Projects v-on:engage="editMode" v-if="projectListActive" />
    <Edit v-if="editModeActive"  :selectedProject=selectedProjectId />
    <Add v-if="addModeActive" />
    <Submissions v-if="submissionsActive" />
  </div>
</template>

<script>
import AdminTop from "@/components/adminComponents/AdminTopPanel.vue"
import Projects from "@/components/adminComponents/AdminProjectList.vue"
import Edit from "@/components/adminComponents/AdminEditProject.vue"
import Add from "@/components/adminComponents/AdminAddProject.vue"
import Submissions from "@/components/adminComponents/AdminGetSubmissions.vue"

export default {
  name: "Admin",
  components: {
    AdminTop,
    Projects,
    Edit,
    Add,
    Submissions
  },
  data() {
      return {
          projectListActive: true,
          editModeActive: false,
          addModeActive: false,
          submissionsActive: false,
          selectedProjectId: ""
      }
  },
  methods: {
    subsOrCurrent(){
      this.projectListActive = !this.projectListActive
      this.submissionsActive = !this.submissionsActive
    },
    editMode(value){
      this.projectListActive = !this.projectListActive
      this.editModeActive = !this.editModeActive
      this.selectedProjectId = value
    },
    addMode(){
      this.projectListActive = !this.projectListActive
      this.addModeActive = !this.addModeActive
    }

  },
};
</script>