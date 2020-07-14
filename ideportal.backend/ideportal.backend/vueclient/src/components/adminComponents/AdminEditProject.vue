<template>
    <div>
        <h1>EDITMODE ENGAGED!</h1>
        {{selectedProject.projectName}}<br>
        <input type="text" placeholder="New Name" v-model="updatedProject.projectName"><br>
        {{selectedProject.projectLink}}<br>
        <input type="text" placeholder="New Link" v-model="updatedProject.projectLink"><br>
        {{selectedProject.projectCategory}}<br>
        <input type="text" placeholder="New Category" v-model="updatedProject.projectCategory"><br>
        <button @click="updateProject()">Update</button>
    </div>
</template>
<script>
//import axios from "axios"
export default {
    name: "EditProject",
    props:{
        selectedProject : Object
    },
    data() {
        return {
            updatedProject: {
                projectName: "",
                projectLink: "",
                projectCategory: ""
            }
        }
    },
    methods: {
        updateProject(){
            console.log(this.updatedProject, " updated?")
        }
    },
}
</script>