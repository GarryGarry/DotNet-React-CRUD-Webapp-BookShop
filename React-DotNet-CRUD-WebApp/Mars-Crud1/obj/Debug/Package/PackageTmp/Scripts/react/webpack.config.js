
//var webpack = require('webpack');

module.exports = {
    context: __dirname,
    entry: {
       app: "./app.js",
        customer: "./customer.js",
        Sales: "./salesDOM.js",
        product: "./product/app.js"
    },
    output:
        {
            path: __dirname + "/dist",
            filename: "[name]_bundle.js"
        },
    watch: true,
    mode: 'development',
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /(node_modules)/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['babel-preset-env', 'babel-preset-react']
                    }
                }
            },
            {
                test: /\.css$/,
                loader: 'style-loader'
            },
            {
                test: /\.css$/,
                loader: 'css-loader',
                query: {
                    modules: true,
                    localIdentName: '[name]__[local]___[hash:base64:5]'
                }
            }

        ]
    }
}
