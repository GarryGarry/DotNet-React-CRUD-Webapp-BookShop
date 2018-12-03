import React from 'react';
import ReactDOM from 'react-dom';


class storeTableData extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            storeData: null,

        };

    };


    render() {
        const store = this.props.store;
        return (

            <tr>
                <td>{store.Id}</td>
                <td>{store.SName}</td>
                <td>{store.Address}</td>
                <td>
                    <button name="edit" store={store} onClick={() => this.props.selectStore(store)}>Edit</button>
                    <button name="delete" store={store} onClick={() => this.props.deleteSelectStore(store)}>Delete</button>
                </td>
            </tr>

        );

    }
}
export default storeTableData;