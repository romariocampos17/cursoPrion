<template>
  <v-container id="login" >
    <Loader :is-visible="load"></Loader>
    <v-form @submit="login">
      <v-row >
        <v-col md="4" offset-md="4">
          <v-text-field v-model="payload.login"  label="Login">
          </v-text-field>
        </v-col>
      </v-row>

      <v-row >
        <v-col md="4" offset-md="4">
          <v-text-field v-model="payload.password" label="Password">
          </v-text-field>
        </v-col>
      </v-row>

      <v-row>
        <v-col>
          <v-btn type="submit">Login</v-btn>
        </v-col>
      </v-row>

      <v-row>
        <v-col>
          <v-btn @Click="carregaLoader()">VueLoader</v-btn>
        </v-col>
      </v-row>
    </v-form>
  </v-container>
</template>

<script>
import Loader from '@/components/Loader.vue';
import { mapActions, mapGetters } from 'vuex';

export default {
  components: { Loader },
  computed: { ...mapGetters(['load']) },
  data() {
    return {
      payload: {},
      load: false,
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
    carregaLoader() {
      this.load = false;
    },
    computed: { ...mapActions(['setLoad']) },
  },
};
</script>

<style scoped>
#login {
  background-color: #42b983;
}

</style>
