-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: bd_svb
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `controlcompte`
--

DROP TABLE IF EXISTS `controlcompte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controlcompte` (
  `numerocompte` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlcompte`
--

LOCK TABLES `controlcompte` WRITE;
/*!40000 ALTER TABLE `controlcompte` DISABLE KEYS */;
INSERT INTO `controlcompte` VALUES (1);
/*!40000 ALTER TABLE `controlcompte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controldepot`
--

DROP TABLE IF EXISTS `controldepot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controldepot` (
  `numerocode` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controldepot`
--

LOCK TABLES `controldepot` WRITE;
/*!40000 ALTER TABLE `controldepot` DISABLE KEYS */;
INSERT INTO `controldepot` VALUES (1);
/*!40000 ALTER TABLE `controldepot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controlemploye`
--

DROP TABLE IF EXISTS `controlemploye`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controlemploye` (
  `numerocode` int DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlemploye`
--

LOCK TABLES `controlemploye` WRITE;
/*!40000 ALTER TABLE `controlemploye` DISABLE KEYS */;
INSERT INTO `controlemploye` VALUES (2);
/*!40000 ALTER TABLE `controlemploye` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controlpayroll`
--

DROP TABLE IF EXISTS `controlpayroll`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controlpayroll` (
  `numerocode` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlpayroll`
--

LOCK TABLES `controlpayroll` WRITE;
/*!40000 ALTER TABLE `controlpayroll` DISABLE KEYS */;
INSERT INTO `controlpayroll` VALUES (1);
/*!40000 ALTER TABLE `controlpayroll` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controlretrait`
--

DROP TABLE IF EXISTS `controlretrait`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controlretrait` (
  `numerocode` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlretrait`
--

LOCK TABLES `controlretrait` WRITE;
/*!40000 ALTER TABLE `controlretrait` DISABLE KEYS */;
INSERT INTO `controlretrait` VALUES (1);
/*!40000 ALTER TABLE `controlretrait` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controltransfert`
--

DROP TABLE IF EXISTS `controltransfert`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controltransfert` (
  `numerocode` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controltransfert`
--

LOCK TABLES `controltransfert` WRITE;
/*!40000 ALTER TABLE `controltransfert` DISABLE KEYS */;
INSERT INTO `controltransfert` VALUES (1);
/*!40000 ALTER TABLE `controltransfert` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controlutilisateur`
--

DROP TABLE IF EXISTS `controlutilisateur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `controlutilisateur` (
  `numerocode` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controlutilisateur`
--

LOCK TABLES `controlutilisateur` WRITE;
/*!40000 ALTER TABLE `controlutilisateur` DISABLE KEYS */;
INSERT INTO `controlutilisateur` VALUES (2);
/*!40000 ALTER TABLE `controlutilisateur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `depot`
--

DROP TABLE IF EXISTS `depot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `depot` (
  `Idtransaction` varchar(255) NOT NULL,
  `numerocompte` varchar(255) NOT NULL,
  `montant` float NOT NULL,
  `description` varchar(255) NOT NULL,
  `date` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `depot`
--

LOCK TABLES `depot` WRITE;
/*!40000 ALTER TABLE `depot` DISABLE KEYS */;
/*!40000 ALTER TABLE `depot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employe`
--

DROP TABLE IF EXISTS `employe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employe` (
  `Id` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `sexe` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `salaire` double NOT NULL,
  `role` varchar(255) NOT NULL,
  `dateEmp` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `nif` varchar(255) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  `datenaissance` varchar(255) NOT NULL,
  `NumeroCompte` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employe`
--

LOCK TABLES `employe` WRITE;
/*!40000 ALTER TABLE `employe` DISABLE KEYS */;
INSERT INTO `employe` VALUES ('EMPL-01','Fidele','Rodolph Phayendy Delon','Masculin','(509) 490-4697',50000,'administrateur','14-Aug-23 3:21:30 PM','rodolphfidele@gmail.com','0021-5729-70 -','Bas vertieres','11-11-2000','Choisir');
/*!40000 ALTER TABLE `employe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gestionclient`
--

DROP TABLE IF EXISTS `gestionclient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gestionclient` (
  `numerocompte` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `sexe` varchar(255) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  `telephone` varchar(255) NOT NULL,
  `date_naissance` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `nif_cin` varchar(255) NOT NULL,
  `date_insc` varchar(255) NOT NULL,
  PRIMARY KEY (`numerocompte`),
  UNIQUE KEY `numerocompte` (`numerocompte`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gestionclient`
--

LOCK TABLES `gestionclient` WRITE;
/*!40000 ALTER TABLE `gestionclient` DISABLE KEYS */;
/*!40000 ALTER TABLE `gestionclient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gestioncompte`
--

DROP TABLE IF EXISTS `gestioncompte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gestioncompte` (
  `numerocompte` varchar(255) NOT NULL,
  `type` varchar(255) DEFAULT NULL,
  `monaie` char(255) DEFAULT NULL,
  `solde` double DEFAULT NULL,
  `etat` varchar(255) DEFAULT NULL,
  `date_insc` varchar(255) NOT NULL,
  PRIMARY KEY (`numerocompte`),
  UNIQUE KEY `numero` (`numerocompte`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gestioncompte`
--

LOCK TABLES `gestioncompte` WRITE;
/*!40000 ALTER TABLE `gestioncompte` DISABLE KEYS */;
/*!40000 ALTER TABLE `gestioncompte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payroll`
--

DROP TABLE IF EXISTS `payroll`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payroll` (
  `id_pay` varchar(255) NOT NULL,
  `num_copt` varchar(255) NOT NULL,
  `no` varchar(255) NOT NULL,
  `pre` varchar(255) NOT NULL,
  `sal` float NOT NULL,
  `descp` varchar(255) NOT NULL,
  `saln` float NOT NULL,
  `dat` varchar(255) NOT NULL,
  `ta` float NOT NULL,
  `co` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payroll`
--

LOCK TABLES `payroll` WRITE;
/*!40000 ALTER TABLE `payroll` DISABLE KEYS */;
/*!40000 ALTER TABLE `payroll` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `retrait`
--

DROP TABLE IF EXISTS `retrait`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `retrait` (
  `idtransaction` varchar(255) NOT NULL,
  `numerocompte` varchar(255) NOT NULL,
  `montant` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `date` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `retrait`
--

LOCK TABLES `retrait` WRITE;
/*!40000 ALTER TABLE `retrait` DISABLE KEYS */;
/*!40000 ALTER TABLE `retrait` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltracabilite`
--

DROP TABLE IF EXISTS `tbltracabilite`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbltracabilite` (
  `code_utilisateur` varchar(50) NOT NULL,
  `libele` varchar(1000) NOT NULL,
  `date_tra` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltracabilite`
--

LOCK TABLES `tbltracabilite` WRITE;
/*!40000 ALTER TABLE `tbltracabilite` DISABLE KEYS */;
INSERT INTO `tbltracabilite` VALUES ('User-1','connexion','14-Aug-23 3:08:30 PM'),('User-1','Insertion-- Employe-->Code-->:EMPL-01-->Nom-->:Fidele','14-Aug-23 3:21:30 PM'),('User-1','Insertion-Utilisateur-->Code-->:USER-1Foction-->administrateur','14-Aug-23 3:23:07 PM'),('User-1','deconnexion','14-Aug-23 3:21:27 PM');
/*!40000 ALTER TABLE `tbltracabilite` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblutilisateur`
--

DROP TABLE IF EXISTS `tblutilisateur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblutilisateur` (
  `code_utilisateur` varchar(50) NOT NULL,
  `code_empl` varchar(50) NOT NULL,
  `fonction` varchar(60) DEFAULT NULL,
  `user` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `module_acces` varchar(255) NOT NULL,
  `Date_insc` varchar(255) NOT NULL,
  `etat` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblutilisateur`
--

LOCK TABLES `tblutilisateur` WRITE;
/*!40000 ALTER TABLE `tblutilisateur` DISABLE KEYS */;
INSERT INTO `tblutilisateur` VALUES ('USER-1','EMPL-01','administrateur','Dolphy','Rodolph4904@','Tous les modules','14-Aug-23 3:23:07 PM',0);
/*!40000 ALTER TABLE `tblutilisateur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transfert`
--

DROP TABLE IF EXISTS `transfert`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transfert` (
  `idtransaction` varchar(255) NOT NULL,
  `de_compte` varchar(11) NOT NULL,
  `a_compte` varchar(11) NOT NULL,
  `montant` float NOT NULL,
  `description` varchar(255) NOT NULL,
  `date` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transfert`
--

LOCK TABLES `transfert` WRITE;
/*!40000 ALTER TABLE `transfert` DISABLE KEYS */;
/*!40000 ALTER TABLE `transfert` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-08-14 15:36:59
