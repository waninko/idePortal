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
   // import api from '@/ProjectApiService'
    import axios from 'axios'

//litet preview bilde av proj. ved siden av linken?
export default {
name: "ProjectList",
 props: {
    selectedCategory: String
  },
  data() {
      return {
          //her axios'er vi inn fra APIet - behandler data i front? eller sorterer ferdig i back?
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
        
          catsFromDB: [],
        apiTest:[]
      }
  },
        created() {
    this.getAll()
    this.categoryCounters()
     this.$emit("listToHome", this.categoriesAndCounters);
},
  methods: {
      //om ingen projects i cat - "no projects in this category" / ikke push cat name
      //...dette skal kanskje i backend ja.
     
      //prosjekter skal kunne ha flere cat's - index of? elns
    categoryCounters(){
        for(let singleProject of this.allProjects){
            for(let category of this.categoriesAndCounters){
                if(singleProject.cat == category[0]) {
                    category[1]++
                }
            } 
        }
      },
        getAll() {
            axios.get('https://localhost:44307/api/project')
              .then(function (response) {
                  console.log(response);
                  this.apiTest.push(response);
              })
              .catch(function (error) {
                  console.log(error);
              });
          //try {
          //    this.apiTest = await api.getAll()
          //}
          //catch (error) {
          //    console.log(error);
          //}
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
