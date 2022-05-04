const URL = 'mongodb+srv://easyautoweb:webmail2021@easyauto.xe4bn.mongodb.net/test?retryWrites=true&w=majority'

const mongoose = require('mongoose')
mongoose.connect(URL)

module.exports = mongoose
