const CadastrodeCuponsModel = require('./CadastrodeCuponsSchema')

const buscarTodos = async () => {
  const cadastrodecupons = await CadastrodeCuponsModel.find({})
  return cadastrodecupons
}

const inserir = async (cadastrodecupon) => {
  const cadastrodecuponsModel = new CadastrodeCuponsModel(cadastrodecupon)
  const novoCadastrodecupons = await cadastrodecuponsModel.save()

  return novoCadastrodecupons
}

const excluir = async (id) => {
  const cadastrodecupon = await CadastrodeCuponsModel.findByIdAndDelete(id)
  return cadastrodecupon
}

module.exports ={
  buscarTodos,
  inserir,
  excluir
}
