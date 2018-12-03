import React from 'react';
import ReactDOM from 'react-dom';
import styles from './styles/customer.css';
import { Button, Header, Image, Modal, Form, Input, Dropdown, Select } from 'semantic-ui-react'


class SaleModal extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            finalSelectedSale: "",
            ok: this.props.Sales[0]
        };
        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleInputChange1 = this.handleInputChange1.bind(this);
    };

    handleInputChange1(event) {
        this.props.selectedSale.DateSold = event.target.value;
        this.props.saveSale(this.props.selectedSale);

    }


    handleInputChange(type, value) {
        if (type == 'customer') {
            this.props.selectedSale.Customer.CName = value;
        }
        else if (type == 'product') {
            this.props.selectedSale.Product.PName = value;
        }
        else if (type == 'store') {
            this.props.selectedSale.Store.SName = value;
        };
        this.props.selectSale(this.props.selectedSale);
    }

    handleInputChange1(event) {
        this.props.selectedSale.DateSold = event.target.value;
        this.props.selectSale(this.props.selectedSale);

    }

    render() {

        let selectedSale = this.props.selectedSale;
        const Sales = this.props.Sales;

        let customers = Sales.map((sale) => ({ key: sale.Id, text: sale.Customer.CName, value: sale.Customer.CName }));
        let products = Sales.map((sale) => ({ key: sale.Id, text: sale.Product.PName, value: sale.Product.PName }));
        let stores = Sales.map((sale) => ({ key: sale.Id, text: sale.Store.SName, value: sale.Store.SName }));

        return (

            <Modal open={this.props.showModal} style={{ top: 20 + '%', bottom: 'auto' }}>
                <Modal.Header>Sale</Modal.Header>
                <Modal.Content >
                    <Form>
                        <Form.Group widths='equal'>
                            <label>Date Sold</label>
                            <Input id="dateSold" value={selectedSale.DateSold} onChange={this.handleInputChange1} />
                            <Select label='Customer' options={customers} value={selectedSale.Customer.CName } onChange={(e, { value }) => this.handleInputChange("customer", value)} />
                            <Select label='Product' options={products} value={selectedSale.Product.PName } onChange={(e, { value }) => this.handleInputChange("product", value)} />
                            <Select label='Store' options={stores} value={selectedSale.Store.SName  } onChange={(e, { value }) => this.handleInputChange("store", value)} />

                        </Form.Group>
                    </Form>
                </Modal.Content>
                <Modal.Actions>
                    <Button primary >Cancel</Button>
                    <Button color='red' onClick={() => this.props.saveSale(selectedSale)}>Save</Button>
                </Modal.Actions>
            </Modal>
        );
    }
}
export default SaleModal;
