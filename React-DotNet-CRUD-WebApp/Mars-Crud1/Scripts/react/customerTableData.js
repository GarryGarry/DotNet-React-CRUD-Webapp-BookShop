import React from 'react';
import ReactDOM from 'react-dom';


class customerTableData extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            customerData: null,
            
        };
       
    };


    render() {
        const customer = this.props.customer;
        return (

            <tr>
                <td>{customer.Id}</td>
                <td>{customer.CName}</td>
                <td>{customer.Address}</td>
                <td>
                    <button name="edit" customer={customer} onClick={() => this.props.selectCustomer(customer)}>Edit</button>
                    <button name="delete" customer={customer} onClick={() => this.props.deleteSelectCustomer(customer)}>Delete</button>
                 </td>
            </tr>
   
        );

    }
}
export default customerTableData;