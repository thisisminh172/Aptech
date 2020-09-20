import React,{Component} from 'react';
//import logo from './logo.svg';
import './App.css';
import Header from './components/Header'
import Product from './components/Product'
function App() {
  return (
    
    <div class="row">
      <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
        <Header/>
            <Product
              name="Laptop 1"
              price="34000"
              image="../images/lap1.png"
            />
            <Product
              name="Laptop 2"
              price="14000"
              image="../images/lap2.png"
            />
            <Product
              name="Laptop 3"
              price="43000"
              image="../images/lap3.jpg"
            />
            <Product
              name="Laptop 4"
              price="45000"
              image="../images/lap4.jpg"
            />
      </div>
    </div>
    
  );
}

export default App;
