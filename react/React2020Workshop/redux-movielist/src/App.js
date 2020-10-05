import React from 'react';
//import logo from './logo.svg';
import './App.css';
import {connect} from 'react-redux'
import updateMovies from './store/actions/updateMovies'
import fetchUsers from './store/actions/fetchUsers'


function App(props) {
  return (
    <div className="App">
      <h3>REDUX MOVIE LIST APP</h3>
      <br/>
      <span
      style={{color:'green'}}>
        YOUR CURRENT MOVIE IS:
      </span>{props.movies.name}
      <br/><br/>
      <p><button className='btn btn-primary' onClick={props.updateMovies}>SELECT NEW MOVIE</button></p>
      <br/>
      {
      props.users.length===0? <p>THERE ARE NO USERS</p> : props.users.map (user => <p key={user.id}>{user.first_name}-{user.email}</p>)
      }
      <br/>
      <button className='btn btn-danger' onClick={props.fetchUsers}>FETCH USERS</button>
    </div>
  )
};
const MapStateToProps = (state) => {
  return {
    movies: state.movies,
    users: state.users
  }
}
const MapDispatchToProps = (dispatch) => {
  return {
    updateMovies: () => dispatch(updateMovies),
    fetchUsers: () => dispatch(fetchUsers)
  }
}
export default connect(MapStateToProps, MapDispatchToProps) (App);
