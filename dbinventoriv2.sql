-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 13, 2020 at 11:10 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.1.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbinventoriv2`
--

-- --------------------------------------------------------

--
-- Table structure for table `tabelbarang`
--

CREATE TABLE `tabelbarang` (
  `kodebarang` varchar(10) NOT NULL,
  `namabarang` varchar(30) NOT NULL,
  `harga` int(8) NOT NULL,
  `stock` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tabelbarang`
--

INSERT INTO `tabelbarang` (`kodebarang`, `namabarang`, `harga`, `stock`) VALUES
('1', 'Laptop Acer', 15000000, 50);

-- --------------------------------------------------------

--
-- Table structure for table `tabelbeli`
--

CREATE TABLE `tabelbeli` (
  `nofak` varchar(5) NOT NULL,
  `tanggal` date NOT NULL,
  `kodesuplier` varchar(10) NOT NULL,
  `totalitem` int(11) NOT NULL,
  `totalbayar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tabeldetailbeli`
--

CREATE TABLE `tabeldetailbeli` (
  `nofak` varchar(5) NOT NULL,
  `kodebarang` varchar(10) NOT NULL,
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tabeldetailjual`
--

CREATE TABLE `tabeldetailjual` (
  `nofakjual` varchar(5) NOT NULL,
  `kodebarang` varchar(10) NOT NULL,
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tabeljual`
--

CREATE TABLE `tabeljual` (
  `nofakjual` varchar(5) NOT NULL,
  `tanggal` date NOT NULL,
  `kodepelanggan` varchar(10) NOT NULL,
  `totalitem` int(11) NOT NULL,
  `totalbayar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tabellogin`
--

CREATE TABLE `tabellogin` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tabellogin`
--

INSERT INTO `tabellogin` (`username`, `password`) VALUES
('admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `tabelpelanggan`
--

CREATE TABLE `tabelpelanggan` (
  `kodepelanggan` varchar(10) NOT NULL,
  `namapelanggan` varchar(30) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `telp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tabelsuplier`
--

CREATE TABLE `tabelsuplier` (
  `kodesuplier` varchar(10) NOT NULL,
  `namasuplier` varchar(30) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `telp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tabelbarang`
--
ALTER TABLE `tabelbarang`
  ADD PRIMARY KEY (`kodebarang`);

--
-- Indexes for table `tabelbeli`
--
ALTER TABLE `tabelbeli`
  ADD PRIMARY KEY (`nofak`);

--
-- Indexes for table `tabeljual`
--
ALTER TABLE `tabeljual`
  ADD PRIMARY KEY (`nofakjual`);

--
-- Indexes for table `tabellogin`
--
ALTER TABLE `tabellogin`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `tabelpelanggan`
--
ALTER TABLE `tabelpelanggan`
  ADD PRIMARY KEY (`kodepelanggan`);

--
-- Indexes for table `tabelsuplier`
--
ALTER TABLE `tabelsuplier`
  ADD PRIMARY KEY (`kodesuplier`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
