<template>
  <div >
      <AdminTop v-on:listChoice="showSelectedList"/>
    <h1>This is the Admin page (the view)</h1>
    <Projects v-on:engage="editMode" v-if="projectListActive" />
    <Edit v-if="editModeActive"  :selectedProject=selectedProjectId v-on:editmodeOff="editMode"/>
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
          selectedProjectId: "",
          active: "See Submissions"
      }
  },
  methods: {
    showSelectedList(value){
      if(value == "projectList"){
         this.projectListActive = true
         this.submissionsActive = false
         this.editModeActive = false
      }
      if(value == "submissions"){
         this.projectListActive = false
         this.submissionsActive = true
         this.editModeActive = false
      }
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