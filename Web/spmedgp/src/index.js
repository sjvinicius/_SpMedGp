import React from 'react';
import ReactDOM from 'react-dom';
import reportWebVitals from './reportWebVitals';
import { Route, Switch, BrowserRouter } from 'react-router-dom'

import './index.css';

import Login from './Pages/Login';
import Consultas from './Pages/Consultas'
import NovaConsulta from './Pages/NovaConsulta';

const route = (

  <BrowserRouter initialRouteName='Login' >
    <Switch >
      <Route exact path='/' component={Login}/>
      <Route path='/Login' component={Login}/>
      <Route path='/Consultas' component={Consultas}/>
      <Route path='/NovaConsulta' component={NovaConsulta}/>
      {/* <Redirect to path='/NotFound' component={''}/> */}
    </Switch>
  </BrowserRouter>

)

ReactDOM.render( route, document.getElementById('root') );

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
