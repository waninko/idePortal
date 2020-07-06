<template>
    <div>
        <!-- <ul v-for="(category, index) in categories" :key=index>
            <li @click="selectItem(category)">{{category}}</li>

        </ul> -->
      
<vue-word-cloud
  style="
    height: 180px;
    width: 240px;
    margin-left:42%;
    padding: 20px;
  "
  :words="categories"
  :color="([, weight]) => weight > 8 ? 'DeepPink' : weight > 4 ? 'RoyalBlue' : 'Indigo'"
  font-family="Roboto"
>
<div slot-scope="{text, weight}">
     <div :title="weight" class="word" @click="selectItem(text)">
      {{ text }}
    </div>
</div>
</vue-word-cloud>

    </div>
</template>

<script>
//ordsky tid. :|
import VueWordCloud from 'vuewordcloud';


//ta vare på antall prosjekter i hver category - flere prosj, større tekst
export default {
  name: "WordCloud",
  components: {
    [VueWordCloud.name]: VueWordCloud
  },
  data (){
      return {
        // categories:["JS","C#","Vue<3","SQL","React","HTML/CSS"],
          categories:[
              ["JS",5],
              ["C#", 9],
              ["HTML/CSS", 5],
              ["Vue", 6],
              ["SQL", 4]
              ],
          randomNr: Math.floor(Math.random() * 11)
          
  }
  },
  methods: {
      selectItem(clickedCat){
          console.log(clickedCat, " select kjører")
          this.$emit('cloudToHome', clickedCat)
      }
  },
 
  
};
</script>


<style scoped>
.cloud{

}

.word{
cursor: pointer; 
}
.word:hover{
    /* border: 3px dotted #3a7999; */
	color: orange;
 }
</style>