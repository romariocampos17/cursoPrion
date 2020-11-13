export const routes = [
  {
    path: '/home',
    component: () => import(/* webpackChunkName: "about" */ './Home'),
    name: 'home',
  },
];
