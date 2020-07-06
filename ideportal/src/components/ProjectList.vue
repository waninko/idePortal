<template>
  <div>
      <div class="selectedCat">SELECTED CATEGORY: {{selectedCategory}}</div>

 <h3>Projects in this category:</h3>
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
             {name: "C# Project 2",
              cat: "C#",
              link: "http://www.vg.no"
             },
             {name: "FlappyTerje",
              cat: "C#",
              link: "http://www.op.no"
             },
             {name: "Hello World of Javascript!",
              cat: "JS",
              link: "http://www.neopets.com"
             },
         ] 
      }
  },
}
</script>

<style scoped>
.selectedCat{
    font-size: 25px;
    font-weight: bold;
    color: orange;
    margin-bottom: 5%;
}
a {
    font-weight: bold;
    font-size: 20px;
    text-decoration: none;
}
a:hover{
    color: orange;
}
</style>
