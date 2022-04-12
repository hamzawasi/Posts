import React from 'react';
import AppRouter from './router/AppRouter';
import './styles.scss';
import 'bootstrap/dist/css/bootstrap.min.css';
import { createRoot } from 'react-dom/client';

const container = document.getElementById('root');
const root = createRoot(container);
root.render(<AppRouter />);