-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 04, 2024 at 07:00 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `foodordering`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `UserName` varchar(255) NOT NULL,
  `HashedPassword` longtext NOT NULL,
  `AvatarUrl` longtext NOT NULL,
  `Email` longtext NOT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `Id` int(11) NOT NULL,
  `Name` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`Id`, `Name`) VALUES
(2, 'Món chính'),
(3, 'Món ăn nhẹ'),
(4, 'Đồ uống '),
(5, 'Tráng miệng'),
(6, 'Ăn vặt');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `Id` int(11) NOT NULL,
  `Status` longtext NOT NULL,
  `TotalPrice` longtext NOT NULL,
  `Date` int(11) NOT NULL,
  `CustomerUserId` varchar(255) DEFAULT NULL,
  `EmployeeUserId` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`Id`, `Status`, `TotalPrice`, `Date`, `CustomerUserId`, `EmployeeUserId`) VALUES
(1, 'Đã thanh toán', '100000', 111111, 'harry05', 'NV01');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `Id` int(11) NOT NULL,
  `Name` longtext NOT NULL,
  `Description` longtext NOT NULL,
  `Price` bigint(20) NOT NULL,
  `ImageUrl` longtext NOT NULL,
  `categoryId` int(11) NOT NULL,
  `OrderId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`Id`, `Name`, `Description`, `Price`, `ImageUrl`, `categoryId`, `OrderId`) VALUES
(2, 'Bánh mì', 'Bánh mì Việt Nam', 15000, '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', 3, NULL),
(3, 'Bún bò huế', 'Món nước', 50000, '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', 2, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserId` varchar(255) NOT NULL,
  `FullName` longtext NOT NULL,
  `Address` longtext NOT NULL,
  `PhoneNumber` longtext NOT NULL,
  `Discriminator` longtext NOT NULL,
  `Email` longtext DEFAULT NULL,
  `IdCard` longtext DEFAULT NULL,
  `Position` longtext DEFAULT NULL,
  `Salary` bigint(20) DEFAULT NULL,
  `WorkingTime` longtext DEFAULT NULL,
  `ApplyDate` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserId`, `FullName`, `Address`, `PhoneNumber`, `Discriminator`, `Email`, `IdCard`, `Position`, `Salary`, `WorkingTime`, `ApplyDate`) VALUES
('harry05', 'Nguyen Van A', '12C2 NVL', '09837826', 'Customer', NULL, NULL, NULL, NULL, NULL, NULL),
('NV01', 'Nguyen Van B', '14a NVL', '03890213', 'Employee', 'nv1@gmail.com', '9372911203', 'Nhan vien', 10000000, 'Tối', '11/11/2023');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20240325093209_init-database', '6.0.28'),
('20240325093303_reinit-database', '6.0.28');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`UserName`),
  ADD UNIQUE KEY `IX_Account_UserId` (`UserId`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Orders_CustomerUserId` (`CustomerUserId`),
  ADD KEY `IX_Orders_EmployeeUserId` (`EmployeeUserId`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Products_categoryId` (`categoryId`),
  ADD KEY `IX_Products_OrderId` (`OrderId`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30100234;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `FK_Account_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE CASCADE;

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `FK_Orders_Users_CustomerUserId` FOREIGN KEY (`CustomerUserId`) REFERENCES `users` (`UserId`),
  ADD CONSTRAINT `FK_Orders_Users_EmployeeUserId` FOREIGN KEY (`EmployeeUserId`) REFERENCES `users` (`UserId`);

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `FK_Products_Categories_categoryId` FOREIGN KEY (`categoryId`) REFERENCES `categories` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Products_Orders_OrderId` FOREIGN KEY (`OrderId`) REFERENCES `orders` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
