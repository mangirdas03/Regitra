-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2021 at 03:23 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `regitraisp`
--

-- --------------------------------------------------------

--
-- Table structure for table `apeliacija`
--

CREATE TABLE `apeliacija` (
  `priezastis` varchar(100) NOT NULL,
  `tekstas` text NOT NULL,
  `id_Apeliacija` int(11) NOT NULL,
  `fk_Klientasasmens_kodas` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `automobilio_pasas`
--

CREATE TABLE `automobilio_pasas` (
  `paso_nr` int(11) NOT NULL,
  `automobilio_spalva` varchar(25) NOT NULL,
  `kuro_tipas` varchar(20) NOT NULL,
  `co2_kiekis` int(11) NOT NULL,
  `svoris` int(11) NOT NULL,
  `variklio_litrazas` float NOT NULL,
  `kilovatu_skaicius` int(11) NOT NULL,
  `isdavimo_data` date NOT NULL,
  `fk_Automobilisvin` varchar(18) NOT NULL,
  `fk_Darbuotojastabelio_nr` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `automobilis`
--

CREATE TABLE `automobilis` (
  `vin` varchar(18) NOT NULL,
  `marke` varchar(25) NOT NULL,
  `modelis` varchar(35) NOT NULL,
  `sdk` varchar(9) NOT NULL,
  `pagaminimo_metai` date NOT NULL,
  `paskutine_reg_salis` varchar(50) NOT NULL,
  `pirmoji_reg_salis` varchar(50) NOT NULL,
  `valstybiniai_numeriai` varchar(7) NOT NULL,
  `fk_Klientasasmens_kodas` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `darbuotojas`
--

CREATE TABLE `darbuotojas` (
  `tabelio_nr` int(11) NOT NULL,
  `slaptazodis` varchar(30) NOT NULL,
  `vardas` varchar(25) NOT NULL,
  `pavarde` varchar(25) NOT NULL,
  `fk_Filialasid_Filialas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `darbuotojas`
--

INSERT INTO `darbuotojas` (`tabelio_nr`, `slaptazodis`, `vardas`, `pavarde`, `fk_Filialasid_Filialas`) VALUES
(123, '$2a$11$Fxe3TxCxAS30weev18eLiee', 'Test', 'Test1', 102);

-- --------------------------------------------------------

--
-- Table structure for table `egzaminas`
--

CREATE TABLE `egzaminas` (
  `data` date NOT NULL,
  `egzamino_tipas` int(11) NOT NULL,
  `id_Egzaminas` int(11) NOT NULL,
  `fk_Klientasasmens_kodas` varchar(12) NOT NULL,
  `fk_Filialasid_Filialas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `egzamino_tipas`
--

CREATE TABLE `egzamino_tipas` (
  `id_egzamino_tipas` int(11) NOT NULL,
  `name` char(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `egzamino_tipas`
--

INSERT INTO `egzamino_tipas` (`id_egzamino_tipas`, `name`) VALUES
(1, 'teorija'),
(2, 'praktika');

-- --------------------------------------------------------

--
-- Table structure for table `filialas`
--

CREATE TABLE `filialas` (
  `gatve` varchar(75) NOT NULL,
  `gatves_nr` int(11) NOT NULL,
  `teorijos_egz` tinyint(1) DEFAULT NULL,
  `praktikos_egz` tinyint(1) DEFAULT NULL,
  `id_Filialas` int(11) NOT NULL,
  `fk_Miestaspavadinimas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `filialas`
--

INSERT INTO `filialas` (`gatve`, `gatves_nr`, `teorijos_egz`, `praktikos_egz`, `id_Filialas`, `fk_Miestaspavadinimas`) VALUES
('Vasario 16-osios g.', 35, NULL, NULL, 100, 'Jonava'),
('Raudondvario pl.', 234, 1, 1, 101, 'Kaunas'),
('V. Krėvės pr.', 120, 1, NULL, 102, 'Kaunas');

-- --------------------------------------------------------

--
-- Table structure for table `klientas`
--

CREATE TABLE `klientas` (
  `asmens_kodas` varchar(12) NOT NULL,
  `slaptazodis` varchar(30) NOT NULL,
  `vardas` varchar(25) NOT NULL,
  `pavarde` varchar(25) NOT NULL,
  `tel_nr` varchar(10) NOT NULL,
  `el_pastas` varchar(75) NOT NULL,
  `teorijos_egz_data` date DEFAULT NULL,
  `praktikos_egz_data` date DEFAULT NULL,
  `teorijos_egz_islaikytas` tinyint(1) NOT NULL,
  `praktikos_egz_islaikytas` tinyint(1) NOT NULL,
  `nuotrauka` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `klientas`
--

INSERT INTO `klientas` (`asmens_kodas`, `slaptazodis`, `vardas`, `pavarde`, `tel_nr`, `el_pastas`, `teorijos_egz_data`, `praktikos_egz_data`, `teorijos_egz_islaikytas`, `praktikos_egz_islaikytas`, `nuotrauka`) VALUES
('22', '$2a$11$JhwEn2CFudWkbJKf8T2/8uk', 'Remigijus', 'Viršila', '654321', 'testtest', NULL, NULL, 1, 1, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `miestas`
--

CREATE TABLE `miestas` (
  `pavadinimas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `miestas`
--

INSERT INTO `miestas` (`pavadinimas`) VALUES
('Jonava'),
('Kaunas');

-- --------------------------------------------------------

--
-- Table structure for table `pazymejimo_bukle`
--

CREATE TABLE `pazymejimo_bukle` (
  `id_pazymejimo_bukle` int(11) NOT NULL,
  `name` char(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pazymejimo_bukle`
--

INSERT INTO `pazymejimo_bukle` (`id_pazymejimo_bukle`, `name`) VALUES
(1, 'uzsakytas'),
(2, 'pagamintas'),
(3, 'pristatytas');

-- --------------------------------------------------------

--
-- Table structure for table `technine_apziura`
--

CREATE TABLE `technine_apziura` (
  `apziuros_id` int(11) NOT NULL,
  `atlikimo_data` date NOT NULL,
  `galiojimo_data` date NOT NULL,
  `dabartine_rida` varchar(7) NOT NULL,
  `dumingumas` float NOT NULL,
  `vaziuokles_bukle` varchar(30) NOT NULL,
  `variklio_bukle` varchar(30) NOT NULL,
  `kebulo_bukle` varchar(30) NOT NULL,
  `pastabos` text DEFAULT NULL,
  `fk_Darbuotojastabelio_nr` int(11) NOT NULL,
  `fk_Automobilisvin` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `vairuotojo_pazymejimas`
--

CREATE TABLE `vairuotojo_pazymejimas` (
  `pazymejimo_nr` int(11) NOT NULL,
  `pagaminimo_data` date NOT NULL,
  `galiojimo_data` date NOT NULL,
  `pazymejimo_bukle` int(11) NOT NULL,
  `fk_Klientasasmens_kodas` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `apeliacija`
--
ALTER TABLE `apeliacija`
  ADD PRIMARY KEY (`id_Apeliacija`),
  ADD KEY `pildo` (`fk_Klientasasmens_kodas`);

--
-- Indexes for table `automobilio_pasas`
--
ALTER TABLE `automobilio_pasas`
  ADD PRIMARY KEY (`paso_nr`),
  ADD KEY `suteikiamas_vin` (`fk_Automobilisvin`),
  ADD KEY `sudaro` (`fk_Darbuotojastabelio_nr`);

--
-- Indexes for table `automobilis`
--
ALTER TABLE `automobilis`
  ADD PRIMARY KEY (`vin`),
  ADD KEY `priklauso` (`fk_Klientasasmens_kodas`);

--
-- Indexes for table `darbuotojas`
--
ALTER TABLE `darbuotojas`
  ADD PRIMARY KEY (`tabelio_nr`),
  ADD KEY `dirba` (`fk_Filialasid_Filialas`);

--
-- Indexes for table `egzaminas`
--
ALTER TABLE `egzaminas`
  ADD PRIMARY KEY (`id_Egzaminas`),
  ADD KEY `egzamino_tipas` (`egzamino_tipas`),
  ADD KEY `laiko` (`fk_Klientasasmens_kodas`),
  ADD KEY `laikomas` (`fk_Filialasid_Filialas`);

--
-- Indexes for table `egzamino_tipas`
--
ALTER TABLE `egzamino_tipas`
  ADD PRIMARY KEY (`id_egzamino_tipas`);

--
-- Indexes for table `filialas`
--
ALTER TABLE `filialas`
  ADD PRIMARY KEY (`id_Filialas`),
  ADD KEY `turi` (`fk_Miestaspavadinimas`);

--
-- Indexes for table `klientas`
--
ALTER TABLE `klientas`
  ADD PRIMARY KEY (`asmens_kodas`);

--
-- Indexes for table `miestas`
--
ALTER TABLE `miestas`
  ADD PRIMARY KEY (`pavadinimas`);

--
-- Indexes for table `pazymejimo_bukle`
--
ALTER TABLE `pazymejimo_bukle`
  ADD PRIMARY KEY (`id_pazymejimo_bukle`);

--
-- Indexes for table `technine_apziura`
--
ALTER TABLE `technine_apziura`
  ADD PRIMARY KEY (`apziuros_id`),
  ADD KEY `atlieka` (`fk_Darbuotojastabelio_nr`),
  ADD KEY `atliekama` (`fk_Automobilisvin`);

--
-- Indexes for table `vairuotojo_pazymejimas`
--
ALTER TABLE `vairuotojo_pazymejimas`
  ADD PRIMARY KEY (`pazymejimo_nr`),
  ADD KEY `pazymejimo_bukle` (`pazymejimo_bukle`),
  ADD KEY `suteikiamas` (`fk_Klientasasmens_kodas`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `apeliacija`
--
ALTER TABLE `apeliacija`
  ADD CONSTRAINT `pildo` FOREIGN KEY (`fk_Klientasasmens_kodas`) REFERENCES `klientas` (`asmens_kodas`);

--
-- Constraints for table `automobilio_pasas`
--
ALTER TABLE `automobilio_pasas`
  ADD CONSTRAINT `sudaro` FOREIGN KEY (`fk_Darbuotojastabelio_nr`) REFERENCES `darbuotojas` (`tabelio_nr`),
  ADD CONSTRAINT `suteikiamas_vin` FOREIGN KEY (`fk_Automobilisvin`) REFERENCES `automobilis` (`vin`);

--
-- Constraints for table `automobilis`
--
ALTER TABLE `automobilis`
  ADD CONSTRAINT `priklauso` FOREIGN KEY (`fk_Klientasasmens_kodas`) REFERENCES `klientas` (`asmens_kodas`);

--
-- Constraints for table `darbuotojas`
--
ALTER TABLE `darbuotojas`
  ADD CONSTRAINT `dirba` FOREIGN KEY (`fk_Filialasid_Filialas`) REFERENCES `filialas` (`id_Filialas`);

--
-- Constraints for table `egzaminas`
--
ALTER TABLE `egzaminas`
  ADD CONSTRAINT `egzaminas_ibfk_1` FOREIGN KEY (`egzamino_tipas`) REFERENCES `egzamino_tipas` (`id_egzamino_tipas`),
  ADD CONSTRAINT `laiko` FOREIGN KEY (`fk_Klientasasmens_kodas`) REFERENCES `klientas` (`asmens_kodas`),
  ADD CONSTRAINT `laikomas` FOREIGN KEY (`fk_Filialasid_Filialas`) REFERENCES `filialas` (`id_Filialas`);

--
-- Constraints for table `filialas`
--
ALTER TABLE `filialas`
  ADD CONSTRAINT `turi` FOREIGN KEY (`fk_Miestaspavadinimas`) REFERENCES `miestas` (`pavadinimas`);

--
-- Constraints for table `technine_apziura`
--
ALTER TABLE `technine_apziura`
  ADD CONSTRAINT `atlieka` FOREIGN KEY (`fk_Darbuotojastabelio_nr`) REFERENCES `darbuotojas` (`tabelio_nr`),
  ADD CONSTRAINT `atliekama` FOREIGN KEY (`fk_Automobilisvin`) REFERENCES `automobilis` (`vin`);

--
-- Constraints for table `vairuotojo_pazymejimas`
--
ALTER TABLE `vairuotojo_pazymejimas`
  ADD CONSTRAINT `suteikiamas` FOREIGN KEY (`fk_Klientasasmens_kodas`) REFERENCES `klientas` (`asmens_kodas`),
  ADD CONSTRAINT `vairuotojo_pazymejimas_ibfk_1` FOREIGN KEY (`pazymejimo_bukle`) REFERENCES `pazymejimo_bukle` (`id_pazymejimo_bukle`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
