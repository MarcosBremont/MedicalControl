CREATE DATABASE  IF NOT EXISTS `medicalcontrol` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `medicalcontrol`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: medicalcontrol
-- ------------------------------------------------------
-- Server version	5.7.22-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
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
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_alergia` (
  `IDALERGIA` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBREA` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`IDALERGIA`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_alergia`
--

LOCK TABLES `t_alergia` WRITE;
/*!40000 ALTER TABLE `t_alergia` DISABLE KEYS */;
INSERT INTO `t_alergia` VALUES (1,'Polen'),(2,'Agua'),(3,'Azucar'),(4,''),(5,'Polenn');
/*!40000 ALTER TABLE `t_alergia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_citamedica`
--

DROP TABLE IF EXISTS `t_citamedica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_citamedica` (
  `IDCITAMEDICA` int(11) NOT NULL AUTO_INCREMENT,
  `HORACM` varchar(30) NOT NULL,
  `FECHACM` varchar(30) NOT NULL,
  `COMENTARIO` varchar(50) DEFAULT NULL,
  `ID2SEGUR` int(11) DEFAULT NULL,
  `ID2ALERG` int(11) DEFAULT NULL,
  `ID2DOCTOR` int(11) DEFAULT NULL,
  `NombreCompleto` varchar(60) NOT NULL,
  PRIMARY KEY (`IDCITAMEDICA`),
  KEY `FK2SEGURO` (`ID2SEGUR`),
  KEY `FK2DOCTOR` (`ID2DOCTOR`),
  KEY `FK2ALERG` (`ID2ALERG`),
  CONSTRAINT `FK2ALERG` FOREIGN KEY (`ID2ALERG`) REFERENCES `t_alergia` (`IDALERGIA`),
  CONSTRAINT `FK2DOCTOR` FOREIGN KEY (`ID2DOCTOR`) REFERENCES `t_doctor` (`IDDOCTOR`),
  CONSTRAINT `FK2SEGURO` FOREIGN KEY (`ID2SEGUR`) REFERENCES `t_segurom` (`IDSEGURO`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_citamedica`
--

