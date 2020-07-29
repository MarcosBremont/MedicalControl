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
  `HORACM` varchar(30) DEFAULT NULL,
  `FECHACM` varchar(30) DEFAULT NULL,
  `COMENTARIO` varchar(30) DEFAULT NULL,
  `ID2SEGUR` int(11) DEFAULT NULL,
  `ID2ALERG` int(11) DEFAULT NULL,
  `ID2DOCTOR` int(11) DEFAULT NULL,
  PRIMARY KEY (`IDCITAMEDICA`),
  KEY `FK2SEGURO` (`ID2SEGUR`),
  KEY `FK2DOCTOR` (`ID2DOCTOR`),
  CONSTRAINT `FK2DOCTOR` FOREIGN KEY (`ID2DOCTOR`) REFERENCES `t_doctor` (`IDDOCTOR`),
  CONSTRAINT `FK2SEGURO` FOREIGN KEY (`ID2SEGUR`) REFERENCES `t_segurom` (`IDSEGURO`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_citamedica`
--

LOCK TABLES `t_citamedica` WRITE;
/*!40000 ALTER TABLE `t_citamedica` DISABLE KEYS */;
INSERT INTO `t_citamedica` VALUES (1,'09:11:20 a. m.','25/07/2020','pACIENTE EN MAL ESTADO',1,1,1);
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
  PRIMARY KEY (`idt_inventario`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_inventario`
--

LOCK TABLES `t_inventario` WRITE;
/*!40000 ALTER TABLE `t_inventario` DISABLE KEYS */;
INSERT INTO `t_inventario` VALUES (1,'Acetaminofen',16,'F San Miguel','Sirve para x cosa'),(2,'Diclofenaco Sodico',28,'F El Pueblo','Sirve para esto y lo otro'),(3,'Ibuprofeno',55,'F Marcos','dsdsds');
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

--
-- Temporary view structure for view `vtpacientetdtatsg`
--

DROP TABLE IF EXISTS `vtpacientetdtatsg`;
/*!50001 DROP VIEW IF EXISTS `vtpacientetdtatsg`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
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
-- Dumping routines for database 'medicalcontrol'
--
/*!50003 DROP PROCEDURE IF EXISTS `FILTROT_PACIENTE` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`%`@`%` PROCEDURE `FILTROT_PACIENTE`(
PRM_FILTRO VARCHAR(60)
)
BEGIN 
SELECT * FROM T_PACIENTE WHERE NOMBREP LIKE CONCAT('%',PRM_FILTRO,'%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SENT_PACIENTECRUD` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`%`@`%` PROCEDURE `SENT_PACIENTECRUD`(
PRM_IDPACIENTE INT,
PRM_NOMBREP VARCHAR (30),
PRM_APELLIDOP VARCHAR (30),
PRM_EDADP  INT,
PRM_CEDULAP VARCHAR (30),
PRM_DIRECCIONP VARCHAR(30),
PRM_TELEFONOP VARCHAR (13),
PRM_TELEFONOP2 VARCHAR (13),
PRM_IDTALER INT,
PRM_IDTSEGURO INT,
PRM_IDTDOCTOR INT,
PRM_IDCIT INT,
ACCION CHAR(1)
)
BEGIN 
IF ACCION='I' THEN
	INSERT INTO T_PACIENTE (NOMBREP, APELLIDOP, EDADP, CEDULAP, DIRECCIONP, TELEFONOP, TELEFONOP2, IDTALER, IDTSEGURO, IDTDOCTOR, IDCIT)VALUES(PRM_NOMBREP,PRM_APELLIDOP,PRM_EDADP,PRM_CEDULAP,PRM_DIRECCIONP,PRM_TELEFONOP,PRM_TELEFONOP2, PRM_IDTALER, PRM_IDTSEGURO, PRM_IDTDOCTOR, PRM_IDCIT);
ELSEIF ACCION='U' THEN 
	UPDATE T_PACIENTE SET NOMBREP=PRM_PACIENTE, APELLIDOP=PRM_APELLIDOP, EDADP=PRM_EDADP,CEDULAP=PRM_CEDULAP, DIRECCION=PRM_DIRECCIONP, TELEFONOP=PRM_DIRECCIONP, TELEFONOP=PRM_TELEFONOP, TELEFONOP2=PRM_TELEFONOP2, IDTALER=PRM_IDTALER, IDTSEGURO=PRM_IDT, IDTDOCTOR=PRM_IDTDOCTOR, IDCIT=PRM_IDCIT WHERE ID_PACIENTE=PRM_IDPACIENTE;
ELSE 
	DELETE FROM T_PACIENTE WHERE ID_PACIENTE=PRM_IDPACIENTE;

END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

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
/*!50013 DEFINER=`%`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `vtpacientetdtatsg` AS select `tp`.`IDPACIENTE` AS `IDPACIENTE`,`tp`.`NOMBREP` AS `NOMBREP`,`tp`.`APELLIDOP` AS `APELLIDOP`,`tp`.`EDADP` AS `EDADP`,`tp`.`CEDULAP` AS `CEDULAP`,`tp`.`DIRECCIONP` AS `DIRECCIONP`,`tp`.`TELEFONOP` AS `TELEFONOP`,`tp`.`TELEFONOP2` AS `TELEFONOP2`,`tp`.`SEXOP` AS `SEXOP`,`tsm`.`IDSEGURO` AS `IDSEGURO`,`tsm`.`NOMBRESEGURO` AS `NOMBRESEGURO`,`ta`.`IDALERGIA` AS `IDALERGIA`,`ta`.`NOMBREA` AS `NOMBREA`,`td`.`IDDOCTOR` AS `IDDOCTOR`,`td`.`NOMBREDOCTOR` AS `NOMBREDOCTOR`,`td`.`ESPECIALIDAD` AS `ESPECIALIDAD` from (((`t_paciente` `tp` join `t_segurom` `tsm` on((`tp`.`IDTSEGURO` = `tsm`.`IDSEGURO`))) join `t_alergia` `ta` on((`tp`.`IDTALER` = `ta`.`IDALERGIA`))) join `t_doctor` `td` on((`tp`.`IDTDOCTOR` = `td`.`IDDOCTOR`))) */;
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

-- Dump completed on 2020-07-27 17:15:53
