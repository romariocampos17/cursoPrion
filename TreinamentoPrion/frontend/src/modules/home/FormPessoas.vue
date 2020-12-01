<template>
<v-form @submit.prevent="addPessoas">
    <v-container>
      <v-row>
        <v-col
          cols="12"
          md="4"
          offset-md="4"
        >
          <v-text-field
            v-model="pessoas.nome"
            :rules="nameRules"
            label="Nome"
          ></v-text-field>
        </v-col>
      </v-row>

      <v-row>
        <v-col
          cols="12"
          md="4"
          offset-md="4"
        >
          <v-text-field
            v-model="pessoas.email"
            :rules="emailRules"
            label="E-mail"
          ></v-text-field>
        </v-col>
      </v-row>

      <v-btn type="submit">Cadastrar Pessoas</v-btn>
    </v-container>
  </v-form>
</template>

<script>
import { pessoaAPI } from './API/PessoaAPI';

export default {
  data() {
    return {
      pessoas: {},
    };
  },
  methods: {
    addPessoas() {
      pessoaAPI.create(this.pessoas)
        .then(() => {
          console.log('Cadastrado Com Sucesso');
        })
        .catch((error) => (console.log(error)));
    },
  },
};
</script>
