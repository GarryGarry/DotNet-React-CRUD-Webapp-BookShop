import React from 'react';
import ReactDOM from 'react-dom';
import styles from './styles/customer.css';
import SaleTableData from './saleTableData.js';

class SalesData extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            SalesList: []
        };
       
    };



    render() {
        const Sales = this.props.Sales;

        return (
         
            <table>
                <thead>
                    <tr>
                        <th>Sales Id</th>
                        <th>Customer Name</th>
                        <th>Product</th>
                        <th>Store</th>
                        <th>Date Sold</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody >
                    {
                        Sales.map(sale => (
                            <SaleTableData key={sale.Id} sale={sale} selectSale={this.props.selectSale} deleteSelectSale={this.props.deleteSelectSale}/>

                        ))}
                </tbody>
            </table>
        );
    }
}
export default SalesData;

