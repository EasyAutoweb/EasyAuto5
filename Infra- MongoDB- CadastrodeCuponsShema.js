const {Schema} = require('mongoose')

const cadastrodecuponsSchema = new Schema({
  cupom: String,
  status: String, 
})

const mongoose = require('./Conexao')

const CadastrodeCuponsModel = mongoose.model('cadastrodecupons', cadastrodecuponsSchema)

module.exports = CadastrodeCuponsModel
