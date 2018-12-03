import React from 'react';
import ReactDOM from 'react-dom';
import styles from './styles/customer.css';
import { Button, Header, Image, Modal, Form, Input, Dropdown, Select } from 'semantic-ui-react'


class SaleModal extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            finalSelectedSale: "",
            customerDropdown: [],
            productDropdown: [],
            storeDropdown: [],
            selectedSale :[]


        };
        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleInputChange1 = this.handleInputChange1.bind(this);
    }

    //componentWillReceiveProps(nextProps) {
        
    //    let customerList = nextProps.customerList;
    //    let productList = nextProps.productList;
    //    let storeList = nextProps.storeList;
    //    let selectedSale = nextProps.selectedSale;

    //    let customers = customerList.map((c) => ({ key: c.Id, text: c.CName, value: c.CName }));
    //    let products = productList.map((p) => ({ key: p.Id, text: p.PName, value: p.PName }));
    //    let stores = storeList.map((s) => ({ key: s.Id, text: s.SName, value: s.SName }));

    //    this.setState({
    //        customerDropdown: customers,
    //        productDropdown: products,
    //        storeDropdown: stores,
    //        selectedSale: selectedSale

    //    });   

    //    console.log("iiiiiii" + this.state.customerDropdown);

    //}

    handleInputChange( type,value, object) {
        debugger;
        if (type == 'customer') {           
            const cID = object.find(item => item.value == value).key;
            this.props.selectedSale.CustomerId = cID;
            this.props.selectedSale.CName = value;
            
        }
        else if (type == 'product') {
            const pID = object.find(item => item.value == value).key;
            this.props.selectedSale.PName = value;
            this.props.selectedSale.ProductId = pID;
        }
        else if (type == 'store') {
            const sID = object.find(item => item.value == value).key;
            this.props.selectedSale.SName = value;
            this.props.selectedSale.StoreId = sID;
      
           
        };
     
        this.props.selectSale(this.props.selectedSale);
    }

    handleInputChange1(event) {
        this.props.selectedSale.DateSold = event.target.value;
        this.props.selectSale(this.props.selectedSale);

    }

    render() {
        let customerList = this.props.customerList;
        let productList = this.props.productList;
        let storeList = this.props.storeList;
        let selectedSale = this.props.selectedSale;


        let customers = customerList.map((c) => ({ key: c.Id, text: c.CName, value: c.CName }));
        let products = productList.map((p) => ({ key: p.Id, text: p.PName, value: p.PName }));
        let stores = storeList.map((s) => ({ key: s.Id, text: s.SName, value: s.SName }));

        return (
           
            <Modal id="edit" open={this.props.showModal} style={{ top: 20 + '%', bottom: 'auto' }}>
                <Modal.Header>Sale</Modal.Header>
                <Modal.Content >
                    <Form>
                        <Form.Group widths='equal'>
                            <label>Date Sold</label>

                            <Input id="dateSold" value={selectedSale.DateSold} onChange={this.handleInputChange1} />
                            <label>Customer Name</label>
                            <Dropdown id="customer" fluid selection options={customers} value={selectedSale.CName} onChange={(event, { value }, object) => this.handleInputChange("customer", value, customers)} />
                            <label>Product Name</label>
                            <Dropdown id="product" fluid selection options={products} value={selectedSale.PName} onChange={(e, { value }) => this.handleInputChange("product", value, products)} />
                            <label>Store Name</label>
                            <Dropdown id="store" fluid selection options={stores} value={selectedSale.SName} onChange={(e, { value }) => this.handleInputChange("store", value, stores)} />

                        </Form.Group>
                    </Form>
                </Modal.Content>
                <Modal.Actions>
                    <Button primary onClick={() => this.props.closeModal()} >Cancel</Button>
                    <Button color='red' onClick={() => this.props.saveSale(selectedSale)}>Save</Button>
                </Modal.Actions>
            </Modal>

        );
    }
}
export default SaleModal;


//<Modal.Content >
//    <Form>
//        <Form.Group widths='equal'>
//            <label>Date Sold</label>
//            <Input id="dateSold" value={selectedSale.DateSold} onChange={this.handleInputChange1} />
//            <Select label='Customer' options={customers} value={selectedSale.Customer.CName} onChange={(e, { value }) => this.handleInputChange("customer", value)} />
//            <Select label='Product' options={products} value={selectedSale.Product.PName} onChange={(e, { value }) => this.handleInputChange("product", value)} />
//            <Select label='Store' options={stores} value={selectedSale.Store.SName} onChange={(e, { value }) => this.handleInputChange("store", value)} />

//        </Form.Group>
//    </Form>
//</Modal.Content>
