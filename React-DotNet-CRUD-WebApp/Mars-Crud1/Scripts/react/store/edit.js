import React from 'react';
import ReactDOM from 'react-dom';
import styles from '../styles/store.css';
import { Button, Header, Image, Modal, Form, Input } from 'semantic-ui-react'


class Edit extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            Store: null,

        };

        this.handleInputChange1 = this.handleInputChange1.bind(this);
    };

    handleInputChange1(event, type, value) {
        debugger;
        //const target = event.target;
        //const value = target.value;
        if (type == 'name') {
            this.props.selectedStore.SName = value;
        }
        else {
            this.props.selectedStore.Address = value;
        }

        this.props.selectStore(this.props.selectedStore);

    }


    render() {
        const selectedStore = this.props.selectedStore;

        return (

            <Modal open={this.props.showModal} style={{ top: 20 + '%', bottom: 'auto' }}>
                <Modal.Header>Store</Modal.Header>
                <Modal.Content >
                    <Form>
                        <Form.Field>
                            <label>Store Name</label>
                            <Input placeholder="Store Name" value={selectedStore.SName} id="name" onChange={(event, { value }) => this.handleInputChange1(event, "name", value)} />
                        </Form.Field>

                        <Form.Field>
                            <label>Store Address</label>
                            <Input placeholder="Store Address" value={selectedStore.Address} id="address" onChange={(event, { value }) => this.handleInputChange1(event, "address", value)} />
                        </Form.Field>
                    </Form>
                </Modal.Content>
                <Modal.Actions>
                    <Button primary onClick={() =>this.props.closeModal()} >Cancel</Button>
                    <Button color='red' onClick={() => this.props.saveStore(selectedStore)}>Save</Button>
                </Modal.Actions>
            </Modal>
        );
    }
}
export default Edit;