SET IDENTITY_INSERT [dbo].[TbUsuarios] ON
INSERT INTO [dbo].[TbUsuarios] ([usuarioID], [usuario_NomeCompleto], [usuario_email], [usuario_Senha], [usuario_Tipo], [usuario_Telefone], [usuario_DataCadastro], [usuario_Imagem]) VALUES (1, N'Augusto', N'augusto@gmail.com', N'senha', N'vendedor', NULL, NULL, NULL)
INSERT INTO [dbo].[TbUsuarios] ([usuarioID], [usuario_NomeCompleto], [usuario_email], [usuario_Senha], [usuario_Tipo], [usuario_Telefone], [usuario_DataCadastro], [usuario_Imagem]) VALUES (2, N'Letícia', N'leticia@gmail.com', N'senha', N'gerente', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TbUsuarios] OFF
