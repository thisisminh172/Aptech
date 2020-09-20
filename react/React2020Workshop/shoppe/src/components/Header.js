import React, {Component} from 'react'

class Header extends Component {
    constructor(props) {
        super(props);
        this.state = {  }
    }
    render() { 
        return ( 
            <nav className="navbar navbar-inverse">
                <a className="navbar-brand" href="">Thế giới di động</a>
                <ul className="nav navbar-nav">
                        <li className="active">
                            <a href="">TRang chủ</a>
                        </li>
                        <li>
                            <a href="?"> Liên kết</a>
                        </li>
                </ul>

            </nav>
         );
    }
}
 
export default Header;