import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import Consultas from './Pages/Consultas/index'
import reportWebVitals from './reportWebVitals';

import { Route, Switch, BrowserRouter } from 'react-router-dom'
import Login from './Pages/Login';

const route = (

  <BrowserRouter initialRouteName='Login' >
    <Switch >
      <Route name='Login' component={Login}/>
      <Route name='Consultas' component={Consultas}/>
    </Switch>
  </BrowserRouter>

)

ReactDOM.render( route, document.getElementById('root') );

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
