<template>
  <v-container id="login" >
    <v-form @submit="login">
      <v-row>
      <v-col >
        <v-text-field v-model="payload.login"  label="Login">
        </v-text-field>
      </v-col>
    </v-row>

    <v-row >
      <v-col >
        <v-text-field v-model="payload.password" label="Password">
        </v-text-field>
      </v-col>
    </v-row>

    <v-row>
      <v-col>
        <v-btn type="submit">Login</v-btn>
      </v-col>
    </v-row>
    </v-form>
  </v-container>
</template>

<script>
import { mapActions } from 'vuex';

export default {
  data() {
    return {
      payload: {},
    };
  },
  methods: {
    ...mapActions([
      'setUser',
    ]),
    login() {
      if (this.payload.login === '123456' && this.payload.password === '123456') {
        this.setUser(JSON.stringify(this.payload));
        console.log('Logou!!!');
      // else {
      //     console.log('Acesso Negado')
      //   }
      }
    },
  },
};
</script>

<style scoped>
#login {
  background-color: #42b983;
  width: 30%;
  border-radius: 20px;
}

</style>
