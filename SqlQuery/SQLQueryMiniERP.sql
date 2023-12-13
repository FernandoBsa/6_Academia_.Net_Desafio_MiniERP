create database MiniERP2

CREATE TABLE Fornecedores (
    ID INT PRIMARY KEY IDENTITY,
    CPF_CNPJ VARCHAR(14),
    Nome_RazãoSocial VARCHAR(255),
    Telefone VARCHAR(20),
	Pais VARCHAR(50),
	Estado VARCHAR(50),
	Cidade VARCHAR(50),
    Rua VARCHAR(255),
    Numero INT,
    Bairro VARCHAR(255)
);

CREATE TABLE Produtos (
    ID INT PRIMARY KEY IDENTITY,
    Nome VARCHAR(50),
    Marca VARCHAR(20),
    Preco DECIMAL(10, 2),
    FornecedorID INT,
    FOREIGN KEY (FornecedorId) REFERENCES Fornecedores(ID)
);


CREATE TABLE Clientes
(
    ID INT PRIMARY KEY IDENTITY,
    CPF_CNPJ VARCHAR(14),
    Nome_RazãoSocial VARCHAR(255),
    Telefone VARCHAR(20),
	Pais VARCHAR(50),
	Estado VARCHAR(50),
	Cidade VARCHAR(50),
    Rua VARCHAR(255),
    Numero INT,
    Bairro VARCHAR(255)
);


CREATE TABLE NotasFiscais (
    NotaFiscalID INT PRIMARY KEY IDENTITY,
    ClienteID INT,
    Data DATETIME,
    Total DECIMAL(10, 2),
    FOREIGN KEY (ClienteId) REFERENCES Clientes(ID)
);

CREATE TABLE NotaFiscalProdutos (
    NotaFiscalID INT,
    ProdutoID INT,
    Quantidade INT,
    PrecoUnitario DECIMAL(10, 2),
    PRIMARY KEY (NotaFiscalId, ProdutoId),
    FOREIGN KEY (NotaFiscalId) REFERENCES NotasFiscais(NotaFiscalId),
    FOREIGN KEY (ProdutoId) REFERENCES Produtos(ID)
);

CREATE LOGIN MiniERP WITH PASSWORD = 'senha_1234';
CREATE USER MiniERP FOR LOGIN MiniERP;


