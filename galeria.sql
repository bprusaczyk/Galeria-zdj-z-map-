-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 21 Paź 2019, 15:35
-- Wersja serwera: 10.4.6-MariaDB
-- Wersja PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `galeria`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `zdjecia`
--

CREATE TABLE `zdjecia` (
  `idZdjecia` int(11) NOT NULL,
  `sciezka` text DEFAULT NULL,
  `szerokoscGeo` double DEFAULT NULL,
  `dlugoscGeo` double DEFAULT NULL,
  `szerokoscZdj` int(11) DEFAULT NULL,
  `wysokoscZdj` int(11) DEFAULT NULL,
  `datWykonania` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Zrzut danych tabeli `zdjecia`
--

INSERT INTO `zdjecia` (`idZdjecia`, `sciezka`, `szerokoscGeo`, `dlugoscGeo`, `szerokoscZdj`, `wysokoscZdj`, `datWykonania`) VALUES
(1, 'F:\\Semestr II\\Multimedia w platformach mobilnych\\galeria\\zdjecia\\3619027441_d10b77b836_o.jpg', 50.86233333333333, -0.3666388888888889, 2048, 1536, '2009-06-09'),
(2, 'F:\\Semestr II\\Multimedia w platformach mobilnych\\galeria\\zdjecia\\japan-katsura-river.jpg', 35.14377777777778, 135.69013888888887, 1600, 1200, '2016-11-12'),
(3, 'F:\\Semestr II\\Multimedia w platformach mobilnych\\galeria\\zdjecia\\turkey-bodrum.jpg', 37.14952777777778, 27.532638888888886, 1600, 1200, '2018-10-18');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `zdjecia`
--
ALTER TABLE `zdjecia`
  ADD PRIMARY KEY (`idZdjecia`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `zdjecia`
--
ALTER TABLE `zdjecia`
  MODIFY `idZdjecia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
