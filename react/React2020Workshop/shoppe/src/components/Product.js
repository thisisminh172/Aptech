import React, {Component} from 'react'

class Product extends Component {
    constructor(props) {
        super(props);
        this.state = {  }
    }
    render() { 
        return ( 
<div>
                <img src="{this.props.image}" alt=""/>
                <p>{this.props.name}</p>
                <p>{this.props.price}</p>
                
                <button type="button" className="btn btn-danger">Mua</button>
                <button type="button" className="btn btn-dark">Hủy</button>
                </div>     
    
            
        );
    }
}
 
export default Product;