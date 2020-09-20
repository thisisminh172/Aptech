import React, {Component} from 'react';
import ReactDOM from 'react-dom';

// function UserInfor(props){
//   return (
//     <div>
//       <p>Name: {props.name}</p>
//       <p>Email: {props.email}</p>
//     </div>
//   )
  
// }
class UserInfor extends Component {
  constructor(props) {
    super(props);
    sthis.state = {  }
  }
  render() { 
    return ( 
      <div>
        <p>Name: {props.name}</p>
        <p>Email: {props.email}</p>
      </div>
     );
  }
}
const element = <UserInfor name ='MInh Lê' email = 'minhle@gmail.com'></UserInfor>
ReactDOM.render(
  element,document.getElementById('root')
)
export default UserInfor;

// const element = <UserInfor name ='MInh Lê' email = 'minhle@gmail.com'></UserInfor>
//   ReactDOM.render (
//     element,document.getElementById('root')
//   )