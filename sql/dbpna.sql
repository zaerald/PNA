-- phpMyAdmin SQL Dump
-- version 4.5.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 14, 2016 at 06:53 PM
-- Server version: 10.1.8-MariaDB
-- PHP Version: 5.6.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbpna`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblpa`
--

CREATE TABLE `tblpa` (
  `id` int(20) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `firstname` varchar(30) NOT NULL,
  `phonenumber` varchar(11) NOT NULL,
  `street` varchar(30) NOT NULL,
  `city` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpa`
--

INSERT INTO `tblpa` (`id`, `lastname`, `firstname`, `phonenumber`, `street`, `city`) VALUES
(2, 'Fujioka', 'Haruhi', '09561456793', 'Ouran', 'Cabanatuan'),
(3, 'Jack', 'Black', '09362572940', 'Astro St.', 'Cebu'),
(5, 'Lamperouge', 'Lelouch', '09245937304', 'Geass St.', 'Manila'),
(6, 'Onizuka', 'Eikichi', '09362830495', 'Onsdf St.', 'Cagayan De Oro'),
(7, 'Lupin', 'Arsene', '09173910294', 'Lupeen', 'Cagayan De Oro'),
(8, 'Hatake', 'Kakashi', '09355721057', 'Naruto', 'Quezon'),
(9, 'Haruhara', 'Haruko', '09244720947', 'Flo', 'Quezon'),
(10, 'Onodera', 'Kosaki', '09367714590', 'Nisekoi', 'Cabanatuan'),
(11, 'Iwakura', 'Lain', '09362948573', 'Serial Lain', 'Pasay'),
(12, 'Kusanagi', 'Motoko ', '09348576352', 'Ghost Shell', 'Pasay'),
(13, 'Elric', 'Edward', '09467383746', 'Full Metal St.', 'Pasay'),
(14, 'Yagami', 'Light', '09364829485', 'Death St.', 'Davao'),
(15, 'Liebert', 'Liebert', '09353847593', 'Remonta St.', 'Manila'),
(16, 'Himura', 'Kenshin', '09473984731', 'Ruroni St.', 'Manila'),
(17, 'Spiegel', 'Spike ', '09364510932', 'Cowbepo St.', 'Manila'),
(19, 'Luffy', 'Monkey', '09369341904', 'Onepeas', 'Cotabato'),
(20, 'Rintarou', 'Okabe', '09472394857', 'Future St.', 'Bacolod'),
(21, 'Gintoki', 'Sakata', '09473620193', 'Ginsa', 'Makati'),
(22, 'Zoro', 'Roronoa', '09472347893', 'Zonoa', 'Makati'),
(23, 'Kazuto', 'Kirigaya', '09234731630', 'Aincrad', 'Iloilo'),
(24, 'Uzumaki', 'Naruto', '09348391039', 'Konoha', 'Pasay'),
(25, 'Yuno', 'Gasai', '09348573629', 'Yandere', 'Iloilo'),
(26, 'Kurisu', 'Makise', '09348374621', 'Future St.', 'Davao'),
(27, 'Kirisaki', 'Chitoge', '09348371630', 'Nisekoi', 'Cabanatuan'),
(28, 'Tachibana', 'Marika', '09348371230', 'Nisekoi', 'Cabanatuan'),
(29, 'Onodera', 'Haru', '09238231039', 'Nisekoi', 'Cabanatuan'),
(30, 'Kanakura', 'Yui', '09231742394', 'Nisekoi', 'Cabanatuan'),
(31, 'Mustang', 'Roy', '09361234567', 'Alchemist', 'Cabanatuan');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `id` int(20) NOT NULL,
  `user` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`id`, `user`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'client', 'client'),
(3, 'Z', 'zero'),
(5, 'Tomoko', 'Kuroki'),
(6, 'Sanoko', 'test'),
(7, 'Hello', 'World');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblpa`
--
ALTER TABLE `tblpa`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblpa`
--
ALTER TABLE `tblpa`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
