import React from 'react';
import ReactDOM from 'react-dom';

import CustomerData from './customerData.js';
import Edit from './edit.js';
import { Button, Header, Image, Modal, Form, Input } from 'semantic-ui-react'


class Customer extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            customerList: [],
            showModal: false,
            selectedCustomer: ""
        };
        this.selectCustomer = this.selectCustomer.bind(this);
        this.deleteSelectCustomer = this.deleteSelectCustomer.bind(this);
        this.saveCustomer = this.saveCustomer.bind(this); 
        this.closeModal = this.closeModal.bind(this);
    }

    componentDidMount() {
        fetch("/Default/GetCustomerList")
            .then(res => res.json())
            .then(
                (result) => {
                    this.setState({
                        customerList: result
                    });
                }
            )
    }
   
    closeModal() {
        this.setState({
            showModal: false
        });
    }

    selectCustomer(customer) {
        debugger;
        console.log(customer);
        this.setState({
            selectedCustomer: customer,
            showModal: true
        });        
    }

    deleteSelectCustomer(customer) {
        $.ajax({
            type: 'POST',
            url: '/Default/DeletCustomer/id=' + customer.Id,
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(customer),
            success: function (customer) {
                console.log("success");
                window.location.href = '/Default/Index';
            }
        });

    }

    addNew() {
        this.setState({
            selectedCustomer: {},
                showModal: true,
            });
    }

    saveCustomer(customerTobeSaved) {
        debugger;
        console.log(customerTobeSaved);
        this.setState({
            showModal: false
        }); 
        //data: $("form[name=UserAddForm]").serialize(),
        $.ajax({
            type: 'POST',
            url: '/Default/EditCustomer',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(customerTobeSaved),
            success: function (data) {
                console.log("success");
                window.location.href = '/Default/Index';
            }
        });
    }

    render() {
        return (
            <div >
                <Button color='red' onClick={() => this.addNew()}>Add</Button>
                <CustomerData customerData={this.state.customerList} selectCustomer={this.selectCustomer} deleteSelectCustomer={this.deleteSelectCustomer}/>
                {this.state.selectedCustomer && <Edit selectCustomer={this.selectCustomer}
                    closeModal={this.closeModal}
                    selectedCustomer={this.state.selectedCustomer} showModal={this.state.showModal} saveCustomer={this.saveCustomer} />
                }
            </div>
        );
    }
}
export default Customer;

//<Add selectCustomer={this.selectCustomer} selectedCustomer={} showModal={this.state.showModal} saveCustomer={this.saveCustomer} />



