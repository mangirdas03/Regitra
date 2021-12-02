#@(#) script.ddl

DROP TABLE IF EXISTS Technine_apziura;
DROP TABLE IF EXISTS Automobilio_pasas;
DROP TABLE IF EXISTS Darbuotojas;
DROP TABLE IF EXISTS Egzaminas;
DROP TABLE IF EXISTS Vairuotojo_pazymejimas;
DROP TABLE IF EXISTS Apeliacija;
DROP TABLE IF EXISTS Automobilis;
DROP TABLE IF EXISTS Filialas;
DROP TABLE IF EXISTS Miestas;
DROP TABLE IF EXISTS Klientas;
DROP TABLE IF EXISTS pazymejimo_bukle;
DROP TABLE IF EXISTS egzamino_tipas;

CREATE TABLE Klientas
(
	asmens_kodas varchar (12) NOT NULL,
	vardas varchar (25) NOT NULL,
	pavarde varchar (25) NOT NULL,
	tel_nr varchar (10) NOT NULL,
	el_pastas varchar (75) NOT NULL,
	teorijos_egz_data date NULL,
	praktikos_egz_data date NULL,
	teorijos_egz_islaikytas boolean NOT NULL,
	praktikos_egz_islaikytas boolean NOT NULL,
	nuotrauka longblob NULL,
	PRIMARY KEY(asmens_kodas)
);

CREATE TABLE Miestas
(
	pavadinimas varchar (50) NOT NULL,
	PRIMARY KEY(pavadinimas)
);

CREATE TABLE Filialas
(
	gatve varchar (75) NOT NULL,
	gatves_nr int NOT NULL,
	teorijos_egz boolean NULL,
	praktikos_egz boolean NULL,
	id_Filialas integer NOT NULL,
	fk_Miestaspavadinimas varchar (50) NOT NULL,
	PRIMARY KEY(id_Filialas),
	CONSTRAINT turi FOREIGN KEY(fk_Miestaspavadinimas) REFERENCES Miestas (pavadinimas)
);

CREATE TABLE Automobilis
(
	vin varchar (18) NOT NULL,
	marke varchar (25) NOT NULL,
	modelis varchar (35) NOT NULL,
	sdk varchar (9) NOT NULL,
	pagaminimo_metai date NOT NULL,
	paskutine_reg_salis varchar (50) NOT NULL,
	pirmoji_reg_salis varchar (50) NOT NULL,
	valstybiniai_numeriai varchar (7) NOT NULL,
	fk_Klientasasmens_kodas varchar (12) NOT NULL,
	PRIMARY KEY(vin),
	CONSTRAINT priklauso FOREIGN KEY(fk_Klientasasmens_kodas) REFERENCES Klientas (asmens_kodas)
);

CREATE TABLE Apeliacija
(
	priezastis varchar (100) NOT NULL,
	tekstas text NOT NULL,
	id_Apeliacija integer NOT NULL,
	fk_Klientasasmens_kodas varchar (12) NOT NULL,
	PRIMARY KEY(id_Apeliacija),
	CONSTRAINT pildo FOREIGN KEY(fk_Klientasasmens_kodas) REFERENCES Klientas (asmens_kodas)
);

CREATE TABLE pazymejimo_bukle
(
	id_pazymejimo_bukle integer,
	name char (30) NOT NULL,
	PRIMARY KEY(id_pazymejimo_bukle)
);

INSERT INTO pazymejimo_bukle(id_pazymejimo_bukle, name) VALUES(1, 'uzsakytas');
INSERT INTO pazymejimo_bukle(id_pazymejimo_bukle, name) VALUES(2, 'pagamintas');
INSERT INTO pazymejimo_bukle(id_pazymejimo_bukle, name) VALUES(3, 'pristatytas');

