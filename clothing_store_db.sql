-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 03, 2026 at 01:40 PM
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
-- Database: `clothing_store_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `contact_number` varchar(30) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `name`, `contact_number`, `created_at`) VALUES
(7, 'Jklai', '0167190770', '2026-09-22 04:59:55'),
(8, 'boon bing', '6767676767', '2026-09-22 05:02:54'),
(9, 'Jun Kah', '6767676676767', '2026-09-23 04:26:31'),
(10, 'TBB', '01010101', '2026-09-27 13:48:49'),
(11, 'Tan Boon Bing', '01111333149', '2026-09-29 03:57:45'),
(12, 'kkkkk', '999', '2026-09-30 04:18:39'),
(13, 'ASD', '888', '2026-09-30 05:17:27');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `address` text DEFAULT NULL,
  `premium_packaging` tinyint(1) DEFAULT 0,
  `express_delivery` tinyint(1) DEFAULT 0,
  `promo_code` varchar(50) DEFAULT NULL,
  `discount_applied` decimal(10,2) DEFAULT 0.00,
  `subtotal` decimal(10,2) NOT NULL,
  `services_fee` decimal(10,2) DEFAULT 0.00,
  `total_amount` decimal(10,2) NOT NULL,
  `order_status` varchar(20) NOT NULL DEFAULT 'Pending',
  `order_date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_id`, `customer_id`, `address`, `premium_packaging`, `express_delivery`, `promo_code`, `discount_applied`, `subtotal`, `services_fee`, `total_amount`, `order_status`, `order_date`) VALUES
(9, 7, '12, Jln Bestari 123, Tmn Bestari 2', 1, 1, 'WELCOME10', 32.80, 228.00, 15.00, 210.20, 'Completed', '2026-09-22 08:16:15'),
(10, 9, '67676767676', 1, 1, 'WELCOME10', 232.00, 2220.00, 15.00, 2003.00, 'Shipped', '2026-09-23 04:27:04'),
(11, 10, '1111111', 1, 1, NULL, 0.00, 80.00, 15.00, 95.00, 'Paid', '2026-09-27 13:49:08'),
(12, 13, '', 1, 0, 'WELCOME10', 2.00, 20.00, 5.00, 23.00, 'Pending', '2026-09-30 05:18:01');

-- --------------------------------------------------------

--
-- Table structure for table `order_items`
--

CREATE TABLE `order_items` (
  `item_id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `product_name` varchar(100) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `quantity` int(11) NOT NULL,
  `size` varchar(10) NOT NULL,
  `item_total` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `order_items`
--

INSERT INTO `order_items` (`item_id`, `order_id`, `product_name`, `price`, `quantity`, `size`, `item_total`) VALUES
(28, 9, 'Basic T-Shirt', 20.00, 1, '3', 20.00),
(29, 9, 'Jeans', 42.00, 2, '3', 84.00),
(30, 9, 'Pyjamas', 55.00, 1, '2', 55.00),
(31, 9, 'Swimsuit', 69.00, 1, '4', 69.00),
(32, 10, 'Basic T-Shirt', 20.00, 111, '0', 2220.00),
(33, 11, 'Basic T-Shirt', 20.00, 2, '2', 40.00),
(34, 11, 'Cargo Pants', 40.00, 1, '1', 40.00),
(35, 12, 'Basic T-Shirt', 20.00, 1, '4', 20.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Indexes for table `order_items`
--
ALTER TABLE `order_items`
  ADD PRIMARY KEY (`item_id`),
  ADD KEY `order_id` (`order_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `order_items`
--
ALTER TABLE `order_items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`);

--
-- Constraints for table `order_items`
--
ALTER TABLE `order_items`
  ADD CONSTRAINT `order_items_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
