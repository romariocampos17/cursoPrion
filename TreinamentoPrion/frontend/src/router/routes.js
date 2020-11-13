import { routes as Home } from '@/modules/home';
import { routes as About } from '@/modules/about';

export default [
  {
    path: '*',
    redirect: '/',
  },
  ...Home,
  ...About,
];
