<template>
  <div >
      <AdminTop v-on:listChoice="showSelectedList"/>
    <Projects v-on:engage="editMode" v-if="projectListActive" />
    <Edit v-if="editModeActive"  :selectedProject=selectedProjectId v-on:editmodeOff="editMode"/>
    <Add v-if="addModeActive" />
    <Submissions v-if="submissionsActive" />
    <AdminAdministration v-if="administrateAdminsActive" />
  </div>
</template>

<script>
import AdminTop from "@/components/adminComponents/AdminTopPanel.vue"
import Projects from "@/components/adminComponents/AdminProjectList.vue"
import Edit from "@/components/adminComponents/AdminEditProject.vue"
import Add from "@/components/adminComponents/AdminAddProject.vue"
import Submissions from "@/components/adminComponents/AdminGetSubmissions.vue"
import AdminAdministration from "@/components/adminComponents/AdminAdministration.vue"

export default {
  name: "Admin",
  components: {
    AdminTop,
    Projects,
    Edit,
    Add,
    Submissions,
    AdminAdministration
  },
  data() {
      return {
          projectListActive: true,
          editModeActive: false,
          addModeActive: false,
          submissionsActive: false,
          administrateAdminsActive: false,
          selectedProjectId: "",
          
      }
  },
  methods: {
    showSelectedList(value){
      if(value == "projectList"){
         this.projectListActive = true
         this.submissionsActive = false
         this.administrateAdminsActive = false
         this.editModeActive = false
      }
      if(value == "submissions"){
         this.projectListActive = false
         this.submissionsActive = true
         this.administrateAdminsActive = false
         this.editModeActive = false
      }
       if(value == "administrateAdmins"){
         this.projectListActive = false
         this.submissionsActive = false
         this.administrateAdminsActive = true
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