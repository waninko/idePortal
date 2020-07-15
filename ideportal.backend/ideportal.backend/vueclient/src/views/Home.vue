<template>
  <div class="home">
    <LoginPanel />
    <img alt="Portal Logo" src="../assets/logo.png" />
    <WordCloud v-on:cloudToHome="setSelected" :categories=currentProjectCounts />
    <ProjectList v-on:listToHome="setProjectCountForCloud" :selectedCategory=selectedCatFromCloud />
     <router-link to="/submit">Submit a new Project</router-link>
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
