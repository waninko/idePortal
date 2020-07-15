<template>
    <div>
        <h1>EDITMODE ENGAGED!</h1>
        {{selectedProject.projectName}}<br>
        <input type="text" placeholder="New Name" v-model="updatedProject.projectName"><br>
        {{selectedProject.projectLink}}<br>
        <input type="text" placeholder="New Link" v-model="updatedProject.projectLink"><br>
        {{selectedProject.projectCategory}}<br>
        <input type="text" placeholder="New Category" v-model="updatedProject.projectCategory"><br>
        <button @click="updateProject()">Update</button> <button @click="cancelEdit()">Cancel</button>
    </div>
</template>
<script>
import axios from "axios"
export default {
    name: "EditProject",
    props:{
        selectedProject : Object
    },
    data() {
        return {
            updatedProject: {
                id: this.selectedProject.id,
                projectName: "",
                projectLink: "",
                projectCategory: ""
            }
        }
    },
    methods: {
        //oppdatere i db
        updateProject(){
            console.log("https://localhost:44307/api/project/" + this.selectedProject.id ,  " ser dette ut som en valid sak?")
             axios.put("https://localhost:44307/api/project/" + this.selectedProject.id, this.updatedProject)
            .then(function (response){
                console.log(response)
            })
            .catch(function (error){
                console.log(error)
            })
        },
        cancelEdit(){
             this.$emit("editmodeOff", false);
        }
    },
}
</script>