-- phpMyAdmin SQL Dump
-- version 4.6.6deb5
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost:3306
-- Üretim Zamanı: 09 Oca 2020, 00:15:05
-- Sunucu sürümü: 5.7.28-0ubuntu0.19.04.2
-- PHP Sürümü: 7.2.24-0ubuntu0.19.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `TheEyeControlDB`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ControlTable`
--

CREATE TABLE `ControlTable` (
  `Id` int(11) NOT NULL,
  `CompanyName` varchar(500) NOT NULL,
  `CompanyTaxNo` int(11) NOT NULL,
  `CompanyType` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `ControlTable`
--

INSERT INTO `ControlTable` (`Id`, `CompanyName`, `CompanyTaxNo`, `CompanyType`) VALUES
(1, 'ismet kizgin Petrol Ofisi', 123123, 1),
(3, 'Kadir Can Petrol Ofisi', 45, 1),
(4, 'Alihan Ecazanesi', 99, 2),
(5, 'Irem Otopark', 100, 0),
(8, 'Shell', 350, 1),
(9, 'Bayrak Otopark', 88, 0),
(10, 'Doeuk Eczanesi', 72, 2),
(11, 'Arya Eczanesi', 65, 2),
(12, 'Derin Otopark', 36, 0);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `ControlTable`
--
ALTER TABLE `ControlTable`
  ADD PRIMARY KEY (`Id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `ControlTable`
--
ALTER TABLE `ControlTable`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