CREATE TABLE Vairuotojo_pazymejimas
(
	pazymejimo_nr int NOT NULL,
	pagaminimo_data date NOT NULL,
	galiojimo_data date NOT NULL,
	pazymejimo_bukle integer NOT NULL,
	fk_Klientasasmens_kodas varchar (12) NOT NULL,
	PRIMARY KEY(pazymejimo_nr),
	FOREIGN KEY(pazymejimo_bukle) REFERENCES pazymejimo_bukle (id_pazymejimo_bukle),
	CONSTRAINT suteikiamas FOREIGN KEY(fk_Klientasasmens_kodas) REFERENCES Klientas (asmens_kodas)
);

CREATE TABLE egzamino_tipas
(
	id_egzamino_tipas integer,
	name char (30) NOT NULL,
	PRIMARY KEY(id_egzamino_tipas)
);

INSERT INTO egzamino_tipas(id_egzamino_tipas, name) VALUES(1, 'teorija');
INSERT INTO egzamino_tipas(id_egzamino_tipas, name) VALUES(2, 'praktika');

CREATE TABLE Egzaminas
(
	data date NOT NULL,
	egzamino_tipas integer NOT NULL,
	id_Egzaminas integer NOT NULL,
	fk_Klientasasmens_kodas varchar (12) NOT NULL,
	fk_Filialasid_Filialas integer NOT NULL,
	FOREIGN KEY(egzamino_tipas) REFERENCES egzamino_tipas (id_egzamino_tipas),
	PRIMARY KEY(id_Egzaminas),
	CONSTRAINT laiko FOREIGN KEY(fk_Klientasasmens_kodas) REFERENCES Klientas (asmens_kodas),
	CONSTRAINT laikomas FOREIGN KEY(fk_Filialasid_Filialas) REFERENCES Filialas (id_Filialas)
);

CREATE TABLE Darbuotojas
(
	tabelio_nr int NOT NULL,
	vardas varchar (25) NOT NULL,
	pavarde varchar (25) NOT NULL,
	fk_Filialasid_Filialas integer NOT NULL,
	PRIMARY KEY(tabelio_nr),
	CONSTRAINT dirba FOREIGN KEY(fk_Filialasid_Filialas) REFERENCES Filialas (id_Filialas)
);

CREATE TABLE Automobilio_pasas
(
	paso_nr int NOT NULL,
	automobilio_spalva varchar (25) NOT NULL,
	kuro_tipas varchar (20) NOT NULL,
	co2_kiekis int NOT NULL,
	svoris int NOT NULL,
	variklio_litrazas float NOT NULL,
	kilovatu_skaicius int NOT NULL,
	isdavimo_data date NOT NULL,
	fk_Automobilisvin varchar (18) NOT NULL,
	fk_Darbuotojastabelio_nr int NOT NULL,
	PRIMARY KEY(paso_nr),
	CONSTRAINT suteikiamas_vin FOREIGN KEY(fk_Automobilisvin) REFERENCES Automobilis (vin),
	CONSTRAINT sudaro FOREIGN KEY(fk_Darbuotojastabelio_nr) REFERENCES Darbuotojas (tabelio_nr)
);

CREATE TABLE Technine_apziura
(
	apziuros_id integer NOT NULL PRIMARY KEY,
	atlikimo_data date NOT NULL,
	galiojimo_data date NOT NULL,
	dabartine_rida varchar (7) NOT NULL,
	dumingumas float NOT NULL,
	vaziuokles_bukle varchar (30) NOT NULL,
	variklio_bukle varchar (30) NOT NULL,
	kebulo_bukle varchar (30) NOT NULL,
	pastabos text NULL,
	fk_Darbuotojastabelio_nr int NOT NULL,
	fk_Automobilisvin varchar (18) NOT NULL,
	CONSTRAINT atlieka FOREIGN KEY(fk_Darbuotojastabelio_nr) REFERENCES Darbuotojas (tabelio_nr),
	CONSTRAINT atliekama FOREIGN KEY(fk_Automobilisvin) REFERENCES Automobilis (vin)
);
