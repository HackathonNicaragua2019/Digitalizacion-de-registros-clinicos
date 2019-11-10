CREATE DATABASE Registro;
USE Registro;

DROP DATABASE Registro;

CREATE TABLE Pacientes
(
ID varchar(10) primary key,
N_Expediente varchar(10),
Fecha_Nacimiento date,
Dirrecion varchar(50),
Alergias varchar(25),
Enfermedades varchar(25),
Sector varchar(25),
N_Telefono varchar(9)
)engine=InnoDB;

CREATE TABLE Usuarios
(
ID varchar(10) primary key,
Nombre varchar(50),
Funcion_o_Tipo varchar(15),
Especialidad varchar(25),
Contraseña varchar(20),
Cod_MINSA varchar(10),
Dirrecion varchar(25),
N_Telefono varchar(9)
)engine=InnoDB;

CREATE TABLE Consulta_O_Evento
(
Motivos_o_Sintomas varchar(50),
Fecha_Entrada date,
Fecha_Salida date,
Diagnostico varchar(50),
Tratamiento varchar(50),
Estado_o_Prioridad varchar(50),
ID_Paciente varchar(10),
ID_Usuario varchar(10),
foreign key (ID_Paciente) references Pacientes (ID) on delete cascade on update cascade,
foreign key (ID_Usuario) references Usuarios (ID) on delete cascade on update cascade
)engine=InnoDB;

CREATE TABLE Estudios_Requeridos
(
Fecha date,
Resultados varchar(50),
Tipo varchar(50),
ID_P varchar(10),
ID_U varchar(10),
foreign key (ID_P) references Pacientes (ID) on delete cascade on update cascade,
foreign key (ID_U) references Usuarios (ID) on delete cascade on update cascade
)engine=InnoDB;

CREATE TABLE Cirujias_e_Incidencias
(
Cirujias varchar(50),
Incidencias varchar(50),
ID_Pacientes varchar(10),
foreign key (ID_Pacientes) references Pacientes (ID) on delete cascade on update cascade
)engine=InnoDB;

CREATE TABLE Existencia
(
Nombre_de_Medicamento varchar(20) primary key,
Existencias int(10)
)engine=InnoDB;

CREATE TABLE Salidas
(
Fecha_de_Salida date,
Nombre_de_Medicamento varchar(20),
Cantidad int,
foreign key (Nombre_de_Medicamento) references Existencia (Nombre_de_Medicamento) on delete cascade on update cascade
)engine=InnoDB;

CREATE TABLE Entradas
(
Fecha_de_Salida date,
Nombre_de_Medicamento varchar(20),
Cantidad int,
foreign key (Nombre_de_Medicamento) references Existencia (Nombre_de_Medicamento) on delete cascade on update cascade
)engine=InnoDB;

CREATE TABLE Enfermedades_Cronicas
(
Enfermedad_Cronica varchar(25),
Tratamiento varchar(50),
ID_PC varchar(10),
foreign key (ID_PC) references Pacientes (ID) on delete cascade on update cascade
)engine=InnoDB;

CREATE TABLE Alergias
(
Tipo_De_Alergia varchar(25),
Tratamiento varchar(25),
ID_Pc varchar(10),
foreign key (ID_Pc) references Pacientes (ID) on delete cascade on update cascade
)engine=InnoDB;






