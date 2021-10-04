# BankAPI

#### Pré requisito
No momento o projeto pode ser executado apenas em Localhost e conectado com um servidor local, então para executá-lo será necessário instalá-lo e executá-lo em uma IDE e configurar a conexão com seu servidor e com o banco de dados no "ConnectionStrings" localizado no arquivo appsettings.json.
Após configurar a conexção com seu servidor, abra o console do gerenciador de pacotes e digite o comando Update-Database para criar a tabela em seu banco de dados.

#### Example Postman
[Collection Postman](https://github.com/Henrique-GF/Challenge-BankAPI/blob/master/BankAPI.postman_collection.json)

## Recursos   

✅ [Cadastro](#cadastro)

✅ [Saque](#saque)

✅ [Deposito](#deposito)

✅ [Saldo](#saldo)

### Cadastro
#### Antes realizar qualquer movimentação na conta, será necessário cadastrá-la primeiro

* Endpoint: http://localhost:[porta]//Cadastro?Nome={nome}&Senha={senha}
* Método: GET

Ex.: 

Request
https://localhost:44341/Cadastro?Nome=Henrique&Senha=password

Response
{"Cadastro":{"Mensagem":"Sua conta foi cadastrada.","conta":"649209"}}


### Deposito
#### Será possível Depositar apenas se utilizar a senha correta de seu conta.

* Endpoint: http://localhost:[porta]//Deposito?Conta={conta}&Valor={valor}&Senha={senha}
* Método: GET

Ex.:
Request
https://localhost:44341/Deosito?Conta=649209&Valor=500&Senha=password

Response
{"Depositar":{"conta":"649209","saldo":500.00}}


### Saque
#### Será possível sacar se utilizar a senha correta da conta e se o seu saldo for suficiente

* Endpoint: http://localhost:[porta]//Saque?Conta={conta}&Valor={valor}&Senha={senha}
* Método: GET

Ex.:
Request
https://localhost:44341/Saque?Conta=649209&Valor=100&Senha=password

Response
{"Sacar":{"conta":"649209","saldo":400.00}}



### Saldo
#### Para consultar o saldo informe a conta e a senha de sua conta

* Endpoint: http://localhost:[porta]//Saldo?Conta={conta}&Senha={senha}
* Método: GET

Ex.:

Request
https://localhost:44341/Saldo?Conta=649209&Senha=password

Response
{"Saldo":{"conta":"649209","saldo":400.00}}


