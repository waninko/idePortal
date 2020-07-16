<template>
  <div>
    <b-button variant="outline-warning" @click="chooseList('projectList')">Current Projects</b-button>
    <b-button variant="outline-warning" @click="chooseList('submissions')">Submissions</b-button>
    <b-button variant="outline-warning" @click="chooseList('administrateAdmins')">Administrate Admins</b-button>
    <b-button variant="outline-warning" @click="logout()">LOGOUT</b-button>

  </div>
</template>

<script>
export default {
  name: "TopPanel",
  methods: {
    chooseList(chosenList){
      this.$emit("listChoice", chosenList);
    },

    logout(){
       this.$router.push('/') 
    }
  },
};
</script>