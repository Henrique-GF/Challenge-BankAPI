# BankAPI

Este projeto é uma API que simula transações de uma conta bancária. Você pode cadastrar uma conta, depositar, sacar e conferir seu saldo.

Para utilizar essa API recomendo o uso do Postman

#### Exemplo Postman
[Collection Postman](https://github.com/Henrique-GF/Challenge-BankAPI/blob/master/BankAPI.postman_collection.json)


### Está listado abaixo o passo a passo para utilizar cada recurso da API

## Atalhos   

✅ [Cadastro](#cadastro)

✅ [Saque](#saque)

✅ [Deposito](#deposito)

✅ [Saldo](#saldo)

### Cadastro
#### Antes realizar qualquer movimentação em sua conta, será necessário cadastrá-la primeiro

* Endpoint: https://bankapi20211004150436.azurewebsites.net/Cadastro?Nome={nome}&Senha={senha}
* Método: GET

Ex.: 

Request
https://bankapi20211004150436.azurewebsites.net/Cadastro?Nome=Henrique&Senha=password

Response
{"Cadastro":{"Mensagem":"Sua conta foi cadastrada.","conta":"649209"}}



### Deposito
#### Deve informar a senha de sua conta

* Endpoint: https://bankapi20211004150436.azurewebsites.net/Deposito?Conta={conta}&Valor={valor}&Senha={senha}
* Método: GET

Ex.:
Request
https://bankapi20211004150436.azurewebsites.net/Deosito?Conta=649209&Valor=500&Senha=password

Response
{"Depositar":{"conta":"649209","saldo":500.00}}

#### Possíveis Erros

Conta inexistente

Response: {"Erro":{"Mensagem":"Não existe uma conta com esse número"}}

Senha incorreta

Response: {"Erro":{"Mensagem":"Senha incorreta"}}


### Saque
#### Deve informar a senha de sua conta e ter saldo suficiente

* Endpoint: https://bankapi20211004150436.azurewebsites.net/Saque?Conta={conta}&Valor={valor}&Senha={senha}
* Método: GET

Ex.:
Request
https://bankapi20211004150436.azurewebsites.net/Saque?Conta=649209&Valor=100&Senha=password

Response
{"Sacar":{"conta":"649209","saldo":400.00}}

#### Possíveis Erros

Conta inexistente

Response: {"Erro":{"Mensagem":"Não existe uma conta com esse número"}}

Senha Incorreta

Response: {"Erro":{"Mensagem":"Senha incorreta"}}

Saldo Insuficiente

Response: {"Erro":{"Message":"Saldo insuficiente."}}

### Saldo
#### Deve informar a senha de sua conta

* Endpoint: https://bankapi20211004150436.azurewebsites.net/Saldo?Conta={conta}&Senha={senha}
* Método: GET

Ex.:

Request
https://bankapi20211004150436.azurewebsites.net/Saldo?Conta=649209&Senha=password

Response
{"Saldo":{"conta":"649209","saldo":400.00}}

#### Possíveis Erros

Conta inexistente

Response: {"Erro":{"Mensagem":"Não existe uma conta com esse número"}}

Senha incorreta

Response: {"Erro":{"Mensagem":"Senha incorreta"}}
