import React from 'react';
import ReactDOM from 'react-dom';
import styles from './styles/customer.css';
import { Button, Header, Image, Modal, Form, Input } from 'semantic-ui-react'


class Edit extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            Customer: null,

        };

        this.handleInputChange1 = this.handleInputChange1.bind(this);
    };

    handleInputChange1(event, type, value) {
        debugger;
        //const target = event.target;
        //const value = target.value;
        if (type == 'name') {
            this.props.selectedCustomer.CName = value;
        }
        else {
            this.props.selectedCustomer.Address = value;
        }
        
        this.props.selectCustomer(this.props.selectedCustomer);

    }

    render() {
        const selectedCustomer = this.props.selectedCustomer;

        return (

            <Modal open={this.props.showModal} style={{ top: 20 + '%', bottom: 'auto' }}>
                <Modal.Header>Customer</Modal.Header>
                <Modal.Content >
                    <Form>
                        <Form.Field>
                            <label>Customer Name</label>
                            <Input placeholder="Customer Name" value={selectedCustomer.CName} id="name" onChange={(event, { value }) => this.handleInputChange1(event, "name", value)}/>
                        </Form.Field>

                        <Form.Field>
                            <label>Customer Address</label>
                            <Input placeholder="Customer Address" value={selectedCustomer.Address} id="address" onChange={(event, { value }) => this.handleInputChange1(event, "address", value)}/>
                        </Form.Field>
                    </Form>
                </Modal.Content>
                <Modal.Actions>
                    <Button primary onClick={() => this.props.closeModal()} >Cancel</Button>
                    <Button color='red' onClick={() =>this.props.saveCustomer(selectedCustomer)}>Save</Button>
                </Modal.Actions>
            </Modal>
        );
    }
}
export default Edit;