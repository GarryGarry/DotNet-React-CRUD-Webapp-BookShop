import React from 'react';
import ReactDOM from 'react-dom';
import { Button, Header, Image, Modal, Form, Input, Dropdown, Select } from 'semantic-ui-react'

class SaleTableData extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            SaleData: "",

        };

    };


    render() {
        const sale = this.props.sale;
 
        return (
            
            <tr>
                <td>{sale.Id}</td>
                <td>{sale.CName}</td>
                <td>{sale.PName}</td>
                <td>{sale.SName}</td>
                <td>{sale.DateSold}</td>
                <td>
                    <button name="edit" sale={sale} onClick={() => this.props.selectSale(sale)}>Edit</button>
                    <button name="delete" sale={sale} onClick={() => this.props.deleteSelectSale(sale)}>Delete</button>
                </td>
            </tr>

        );

    }
}
export default SaleTableData;