<template>
  <div id="app">
    <Loader :is-visible="load"></Loader>
    <div id="nav">
      <router-link to="/home">Home</router-link> |
      <router-link to="/about">About</router-link> |
      <router-link to="/login">Login</router-link> |
      <router-link to="/lista-pessoas">ListPessoas</router-link> |
      <router-link to="/form-pessoas">FormPessoas</router-link>
    </div>
    <router-view/>
  </div>
</template>

<script>
import Loader from '@/components/Loader.vue';
import { mapActions, mapGetters } from 'vuex';

export default {
  components: { Loader },
  computed: { ...mapGetters(['load']) },
  data() {
    return {
    };
  },
  methods: {
    computed: { ...mapActions(['setLoad']) },
  },
};
</script>

<style
    Loaderlang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  padding: 30px;

  a {
    font-weight: bold;
    color: #2c3e50;

    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
</style>
