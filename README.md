# Loja Manoel - Sistema de Embalagem de Pedidos
Avaliação Técnica .NET C#
# Descrição
Este projeto é uma API Web desenvolvida em ASP.NET Core 8.0 que processa uma lista de pedidos, calcula a melhor forma de embalar os produtos e seleciona a(s) caixa(s) apropriada(s) para cada pedido. O sistema é capaz de otimizar o uso de caixas pré-fabricadas, minimizando o número de embalagens necessárias, com base nas dimensões dos produtos.

O projeto segue os princípios de Domain-Driven Design (DDD), utilizando separação de responsabilidades entre as camadas de domínio, aplicação, infraestrutura e interfaces.

# Funcionalidades
Receber uma lista de pedidos via JSON.
Processar os produtos de cada pedido, verificando as dimensões de cada produto.
Selecionar a(s) caixa(s) mais adequada(s) com base nas caixas disponíveis.
Otimizar o uso do espaço das caixas, minimizando o número total de caixas usadas.
Retornar, para cada pedido, as caixas utilizadas e quais produtos foram colocados em cada uma delas.

# Tecnologias Utilizadas
ASP.NET Core 8.0
Domain-Driven Design (DDD)
Swagger para documentação da API
XUnit para testes unitários

# Teste Unitário
O projeto utiliza o XUnit para a execução dos testes unitários. Para rodar os testes:
Os testes cobrem as funcionalidades do serviço PacoteService para garantir que os produtos sejam corretamente embalados nas caixas.
