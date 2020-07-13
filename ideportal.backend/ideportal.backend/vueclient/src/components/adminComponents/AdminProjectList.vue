<template>
  <div>
      <h2>All Projects:</h2>
      <div v-for="(project, index) in allProjects" :key="index">
      {{project.projectName}} <button>Edit</button>  <button>Delete</button>    
      </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  name: "ProjectList",
  data() {
    return {
      msg: "ListComponent w/options goes here",
      allProjects: []
    };
  },
  mounted() {
    this.getProjects();
  },
  methods: {
      getProjects(){
    var vueInstance = this;
      axios
        .get("https://localhost:44307/api/project")
        .then(function(response) {
          vueInstance.allProjects = response.data;
          vueInstance.categoryCounters();
        })
        .catch(function(error) {
          console.log(error);
        });
      }
  },
};
</script>