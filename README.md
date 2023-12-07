Kolegij: Računalni praktikum, vježba videoteka.

Baza podataka:
-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Generation Time: Dec 07, 2023 at 04:21 PM
-- Server version: 8.0.31
-- PHP Version: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `videoteka`
--

-- --------------------------------------------------------

--
-- Table structure for table `filmovi`
--

DROP TABLE IF EXISTS `filmovi`;
CREATE TABLE IF NOT EXISTS `filmovi` (
  `id` int NOT NULL AUTO_INCREMENT,
  `naziv` varchar(50) COLLATE utf32_croatian_ci NOT NULL,
  `producent` varchar(50) COLLATE utf32_croatian_ci NOT NULL,
  `trajanje` time NOT NULL,
  `maxIzdDana` date NOT NULL,
  `id_kategorija` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_id_kategorija` (`id_kategorija`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `filmovi`
--

INSERT INTO `filmovi` (`id`, `naziv`, `producent`, `trajanje`, `maxIzdDana`, `id_kategorija`) VALUES
(1, 'Nowhere', 'Igor Marković', '00:58:54', '2023-11-30', 50),
(2, 'Oppenheimer', 'Mihaela Soldat', '01:28:54', '2023-12-12', 51),
(3, 'Old Dads', 'Marin Budić', '01:24:42', '2023-12-28', 53);

-- --------------------------------------------------------

--
-- Table structure for table `kategorija`
--

DROP TABLE IF EXISTS `kategorija`;
CREATE TABLE IF NOT EXISTS `kategorija` (
  `id` int NOT NULL AUTO_INCREMENT,
  `naziv` varchar(50) COLLATE utf32_croatian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=54 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `kategorija`
--

INSERT INTO `kategorija` (`id`, `naziv`) VALUES
(50, 'Akcija'),
(51, 'Triler'),
(53, 'Horor');

-- --------------------------------------------------------

--
-- Table structure for table `korisnik`
--

DROP TABLE IF EXISTS `korisnik`;
CREATE TABLE IF NOT EXISTS `korisnik` (
  `id` int NOT NULL AUTO_INCREMENT,
  `korisnicko_ime` varchar(30) COLLATE utf32_croatian_ci NOT NULL,
  `ime` varchar(30) COLLATE utf32_croatian_ci NOT NULL,
  `prezime` varchar(30) COLLATE utf32_croatian_ci NOT NULL,
  `lozinka` varchar(30) COLLATE utf32_croatian_ci NOT NULL,
  `datum_pristupa` date NOT NULL,
  `datum_clanarine` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=104 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `korisnik`
--

INSERT INTO `korisnik` (`id`, `korisnicko_ime`, `ime`, `prezime`, `lozinka`, `datum_pristupa`, `datum_clanarine`) VALUES
(100, 'imarkovic', 'Igor', 'Marković', 'igor', '2023-10-02', '2023-11-30'),
(101, 'dlukic', 'Dino ', 'Lukic', 'dino', '2023-11-05', '2023-11-29'),
(102, 'gmirko ', 'Gabrijel ', 'Mirko ', 'gabrijel', '2023-11-01', '2023-12-20'),
(103, 'pbursic', 'Paulo', 'Bursic', 'paulo', '2023-09-10', '2023-11-13');

-- --------------------------------------------------------

--
-- Table structure for table `posudba`
--

DROP TABLE IF EXISTS `posudba`;
CREATE TABLE IF NOT EXISTS `posudba` (
  `id` int NOT NULL AUTO_INCREMENT,
  `datum_posudbe` date NOT NULL,
  `MaxIzdDana` int DEFAULT NULL,
  `id_film` int NOT NULL,
  `id_korisnik` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_film_id` (`id_film`),
  KEY `FK_korisnik_id` (`id_korisnik`)
) ENGINE=MyISAM AUTO_INCREMENT=205 DEFAULT CHARSET=utf32 COLLATE=utf32_croatian_ci;

--
-- Dumping data for table `posudba`
--

INSERT INTO `posudba` (`id`, `datum_posudbe`, `MaxIzdDana`, `id_film`, `id_korisnik`) VALUES
(200, '2023-11-14', 30, 1, 100),
(201, '2023-10-09', 15, 2, 100),
(202, '2023-11-14', 22, 3, 103),
(203, '2023-11-04', 12, 1, 103),
(204, '2023-11-20', 35, 2, 102);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
