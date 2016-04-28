CREATE TABLE administrador
(
	nomina varchar(20) primary key,
	contrasena varchar(20) not null,
	nombre_adm varchar(100) not null,
	area varchar(20)
);

CREATE TABLE aval
(
	id_aval integer primary key,
	nombre_av varchar(100) not null,
	direccion_av varchar(70) not null,
	relaion_alumno varchar(20)
);

CREATE TABLE campus
(
	id_campus integer primary key,
	nombre varchar(30) not null,
	ciudad varchar(30) not null,
	estado varchar(30) not null,
	dirección varchar(70) not null
);

CREATE TABLE beca
(
	id_beca integer primary key,
	estatus varchar(30) not null,
	puro integer not null,
	credito integer  not null
);

CREATE TABLE cita
(
	id_cita integer primary key,
	hora time not null
); 

CREATE TABLE alumno_admin_cita
(
	matricula varchar(20) not null,
	nomina varchar(20) not null,
	id_cita integer not null,
	fecha date not null,
	CONSTRAINT alumno_admin_cita_pkey PRIMARY KEY (matricula, nomina, id_cita)
); 

CREATE TABLE alumno
(
	matricula varchar(20) primary key,
	contrasena varchar(20) not null,
	nombre varchar(100) not null,
	promedio decimal(2,1) not null,
	nivel_e varchar(20) not null,
	id_aval integer not null,
	id_campus integer not null,
	id_beca integer not null
);

ALTER TABLE alumno ADD CONSTRAINT fk_aval
FOREIGN KEY (id_aval)
REFERENCES aval (id_aval)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE  alumno ADD CONSTRAINT fk_campus
FOREIGN KEY (id_campus)
REFERENCES campus (id_campus)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE  alumno ADD CONSTRAINT fk_beca
FOREIGN KEY (id_beca)
REFERENCES beca (id_beca)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE alumno_admin_cita ADD CONSTRAINT fk_alumno
FOREIGN KEY (matricula)
REFERENCES alumno (matricula)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE alumno_admin_cita ADD CONSTRAINT fk_admin
FOREIGN KEY (nomina)
REFERENCES administrador (nomina)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE alumno_admin_cita ADD CONSTRAINT fk_cita
FOREIGN KEY (id_cita)
REFERENCES cita (id_cita)
ON DELETE CASCADE
ON UPDATE CASCADE;