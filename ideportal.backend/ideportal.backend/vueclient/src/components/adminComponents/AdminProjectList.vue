<template>
  <div>
      <h2>All Current Projects:</h2>
      <div v-for="(project, index) in allProjects" :key="index">
      {{project.projectName}} <button>Edit</button>  <button @click="removeProject(project)">Delete</button>    
      </div>
  </div>
</template>

<script>
//engage editmode! emit til parent, som shower editmode om dette er tilfelle.
//send med selected project id til det som skal endres, så riktig updates i db

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
        })
        .catch(function(error) {
          console.log(error);
        });
      },
      removeProject(project){
        //får en XML(?) root error selv om det funker. sjekk ut det.
         axios.delete("https://localhost:44307/api/project/"+ project.id)
         .then(function (response){
                console.log(response)
            })
            .catch(function (error){
                console.log(error)
            })
      }
  },
};
</script>