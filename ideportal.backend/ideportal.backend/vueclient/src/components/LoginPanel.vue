<template>
    <div>
        <b-form-input size="sm" type="password" placeholder="Username" v-model="username" /> 
        <b-form-input size="sm" type="password" placeholder="Password" v-model="password" />
        <b-button variant="outline-warning" @click="checkLogin()">LOGIN as ADMIN</b-button>
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