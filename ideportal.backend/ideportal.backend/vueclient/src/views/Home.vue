<template>
  <div class="home">
    <img class="logo" src="../assets/logo.png" />
    <div>
    <b-button v-b-toggle.collapse-1 variant="warning">Submit a Project / Log in as Admin</b-button>
  <b-collapse id="collapse-1" class="mt-2">
    <b-card>
      <p class="card-text"> 
        <b-button variant="warning" to="/submit">Submit a new Project</b-button></p>
      <b-button variant="warning" v-b-toggle.collapse-1-inner size="sm">Are you an Admin?</b-button>
      <b-collapse id="collapse-1-inner" class="mt-2">
        <b-card><LoginPanel /></b-card>
      </b-collapse>
    </b-card>
  </b-collapse>
  </div>

    <WordCloud v-on:cloudToHome="setSelected" :categories=currentProjectCounts />
    <ProjectList v-on:listToHome="setProjectCountForCloud" :selectedCategory=selectedCatFromCloud />
    
  </div>
</template>

<script>
import WordCloud from "@/components/WordCloud.vue"
import ProjectList from "@/components/ProjectList.vue"
import LoginPanel from "@/components/LoginPanel.vue"


export default {
  name: "Home",
  components: {
    WordCloud,
    ProjectList,
    LoginPanel
  },
  data() {
    return {
      selectedCatFromCloud: '',
      currentProjectCounts: []
    }
  },
  methods: {
    setSelected(value){
      this.selectedCatFromCloud = value
    },
    setProjectCountForCloud(value){
      this.currentProjectCounts = value

    }
  },
};
</script>
<style scoped>
  .logo{
  position: absolute;
  left: 0px;
  top: 0px;
  z-index: -1;
  height: 25%;
  }
</style>