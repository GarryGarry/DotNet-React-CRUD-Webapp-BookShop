import React from 'react';
import ReactDOM from 'react-dom';
import SalesData from './salesList.js';
import SaleModal from './ProductSoldModal.js';
import AddNewModal from './addNewModal.js';
import { Button, Header, Image, Modal, Form, Input, Dropdown, Select } from 'semantic-ui-react'


class Sales extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            Sales: [],
            customerList: [],
            prooductList: [],
            storeList: [],
            showModal: false,
            selectedSale: "",
            mode: ""

        };
        this.selectSale = this.selectSale.bind(this);
        this.deleteSelectSale = this.deleteSelectSale.bind(this);
        this.saveSale = this.saveSale.bind(this);
        this.addNew = this.addNew.bind(this);
        this.closeModal = this.closeModal.bind(this);
    }

    closeModal() {
        this.setState({
            showModal: false
        });
    }
    
    selectSale(sale) {
        debugger;
        this.setState({
            selectedSale: sale,
            showModal: true,
            mode: "edit"
        });
    }
    deleteSelectSale(sale) {
        $.ajax({
            type: 'POST',
            url: '/Sales/DeleteSale/id=' + sale.Id,
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(sale),
            success: function (data) {
                console.log("success");
                window.location.href = '/Sales/Index';
            }
        });

    }

    addNew() {
        this.state.Sales[0].DateSold = "",
            this.state.Sales[0].Id = "",
            this.setState({
                selectedSale: this.state.Sales[0],
                showModal: true,
            });
    }

    saveSale(SelectedSale) {
        debugger;
        console.log(SelectedSale);
        this.setState({
            showModal: false
        });
        debugger;
        $.ajax({
            type: 'POST',
            url: '/Sales/SaveEditSale',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(SelectedSale),
            success: function (data) {
                console.log("success");
                window.location.href = '/Sales/Index';
            }
        });
    }

    componentDidMount() {
        $.get("/Sales/GetProductSoldList", (data) => {
            this.setState({
                Sales: data
            });
        });

        //$.ajax({
        //    type: 'GET',
        //    url: '/Sales/GetProductSoldList',
            
        //    success: function (result) {
        //        this.setState({
        //            Sales: result
        //        });

        //    }
        //});
        //fetch("/Sales/GetProductSoldList")
        //    .then(res => res.json())
        //    .then(
        //        (result) => {

        //            this.setState({
        //                Sales: result
        //            });

        //        }
        //    );
        $.get("/Sales/GetProducts", (data) => {
            this.setState({
                productList: data
            });
        });

        //$.ajax({
        //    type: 'GET',
        //    url: '/Sales/GetProducts',           
        //    success: function (result) {
        //        this.setState({
        //            productList: result
        //        });

        //    }
        //});
        //fetch("/Sales/GetProducts")
        //    .then(res => res.json())
        //    .then(
        //        (result) => {
        //            debugger;
        //            this.setState({
        //                productList: result
        //            });

        //        }
        //    );
        $.get("/Sales/GetCustomers", (data) => {
            this.setState({
                customerList: data
            });
        });
        //$.ajax({
        //    type: 'GET',
        //    url: '/Sales/GetCustomers',
            
        //    success: function (result) {
        //        this.setState({
        //            customerList: result
        //        });

        //    }
        //});
        //fetch("/Sales/GetCustomers")
        //    .then(res => res.json())
        //    .then(
        //        (result) => {

        //            this.setState({
        //                customerList: result
        //            });

        //        }
        //    );

        $.get("/Sales/GetStores", (data) => {
            this.setState({
                storeList: data
            });
        });

        //$.ajax({
        //    type: 'GET',
        //    url: '/Sales/GetStores',
            
        //    success: function (result) {
        //        this.setState({
        //            storeList: result
        //        });

        //    }
        //});
        //fetch("/Sales/GetStores")
        //    .then(res => res.json())
        //    .then(
        //        (result) => {
                
        //            this.setState({
        //                storeList: result
        //            });

        //        }
        //    );
    }

    render() {
        return (

            <div>
                <Button color='red' onClick={() => this.addNew()}>Add</Button>
                <SalesData Sales={this.state.Sales} selectSale={this.selectSale} deleteSelectSale={this.deleteSelectSale} />
                {this.state.selectedSale &&
                    <SaleModal
                        customerList={this.state.customerList}
                        productList={this.state.productList}
                        storeList={this.state.storeList}
                        showModal={this.state.showModal}
                    mode={this.state.mode}
                    closeModal={this.closeModal}
                        selectSale={this.selectSale}
                        selectedSale={this.state.selectedSale}
                        Sales={this.state.Sales}
                        saveSale={this.saveSale} />}

            </div>
        );
    }
}
export default Sales;

//

//<Button color='red' onClick={() => this.addNew}>Add New</Button>
//{ this.state.selectedSale && this.state.Sales && <SaleModal showModal={this.state.showModal} selectSale={this.selectSale} selectedSale={this.state.selectedSale} Sales={this.state.Sales} saveSale={this.saveSale} /> }
//line 45 makes sure empty state doesnt go to next level it should have value before it goes to rendering the other page
//{this.state.addNewState == true && <AddNewModal showModal={this.state.showModal} Sales={this.state.Sales} selectedSale={this.state.selectedSale} saveSale={this.saveSale} />}

//line 45 makes sure empty state doesnt go to next level it should have value before it goes to rendering the other page

//if (isAddNew === true) {
//    <SaleModal showModal={this.state.showModal} selectSale={this.selectSale} selectedSale={this.state.selectedSale} Sales={this.state.Sales} saveSale={this.saveSale} />
//}
//                }





