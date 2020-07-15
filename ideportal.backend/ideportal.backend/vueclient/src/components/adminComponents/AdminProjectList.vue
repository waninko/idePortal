<template>
  <div>
      <h2>All Current Projects:</h2>
  <div class="tableDiv">
      <table v-for="(project, index) in allProjects" :key="index">
     <tr>
     <td> {{project.projectName}} </td>
     <td> <b-button variant="outline-warning" @click="engageEditMode(project)">Edit</b-button> </td>
     <td><b-button variant="outline-warning" @click="removeProject(project)">Delete</b-button></td>    
     </tr>
      </table>
  </div>   
  </div>
</template>

<script>
import axios from "axios";
export default {
  name: "ProjectList",
  data() {
    return {
      allProjects: [],

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
      },
      engageEditMode(project){
        console.log(project, " clicked proj.")
         this.$emit("engage", project);
      }
  },
};
</script>

<style scoped>

.tableDiv{
  margin-left: 400px;
}
td{
 width: 150px;
 font-family:Verdana, Geneva, Tahoma, sans-serif;
 font-weight: bold;
}
tr:hover{
  background-color: rgba(240, 184, 32, 0.157);
}
</style>