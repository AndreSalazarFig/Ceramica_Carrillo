/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      UTM
 * Project :      Modelo Relacional.DM1
 * Author :       ANDRE
 *
 * Date Created : Thursday, June 01, 2017 22:14:25
 * Target DBMS : Microsoft SQL Server 2008
 */


CREATE DATABASE BDCarrillo;
GO

USE BDCarrillo;
GO

/* 
 * TABLE: Actividades 
 */

CREATE TABLE Actividades(
    IdActividad    int             IDENTITY(1,1),
    Nombre         varchar(50)     NULL,
    Descripcion    varchar(max)    NULL,
    FechaLimite    date            NULL,
    IdPersonal     int             NOT NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (IdActividad)
)
go



IF OBJECT_ID('Actividades') IS NOT NULL
    PRINT '<<< CREATED TABLE Actividades >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Actividades >>>'
go

/* 
 * TABLE: Anomalias 
 */

CREATE TABLE Anomalias(
    IdAnomalias    int             IDENTITY(1,1),
    Descripcion    varchar(max)    NULL,
    Fecha          date            NULL,
    IdPersonal     int             NOT NULL,
    IdProductos    int             NOT NULL,
    CONSTRAINT PK8 PRIMARY KEY NONCLUSTERED (IdAnomalias)
)
go



IF OBJECT_ID('Anomalias') IS NOT NULL
    PRINT '<<< CREATED TABLE Anomalias >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Anomalias >>>'
go

/* 
 * TABLE: DetalleVenta 
 */

CREATE TABLE DetalleVenta(
    IdFolio        int    NOT NULL,
    IdProductos    int    NOT NULL
)
go



IF OBJECT_ID('DetalleVenta') IS NOT NULL
    PRINT '<<< CREATED TABLE DetalleVenta >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE DetalleVenta >>>'
go

/* 
 * TABLE: Folio 
 */

CREATE TABLE Folio(
    IdFolio       int      NOT NULL,
    TotalVenta    float    NULL,
    FechaVenta    date     NULL,
    IdPersonal    int      NOT NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (IdFolio)
)
go



IF OBJECT_ID('Folio') IS NOT NULL
    PRINT '<<< CREATED TABLE Folio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Folio >>>'
go

/* 
 * TABLE: Personal 
 */

CREATE TABLE Personal(
    IdPersonal         int             IDENTITY(1,1),
    Nombre             varchar(50)     NULL,
    Apellido           varchar(100)    NULL,
    Telefono           varchar(15)     NULL,
    Movil              varchar(15)     NULL,
    Direccion          varchar(100)    NULL,
    FechaNacimiento    date            NULL,
    Puesto             varchar(20)     NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (IdPersonal)
)
go



IF OBJECT_ID('Personal') IS NOT NULL
    PRINT '<<< CREATED TABLE Personal >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Personal >>>'
go

/* 
 * TABLE: Productos 
 */

CREATE TABLE Productos(
    IdProductos     int             IDENTITY(1,1),
    Nombre          varchar(50)     NULL,
    Descripcion     varchar(100)    NULL,
    PrecioCompra    float           NULL,
    PrecioVenta     float           NULL,
    Unidades        int             NULL,
    Foto            image           NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (IdProductos)
)
go



IF OBJECT_ID('Productos') IS NOT NULL
    PRINT '<<< CREATED TABLE Productos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Productos >>>'
go

/* 
 * TABLE: Solicitudes 
 */

CREATE TABLE Solicitudes(
    idSolicitudes    char(10)        NOT NULL,
    Descripcion      varchar(max)    NULL,
    Status           varchar(20)     NULL,
    IdPersonal       int             NOT NULL,
    IdProductos      int             NOT NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (idSolicitudes)
)
go



IF OBJECT_ID('Solicitudes') IS NOT NULL
    PRINT '<<< CREATED TABLE Solicitudes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Solicitudes >>>'
go

/* 
 * TABLE: Actividades 
 */

ALTER TABLE Actividades ADD CONSTRAINT RefPersonal6 
    FOREIGN KEY (IdPersonal)
    REFERENCES Personal(IdPersonal)
go


/* 
 * TABLE: Anomalias 
 */

ALTER TABLE Anomalias ADD CONSTRAINT RefPersonal4 
    FOREIGN KEY (IdPersonal)
    REFERENCES Personal(IdPersonal)
go

ALTER TABLE Anomalias ADD CONSTRAINT RefProductos5 
    FOREIGN KEY (IdProductos)
    REFERENCES Productos(IdProductos)
go


/* 
 * TABLE: DetalleVenta 
 */

ALTER TABLE DetalleVenta ADD CONSTRAINT RefFolio8 
    FOREIGN KEY (IdFolio)
    REFERENCES Folio(IdFolio)
go

ALTER TABLE DetalleVenta ADD CONSTRAINT RefProductos10 
    FOREIGN KEY (IdProductos)
    REFERENCES Productos(IdProductos)
go


/* 
 * TABLE: Folio 
 */

ALTER TABLE Folio ADD CONSTRAINT RefPersonal7 
    FOREIGN KEY (IdPersonal)
    REFERENCES Personal(IdPersonal)
go


/* 
 * TABLE: Solicitudes 
 */

ALTER TABLE Solicitudes ADD CONSTRAINT RefProductos2 
    FOREIGN KEY (IdProductos)
    REFERENCES Productos(IdProductos)
go

ALTER TABLE Solicitudes ADD CONSTRAINT RefPersonal1 
    FOREIGN KEY (IdPersonal)
    REFERENCES Personal(IdPersonal)
go


