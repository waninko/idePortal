<template>
  <div>
SELECTED CATEGORY: {{selectedCategory}}

<div v-for="(project, index) in allProjects" :key="index">
    <div v-if="selectedCategory==project.cat">
        <a :href=project.link>{{project.name}} </a>
    </div>
</div>

  </div>
</template>

<script>
//litet preview bilde av proj. ved siden av linken?
export default {
name: "ProjectList",
 props: {
    selectedCategory: String
  },
  data() {
      return {
         allProjects: [
             {name: "test",
              cat: "C#",
              link: "http://www.vg.no"
             },
             {name: "test2",
              cat: "C#",
              link: "http://www.op.no"
             },
             {name: "test3",
              cat: "JS",
              link: "http://www.neopets.com"
             },
         ] 
      }
  },
}
</script>

<style>

</style>
