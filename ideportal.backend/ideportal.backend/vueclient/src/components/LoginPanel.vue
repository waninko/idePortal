<template>
    <div>
        <input type="text" placeholder="Username" v-model="username" /> 
        <input type="text" placeholder="Password" v-model="password" />
        <button @click="checkLogin()">LOGIN as ADMIN</button>
    </div>
</template>
<script>
export default {
    name:"Login",
    data() {
        return {
            username: "",
            password: ""
        }
    },
    methods: {
        checkLogin(){
            if(this.username == "admin" && this.password == "admin"){
                this.$router.push('Admin') 
            }
        }
    },
}
</script>