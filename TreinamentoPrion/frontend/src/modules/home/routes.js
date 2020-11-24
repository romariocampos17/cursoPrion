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
];
