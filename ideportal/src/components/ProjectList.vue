<template>
  <div>
SELECTED CATEGORY: {{selectedCategory}}

  <div v-for="(project, index) in allProjects" :key="index">
<div v-if="selectedCategory==project.cat">{{project.name}} </div>
  </div>

  </div>
</template>

<script>
//obj array m/category og proj name
//sil ut etter selected cat

export default {
name: "ProjectList",
 props: {
    selectedCategory: String
  },
  data() {
      return {
         allProjects: [
             {name: "test",
              cat: "C#"
             },
             {name: "test2",
              cat: "C#"
             },
             {name: "test3",
              cat: "JS"
             },
         ] 
      }
  },
}
</script>

<style>

</style>
