<template>
    <div>
        <ul v-for="(category, index) in categories" :key=index>
            <li @click="selectItem(category)">{{category}}</li>

        </ul>
      
    </div>
</template>

<script>
//ordsky tid. :|
export default {
  name: "WordCloud",
  data (){
      return {
          categories:["JS","C#","Vue<3","SQL","React","HTML/CSS"],
      }
  },
  methods: {
      selectItem(clickedCat){
          this.$emit('cloudToHome', clickedCat)
      }
  },
 
  
};
</script>