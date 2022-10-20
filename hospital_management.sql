-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 20, 2022 at 10:09 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hospital_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Last_name` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Birth_Date` varchar(50) NOT NULL,
  `Phone_No` varchar(50) NOT NULL,
  `Specialist` varchar(50) DEFAULT NULL,
  `Reg_Date` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `User_Type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `First_Name`, `Last_name`, `Gender`, `Birth_Date`, `Phone_No`, `Specialist`, `Reg_Date`, `Email`, `Password`, `User_Type`) VALUES
(42696, 'John', 'Adams', 'Male', '10/6/2022', '071254526', NULL, '10/7/2022', 'john@gmail.com', '1234', 'Patient'),
(42704, 'Kamal', 'Perera', 'Male', '10/04/2022', '0114528645', NULL, '10/07/2022', 'kamal@gmail.com', '1234', 'Biologist'),
(42705, 'David', 'James', 'Male', '10/14/2022', '0114526587', 'Urologists', '10/06/2022', 'david@gmail.com', '1234', 'Doctor'),
(42706, 'Natasha', 'Adams', 'Female', '10/06/2022', '0714526358', NULL, '10/06/2022', 'natasha@gmail.com', '1234', 'Receptionist'),
(42707, 'Bill', 'Pitt', 'Male', '10/15/2022', '075426354', NULL, '10/05/2022', 'bill@gmail.com', '1234', 'Biologist'),
(42708, 'Evelyn', 'Joshep', 'Female', '10/08/2022', '0723625418', NULL, '10/04/2022', 'evlyn@gmail.com', '1234', 'Biologist'),
(42709, 'Nimal', 'Alwis', 'Male', '10/14/2022', '074256328', 'Cardiologists', '10/06/2022', 'nimal@gmail.com', '1234', 'Doctor'),
(42710, 'Henry', 'Parker', 'Male', '10/05/2022', '0752410365', NULL, '10/07/2022', 'henry@gmail.com', '1234', 'Receptionist'),
(42711, 'Peter', 'Jackson', 'Male', '10/14/2022', '070256348', NULL, '10/19/2022', 'peter@gmail.com', '1234', 'Patient'),
(42712, 'Mary', 'Williams', 'Female', '10/15/2022', '0726586425', 'Endocrinologists', '10/12/2022', 'mary@gmail.com', '1234', 'Doctor');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42713;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
