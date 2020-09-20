import React ,{Component} from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';

class Car extends Component {
  constructor(props) {
    super(props);
    this.state = {
      brand: "toyota",
      model:"Camry",
      color:"Tomato",
      price:"35.000USD",
      year: 2020
      }
  }
  render() { 
    return (
      <div className='mydiv'>
        <h1>{this.state.brand}</h1>
          <p>
              {this.state.brand} &nbsp;
              {this.state.model} &nbsp;
              {this.state.price} &nbsp;
              {this.state.year} &nbsp;
          </p>
        
      </div>
      );
  }
}
 ReactDOM.render(<Car/>,document.getElementById('root'))
export default Car;