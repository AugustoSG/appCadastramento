CREATE TABLE [dbo].[TbUsuarios]
(
	[usuarioID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [usuario_NomeCompleto] VARCHAR(250) NULL, 
    [usuario_email] VARCHAR(250) NULL, 
    [usuario_Senha] VARCHAR(250) NULL, 
    [usuario_Tipo] VARCHAR(250) NULL, 
    [usuario_Telefone] VARCHAR(250) NULL, 
    [usuario_DataCadastro] VARCHAR(250) NULL, 
    [usuario_Imagem] VARCHAR(250) NULL
)
