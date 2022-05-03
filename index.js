const express = require('express')
const app = express()
const nodemailer = require("nodemailer")

app.use(express.json())

const faleconoscoRepository = require('./infra/mongoDB/FaleconoscoRepository')

app.get('/', async function (req, res){
 const faleconosco = await faleconoscoRepository.buscarTodos()
  res.json(faleconosco)
})

app.post('/', async function (req, res){
  const faleconosco = req.body

  const novoFaleconosco = await faleconoscoRepository.inserir(faleconosco)

  const transporter = nodemailer.createTransport({
    host: 'smtp.ethereal.email',
    port: 587,
    auth: {
        user: 'brice.borer1@ethereal.email',
        pass: 'hacMQzcyJVE3r4pHNF'
    }
})

await transporter.sendMail({
    from: 'brice.borer1@ethereal.email',
    to: 'brice.borer1@ethereal.email',
    subject: 'Formulário encaminhado.',
    html: '<h1>O seu formulário de fale conosco EasyAuto foi encaminhado com sucesso!</h1>'
})
  
  res.json({
    mensagem: 'Mensagem enviada com sucesso!',
    novoFaleconosco
  })
})

app.listen(3000)

