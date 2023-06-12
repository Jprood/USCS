CREATE database controle;
use controle;

CREATE TABLE Natureza (
	idNatureza INT AUTO_INCREMENT NOT NULL,
    descricao varchar(50) NOT NULL,
    PRIMARY KEY (idNatureza)
);

CREATE TABLE Forma_Pag (
	idForma_Pag INT AUTO_INCREMENT NOT NULL,
    descricao varchar(50) NOT NULL,
    PRIMARY KEY (idForma_Pag)
);

CREATE TABLE Grupo (
	idGrupo INT AUTO_INCREMENT NOT NULL,
    descricao varchar(60) NOT NULL,
    PRIMARY KEY (idGrupo)
);

CREATE TABLE Fornecedor (
	idFornecedor INT AUTO_INCREMENT NOT NULL,
    nome varchar(50) NOT NULL,
    endereco varchar(100),
    telefone CHAR(11)NOT NULL,
    email varchar(50) NOT NULL,
    cnpj char(14) NOT NULL,
    PRIMARY KEY (idFornecedor)
    );

CREATE TABLE Produto (
	idProduto INT AUTO_INCREMENT NOT NULL,
    idFornecedor INT NOT NULL,
    idGrupo INT NOT NULL,
    nome varchar(50) NOT NULL,
    preco double NOT NULL,
    lote varchar(100) NOT NULL,
    quantidade_disp INT NOT NULL,
    CONSTRAINT idFornecedorP FOREIGN KEY (idFornecedor) REFERENCES Fornecedor (idFornecedor),
    CONSTRAINT idGrupoP FOREIGN KEY (idGrupo) REFERENCES Grupo (idGrupo),
    PRIMARY KEY (idProduto)
);
    
CREATE TABLE Item (
    idItem INT Auto_INCREMENT NOT NULL,
    total double NOT NULL,
    PRIMARY KEY (idItem)
);
    
CREATE TABLE Produto_Item (
	idProduto INT NOT NULL,
    idItem INT NOT NULL,
	CONSTRAINT idProdutoPD FOREIGN KEY (idProduto) REFERENCES Produto (idProduto),
    CONSTRAINT idItemPD FOREIGN KEY (idItem) REFERENCES Item (idItem),
    quantidade INT NOT NULL,
    PRIMARY KEY (idProduto, idItem)
);

CREATE TABLE Pedido (
	idPedido INT AUTO_INCREMENT NOT NULL,
    idNatureza INT NOT NULL,
    idItem INT NOT NULL,
    idForma_Pag INT NOT NULL,
    CONSTRAINT idNaturezaPE FOREIGN KEY (idNatureza) REFERENCES Natureza (idNatureza),
    CONSTRAINT idItemPE FOREIGN KEY (idItem) REFERENCES Item (idItem),
    CONSTRAINT idForma_PagPE FOREIGN KEY (idForma_Pag) REFERENCES Forma_Pag  (idForma_Pag ),
    PRIMARY KEY (idPedido)
);

CREATE TABLE Financeiro (
	idFinanceiro INT AUTO_INCREMENT NOT NULL,
    idNatureza INT NOT NULL,
    CONSTRAINT idNaturezaF FOREIGN KEY (idNatureza) REFERENCES Natureza (idNatureza),
    data_pd timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
    TOTAL DOUBLE NOT NULL, 
    PRIMARY KEY (idFinanceiro)
);

CREATE TABLE Tipo_Usuario (
	idTipo_Usuario INT AUTO_INCREMENT NOT NULL,
    descricao varchar(50) NOT NULL,
    PRIMARY KEY (idTipo_Usuario)
); 

CREATE TABLE Usuario (
	idUsuario INT AUTO_INCREMENT NOT NULL,
    idTipo_Usuario INT NOT NULL,
    CONSTRAINT idTipo_Usuario FOREIGN KEY (idTipo_Usuario) REFERENCES Tipo_Usuario (idTipo_Usuario),
    email varchar(50) NOT NULL,
    senha varchar(50) NOT NULL,
    PRIMARY KEY (idUsuario)
); 

