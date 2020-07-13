<template>
  <div>
      <input type="text" id="name" v-model="projectToBeSubmitted.ProjectName"/>
      <input type="text" id="link" v-model="projectToBeSubmitted.ProjectLink"/>
      <input type="text" id="cat" v-model="projectToBeSubmitted.ProjectCategory"/>
      <button @click="submitProject()">Submit</button>
  </div>
</template>

<script>
//brukere skal kunne sende inn prosjektforslag - som admin godkjenner og adder.
export default {
name:"submitPage",
data() {
    return {
        projectToBeSubmitted: {
            ProjectName: "",
            ProjectLink: "",
            ProjectCategory: ""
        }
    }
},
methods: {
    submitProject(){
        //sende til sende til en admin-forslagslagring-db - vise beskjed om det blir error||200
       console.log(this.projectToBeSubmitted, " submitted project")
    }
},
}
</script>

<style>

</style>