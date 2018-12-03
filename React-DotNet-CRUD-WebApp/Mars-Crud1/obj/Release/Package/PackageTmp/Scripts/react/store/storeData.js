import React from 'react';
import ReactDOM from 'react-dom';
import styles from '../styles/store.css';
import StoreTableData from './storeTableData.js';


class storeData extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            storeList: []
        };
    };


    render() {
        const storeData = this.props.storeData;
        return (
            <table>
                <thead>
                    <tr>
                        <th>Store Id</th>
                        <th>Store Name</th>
                        <th>Address</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody >
                    {
                        storeData.map(store => (
                            <StoreTableData key={store.Id} store={store} selectStore={this.props.selectStore} deleteSelectStore={this.props.deleteSelectStore} />

                        ))}
                </tbody>
            </table>
        );
    }
}
export default storeData;