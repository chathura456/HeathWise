-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 14, 2022 at 07:44 PM
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
-- Table structure for table `patientlab`
--

CREATE TABLE `patientlab` (
  `SSNo` int(20) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Last_Name` varchar(50) NOT NULL,
  `Reg_Date` varchar(50) NOT NULL,
  `Appointed_Specialist` varchar(30) NOT NULL,
  `Appointed_Dr` varchar(30) NOT NULL,
  `DId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patientlab`
--

INSERT INTO `patientlab` (`SSNo`, `First_Name`, `Last_Name`, `Reg_Date`, `Appointed_Specialist`, `Appointed_Dr`, `DId`) VALUES
(20312, 'Smith', 'Fdo', '10/25/2022', 'Urologists', 'David', 42705),
(20315, 'Julia', 'Smith', '11/10/2022', 'Cardiologists', 'Nimal', 42709),
(20303, 'Vans', 'Silva', '0000-00-00', 'Cardiologists', 'Nimal', 42709);

-- --------------------------------------------------------

--
-- Table structure for table `patientsdetails`
--

CREATE TABLE `patientsdetails` (
  `SSNo` int(20) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Last_name` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Birth_Date` varchar(50) NOT NULL,
  `Phone_No` varchar(50) NOT NULL,
  `Weight` varchar(50) DEFAULT NULL,
  `height` varchar(50) NOT NULL,
  `Blood_Type` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Reg_Date` varchar(50) NOT NULL,
  `Appointed_Specialist` varchar(30) NOT NULL,
  `Appointed_Dr` varchar(30) NOT NULL,
  `DId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patientsdetails`
--

INSERT INTO `patientsdetails` (`SSNo`, `First_Name`, `Last_name`, `Gender`, `Birth_Date`, `Phone_No`, `Weight`, `height`, `Blood_Type`, `Address`, `Reg_Date`, `Appointed_Specialist`, `Appointed_Dr`, `DId`) VALUES
(20309, 'George', 'silva', 'Male', '10/24/2022', '07112344567', '78', '178cm', 'B', 'colombo 10', '10/24/2022', 'Urologists', 'David', 42705),
(20310, 'Leonard', 'Smith', 'Male', '12/26/1988', '0772341232', '78', '178cm', 'B', 'Colombo 02', '10/25/2022', 'Urologists', 'David', 42705),
(20311, 'Alan', 'Smith', 'Male', '10/25/2022', '0711256567', '78', '167', 'B', 'Colombo 10', '10/25/2022', 'Urologists', 'David', 42705),
(20312, 'Smith', 'Fdo', 'Male', '2/2/2000', '07445656332', '78', '178cm', 'B+', 'Clombo 9', '10/25/2022', 'Urologists', 'David', 42705),
(20313, 'Eric', 'Silva', 'Male', 'Monday, January 9, 1989', '0726786786', '78', '178', 'B', 'Colombo 3', '11/5/2022', 'Cardiologists', 'Nimal', 42709),
(20314, 'Ajith', 'Perera', 'Male', 'Saturday, November 5, 2022', '0726786783', '56', '156', 'A', 'Kandy', '11/5/2022', 'Urologists', 'David', 42705),
(20315, 'Julia', 'Smith', 'Female', 'Thursday, November 10, 2022', '0752525684', '72', '185', 'A+', 'Colombo 10', '11/10/2022', 'Cardiologists', 'Nimal', 42709),
(20316, 'Namal', 'Perera', 'Male', 'Wednesday, November 9, 2022', '07525684', '70', '175', 'O+', 'colombo', '11/16/2022', 'Cardiologists', 'Nimal', 42709);

-- --------------------------------------------------------

--
-- Table structure for table `patientsprescription`
--

CREATE TABLE `patientsprescription` (
  `SSNo` int(20) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Last_Name` varchar(50) NOT NULL,
  `Date` varchar(50) DEFAULT NULL,
  `Age` varchar(30) DEFAULT NULL,
  `Diagnosis` varchar(150) NOT NULL,
  `Medicines` varchar(150) NOT NULL,
  `Notes` varchar(150) DEFAULT NULL,
  `Appointed_Dr` varchar(30) NOT NULL,
  `DId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patientsprescription`
--

INSERT INTO `patientsprescription` (`SSNo`, `First_Name`, `Last_Name`, `Date`, `Age`, `Diagnosis`, `Medicines`, `Notes`, `Appointed_Dr`, `DId`) VALUES
(20308, 'yiuyi', 'jhkjh', NULL, '323', 'Aids', 'No medicins', 'God bless', 'David', 42705),
(20314, 'Ajith', 'Perera', NULL, '23', 'fever', 'panadol', '', 'David', 42705),
(20303, 'Vans', 'Silva', NULL, '25', 'Fever', 'Panadol', '', 'Nimal', 42709);

-- --------------------------------------------------------

--
-- Table structure for table `patientswaiting`
--

CREATE TABLE `patientswaiting` (
  `SSNo` int(20) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Last_Name` varchar(50) NOT NULL,
  `Reg_Date` varchar(50) NOT NULL,
  `Appointed_Specialist` varchar(30) NOT NULL,
  `Appointed_Dr` varchar(30) NOT NULL,
  `DId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patientswaiting`
--

INSERT INTO `patientswaiting` (`SSNo`, `First_Name`, `Last_Name`, `Reg_Date`, `Appointed_Specialist`, `Appointed_Dr`, `DId`) VALUES
(20304, 'George', 'SIlva', '0000-00-00', 'Endocrinologists', 'Mary', 42712),
(20313, 'Eric', 'Silva', '11/5/2022', 'Cardiologists', 'Nimal', 42709),
(20314, 'Ajith', 'Perera', '11/5/2022', 'Urologists', 'David', 42705),
(20316, 'Namal', 'Perera', '11/16/2022', 'Cardiologists', 'Nimal', 42709);

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
(42704, 'Kamal', 'Perera', 'Male', '10/04/2022', '0114528645', NULL, '10/07/2022', 'kamal@gmail.com', '1234', 'Biologist'),
(42705, 'David', 'James', 'Male', '10/14/2022', '0114526587', 'Urologists', '10/06/2022', 'david@gmail.com', '1234', 'Doctor'),
(42706, 'Natasha', 'Adams', 'Female', '10/06/2022', '0714526358', NULL, '10/06/2022', 'natasha@gmail.com', '1234', 'Receptionist'),
(42707, 'Bill', 'Pitt', 'Male', '10/15/2022', '075426354', NULL, '10/05/2022', 'bill@gmail.com', '1234', 'Biologist'),
(42708, 'Evelyn', 'Joshep', 'Female', '10/08/2022', '0723625418', NULL, '10/04/2022', 'evlyn@gmail.com', '1234', 'Biologist'),
(42709, 'Nimal', 'Alwis', 'Male', '10/14/2022', '074256328', 'Cardiologists', '10/06/2022', 'nimal@gmail.com', '1234', 'Doctor'),
(42710, 'Henry', 'Parker', 'Male', '10/05/2022', '0752410365', NULL, '10/07/2022', 'henry@gmail.com', '1234', 'Receptionist'),
(42711, 'Peter', 'Jackson', 'Male', '10/14/2022', '070256348', NULL, '10/19/2022', 'peter@gmail.com', '1234', 'Patient'),
(42712, 'Mary', 'Williams', 'Female', '11/24/2022', '0726586425', 'Endocrinologists', '10/12/2022', 'mary@gmail.com', '1234', 'Doctor'),
(42713, 'Ash', 'Michell', 'Male', '11/23/2022', '0752878658', NULL, '11/09/2022', 'ash@gmail.com', '1234', 'Patient'),
(42714, 'John', 'Doe', 'Male', '11/24/2022', '0712458789', NULL, '11/15/2022', 'john@gmail.com', '1234', 'Receptionist'),
(42716, 'Evelyn', 'Adams', 'Female', '11/18/2022', '0756585412', NULL, '11/17/2022', 'eve@gmail.com', '1234', 'Biologist'),
(42717, 'Alex', 'Hales', 'Male', '11/24/2022', '0751414125', NULL, '11/21/2022', 'alexx@gmail.com', '1234', 'Pharmacist'),
(42718, 'Elena', 'Hoper', 'Female', '11/08/2022', '0114758678', NULL, '11/15/2022', 'elena@gmail.com', '1234', 'Pharmacist'),
(42724, 'Lary', 'Parker', 'Male', '11/23/2022', '0752587658', NULL, '11/30/2022', 'lary@gmail.com', '1234', 'Patient');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `patientsdetails`
--
ALTER TABLE `patientsdetails`
  ADD PRIMARY KEY (`SSNo`);

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
-- AUTO_INCREMENT for table `patientsdetails`
--
ALTER TABLE `patientsdetails`
  MODIFY `SSNo` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20317;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42725;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
