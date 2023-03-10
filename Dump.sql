CREATE DATABASE  IF NOT EXISTS `dbshopcomputerparts` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `dbshopcomputerparts`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dbshopcomputerparts
-- ------------------------------------------------------
-- Server version	5.7.38

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `idCategory` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`idCategory`),
  UNIQUE KEY `idCategory_UNIQUE` (`idCategory`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (4,'Процессоры'),(9,'Кулеры');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compositions_orders`
--

DROP TABLE IF EXISTS `compositions_orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compositions_orders` (
  `idCompositionsOrders` int(11) NOT NULL AUTO_INCREMENT,
  `idOrder` int(11) NOT NULL,
  `idProduct` int(11) NOT NULL,
  `countProduct` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCompositionsOrders`),
  UNIQUE KEY `idCompositionsOrders_UNIQUE` (`idCompositionsOrders`),
  KEY `idOrder_idx` (`idOrder`),
  KEY `idProduct_idx` (`idProduct`),
  CONSTRAINT `idOrder` FOREIGN KEY (`idOrder`) REFERENCES `orders` (`idOrder`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `idProduct` FOREIGN KEY (`idProduct`) REFERENCES `products` (`idProduct`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compositions_orders`
--

LOCK TABLES `compositions_orders` WRITE;
/*!40000 ALTER TABLE `compositions_orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `compositions_orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `idOrder` int(11) NOT NULL AUTO_INCREMENT,
  `date` datetime NOT NULL,
  `idUser` int(11) NOT NULL,
  `countPosition` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `status` enum('Выполнен','Отменен') NOT NULL,
  PRIMARY KEY (`idOrder`),
  UNIQUE KEY `idOrder_UNIQUE` (`idOrder`),
  KEY `user_idx` (`idUser`),
  CONSTRAINT `user` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `idProduct` int(11) NOT NULL,
  `name` varchar(45) NOT NULL,
  `characteristic` varchar(1000) NOT NULL,
  `idCategory` int(11) NOT NULL,
  `linkPhoto` varchar(45) DEFAULT NULL,
  `count` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  PRIMARY KEY (`idProduct`),
  UNIQUE KEY `idProduct_UNIQUE` (`idProduct`),
  UNIQUE KEY `idCategory_UNIQUE` (`idCategory`),
  CONSTRAINT `idCategory` FOREIGN KEY (`idCategory`) REFERENCES `categories` (`idCategory`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Рязянь 3','ну пых пых ...',4,'photo',23,99);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staffs`
--

DROP TABLE IF EXISTS `staffs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staffs` (
  `idStaff` int(11) NOT NULL AUTO_INCREMENT,
  `fullName` varchar(45) NOT NULL,
  `post` varchar(45) NOT NULL,
  `phoneNumber` varchar(17) NOT NULL,
  PRIMARY KEY (`idStaff`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staffs`
--

LOCK TABLES `staffs` WRITE;
/*!40000 ALTER TABLE `staffs` DISABLE KEYS */;
INSERT INTO `staffs` VALUES (1,'Kostin N.K.','main admin','+7 (888) 999-3344'),(2,'Remizov F.G.','toster','+7 (986) 742-3467'),(3,'Ann S.V.','tostic','+7 (956) 907-6543');
/*!40000 ALTER TABLE `staffs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(45) NOT NULL,
  `password` varchar(1000) NOT NULL,
  `status` enum('admin','user') NOT NULL,
  `idStaff` int(11) NOT NULL,
  PRIMARY KEY (`idUser`),
  UNIQUE KEY `idUser_UNIQUE` (`idUser`),
  UNIQUE KEY `login_UNIQUE` (`login`),
  KEY `idStaff_idx` (`idStaff`),
  CONSTRAINT `idStaff` FOREIGN KEY (`idStaff`) REFERENCES `staffs` (`idStaff`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','admin',1),(2,'user','04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb','user',2),(3,'anna','4d4f26369171994f3a46776ee2d88494fb9955800a5bb6261c016c4bb9f30b56','user',3);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-09 18:59:42
