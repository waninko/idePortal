<template>
  <div>
    <h2>HEre's the submissions!</h2>
    <div v-for="(submission, index) in subArr" :key="index">
      {{submission.submitName }} - {{submission.submitCategory}} - {{submission.submitLink}}
      <button @click="approveProject(submission)">Approve</button>
      <button @click="denyProject(submission)">Deny</button>
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
      axios
        .get("https://localhost:44307/api/submit")
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
        
         axios.post("https://localhost:44307/api/project", this.submissionToBeSubmitted)
            .then(function (response){
                console.log(response)
            })
            .catch(function (error){
                console.log(error)
            })
    },
    denyProject(sub){
       //får en XML(?) root error selv om det funker. sjekk ut det.
        axios.delete("https://localhost:44307/api/submit/"+ sub.id)
         .then(function (response){
                console.log(response)
            })
            .catch(function (error){
                console.log(error)
            })
    }
  }
};
</script>