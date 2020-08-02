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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_alergia`
--

LOCK TABLES `t_alergia` WRITE;
/*!40000 ALTER TABLE `t_alergia` DISABLE KEYS */;
INSERT INTO `t_alergia` VALUES (7,'AINES'),(8,'Anticonvulsivos'),(9,'Insulina'),(10,'Penicilinas'),(11,'Sulfamidas');
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
  `NombreCompleto` varchar(60) DEFAULT NULL,
  `HORACM` varchar(30) DEFAULT NULL,
  `FECHACM` varchar(30) DEFAULT NULL,
  `COMENTARIO` varchar(30) DEFAULT NULL,
  `ID2SEGUR` int DEFAULT NULL,
  `ID2ALERG` int DEFAULT NULL,
  `ID2DOCTOR` int DEFAULT NULL,
  PRIMARY KEY (`IDCITAMEDICA`),
  KEY `FK2SEGURO` (`ID2SEGUR`),
  KEY `FK2DOCTOR` (`ID2DOCTOR`),
  CONSTRAINT `FK2DOCTOR` FOREIGN KEY (`ID2DOCTOR`) REFERENCES `t_doctor` (`IDDOCTOR`),
  CONSTRAINT `FK2SEGURO` FOREIGN KEY (`ID2SEGUR`) REFERENCES `t_segurom` (`IDSEGURO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_citamedica`
--

LOCK TABLES `t_citamedica` WRITE;
/*!40000 ALTER TABLE `t_citamedica` DISABLE KEYS */;
INSERT INTO `t_citamedica` VALUES (4,'Mary Mejia','4:00:00 p. m.','11/8/2020','Paciente con problemas corazon',1,7,20);
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
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_doctor`
--

LOCK TABLES `t_doctor` WRITE;
/*!40000 ALTER TABLE `t_doctor` DISABLE KEYS */;
INSERT INTO `t_doctor` VALUES (20,'Dr/a Carlos Jimenez','Neurologo'),(21,'Dr/a Karla Perez','Endocrinologa'),(22,'Dr/a Manuel Reyes','Cardiologo'),(23,'Dr Susan Rodriguez','Neumologa'),(24,'Dra Paola Marte','Ortopeda'),(25,'Dr. Oliver Payano','Neurocirugano');
/*!40000 ALTER TABLE `t_doctor` ENABLE KEYS */;
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
  `Descripcion` varchar(300) DEFAULT NULL,
  `Fecha` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`idt_inventario`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_inventario`
--

LOCK TABLES `t_inventario` WRITE;
/*!40000 ALTER TABLE `t_inventario` DISABLE KEYS */;
INSERT INTO `t_inventario` VALUES (7,'Ibuprofeno',60,'1','El ibuprofeno de venta libre se usa para bajar la fiebre y para aliviar dolores leves como dolores de cabeza, dolores musculares, artritis, cólicos menstruales, molestias del resfriado común, dolores de dientes y dolores de espalda.','2/8/2020'),(8,'Paracetamol',50,'1','Paracetamol pertenece al grupo de medicamentos llamados analgésicos y antipiréticos. Paracetamol está indicado para el tratamiento de los síntomas del dolor leve a moderado y la fiebre.','2/8/2020'),(9,'Diclofenac',80,'2','Diclofenac es una droga antiinflamatoria no esteroide (AINE o NSAID, por sus siglas en inglés). Esta medicina trabaja reduciendo sustancias en el cuerpo que causan dolor e inflamación. Diclofenac se usa para tratar el dolor leve a moderado, o los signos y síntomas de la osteoartritis','2/8/2020'),(10,'Penicilina',120,'3','La inyección de penicilina G se usa para tratar y prevenir ciertas infecciones provocadas por bacterias. La inyección de penicilina G pertenece a una clase de medicamentos llamados penicilinas. Funciona matando las bacterias que causan infecciones.','2/8/2020'),(11,'Loratadina',20,'4','La loratadina se usa para aliviar en forma temporal los síntomas de la fiebre del heno (alergia al polen, polvo u otras sustancias en el aire) y otras alergias. Estos síntomas incluyen estornudos, secreción nasal, y picazón en los ojos, nariz y garganta.\r\n','2/8/2020'),(12,'Antihipertensivos',250,'4','Los antihipertensivos son medicamentos utilizados para disminuir el riesgo cardiovascular en los pacientes con hipertensión arterial controlando la presión arterial hasta niveles adecuados. La hipertensión arterial es una enfermedad de la pared arterial de los vasos sanguíneos.\r\n','2/8/2020');
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_paciente`
--

LOCK TABLES `t_paciente` WRITE;
/*!40000 ALTER TABLE `t_paciente` DISABLE KEYS */;
INSERT INTO `t_paciente` VALUES (13,'Omar','Bremont',19,'402-5295685-','Jarabacoa, Medina','809-556-6633','809-522-4455','M',8,5,23),(14,'Juan','Gomez',22,'402-5552221-1','Jarabacoa, La Colonia','809-556-6633','809-522-4455','M',9,6,23);
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
  `TelefonoProveedor` varchar(13) DEFAULT NULL,
  `Correo` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`idt_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_proveedor`
--

LOCK TABLES `t_proveedor` WRITE;
/*!40000 ALTER TABLE `t_proveedor` DISABLE KEYS */;
INSERT INTO `t_proveedor` VALUES (1,'Laboratorios Alfa','Santiago ','808-088-8808','LaboratoriosAlfa@gmail,com'),(2,'Laboratorio Magnachem Intl. S.R.L','La Vega','809-585-8555','LaboratorioMagnachemIntl.S.R.L@gmail.com'),(3,'Ethical','Santo Domingo','809-568-5957','EthicalFarm@gmail.com'),(4,'Ibero Fármacos, SRL','Bonao','809-526-3254','IberoFármacosSRL@gmail.com');
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_segurom`
--

LOCK TABLES `t_segurom` WRITE;
/*!40000 ALTER TABLE `t_segurom` DISABLE KEYS */;
INSERT INTO `t_segurom` VALUES (1,'ARS Semma'),(2,'ARS Senasa'),(3,'ARS Senasa Subsidiado'),(5,'ARS Palic Salud'),(6,'ARS Simag'),(7,'Humano'),(8,'ARS Humano');
/*!40000 ALTER TABLE `t_segurom` ENABLE KEYS */;
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

-- Dump completed on 2020-08-02 15:11:43
