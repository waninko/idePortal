<template>
  <div>
    <div class="selectedCat">SELECTED CATEGORY: {{selectedCategory}}</div>

    <h3>Projects in this category:</h3>
    <div v-for="(project, index) in allProjects" :key="index">
      <div v-if="selectedCategory==project.cat">
        <a :href="project.link">{{project.name}}</a>
      </div>
    </div>
  </div>
</template>

<script>
//litet preview bilde av proj. ved siden av linken?
//tell antall prosjekter i hver kategori
//send tallet til wordcloud, og bruk som value
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
              {name: "FlappyTerje 3",
              cat: "C#",
              link: "http://www.op.no"
             },
             {name: "Hello World of Javascript!",
              cat: "JS",
              link: "http://www.neopets.com"
             },
              {name: "Hello, plz work!",
              cat: "JS",
              link: "http://www.javascript.com"
             },
             {name: "Hey, vue-huu you :)",
              cat: "Vue",
              link: "https://vuejs.org/"
             },
             {name: "Hello Vue!",
              cat: "Vue",
              link: "https://vuejs.org/"
             },
             {name: "My VUE-BOT!",
              cat: "Vue",
              link: "https://vuejs.org/"
             },
             {name: "Test DB",
              cat: "SQL",
              link: "https://vg.no/"
             },
         ],
        categoriesAndCounters: [["JS", 0],
        ["C#",0],
        ["HTML/CSS", 0],
        ["Vue",0],
        ["SQL", 0],
        ["React", 0]] ,   
      }
  },
created() {
    this.categoryCounters()
     this.$emit("listToHome", this.categoriesAndCounters);
},
  methods: {
    categoryCounters(){
        for(let singleProject of this.allProjects){
            for(let category of this.categoriesAndCounters){
                if(singleProject.cat == category[0]) {
                    category[1]++
                }
            } 
        }
    }
}
}
</script>

<style scoped>
.selectedCat {
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
a:hover {
  color: orange;
}
</style>
