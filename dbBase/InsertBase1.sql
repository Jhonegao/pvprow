﻿INSERT INTO Users (NOME, CPF, DATA_NASCIMENTO, SENHA) VALUES ('Jhonata Simonetto', '72821053088', '1991/06/29', '12345678')
INSERT INTO Users (NOME, CPF, DATA_NASCIMENTO, SENHA) VALUES ('Karina M Cusotodio', '50068714408', '1993/07/01', '12345678')
INSERT INTO Users (NOME, CPF, DATA_NASCIMENTO, SENHA) VALUES ('Joao Paulo Francisco', '99094202603', '1977/5/22', '12345678')
INSERT INTO Users (NOME, CPF, DATA_NASCIMENTO, SENHA) VALUES ('Maria Lucia', '60697593037', '1960/1/5', '12345678')
INSERT INTO Users (NOME, CPF, DATA_NASCIMENTO, SENHA) VALUES ('Antonio da Veiga', '82668842182', '1985/12/14', '12345678')

INSERT INTO Wallets(CONTAID, SALDO, NUMEROCONTA) VALUES (1, 300 ,201)
INSERT INTO Wallets(CONTAID, SALDO, NUMEROCONTA) VALUES (2, 100, 202)
INSERT INTO Wallets(CONTAID, NUMEROCONTA) VALUES (3,203)
INSERT INTO Wallets(CONTAID, SALDO, NUMEROCONTA) VALUES (4, 150.00 ,204)
INSERT INTO Wallets(CONTAID, SALDO, NUMEROCONTA) VALUES (5, 80.58 ,205)

SELECT * FROM Users
SELECT * FROM Wallets JOIN Users ON ID = 3 WHERE ID = CONTAID