import React from 'react';
import ReactDOM from 'react-dom';
import styles from '../styles/product.css';
import { Button, Header, Image, Modal, Form, Input } from 'semantic-ui-react'


class Edit extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            Product: null,

        };

        this.handleInputChange1 = this.handleInputChange1.bind(this);
    };

    handleInputChange1(event, type, value) {
        debugger;
        //const target = event.target;
        //const value = target.value;
        if (type == 'name') {
            this.props.selectedProduct.PName = value;
        }
        else {
            this.props.selectedProduct.Price = value;
        }

        this.props.selectProduct(this.props.selectedProduct);

    }


    render() {
        const selectedProduct = this.props.selectedProduct;

        return (

            <Modal open={this.props.showModal} style={{ top: 20 + '%', bottom: 'auto' }}>
                <Modal.Header>Product</Modal.Header>
                <Modal.Content >
                    <Form>
                        <Form.Field>
                            <label>Product Name</label>
                            <Input placeholder="Product Name" value={selectedProduct.PName} id="name" onChange={(event, { value }) => this.handleInputChange1(event, "name", value)} />
                        </Form.Field>

                        <Form.Field>
                            <label>Product Price</label>
                            <Input placeholder="Product Price" value={selectedProduct.Price} id="price" onChange={(event, { value }) => this.handleInputChange1(event, "price", value)} />
                        </Form.Field>
                    </Form>
                </Modal.Content>
                <Modal.Actions>
                    <Button primary onClick={() =>this.props.closeModal()} >Cancel</Button>
                    <Button color='red' onClick={() => this.props.saveProduct(selectedProduct)}>Save</Button>
                </Modal.Actions>
            </Modal>
        );
    }
}
export default Edit;