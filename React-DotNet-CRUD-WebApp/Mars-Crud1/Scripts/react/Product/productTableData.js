import React from 'react';
import ReactDOM from 'react-dom';


class productTableData extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            productData: null,

        };

    };


    render() {
        const product = this.props.product;
        return (

            <tr>
                <td>{product.Id}</td>
                <td>{product.PName}</td>
                <td>{product.Price}</td>
                <td>
                    <button name="edit" product={product} onClick={() => this.props.selectProduct(product)}>Edit</button>
                    <button name="delete" product={product} onClick={() => this.props.deleteSelectProduct(product)}>Delete</button>
                </td>
            </tr>

        );

    }
}
export default productTableData;