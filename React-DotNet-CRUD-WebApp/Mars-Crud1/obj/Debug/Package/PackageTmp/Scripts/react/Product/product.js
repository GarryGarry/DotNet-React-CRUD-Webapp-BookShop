import React from 'react';
import ReactDOM from 'react-dom';

import ProductData from './productData.js';
import Edit from './edit.js';
import { Button, Header, Image, Modal, Form, Input } from 'semantic-ui-react'


class Product extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            productList: [],
            showModal: false,
            selectedProduct: ""
        };
        this.selectProduct = this.selectProduct.bind(this);
        this.deleteSelectProduct = this.deleteSelectProduct.bind(this);
        this.saveProduct = this.saveProduct.bind(this);
        this.closeModal = this.closeModal.bind(this);
    }

    componentDidMount() {
        fetch("/Products/GetProductList")
            .then(res => res.json())
            .then(
                (result) => {
                    this.setState({
                        productList: result
                    });
                }
            )
    }
    closeModal() {
        this.setState({
            showModal: false
        });
    }


    selectProduct(product) {
        debugger;
        console.log(product);
        this.setState({
            selectedProduct: product,
            showModal: true
        });
    }

    deleteSelectProduct(product) {
        $.ajax({
            type: 'POST',
            url: '/Products/DeletProduct/id=' + product.Id,
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(product),
            success: function (product) {
                console.log("success");
                window.location.href = '/Products/Index';
            }
        });

    }

    addNew() {
        this.setState({
            selectedProduct: {},
            showModal: true,
        });
    }

    saveProduct(productTobeSaved) {
        debugger;
        console.log(productTobeSaved);
        this.setState({
            showModal: false
        });
        //data: $("form[name=UserAddForm]").serialize(),
        $.ajax({
            type: 'POST',
            url: '/Products/EditProduct',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(productTobeSaved),
            success: function (data) {
                console.log("success");
                window.location.href = '/Products/Index';
            }
        });
    }

    render() {
        return (
            <div >
                <Button color='red' onClick={() => this.addNew()}>Add</Button>
                <ProductData productData={this.state.productList} selectProduct={this.selectProduct} deleteSelectProduct={this.deleteSelectProduct} />
                {this.state.selectedProduct && <Edit selectProduct={this.selectProduct} selectedProduct={this.state.selectedProduct}
                    closeModal={this.closeModal} showModal={this.state.showModal} saveProduct={this.saveProduct} />
                }
            </div>
        );
    }
}
export default Product;

//<Add selectProduct={this.selectProduct} selectedProduct={} showModal={this.state.showModal} saveProduct={this.saveProduct} />



