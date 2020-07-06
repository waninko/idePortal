<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png" />
    <WordCloud v-on:cloudToHome="setSelected"/>
    <ProjectList :selectedCategory=selectedCatFromCloud />
  </div>
</template>

<script>
import WordCloud from "@/components/WordCloud.vue"
import ProjectList from "@/components/ProjectList.vue"


//catche selectedItem fra WordCloud - sende til ProjectList
export default {
  name: "Home",
  components: {
    WordCloud,
    ProjectList
  },
  data() {
    return {
      selectedCatFromCloud: ''
    }
  },
  methods: {
    setSelected(value){
      this.selectedCatFromCloud = value
    }
  },
};
</script>
