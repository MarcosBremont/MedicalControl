CREATE DATABASE  IF NOT EXISTS `medicalcontrol` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `medicalcontrol`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: medicalcontrol
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `t_alergia`
--

DROP TABLE IF EXISTS `t_alergia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_alergia` (
  `IDALERGIA` int NOT NULL AUTO_INCREMENT,
  `NOMBREA` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`IDALERGIA`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_alergia`
--

LOCK TABLES `t_alergia` WRITE;
/*!40000 ALTER TABLE `t_alergia` DISABLE KEYS */;
INSERT INTO `t_alergia` VALUES (2,'Agua'),(3,'Azucar'),(6,'sdasdsa'),(7,'sadasdas'),(8,'hjjhj'),(9,'wwwwwwwwww'),(10,'nnnnnn');
/*!40000 ALTER TABLE `t_alergia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_citamedica`
--

DROP TABLE IF EXISTS `t_citamedica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_citamedica` (
  `IDCITAMEDICA` int NOT NULL AUTO_INCREMENT,
  `HORACM` varchar(30) NOT NULL,
  `FECHACM` varchar(30) NOT NULL,
  `COMENTARIO` varchar(50) DEFAULT NULL,
  `ID2SEGUR` int DEFAULT NULL,
  `ID2ALERG` int DEFAULT NULL,
  `ID2DOCTOR` int DEFAULT NULL,
  `NombreCompleto` varchar(60) NOT NULL,
  PRIMARY KEY (`IDCITAMEDICA`),
  KEY `FK2SEGURO` (`ID2SEGUR`),
  KEY `FK2DOCTOR` (`ID2DOCTOR`),
  KEY `FK2ALERG` (`ID2ALERG`),
  CONSTRAINT `FK2ALERG` FOREIGN KEY (`ID2ALERG`) REFERENCES `t_alergia` (`IDALERGIA`),
  CONSTRAINT `FK2DOCTOR` FOREIGN KEY (`ID2DOCTOR`) REFERENCES `t_doctor` (`IDDOCTOR`),
  CONSTRAINT `FK2SEGURO` FOREIGN KEY (`ID2SEGUR`) REFERENCES `t_segurom` (`IDSEGURO`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_citamedica`
--

LOCK TABLES `t_citamedica` WRITE;
/*!40000 ALTER TABLE `t_citamedica` DISABLE KEYS */;
INSERT INTO `t_citamedica` VALUES (8,'4:24:00 p. m.','11/8/2020','Aggggggg',1,2,1,'fdsfsd'),(11,'4:24:00 p. m.','11/8/2020','dfsdfsdfsd',5,3,16,'aaaaaaaaaaa');
/*!40000 ALTER TABLE `t_citamedica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_doctor`
--

DROP TABLE IF EXISTS `t_doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_doctor` (
  `IDDOCTOR` int NOT NULL AUTO_INCREMENT,
  `NOMBREDOCTOR` varchar(30) DEFAULT NULL,
  `ESPECIALIDAD` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`IDDOCTOR`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_doctor`
--

LOCK TABLES `t_doctor` WRITE;
/*!40000 ALTER TABLE `t_doctor` DISABLE KEYS */;
INSERT INTO `t_doctor` VALUES (1,'Dr. Marcos','Pediatría'),(2,'Dra. Angie','of'),(3,'Carlos','Carlos'),(4,'Josefina','aaaaa'),(5,'Emelyt','Emelyt'),(6,'Lola','Lola'),(8,'Polen','Polen'),(9,'Wilkania','Wilkania'),(10,'sdsd','sdsd'),(11,'cccccaaa','cccccaaa'),(12,'fdsfsdfsd','fdsfsdfsd'),(13,'fgffff','fgffff'),(14,'fsdfds','fsdfds'),(15,'dsadsa','dsadsa'),(16,'david','david'),(17,'Yeannna','saasasa'),(20,'sadasd','sadadsa'),(21,'dsada','sdadsa'),(22,'qqq','qq');
/*!40000 ALTER TABLE `t_doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_historialclinico`
--

DROP TABLE IF EXISTS `t_historialclinico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_historialclinico` (
  `IDhistorialClinico` int NOT NULL AUTO_INCREMENT,
  `NombreP` varchar(25) NOT NULL,
  `ApellidoP` varchar(50) NOT NULL,
  `Fecha` datetime DEFAULT NULL,
  `Sexo` varchar(1) NOT NULL,
  `Telefono` varchar(12) NOT NULL,
  `Procedencia` varchar(100) NOT NULL,
  `Residencia` varchar(100) NOT NULL,
  `Edad` int NOT NULL,
  `Cedula` varchar(13) DEFAULT NULL,
  `Telefono2` varchar(12) DEFAULT NULL,
  `Seguro` varchar(40) DEFAULT NULL,
  `Doctor` varchar(40) DEFAULT NULL,
  `Ocupacion` varchar(50) NOT NULL,
  `Religion` varchar(50) NOT NULL,
  `EstadoCivil` varchar(15) DEFAULT NULL,
  `Raza` varchar(25) DEFAULT NULL,
  `AntAlrg` varchar(50) NOT NULL,
  `AntQrg` varchar(50) DEFAULT NULL,
  `AntHops` varchar(100) DEFAULT NULL,
  `AntMed` varchar(100) DEFAULT NULL,
  `AntTra` varchar(100) DEFAULT NULL,
  `Ninez` varchar(100) DEFAULT NULL,
  `Adolescencia` varchar(100) DEFAULT NULL,
  `Adultez` varchar(100) DEFAULT NULL,
  `Sonografia` blob,
  `TomografiaComp` blob,
  `Radriografia` blob,
  `ResonanciaM` blob,
  PRIMARY KEY (`IDhistorialClinico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_historialclinico`
--

LOCK TABLES `t_historialclinico` WRITE;
/*!40000 ALTER TABLE `t_historialclinico` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_historialclinico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_inventario`
--

DROP TABLE IF EXISTS `t_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_inventario` (
  `idt_inventario` int NOT NULL AUTO_INCREMENT,
  `NombreMedicamento` varchar(60) NOT NULL,
  `CantidadMedicamento` int DEFAULT NULL,
  `Proveedor` varchar(60) DEFAULT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  `Fecha` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`idt_inventario`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_inventario`
--

LOCK TABLES `t_inventario` WRITE;
/*!40000 ALTER TABLE `t_inventario` DISABLE KEYS */;
INSERT INTO `t_inventario` VALUES (4,'Advil',59,'3','aaaaaaaaaaaaaa','29/7/2020'),(6,'Dicofenac',100,'1','Sirve para esto','31/7/2020');
/*!40000 ALTER TABLE `t_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_paciente`
--

DROP TABLE IF EXISTS `t_paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_paciente` (
  `IDPACIENTE` int NOT NULL AUTO_INCREMENT,
  `NOMBREP` varchar(30) DEFAULT NULL,
  `APELLIDOP` varchar(30) DEFAULT NULL,
  `EDADP` int DEFAULT NULL,
  `CEDULAP` varchar(13) DEFAULT NULL,
  `DIRECCIONP` varchar(60) DEFAULT NULL,
  `TELEFONOP` varchar(13) DEFAULT NULL,
  `TELEFONOP2` varchar(13) DEFAULT NULL,
  `SEXOP` char(1) DEFAULT NULL,
  `IDTALER` int DEFAULT NULL,
  `IDTSEGURO` int DEFAULT NULL,
  `IDTDOCTOR` int DEFAULT NULL,
  PRIMARY KEY (`IDPACIENTE`),
  KEY `FKSEGURO` (`IDTSEGURO`),
  KEY `FKDOCTOR` (`IDTDOCTOR`),
  CONSTRAINT `FKDOCTOR` FOREIGN KEY (`IDTDOCTOR`) REFERENCES `t_doctor` (`IDDOCTOR`),
  CONSTRAINT `FKSEGURO` FOREIGN KEY (`IDTSEGURO`) REFERENCES `t_segurom` (`IDSEGURO`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_paciente`
--

LOCK TABLES `t_paciente` WRITE;
/*!40000 ALTER TABLE `t_paciente` DISABLE KEYS */;
INSERT INTO `t_paciente` VALUES (6,'Marcos','Bremont',22,'050-5259658-5','Medina','809-907-3244','809-574-6213','M',2,1,1),(7,'aa','dcccc',24,'010-4500212-5','Medina','809-907-3244','809-574-6213','M',3,1,4),(8,'','sdasdas',22,'525-4654664-6','jhgjghjghjhgjgh','565-464-5654','456-456-5465','M',2,1,1),(9,'111','ssdadas',22,'454-6546465-4','dfgdsfdsfdsfds','564-565-4654','546-454-6546','M',2,1,1),(10,'sasasa','fdfsdfsd',33,'342-3432432-4','dfdsfdsfds','343-243-2432','324-234-3242','F',2,1,1),(11,'','dsadasda',22,'323-2323232-3','fdfdsfdsfsdfsd','434-343-3434','432-423-4324','M',2,1,1),(12,'323232','dfsdfsd',344,'343-4213123-2','dfsfsdfsdf','232-323-2234','324-324-2342','M',2,1,1),(13,'fsdfsfs','dsfsfdsdfs',342,'233-2323232-3','fdsdfsdfsd','324-234-3244','342-342-4324','M',2,1,1),(14,'','GHJKJKKJ',212,'545-6456564-4','GFDSGDSGDS','465-465-4654','654-646-4564','M',2,1,1),(15,'5644','gfhdfhd',33,'453-4534534-5','fdgdfgdf','342-423-4234','654-654-6456','M',2,1,1),(16,'sdas','dsadas',22,'232-1321313-1','fdfsdfsd','213-131-2321','213-123-1231','M',2,1,1);
/*!40000 ALTER TABLE `t_paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_proveedor`
--

DROP TABLE IF EXISTS `t_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_proveedor` (
  `idt_proveedor` int NOT NULL AUTO_INCREMENT,
  `NombreProveedor` varchar(60) DEFAULT NULL,
  `UbicacionProveedor` varchar(60) DEFAULT NULL,
  `TelefonoProveedor` varchar(60) DEFAULT NULL,
  `Correo` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`idt_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_proveedor`
--

LOCK TABLES `t_proveedor` WRITE;
/*!40000 ALTER TABLE `t_proveedor` DISABLE KEYS */;
INSERT INTO `t_proveedor` VALUES (1,'No se x','Santiago de los caballeros','809-099-9965','Nose@gmail.com'),(3,'aaaaaa','aaaaaaaaaaa','111-111-1111','dsdsadsadasda'),(4,'aaaaaaaa','Santiago de los caballeros','555-555-5555','Nose@gmail.com');
/*!40000 ALTER TABLE `t_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_segurom`
--

DROP TABLE IF EXISTS `t_segurom`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `t_segurom` (
  `IDSEGURO` int NOT NULL AUTO_INCREMENT,
  `NOMBRESEGURO` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`IDSEGURO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_segurom`
--

LOCK TABLES `t_segurom` WRITE;
/*!40000 ALTER TABLE `t_segurom` DISABLE KEYS */;
INSERT INTO `t_segurom` VALUES (1,'MEDICARE'),(5,'ghgfhfghfd');
/*!40000 ALTER TABLE `t_segurom` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `LoginName` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Email` varchar(150) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `LoginName` (`LoginName`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Admin','Admin','Marcos','Bremont','Marcosbremont00@gmail.com'),(2,'asd','asd','asd','asd','asd');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vtpacientetdtatsg`
--

DROP TABLE IF EXISTS `vtpacientetdtatsg`;
/*!50001 DROP VIEW IF EXISTS `vtpacientetdtatsg`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vtpacientetdtatsg` AS SELECT 
 1 AS `IDPACIENTE`,
 1 AS `NOMBREP`,
 1 AS `APELLIDOP`,
 1 AS `EDADP`,
 1 AS `CEDULAP`,
 1 AS `DIRECCIONP`,
 1 AS `TELEFONOP`,
 1 AS `TELEFONOP2`,
 1 AS `SEXOP`,
 1 AS `IDSEGURO`,
 1 AS `NOMBRESEGURO`,
 1 AS `IDALERGIA`,
 1 AS `NOMBREA`,
 1 AS `IDDOCTOR`,
 1 AS `NOMBREDOCTOR`,
 1 AS `ESPECIALIDAD`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vtpacientetdtatsg`
--

/*!50001 DROP VIEW IF EXISTS `vtpacientetdtatsg`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vtpacientetdtatsg` AS select 1 AS `IDPACIENTE`,1 AS `NOMBREP`,1 AS `APELLIDOP`,1 AS `EDADP`,1 AS `CEDULAP`,1 AS `DIRECCIONP`,1 AS `TELEFONOP`,1 AS `TELEFONOP2`,1 AS `SEXOP`,1 AS `IDSEGURO`,1 AS `NOMBRESEGURO`,1 AS `IDALERGIA`,1 AS `NOMBREA`,1 AS `IDDOCTOR`,1 AS `NOMBREDOCTOR`,1 AS `ESPECIALIDAD` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-12 14:42:59
