-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: projectcdb
-- ------------------------------------------------------
-- Server version	8.0.18

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
-- Table structure for table `announcements`
--

DROP TABLE IF EXISTS `announcements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `announcements` (
  `AnnouncementsID` int(11) NOT NULL,
  `Text` varchar(45) DEFAULT NULL,
  `VakID` int(11) DEFAULT NULL,
  PRIMARY KEY (`AnnouncementsID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `announcements`
--

LOCK TABLES `announcements` WRITE;
/*!40000 ALTER TABLE `announcements` DISABLE KEYS */;
/*!40000 ALTER TABLE `announcements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bericht`
--

DROP TABLE IF EXISTS `bericht`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bericht` (
  `BerichtID` int(11) NOT NULL,
  `Text` varchar(45) DEFAULT NULL,
  `VoirigBericht` int(11) DEFAULT NULL,
  `ChatID` int(11) DEFAULT NULL,
  `UserID` int(11) DEFAULT NULL,
  PRIMARY KEY (`BerichtID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bericht`
--

LOCK TABLES `bericht` WRITE;
/*!40000 ALTER TABLE `bericht` DISABLE KEYS */;
/*!40000 ALTER TABLE `bericht` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chat`
--

DROP TABLE IF EXISTS `chat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chat` (
  `ChatID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `PeerCoachID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ChatID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chat`
--

LOCK TABLES `chat` WRITE;
/*!40000 ALTER TABLE `chat` DISABLE KEYS */;
/*!40000 ALTER TABLE `chat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faqvragen`
--

DROP TABLE IF EXISTS `faqvragen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `faqvragen` (
  `vraag` varchar(45) NOT NULL,
  `vak` varchar(45) DEFAULT NULL,
  `antwoord` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`vraag`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faqvragen`
--

LOCK TABLES `faqvragen` WRITE;
/*!40000 ALTER TABLE `faqvragen` DISABLE KEYS */;
INSERT INTO `faqvragen` VALUES ('qweqwe','Analyse','dasdasdas'),('test2','Development','hbbjhjhbjh');
/*!40000 ALTER TABLE `faqvragen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ingeschrevenvakken`
--

DROP TABLE IF EXISTS `ingeschrevenvakken`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ingeschrevenvakken` (
  `IngeschrevenvakkenID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` int(11) DEFAULT NULL,
  `vakID` int(11) DEFAULT NULL,
  PRIMARY KEY (`IngeschrevenvakkenID`),
  UNIQUE KEY `IngeschrevenvakkenID_UNIQUE` (`IngeschrevenvakkenID`)
) ENGINE=InnoDB AUTO_INCREMENT=400 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingeschrevenvakken`
--

LOCK TABLES `ingeschrevenvakken` WRITE;
/*!40000 ALTER TABLE `ingeschrevenvakken` DISABLE KEYS */;
INSERT INTO `ingeschrevenvakken` VALUES (391,1,19),(392,1,20),(393,1,21),(394,1,22),(395,1,23),(396,1,24),(397,1,25),(398,1,26),(399,1,27);
/*!40000 ALTER TABLE `ingeschrevenvakken` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `klas`
--

DROP TABLE IF EXISTS `klas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `klas` (
  `KlasID` int(11) NOT NULL,
  `Klasnaam` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`KlasID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `klas`
--

LOCK TABLES `klas` WRITE;
/*!40000 ALTER TABLE `klas` DISABLE KEYS */;
INSERT INTO `klas` VALUES (77,'INF1A'),(78,'INF1B'),(79,'INF1C'),(80,'INF1D'),(81,'INF1E'),(82,'INF1F'),(83,'INF1H'),(84,'INF1I'),(85,'INF1J'),(86,'INF1K');
/*!40000 ALTER TABLE `klas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `peercoachwachtrij`
--

DROP TABLE IF EXISTS `peercoachwachtrij`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `peercoachwachtrij` (
  `PeercoachWachtrijID` int(11) NOT NULL,
  `PeercoachID` varchar(45) NOT NULL,
  `WachtrijID` varchar(45) NOT NULL,
  PRIMARY KEY (`PeercoachWachtrijID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `peercoachwachtrij`
--

LOCK TABLES `peercoachwachtrij` WRITE;
/*!40000 ALTER TABLE `peercoachwachtrij` DISABLE KEYS */;
INSERT INTO `peercoachwachtrij` VALUES (1,'1','1'),(21,'1','3'),(41,'1','4');
/*!40000 ALTER TABLE `peercoachwachtrij` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roosterdag`
--

DROP TABLE IF EXISTS `roosterdag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roosterdag` (
  `RoosterDagID` int(11) NOT NULL AUTO_INCREMENT,
  `Uur1` int(11) DEFAULT NULL,
  `Uur2` int(11) DEFAULT NULL,
  `Uur3` int(11) DEFAULT NULL,
  `Uur4` int(11) DEFAULT NULL,
  `Uur5` int(11) DEFAULT NULL,
  `Uur6` int(11) DEFAULT NULL,
  `Uur7` int(11) DEFAULT NULL,
  `Uur8` int(11) DEFAULT NULL,
  `Uur9` int(11) DEFAULT NULL,
  `Uur10` int(11) DEFAULT NULL,
  `Uur11` int(11) DEFAULT NULL,
  `Uur12` int(11) DEFAULT NULL,
  `Uur13` int(11) DEFAULT NULL,
  `Uur14` int(11) DEFAULT NULL,
  `Uur15` int(11) DEFAULT NULL,
  `RoosterWeekID` int(11) DEFAULT NULL,
  `DagnNaam` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`RoosterDagID`),
  UNIQUE KEY `RoosterDagID_UNIQUE` (`RoosterDagID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roosterdag`
--

LOCK TABLES `roosterdag` WRITE;
/*!40000 ALTER TABLE `roosterdag` DISABLE KEYS */;
INSERT INTO `roosterdag` VALUES (11,0,0,0,19,19,0,0,0,0,0,0,0,0,0,0,3,'Maandag '),(12,0,20,20,21,21,21,21,22,0,0,0,0,0,0,0,3,'Dinsdag '),(13,0,0,0,23,23,24,24,0,0,0,0,0,0,0,0,3,'Woensdag '),(14,0,0,0,0,25,25,26,26,27,27,0,0,0,0,0,3,'Donderdag '),(15,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,'Vrijdag ');
/*!40000 ALTER TABLE `roosterdag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roosterweek`
--

DROP TABLE IF EXISTS `roosterweek`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roosterweek` (
  `RoosterWeekID` int(11) NOT NULL AUTO_INCREMENT,
  `WeekNummer` int(11) DEFAULT NULL,
  `KlasID` int(11) DEFAULT NULL,
  PRIMARY KEY (`RoosterWeekID`),
  UNIQUE KEY `RoosterWeekID_UNIQUE` (`RoosterWeekID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roosterweek`
--

LOCK TABLES `roosterweek` WRITE;
/*!40000 ALTER TABLE `roosterweek` DISABLE KEYS */;
INSERT INTO `roosterweek` VALUES (3,47,68);
/*!40000 ALTER TABLE `roosterweek` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `Rol` varchar(45) DEFAULT NULL,
  `KlasID` int(11) DEFAULT NULL,
  `voornaam` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Wachtwoord` varchar(45) DEFAULT NULL,
  `Achternaam` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `UserID_UNIQUE` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'fds',68,'dfs','fds','gd','dg'),(2,'p',68,'laurens','laurensmaas9702@gmail.com','maas','maas'),(3,'s',68,'erik','spam123@gmail.com','makkelijk','qweqwe'),(4,'p',68,'Laurens',NULL,'l',NULL),(5,'s',68,'Matthijs',NULL,'m',NULL),(6,'s',78,'m','mh@email.com','mh','h'),(7,'p',0,'p','pc','pc','c');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vak`
--

DROP TABLE IF EXISTS `vak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vak` (
  `VakID` int(11) NOT NULL AUTO_INCREMENT,
  `Docent` varchar(45) DEFAULT NULL,
  `Locaal` varchar(45) DEFAULT NULL,
  `Naam` varchar(45) DEFAULT NULL,
  `Discriptie` varchar(45) DEFAULT NULL,
  `Isleeg` int(11) DEFAULT NULL,
  PRIMARY KEY (`VakID`),
  UNIQUE KEY `VakID_UNIQUE` (`VakID`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vak`
--

LOCK TABLES `vak` WRITE;
/*!40000 ALTER TABLE `vak` DISABLE KEYS */;
INSERT INTO `vak` VALUES (19,'ROODA','H.3.308','Ondersteuningsmodule Ne','',0),(20,'DUJAA','H.4.318','Skills 1','Project &amp; target group',0),(21,'DUJAA','H.4.318,H.2.','Project A','Creating a board',0),(22,'DUJAA','H.4.318','Studieloopbaancoaching ','',0),(23,'JGBOS','WD.05.002','Analyse 2','Foundation of',0),(24,'PEIAC','WD.05.002','INFDEN02','',0),(25,'GIACF','H.5.314-C120','Development 2','Func lambdas recurs HOFs',0),(26,'JGBOS','H.4.318','Analyse 2','Foundation of',0),(27,'ABBAM','H.2.403','Development 2','Func lambdas recurs HOFs',0);
/*!40000 ALTER TABLE `vak` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vraag`
--

DROP TABLE IF EXISTS `vraag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vraag` (
  `vraagID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `VakID` int(11) DEFAULT NULL,
  `VraagText` varchar(45) DEFAULT NULL,
  `AndwoordText` varchar(45) DEFAULT NULL,
  `IsFAQ` int(11) DEFAULT NULL,
  `DateAdded` datetime(6) DEFAULT NULL,
  `EndDate` datetime(6) DEFAULT NULL,
  `Locatie` varchar(45) DEFAULT NULL,
  `WachtrijID` int(11) DEFAULT NULL,
  `IsinProgress` int(11) DEFAULT NULL,
  PRIMARY KEY (`vraagID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vraag`
--

LOCK TABLES `vraag` WRITE;
/*!40000 ALTER TABLE `vraag` DISABLE KEYS */;
INSERT INTO `vraag` VALUES (0,1,20,'qweqwe','',0,'2019-11-28 17:38:41.000000','0001-01-01 00:00:00.000000','qweq',0,0),(5,1,24,'test3','',0,'2019-11-28 17:38:55.000000','0001-01-01 00:00:00.000000','qweqqweqw',0,0),(6,1,24,'test2','',0,'2019-11-28 17:38:56.000000','0001-01-01 00:00:00.000000','qweqqweqw',0,1),(7,1,24,'test1','',0,'2019-11-28 17:38:56.000000','0001-01-01 00:00:00.000000','qweqqweqw',0,0),(8,1,24,'qweqwe','',0,'2019-11-28 17:38:57.000000','0001-01-01 00:00:00.000000','qweqqweqw',0,0),(9,1,20,'qweqwe','',0,'2019-11-28 17:38:57.000000','0001-01-01 00:00:00.000000','qweqqwe',0,0),(10,1,20,'qweqwe','',0,'2019-11-28 17:38:58.000000','0001-01-01 00:00:00.000000','qweq',0,0);
/*!40000 ALTER TABLE `vraag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wachtrij`
--

DROP TABLE IF EXISTS `wachtrij`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `wachtrij` (
  `WachtrijId` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `DateAdded` datetime DEFAULT NULL,
  `EndDate` datetime DEFAULT NULL,
  PRIMARY KEY (`WachtrijId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wachtrij`
--

LOCK TABLES `wachtrij` WRITE;
/*!40000 ALTER TABLE `wachtrij` DISABLE KEYS */;
INSERT INTO `wachtrij` VALUES (0,'Algemeen','2019-11-19 11:45:00','2019-11-19 16:00:00'),(1,'test1','2019-11-19 11:45:00','2019-11-19 16:00:00'),(2,'test2','2019-11-19 11:45:00','2019-11-19 16:00:00'),(3,'Test','2019-11-19 11:45:00','2019-11-19 16:00:00'),(4,'test wachtrij','2019-11-20 15:15:00','2019-11-20 18:30:00');
/*!40000 ALTER TABLE `wachtrij` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-12-02 13:18:43
