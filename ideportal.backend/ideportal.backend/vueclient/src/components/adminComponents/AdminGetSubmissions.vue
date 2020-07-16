<template>
  <div>
    <h2>Make your Choices...</h2>
    <div class="tableDiv">  
    <table >
      <tr class="headers bord p-3 mb-2 bg-warning text-dark"> 
                           <th>Name</th> 
                           <th>Category</th> 
                           <th class="p-3">Link</th>
                           <th>Approve/Deny</th>
      </tr>
      <tr v-for="(submission, index) in subArr" :key="index">
          <td>{{submission.submitName }}</td>  
          <td>{{submission.submitCategory}}</td>
          <td>{{submission.submitLink}}</td>
          <td><b-button variant="outline-warning" @click="approveProject(submission)">Approve</b-button>
              <b-button variant="outline-warning" @click="denyProject(submission)">Deny</b-button>
         </td>
      </tr>
    </table>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "getSubmissions",
  data() {
    return {
      subArr: [],
      submissionToBeSubmitted: {
          ProjectName: "",
          ProjectLink: "",
          ProjectCategory: ""
      }
    };
  },
  mounted() {
    this.getSubmissionsFromDB();
  },
  methods: {
    getSubmissionsFromDB() {
      var vueInstance = this;
      axios.get("https://localhost:44307/api/submit")
        .then(function(response) {
          vueInstance.subArr = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },

    approveProject(submission){
        this.submissionToBeSubmitted.ProjectName = submission.submitName
        this.submissionToBeSubmitted.ProjectLink = submission.submitLink
        this.submissionToBeSubmitted.ProjectCategory = submission.submitCategory
          var vueInstance = this;
         axios.post("https://localhost:44307/api/project", this.submissionToBeSubmitted)
            .then(function (response){
                console.log(response)
                vueInstance.denyProject(submission)
                
            })
            .catch(function (error){
                console.log(error)
            })
    },
    denyProject(sub){
       var vueInstance = this;
       //får en XML(?) root error selv om det funker. sjekk ut det.
        axios.delete("https://localhost:44307/api/submit/"+ sub.id)
         .then(function (response){
                console.log(response)
                vueInstance.getSubmissionsFromDB()
            })
            .catch(function (error){
                console.log(error)
            })
    }
  }
};
</script>

<style scoped>

.tableDiv{
  width: 50vw;
  position: relative;
  display: flex;
  flex-flow: column wrap;
  margin: 0 auto;
  text-align: center;
}
td{
 width: 200px;
 font-family:Verdana, Geneva, Tahoma, sans-serif;
 font-weight: bold;
}
tr:hover{
  background-color: rgba(240, 184, 32, 0.157);
}
.bord{
  border: solid black 3px;
}
.headers:hover{
   pointer-events: none;
}
</style>