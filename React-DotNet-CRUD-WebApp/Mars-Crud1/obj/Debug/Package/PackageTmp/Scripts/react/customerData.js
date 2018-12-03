import React from 'react';
import ReactDOM from 'react-dom';
import styles from './styles/customer.css';
import CustomerTableData from './customerTableData.js';


class customerData extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            customerList: []
        };
    };


    render() {
        const customerData = this.props.customerData;
        return (
            <table>
                <thead>
                    <tr>
                        <th>Customer Id</th>
                        <th>Customer Name</th>
                        <th>Address</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody >
                    {
                        customerData.map(customer => (
                            <CustomerTableData key={customer.Id} customer={customer} selectCustomer={this.props.selectCustomer} deleteSelectCustomer={this.props.deleteSelectCustomer}/>

                        ))}
                </tbody>
            </table>
        );
    }
}
export default customerData;