<template>
  <div>
 
    <div class="selectedCat">SELECTED CATEGORY: {{selectedCategory}}

    <h4>Projects in this category:</h4></div>
    <div v-for="(project, index) in projectsFromDB" :key="index">
      <div v-if="selectedCategory==project.projectCategory">
        <a :href="project.projectLink">{{project.projectName}}</a>
      </div>
    </div>
  </div>
</template>

<script>
// import api from '@/ProjectApiService'
//import axios from "axios";

//litet preview bilde av proj. ved siden av linken?
export default {
  name: "ProjectList",
  props: {
    selectedCategory: String
  },
  data() {
    return {
      projectsFromDB: [{
        projectName : "Hei",
        projectCategory: "C#",
        projectLink : "www.vg.no"
      },
      {
        projectName : "på",
        projectCategory: "C#",
        projectLink : "www.vg.no"
      },
      {
        projectName : "Deg",
        projectCategory: "JavaScript",
        projectLink : "www.vg.no"
      }],
      existingCatsInDB: ["C#", "JavaScript", "SQL"]
    };
  },
  // mounted() {
  //   this.getAll();
  // },

  methods: {
    //prosjekter skal kunne ha flere cat's - index of? elns - finn en DB løsning på multicats. 2 felt? cat1+cat2?
    categoryCounters() {
      for (let i = 0; i < this.projectsFromDB.length; i++) {
        let tempArr = [this.projectsFromDB[i].projectCategory, 0];
        let doesCatAlreadyExist = this.existingCatsInDB.find(el =>
          el.find(pCat => pCat == this.projectsFromDB[i].projectCategory)
        );
        if (!doesCatAlreadyExist) {
          this.existingCatsInDB.push(tempArr);
        }
      }

      for (let singleProject of this.projectsFromDB) {
        for (let category of this.existingCatsInDB) {
          if (singleProject.projectCategory == category[0]) {
            category[1]++;
          }
        }
      }
      this.$emit("listToHome", this.existingCatsInDB);
    },

    getAll() {

      this.existingCatsInDB = ["C#", "JavaScript", "SQL"]
      this.projectsFromDB = [{
        projectName : "Hei",
        projectCategory: "C#",
        projectLink : "www.vg.no"
      }]
      this.categoryCounters();
      //var vueInstance = this;
      // axios
      //   .get("https://localhost:44307/api/project")
      //   .then(function(response) {
      //     vueInstance.projectsFromDB = response.data;
      //     vueInstance.categoryCounters();
      //   })
      //   .catch(function(error) {
      //     console.log(error);
      //   });
    }
  }
};
</script>

<style scoped>
.selectedCat {
  font-size: 27px;
  font-weight: bold;
  color: orange;
  margin-bottom: 1%;
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
