<template>
  <div>
    <div class="selectedCat">SELECTED CATEGORY: {{selectedCategory}}</div>

    <h3>Projects in this category:</h3>
    <div v-for="(project, index) in projectsFromDB" :key="index">
      <div v-if="selectedCategory==project.projectCategory">
        <a :href="project.projectLink">{{project.projectName}}</a>
      </div>
    </div>
  </div>
</template>

<script>
// import api from '@/ProjectApiService'
import axios from "axios";

//litet preview bilde av proj. ved siden av linken?
export default {
  name: "ProjectList",
  props: {
    selectedCategory: String
  },
  data() {
    return {
      projectsFromDB: [],
      catsFromDB: []
    };
  },
  mounted() {
    this.getAll();
  },

  methods: {
    //prosjekter skal kunne ha flere cat's - index of? elns
    categoryCounters() {
      for (let i = 0; i < this.projectsFromDB.length; i++) {
        let tempArr = [this.projectsFromDB[i].projectCategory, 0];
        let doesCatExist = this.catsFromDB.find(el =>
          el.find(p => p == this.projectsFromDB[i].projectCategory)
        );
        if (!doesCatExist) {
          this.catsFromDB.push(tempArr);
        }
      }

      for (let singleProject of this.projectsFromDB) {
        for (let category of this.catsFromDB) {
          if (singleProject.projectCategory == category[0]) {
            category[1]++;
          }
        }
      }
      this.$emit("listToHome", this.catsFromDB);
    },

    getAll() {
      var vueInstance = this;
      axios
        .get("https://localhost:44307/api/project")
        .then(function(response) {
          vueInstance.projectsFromDB = response.data;
          vueInstance.categoryCounters();
        })
        .catch(function(error) {
          console.log(error);
        });
    }
  }
};
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
