<template>
  <div>
      <input type="text" id="name" placeholder="Project Name" v-model="projectToBeSubmitted.SubmitName"/>
      <input type="text" id="link" placeholder="Project Link" v-model="projectToBeSubmitted.SubmitLink"/>
      <input type="text" id="cat" placeholder="Project Category" v-model="projectToBeSubmitted.SubmitCategory"/>
      <button @click="submitProject()">Submit</button>
  </div>
</template>

<script>
import axios from "axios";
//brukere skal kunne sende inn prosjektforslag - som admin godkjenner og adder.
export default {
name:"SubmitPage",
data() {
    return {
        projectToBeSubmitted: {
            SubmitName: "",
            SubmitLink: "",
            SubmitCategory: ""
        }
    }
},
methods: {
    submitProject(){
       axios.post("https://localhost:44307/api/submit", this.projectToBeSubmitted)
            .then(function (response){
                console.log(response)
            })
            .catch(function (error){
                console.log(error)
            })
    }
},
}
</script>

<style>

</style>