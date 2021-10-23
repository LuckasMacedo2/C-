CREATE TABLE Jogos
(
	Id		uniqueidentifier NOT NULL, 
	Nome		VARCHAR(100) 	 NOT NULL,
	Produtora	VARCHAR(100) 	 NOT NULL,
	Preco		FLOAT		 NOT NULL
)
GO
ALTER TABLE Jogos ADD CONSTRAINT PK_Jogos PRIMARY KEY (Id);

INSERT Jogos (Id, Nome, Produtora, Preco) VALUES
('947bcd16-59d4-47c6-8179-d3a7a87e1895', 'Blech Brave Souls', 'Klab', 100);
INSERT Jogos (Id, Nome, Produtora, Preco) VALUES
('e3485701-0cb6-44d3-b123-c4899a4fee46', 'Pokémon GO', 'Niantic', 10);
INSERT Jogos (Id, Nome, Produtora, Preco) VALUES
('dac49087-45fc-46c3-9ea9-d7ce48e07ac8', 'World Of Warcraft', 'Blizzard', 500);
INSERT Jogos (Id, Nome, Produtora, Preco) VALUES
('0ad9a34a-46ee-419b-b9e0-b0691dbcc9d9', 'Yu-Gi-Oh! Duel Links', 'Konami', 100);

SELECT * FROM Jogos

COMMIT
