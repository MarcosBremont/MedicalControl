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
-- Dumping data for table `t_alergia`
--

LOCK TABLES `t_alergia` WRITE;
/*!40000 ALTER TABLE `t_alergia` DISABLE KEYS */;
INSERT INTO `t_alergia` VALUES (1,'Polen'),(2,'Agua'),(3,'Azucar'),(4,''),(5,'Polenn');
/*!40000 ALTER TABLE `t_alergia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_citamedica`
--

LOCK TABLES `t_citamedica` WRITE;
/*!40000 ALTER TABLE `t_citamedica` DISABLE KEYS */;
INSERT INTO `t_citamedica` VALUES (1,'9:11:20 a. m.','25/7/2020','pACIENTE EN MAL ESTADO',1,4,1,'Frederick Fernandez'),(3,'9:11:20 a. m.','25/7/2020','JHHHHHHHHHHHHHH',1,4,1,'Willy Morales'),(4,'11:19:27 a. m.','29/7/2020','DSDSDS',1,4,1,'Karen Dlegado'),(6,'11:19:27 a. m.','29/7/2020','SDADASDSADSADASDASDSADSDSSD',1,1,1,'Julio Perez'),(7,'11:38:10 a. m.','29/7/2020','aaaaaaaaaaaaaaaaa',1,1,1,'Juana Carmen Maria ');
/*!40000 ALTER TABLE `t_citamedica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_doctor`
--

LOCK TABLES `t_doctor` WRITE;
/*!40000 ALTER TABLE `t_doctor` DISABLE KEYS */;
INSERT INTO `t_doctor` VALUES (1,'Dr. Marcos','Pediatría'),(2,'Dra. Angie','of'),(3,'Carlos','Carlos'),(4,'Josefina','Josefina'),(5,'Emelyt','Emelyt'),(6,'Lola','Lola'),(7,'fdsfsa','fdsfsa'),(8,'Polen','Polen'),(9,'Wilkania','Wilkania'),(10,'sdsd','sdsd'),(11,'cccccaaa','cccccaaa'),(12,'fdsfsdfsd','fdsfsdfsd'),(13,'fgffff','fgffff'),(14,'fsdfds','fsdfds'),(15,'dsadsa','dsadsa'),(16,'david','david'),(17,'Yeannn','saasasa'),(18,'Dr@','');
/*!40000 ALTER TABLE `t_doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_inventario`
--

LOCK TABLES `t_inventario` WRITE;
/*!40000 ALTER TABLE `t_inventario` DISABLE KEYS */;
INSERT INTO `t_inventario` VALUES (1,'Acetaminofen',16,'F San Miguel','Sirve para x cosa'),(2,'Diclofenaco Sodico',28,'F El Pueblo','Sirve para esto y lo otro'),(3,'Ibuprofeno',55,'F Marcos','dsdsds');
/*!40000 ALTER TABLE `t_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `t_paciente`
--

LOCK TABLES `t_paciente` WRITE;
/*!40000 ALTER TABLE `t_paciente` DISABLE KEYS */;
INSERT INTO `t_paciente` VALUES (1,'Juan','Perez',22,'809-8599632-','Medina','875-856-9632','275-275-2752','M',1,3,1),(2,'Ramona','Luz',55,'809-8596325-5','La COlonia','555-555-5555','242-425-7252','F',1,1,1),(5,'sdadasa','asasasasa',22,'124-1212424-2','gdfgdgfdgfd','111-111-1111','777-777-7777','F',1,1,16);
/*!40000 ALTER TABLE `t_paciente` ENABLE KEYS */;
UNLOCK TABLES;

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

-- Dump completed on 2020-07-29 17:13:06
