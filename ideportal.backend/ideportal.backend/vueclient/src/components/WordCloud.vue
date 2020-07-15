<template>
  <div>
    <vue-word-cloud
      style="
    height: 380px;
    width: 440px;
    margin-left:40%;
    padding: 20px;
  "
      font-family="Impact"
      :words="categories"
      :color="([, weight]) => weight >= 3 ? 'DeepPink' 
                            : weight >= 2 ? 'RoyalBlue' 
                            : weight >  1 ? 'Indigo': 'Green'"
    >
      <div slot-scope="{text, weight}">
        <div :title="weight" class="word" @click="selectItem(text)">{{ text }}</div>
      </div>
    </vue-word-cloud>
  </div>
</template>

<script>
import VueWordCloud from "vuewordcloud";


export default {
  name: "WordCloud",
  components: {
    [VueWordCloud.name]: VueWordCloud
  },
   props: {
    categories: Array
  },
  methods: {
    selectItem(clickedCat) {
      this.$emit("cloudToHome", clickedCat);
    }
  }
};
</script>


<style scoped>
.word {
  cursor: pointer;
}
.word:hover {
  color: orange;
}
</style>