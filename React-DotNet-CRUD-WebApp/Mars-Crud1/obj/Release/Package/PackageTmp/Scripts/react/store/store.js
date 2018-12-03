import React from 'react';
import ReactDOM from 'react-dom';

import StoreData from './storeData.js';
import Edit from './edit.js';
import { Button, Header, Image, Modal, Form, Input } from 'semantic-ui-react'


class Store extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            storeList: [],
            showModal: false,
            selectedStore: ""
        };
        this.selectStore = this.selectStore.bind(this);
        this.deleteSelectStore = this.deleteSelectStore.bind(this);
        this.saveStore = this.saveStore.bind(this);
        this.closeModal = this.closeModal.bind(this);
    }

    componentDidMount() {
        $.get("/Stores/GetStoreList", (data) => {
            this.setState({
                storeList: data
            });
        })
        //fetch("/Stores/GetStoreList")
        //    .then(res => res.json())
        //    .then(
        //        (result) => {
        //            this.setState({
        //                storeList: result
        //            });
        //        }
        //    )
    }
    closeModal() {
        this.setState({
            showModal: false
        });
    }


    selectStore(store) {
        debugger;
        console.log(store);
        this.setState({
            selectedStore: store,
            showModal: true
        });
    }

    deleteSelectStore(store) {
        $.ajax({
            type: 'POST',
            url: '/Stores/DeletStore/id=' + store.Id,
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(store),
            success: function (store) {
                console.log("success");
                window.location.href = '/Stores/Index';
            }
        });

    }

    addNew() {
        this.setState({
            selectedStore: {},
            showModal: true,
        });
    }

    saveStore(storeTobeSaved) {
        debugger;
        console.log(storeTobeSaved);
        this.setState({
            showModal: false
        });
        //data: $("form[name=UserAddForm]").serialize(),
        $.ajax({
            type: 'POST',
            url: '/Stores/EditStore',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(storeTobeSaved),
            success: function (data) {
                console.log("success");
                window.location.href = '/Stores/Index';
            }
        });
    }

    render() {
        return (
            <div >
                <Button color='red' onClick={() => this.addNew()}>Add</Button>
                <StoreData storeData={this.state.storeList} selectStore={this.selectStore} deleteSelectStore={this.deleteSelectStore} />
                {this.state.selectedStore && <Edit selectStore={this.selectStore} selectedStore={this.state.selectedStore}
                    closeModal={this.closeModal} showModal={this.state.showModal} saveStore={this.saveStore} />
                }
            </div>
        );
    }
}
export default Store;

//<Add selectStore={this.selectStore} selectedStore={} showModal={this.state.showModal} saveStore={this.saveStore} />



