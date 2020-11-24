<template>
  <v-container>
    <v-data-tabel
      :headers="headers"
      :items="pessoas"
    >
      <template slot="no-data">
        <span>Nenhuma Pessoa Retornada</span>
      </template>
    </v-data-tabel>
  </v-container>
</template>

<script>
import { pessoaAPI } from './API/PessoaAPI';

export default {
  data() {
    return {
      headers: [
        {
          text: 'Nome',
          value: 'nome',
        },
        {
          text: 'Email',
          value: 'email',
        },
      ],
      pessoas: [],
    };
  },
  methods: {
    listaPessoas() {
      pessoaAPI.list()
        .then((resp) => {
          this.pessoas = resp.data;
        })
        .catch((error) => (console.log(error)));
    },
  },
  mounted() {
    this.listaPessoas();
  },
};
</script>
