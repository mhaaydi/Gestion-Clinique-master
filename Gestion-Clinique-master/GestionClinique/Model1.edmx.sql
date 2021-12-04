
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/09/2018 23:31:11
-- Generated from EDMX file: D:\4ème Année\2ème Semestre\Technologie Dot Net\GestionClinique\GestionClinique\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DefaultConnection];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Hospitali__IdCha__4F7CD00D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Hospitalisation] DROP CONSTRAINT [FK__Hospitali__IdCha__4F7CD00D];
GO
IF OBJECT_ID(N'[dbo].[FK__Hospitali__IdPat__571DF1D5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Hospitalisation] DROP CONSTRAINT [FK__Hospitali__IdPat__571DF1D5];
GO
IF OBJECT_ID(N'[dbo].[FK__Hospitali__IdUse__4E88ABD4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Hospitalisation] DROP CONSTRAINT [FK__Hospitali__IdUse__4E88ABD4];
GO
IF OBJECT_ID(N'[dbo].[FK__Laboratoi__IdExa__4BAC3F29]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Laboratoire] DROP CONSTRAINT [FK__Laboratoi__IdExa__4BAC3F29];
GO
IF OBJECT_ID(N'[dbo].[FK__Laboratoi__IdPat__5535A963]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Laboratoire] DROP CONSTRAINT [FK__Laboratoi__IdPat__5535A963];
GO
IF OBJECT_ID(N'[dbo].[FK__Medecin__IdPatie__534D60F1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medecin] DROP CONSTRAINT [FK__Medecin__IdPatie__534D60F1];
GO
IF OBJECT_ID(N'[dbo].[FK__Medecin__IdServi__398D8EEE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medecin] DROP CONSTRAINT [FK__Medecin__IdServi__398D8EEE];
GO
IF OBJECT_ID(N'[dbo].[FK__Medecin__IdUser__37A5467C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medecin] DROP CONSTRAINT [FK__Medecin__IdUser__37A5467C];
GO
IF OBJECT_ID(N'[dbo].[FK__Patient__IdUser__5629CD9C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Patient] DROP CONSTRAINT [FK__Patient__IdUser__5629CD9C];
GO
IF OBJECT_ID(N'[dbo].[FK__Responsab__IdMed__5441852A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Responsable] DROP CONSTRAINT [FK__Responsab__IdMed__5441852A];
GO
IF OBJECT_ID(N'[dbo].[FK__Responsab__IdPat__4222D4EF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Responsable] DROP CONSTRAINT [FK__Responsab__IdPat__4222D4EF];
GO
IF OBJECT_ID(N'[dbo].[FK__Responsab__IdUse__412EB0B6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Responsable] DROP CONSTRAINT [FK__Responsab__IdUse__412EB0B6];
GO
IF OBJECT_ID(N'[dbo].[FK__Traitemen__IdMal__3E52440B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Traitement] DROP CONSTRAINT [FK__Traitemen__IdMal__3E52440B];
GO
IF OBJECT_ID(N'[dbo].[FK__Traitemen__IdMed__3D5E1FD2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Traitement] DROP CONSTRAINT [FK__Traitemen__IdMed__3D5E1FD2];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[Chambre]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Chambre];
GO
IF OBJECT_ID(N'[dbo].[Examen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Examen];
GO
IF OBJECT_ID(N'[dbo].[Hospitalisation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hospitalisation];
GO
IF OBJECT_ID(N'[dbo].[Laboratoire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Laboratoire];
GO
IF OBJECT_ID(N'[dbo].[Login]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Login];
GO
IF OBJECT_ID(N'[dbo].[Maladie]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Maladie];
GO
IF OBJECT_ID(N'[dbo].[Medecin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medecin];
GO
IF OBJECT_ID(N'[dbo].[Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Patient];
GO
IF OBJECT_ID(N'[dbo].[Responsable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Responsable];
GO
IF OBJECT_ID(N'[dbo].[Services]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Services];
GO
IF OBJECT_ID(N'[dbo].[Traitement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Traitement];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [Roles] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Chambres'
CREATE TABLE [dbo].[Chambres] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Localisation] nvarchar(45)  NOT NULL,
    [Categorie] nvarchar(45)  NOT NULL,
    [TypeLit] nvarchar(45)  NOT NULL,
    [Prix] float  NOT NULL
);
GO

-- Creating table 'Examen'
CREATE TABLE [dbo].[Examen] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeExamen] nvarchar(45)  NOT NULL,
    [Prix] float  NOT NULL
);
GO

-- Creating table 'Hospitalisations'
CREATE TABLE [dbo].[Hospitalisations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdUser] nvarchar(128)  NOT NULL,
    [IdPatient] int  NOT NULL,
    [IdChambre] int  NOT NULL,
    [TypeConsultation] varchar(45)  NOT NULL,
    [Observation] varchar(45)  NOT NULL,
    [DateArrivee] datetime  NOT NULL,
    [DateDepart] datetime  NOT NULL,
    [Frais] float  NOT NULL
);
GO

-- Creating table 'Laboratoires'
CREATE TABLE [dbo].[Laboratoires] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdPatient] int  NOT NULL,
    [IdExamen] int  NOT NULL,
    [Observation] nvarchar(45)  NOT NULL,
    [DateAnalyse] datetime  NOT NULL
);
GO

-- Creating table 'Maladies'
CREATE TABLE [dbo].[Maladies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Famille] nvarchar(45)  NOT NULL,
    [SousFamille] nvarchar(45)  NOT NULL,
    [Designation] nvarchar(45)  NOT NULL,
    [Prix] float  NOT NULL
);
GO

-- Creating table 'Medecins'
CREATE TABLE [dbo].[Medecins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdUser] nvarchar(128)  NOT NULL,
    [IdPatient] int  NOT NULL,
    [IdService] int  NOT NULL,
    [Nom] nvarchar(45)  NOT NULL,
    [Prenom] nvarchar(45)  NOT NULL,
    [Genre] nvarchar(45)  NOT NULL,
    [Adresse] nvarchar(45)  NOT NULL,
    [Telephone] nvarchar(45)  NOT NULL,
    [Email] nvarchar(45)  NOT NULL,
    [Grade] nvarchar(45)  NOT NULL,
    [Fonction] nvarchar(45)  NOT NULL,
    [Specialite] nvarchar(45)  NOT NULL,
    [DateNaissance] datetime  NOT NULL,
    [DateRecrutement] datetime  NOT NULL
);
GO

-- Creating table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdUser] nvarchar(128)  NOT NULL,
    [Nom] nvarchar(45)  NOT NULL,
    [Prenom] nvarchar(128)  NOT NULL,
    [Genre] nvarchar(45)  NOT NULL,
    [Adresse] nvarchar(45)  NOT NULL,
    [Telephone] nvarchar(45)  NOT NULL,
    [Email] nvarchar(45)  NOT NULL,
    [Origine] nvarchar(45)  NOT NULL,
    [Poids] float  NOT NULL,
    [Profession] nvarchar(45)  NOT NULL,
    [DateNaissance] datetime  NOT NULL
);
GO

-- Creating table 'Responsables'
CREATE TABLE [dbo].[Responsables] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdUser] nvarchar(128)  NOT NULL,
    [IdPatient] int  NOT NULL,
    [IdMedecin] int  NOT NULL,
    [TypeConsultation] nvarchar(45)  NOT NULL,
    [Observation] nvarchar(45)  NOT NULL,
    [DateConsultation] datetime  NOT NULL,
    [Frais] float  NOT NULL
);
GO

-- Creating table 'Services'
CREATE TABLE [dbo].[Services] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(45)  NOT NULL
);
GO

-- Creating table 'Traitements'
CREATE TABLE [dbo].[Traitements] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdMedecin] int  NOT NULL,
    [IdMaladie] int  NOT NULL,
    [DateDebut] datetime  NOT NULL,
    [DateFin] datetime  NOT NULL,
    [EtatFinal] nvarchar(45)  NOT NULL
);
GO

-- Creating table 'Logins'
CREATE TABLE [dbo].[Logins] (
    [Username] nvarchar(45)  NOT NULL,
    [Password] nvarchar(128)  NOT NULL,
    [Roles] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Chambres'
ALTER TABLE [dbo].[Chambres]
ADD CONSTRAINT [PK_Chambres]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Examen'
ALTER TABLE [dbo].[Examen]
ADD CONSTRAINT [PK_Examen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Hospitalisations'
ALTER TABLE [dbo].[Hospitalisations]
ADD CONSTRAINT [PK_Hospitalisations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Laboratoires'
ALTER TABLE [dbo].[Laboratoires]
ADD CONSTRAINT [PK_Laboratoires]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Maladies'
ALTER TABLE [dbo].[Maladies]
ADD CONSTRAINT [PK_Maladies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Medecins'
ALTER TABLE [dbo].[Medecins]
ADD CONSTRAINT [PK_Medecins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [PK_Patients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Responsables'
ALTER TABLE [dbo].[Responsables]
ADD CONSTRAINT [PK_Responsables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Services'
ALTER TABLE [dbo].[Services]
ADD CONSTRAINT [PK_Services]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Traitements'
ALTER TABLE [dbo].[Traitements]
ADD CONSTRAINT [PK_Traitements]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Username] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [PK_Logins]
    PRIMARY KEY CLUSTERED ([Username] ASC);
GO

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [IdUser] in table 'Hospitalisations'
ALTER TABLE [dbo].[Hospitalisations]
ADD CONSTRAINT [FK__Hospitali__IdUse__4E88ABD4]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Hospitali__IdUse__4E88ABD4'
CREATE INDEX [IX_FK__Hospitali__IdUse__4E88ABD4]
ON [dbo].[Hospitalisations]
    ([IdUser]);
GO

-- Creating foreign key on [IdUser] in table 'Medecins'
ALTER TABLE [dbo].[Medecins]
ADD CONSTRAINT [FK__Medecin__IdUser__37A5467C]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Medecin__IdUser__37A5467C'
CREATE INDEX [IX_FK__Medecin__IdUser__37A5467C]
ON [dbo].[Medecins]
    ([IdUser]);
GO

-- Creating foreign key on [IdUser] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [FK__Patient__IdUser__5629CD9C]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Patient__IdUser__5629CD9C'
CREATE INDEX [IX_FK__Patient__IdUser__5629CD9C]
ON [dbo].[Patients]
    ([IdUser]);
GO

-- Creating foreign key on [IdUser] in table 'Responsables'
ALTER TABLE [dbo].[Responsables]
ADD CONSTRAINT [FK__Responsab__IdUse__412EB0B6]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Responsab__IdUse__412EB0B6'
CREATE INDEX [IX_FK__Responsab__IdUse__412EB0B6]
ON [dbo].[Responsables]
    ([IdUser]);
GO

-- Creating foreign key on [IdChambre] in table 'Hospitalisations'
ALTER TABLE [dbo].[Hospitalisations]
ADD CONSTRAINT [FK__Hospitali__IdCha__4F7CD00D]
    FOREIGN KEY ([IdChambre])
    REFERENCES [dbo].[Chambres]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Hospitali__IdCha__4F7CD00D'
CREATE INDEX [IX_FK__Hospitali__IdCha__4F7CD00D]
ON [dbo].[Hospitalisations]
    ([IdChambre]);
GO

-- Creating foreign key on [IdExamen] in table 'Laboratoires'
ALTER TABLE [dbo].[Laboratoires]
ADD CONSTRAINT [FK__Laboratoi__IdExa__4BAC3F29]
    FOREIGN KEY ([IdExamen])
    REFERENCES [dbo].[Examen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Laboratoi__IdExa__4BAC3F29'
CREATE INDEX [IX_FK__Laboratoi__IdExa__4BAC3F29]
ON [dbo].[Laboratoires]
    ([IdExamen]);
GO

-- Creating foreign key on [IdPatient] in table 'Hospitalisations'
ALTER TABLE [dbo].[Hospitalisations]
ADD CONSTRAINT [FK__Hospitali__IdPat__571DF1D5]
    FOREIGN KEY ([IdPatient])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Hospitali__IdPat__571DF1D5'
CREATE INDEX [IX_FK__Hospitali__IdPat__571DF1D5]
ON [dbo].[Hospitalisations]
    ([IdPatient]);
GO

-- Creating foreign key on [IdPatient] in table 'Laboratoires'
ALTER TABLE [dbo].[Laboratoires]
ADD CONSTRAINT [FK__Laboratoi__IdPat__5535A963]
    FOREIGN KEY ([IdPatient])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Laboratoi__IdPat__5535A963'
CREATE INDEX [IX_FK__Laboratoi__IdPat__5535A963]
ON [dbo].[Laboratoires]
    ([IdPatient]);
GO

-- Creating foreign key on [IdMaladie] in table 'Traitements'
ALTER TABLE [dbo].[Traitements]
ADD CONSTRAINT [FK__Traitemen__IdMal__3E52440B]
    FOREIGN KEY ([IdMaladie])
    REFERENCES [dbo].[Maladies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Traitemen__IdMal__3E52440B'
CREATE INDEX [IX_FK__Traitemen__IdMal__3E52440B]
ON [dbo].[Traitements]
    ([IdMaladie]);
GO

-- Creating foreign key on [IdPatient] in table 'Medecins'
ALTER TABLE [dbo].[Medecins]
ADD CONSTRAINT [FK__Medecin__IdPatie__534D60F1]
    FOREIGN KEY ([IdPatient])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Medecin__IdPatie__534D60F1'
CREATE INDEX [IX_FK__Medecin__IdPatie__534D60F1]
ON [dbo].[Medecins]
    ([IdPatient]);
GO

-- Creating foreign key on [IdService] in table 'Medecins'
ALTER TABLE [dbo].[Medecins]
ADD CONSTRAINT [FK__Medecin__IdServi__398D8EEE]
    FOREIGN KEY ([IdService])
    REFERENCES [dbo].[Services]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Medecin__IdServi__398D8EEE'
CREATE INDEX [IX_FK__Medecin__IdServi__398D8EEE]
ON [dbo].[Medecins]
    ([IdService]);
GO

-- Creating foreign key on [IdPatient] in table 'Responsables'
ALTER TABLE [dbo].[Responsables]
ADD CONSTRAINT [FK__Responsab__IdPat__4222D4EF]
    FOREIGN KEY ([IdPatient])
    REFERENCES [dbo].[Medecins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Responsab__IdPat__4222D4EF'
CREATE INDEX [IX_FK__Responsab__IdPat__4222D4EF]
ON [dbo].[Responsables]
    ([IdPatient]);
GO

-- Creating foreign key on [IdMedecin] in table 'Traitements'
ALTER TABLE [dbo].[Traitements]
ADD CONSTRAINT [FK__Traitemen__IdMed__3D5E1FD2]
    FOREIGN KEY ([IdMedecin])
    REFERENCES [dbo].[Medecins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Traitemen__IdMed__3D5E1FD2'
CREATE INDEX [IX_FK__Traitemen__IdMed__3D5E1FD2]
ON [dbo].[Traitements]
    ([IdMedecin]);
GO

-- Creating foreign key on [IdMedecin] in table 'Responsables'
ALTER TABLE [dbo].[Responsables]
ADD CONSTRAINT [FK__Responsab__IdMed__5441852A]
    FOREIGN KEY ([IdMedecin])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Responsab__IdMed__5441852A'
CREATE INDEX [IX_FK__Responsab__IdMed__5441852A]
ON [dbo].[Responsables]
    ([IdMedecin]);
GO

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRoles]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUsers'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUsers]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------