LOCK TABLES `t_citamedica` WRITE;
/*!40000 ALTER TABLE `t_citamedica` DISABLE KEYS */;
INSERT INTO `t_citamedica` VALUES (1,'9:11:20 a. m.','25/7/2020','pACIENTE EN MAL ESTADO',1,4,1,'Frederick Fernandez'),(3,'9:11:20 a. m.','25/7/2020','JHHHHHHHHHHHHHH',1,4,1,'Willy Morales'),(4,'11:19:27 a. m.','29/7/2020','DSDSDS',1,4,1,'Karen Dlegado'),(6,'11:19:27 a. m.','29/7/2020','SDADASDSADSADASDASDSADSDSSD',1,1,1,'Julio Perez'),(7,'11:38:10 a. m.','29/7/2020','aaaaaaaaaaaaaaaaa',1,1,1,'Juana Carmen Maria ');
/*!40000 ALTER TABLE `t_citamedica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_doctor`
--

DROP TABLE IF EXISTS `t_doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_doctor` (
  `IDDOCTOR` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBREDOCTOR` varchar(30) DEFAULT NULL,
  `ESPECIALIDAD` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`IDDOCTOR`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_doctor`
--

LOCK TABLES `t_doctor` WRITE;
/*!40000 ALTER TABLE `t_doctor` DISABLE KEYS */;
INSERT INTO `t_doctor` VALUES (1,'Dr. Marcos','Pediatría'),(2,'Dra. Angie','of'),(3,'Carlos','Carlos'),(4,'Josefina','Josefina'),(5,'Emelyt','Emelyt'),(6,'Lola','Lola'),(7,'fdsfsa','fdsfsa'),(8,'Polen','Polen'),(9,'Wilkania','Wilkania'),(10,'sdsd','sdsd'),(11,'cccccaaa','cccccaaa'),(12,'fdsfsdfsd','fdsfsdfsd'),(13,'fgffff','fgffff'),(14,'fsdfds','fsdfds'),(15,'dsadsa','dsadsa'),(16,'david','david'),(17,'Yeannn','saasasa'),(18,'Dr@','');
/*!40000 ALTER TABLE `t_doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_inventario`
--

DROP TABLE IF EXISTS `t_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_inventario` (
  `idt_inventario` int(11) NOT NULL AUTO_INCREMENT,
  `NombreMedicamento` varchar(60) NOT NULL,
  `CantidadMedicamento` int(11) DEFAULT NULL,
  `Proveedor` varchar(60) DEFAULT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  `Fecha` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`idt_inventario`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_inventario`
--

LOCK TABLES `t_inventario` WRITE;
/*!40000 ALTER TABLE `t_inventario` DISABLE KEYS */;
INSERT INTO `t_inventario` VALUES (1,'Acetaminofen',16,'F San Miguel','Sirve para x cosa',NULL),(2,'Diclofenaco Sodico',28,'F El Pueblo','Sirve para esto y lo otro',NULL),(4,'Advil',59,'1','sdsdsdsdsdsdsdsdsds','29/7/2020');
/*!40000 ALTER TABLE `t_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_paciente`
--

DROP TABLE IF EXISTS `t_paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_paciente` (
  `IDPACIENTE` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBREP` varchar(30) DEFAULT NULL,
  `APELLIDOP` varchar(30) DEFAULT NULL,
  `EDADP` int(3) DEFAULT NULL,
  `CEDULAP` varchar(13) DEFAULT NULL,
  `DIRECCIONP` varchar(60) DEFAULT NULL,
  `TELEFONOP` varchar(13) DEFAULT NULL,
  `TELEFONOP2` varchar(13) DEFAULT NULL,
  `SEXOP` char(1) DEFAULT NULL,
  `IDTALER` int(11) DEFAULT NULL,
  `IDTSEGURO` int(11) DEFAULT NULL,
  `IDTDOCTOR` int(11) DEFAULT NULL,
  PRIMARY KEY (`IDPACIENTE`),
  KEY `FKSEGURO` (`IDTSEGURO`),
  KEY `FKDOCTOR` (`IDTDOCTOR`),
  CONSTRAINT `FKDOCTOR` FOREIGN KEY (`IDTDOCTOR`) REFERENCES `t_doctor` (`IDDOCTOR`),
  CONSTRAINT `FKSEGURO` FOREIGN KEY (`IDTSEGURO`) REFERENCES `t_segurom` (`IDSEGURO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_paciente`
--

LOCK TABLES `t_paciente` WRITE;
/*!40000 ALTER TABLE `t_paciente` DISABLE KEYS */;
INSERT INTO `t_paciente` VALUES (1,'Juan','Perez',22,'809-8599632-','Medina','875-856-9632','275-275-2752','M',1,3,1),(2,'Ramona','Luz',55,'809-8596325-5','La COlonia','555-555-5555','242-425-7252','F',1,1,1),(5,'sdadasa','asasasasa',22,'124-1212424-2','gdfgdgfdgfd','111-111-1111','777-777-7777','F',1,1,16);
/*!40000 ALTER TABLE `t_paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_proveedor`
--

DROP TABLE IF EXISTS `t_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_proveedor` (
  `idt_proveedor` int(11) NOT NULL AUTO_INCREMENT,
  `NombreProveedor` varchar(60) DEFAULT NULL,
  `UbicacionProveedor` varchar(60) DEFAULT NULL,
  `TelefonoProveedor` varchar(60) DEFAULT NULL,
  `Correo` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`idt_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_proveedor`
--

LOCK TABLES `t_proveedor` WRITE;
/*!40000 ALTER TABLE `t_proveedor` DISABLE KEYS */;
INSERT INTO `t_proveedor` VALUES (1,'No se x','Santiago de los caballeros','809-099-9965','Nose@gmail.com');
/*!40000 ALTER TABLE `t_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_segurom`
--

DROP TABLE IF EXISTS `t_segurom`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_segurom` (
  `IDSEGURO` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBRESEGURO` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`IDSEGURO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_segurom`
--

LOCK TABLES `t_segurom` WRITE;
/*!40000 ALTER TABLE `t_segurom` DISABLE KEYS */;
INSERT INTO `t_segurom` VALUES (1,'MEDICARE'),(2,'MEDICAID'),(3,'UNITED HEALTH CARE'),(4,'Papee');
/*!40000 ALTER TABLE `t_segurom` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-29 17:53:12
