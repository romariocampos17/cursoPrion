export const routes = [
  {
    path: '/',
    component: () => import(/* webpackChunkName: "about" */ './Home'),
    name: 'home',
  },
];
