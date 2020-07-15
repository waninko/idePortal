<template>
 <div  class="form">
    <b-form-input
      size="sm"
      type="text"
      placeholder="Project Name"
      v-model="projectToBeSubmitted.SubmitName"
    />
    <b-form-input
      size="sm"
      type="text"
      placeholder="Project Link"
      v-model="projectToBeSubmitted.SubmitLink"
    />
    <b-form-input
      size="sm"
      type="text"
      placeholder="Project Category"
      v-model="projectToBeSubmitted.SubmitCategory"
    />
    <b-button variant="outline-warning" @click="submitProject()">Submit</b-button>
      
  </div>
</template>

<script>
import axios from "axios";
export default {
  name: "SubmitPage",
  data() {
    return {
      projectToBeSubmitted: {
        SubmitName: "",
        SubmitLink: "",
        SubmitCategory: ""
      }
    };
  },
  methods: {
    submitProject() {
      axios
        .post("https://localhost:44307/api/submit", this.projectToBeSubmitted)
        .then(function(response) {
          console.log(response);
        })
        .catch(function(error) {
          console.log(error);
        });
    }
  }
};
</script>

<style scoped>

.form {
  width: 20vw;
  position: relative;
  display: flex;
  flex-flow: column wrap;
  margin: 0 auto;
  text-align: center;
}
::placeholder {
  text-align: center;
}
input:placeholder-shown {
  text-align: center;
}
input{
   text-align: center; 
}
</style>