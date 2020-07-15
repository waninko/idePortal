<template>
  <div>
    <button @click="chooseList('projectList')">Current Projects</button>
    <button @click="chooseList('submissions')">Submissions</button>
    <button>Add/Remove Admins</button>
    <button @click="logout()">LOGOUT</button>

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