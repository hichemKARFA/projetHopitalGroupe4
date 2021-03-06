USE [slam2019projetHopitalGroupe4]
GO
/****** Object:  User [comptdaer]    Script Date: 12/11/2018 15:59:29 ******/
CREATE USER [comptdaer] FOR LOGIN [comptdaer] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [karfa]    Script Date: 12/11/2018 15:59:29 ******/
CREATE USER [karfa] FOR LOGIN [karfa] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Statut]    Script Date: 12/11/2018 15:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Statut](
	[id] [int] NOT NULL,
	[libelle] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Statut] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Statut] ([id], [libelle]) VALUES (1, N'Pharmacien')
INSERT [dbo].[Statut] ([id], [libelle]) VALUES (2, N'Infirmier')
/****** Object:  Table [dbo].[Medicaments]    Script Date: 12/11/2018 15:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medicaments](
	[id] [int] NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[stock] [int] NOT NULL,
	[seuil] [int] NOT NULL,
 CONSTRAINT [PK_Medicaments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Medicaments] ([id], [nom], [stock], [seuil]) VALUES (1, N'Doliprane', 63, 50)
INSERT [dbo].[Medicaments] ([id], [nom], [stock], [seuil]) VALUES (2, N'Dafalgan', 125, 10)
INSERT [dbo].[Medicaments] ([id], [nom], [stock], [seuil]) VALUES (3, N'test', 50, 12)
INSERT [dbo].[Medicaments] ([id], [nom], [stock], [seuil]) VALUES (4, N'Imodium', 80, 2)
INSERT [dbo].[Medicaments] ([id], [nom], [stock], [seuil]) VALUES (5, N'oui', 145, 5)
/****** Object:  Table [dbo].[Etat]    Script Date: 12/11/2018 15:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Etat](
	[id] [int] NOT NULL,
	[libelle] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Etat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Etat] ([id], [libelle]) VALUES (1, N'Accepté')
INSERT [dbo].[Etat] ([id], [libelle]) VALUES (2, N'En attente')
INSERT [dbo].[Etat] ([id], [libelle]) VALUES (3, N'Refusé')
/****** Object:  Table [dbo].[Utilisateurs]    Script Date: 12/11/2018 15:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Utilisateurs](
	[id] [int] NOT NULL,
	[login] [varchar](250) NOT NULL,
	[mdp] [varchar](250) NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[prenom] [varchar](50) NOT NULL,
	[statut] [int] NOT NULL,
 CONSTRAINT [PK_Utilisateurs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Utilisateurs] ([id], [login], [mdp], [nom], [prenom], [statut]) VALUES (1, N'admin', N'admin', N'admin', N'admin', 1)
INSERT [dbo].[Utilisateurs] ([id], [login], [mdp], [nom], [prenom], [statut]) VALUES (2, N'Pharmacien1', N'comptdaer', N'comptdaer', N'louis', 1)
INSERT [dbo].[Utilisateurs] ([id], [login], [mdp], [nom], [prenom], [statut]) VALUES (3, N'Infirmier1', N'karfa', N'karfa', N'hichem', 2)
INSERT [dbo].[Utilisateurs] ([id], [login], [mdp], [nom], [prenom], [statut]) VALUES (4, N'Infirmier2', N'jablonski', N'jablonski', N'tom', 2)
INSERT [dbo].[Utilisateurs] ([id], [login], [mdp], [nom], [prenom], [statut]) VALUES (5, N'a', N'a', N'a', N'a', 2)
INSERT [dbo].[Utilisateurs] ([id], [login], [mdp], [nom], [prenom], [statut]) VALUES (6, N'b', N'b', N'b', N'b', 1)
/****** Object:  Table [dbo].[Demandes]    Script Date: 12/11/2018 15:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demandes](
	[id] [int] NOT NULL,
	[utilisateur] [int] NOT NULL,
	[etat] [int] NOT NULL,
 CONSTRAINT [PK_Demandes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Demandes] ([id], [utilisateur], [etat]) VALUES (1, 1, 1)
/****** Object:  Table [dbo].[ContenuDemande]    Script Date: 12/11/2018 15:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContenuDemande](
	[demande] [int] NOT NULL,
	[medicament] [int] NOT NULL,
	[quantite] [int] NOT NULL,
 CONSTRAINT [PK_Liste] PRIMARY KEY CLUSTERED 
(
	[demande] ASC,
	[medicament] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ContenuDemande] ([demande], [medicament], [quantite]) VALUES (1, 1, 50)
INSERT [dbo].[ContenuDemande] ([demande], [medicament], [quantite]) VALUES (1, 2, 30)
/****** Object:  ForeignKey [FK_Liste_Demandes]    Script Date: 12/11/2018 15:59:29 ******/
ALTER TABLE [dbo].[ContenuDemande]  WITH CHECK ADD  CONSTRAINT [FK_Liste_Demandes] FOREIGN KEY([demande])
REFERENCES [dbo].[Demandes] ([id])
GO
ALTER TABLE [dbo].[ContenuDemande] CHECK CONSTRAINT [FK_Liste_Demandes]
GO
/****** Object:  ForeignKey [FK_Liste_Medicaments]    Script Date: 12/11/2018 15:59:29 ******/
ALTER TABLE [dbo].[ContenuDemande]  WITH CHECK ADD  CONSTRAINT [FK_Liste_Medicaments] FOREIGN KEY([medicament])
REFERENCES [dbo].[Medicaments] ([id])
GO
ALTER TABLE [dbo].[ContenuDemande] CHECK CONSTRAINT [FK_Liste_Medicaments]
GO
/****** Object:  ForeignKey [FK_Demandes_Etat]    Script Date: 12/11/2018 15:59:29 ******/
ALTER TABLE [dbo].[Demandes]  WITH CHECK ADD  CONSTRAINT [FK_Demandes_Etat] FOREIGN KEY([etat])
REFERENCES [dbo].[Etat] ([id])
GO
ALTER TABLE [dbo].[Demandes] CHECK CONSTRAINT [FK_Demandes_Etat]
GO
/****** Object:  ForeignKey [FK_Demandes_Utilisateurs]    Script Date: 12/11/2018 15:59:29 ******/
ALTER TABLE [dbo].[Demandes]  WITH CHECK ADD  CONSTRAINT [FK_Demandes_Utilisateurs] FOREIGN KEY([utilisateur])
REFERENCES [dbo].[Utilisateurs] ([id])
GO
ALTER TABLE [dbo].[Demandes] CHECK CONSTRAINT [FK_Demandes_Utilisateurs]
GO
/****** Object:  ForeignKey [FK_Utilisateurs_Statut]    Script Date: 12/11/2018 15:59:29 ******/
ALTER TABLE [dbo].[Utilisateurs]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateurs_Statut] FOREIGN KEY([statut])
REFERENCES [dbo].[Statut] ([id])
GO
ALTER TABLE [dbo].[Utilisateurs] CHECK CONSTRAINT [FK_Utilisateurs_Statut]
GO
