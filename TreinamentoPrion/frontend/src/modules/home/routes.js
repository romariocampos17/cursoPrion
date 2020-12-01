export const routes = [
  {
    path: '/',
    component: () => import(/* webpackChunkName: "about" */ './Home'),
    name: 'home',
  },
  {
    path: '/lista-pessoas',
    component: () => import(/* webpackChunkName: "about" */ './ListaPessoas'),
    name: 'lista.pessoa',
  },
  {
    path: '/form-pessoas',
    component: () => import(/* webpackChunkName: "about" */ './FormPessoas'),
    name: 'form.pessoas',
  },
];
