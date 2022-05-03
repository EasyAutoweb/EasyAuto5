const express = require('express')
const app = express()

app.use(express.json())

const cartaoRepository = require('./Infra/MongoDB/CartaoRepository')

app.get('/', async function(req, res) {
  const cartoes = await cartaoRepository.todosCartoes()
  res.json(cartoes)
})

app.post('/', async function(req, res) {
  const cartao = req.body

  const  novoCartao = await cartaoRepository.inserirCartao(cartao)

  res.json({
    mensagem: 'Cartao cadastrado com sucesso!',
    novoCartao
  })
  
})

app.put('/', function(req, res) {
  res.send('Este é um PUT em /')
})

app.delete('/:id', async function(req, res) {
  const id = req.params.id
   try {
      const cartao = await cartaoRepository.excluirCartao(id)
    
      res.json({
        mensagem: 'Cartão excluido com sucesso',
        cartao
      })  
    }catch(err) {
      res.status(404).json({
        mensagem: 'Cartão não encontrado'
      })
    }
  
})

app.listen(3000)