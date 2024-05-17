-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: proyectomex
-- ------------------------------------------------------
-- Server version	5.7.29-log

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
-- Table structure for table `banio_hom`
--

DROP TABLE IF EXISTS `banio_hom`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `banio_hom` (
  `idbanio_hom` int(2) NOT NULL AUTO_INCREMENT,
  `matriculabanio_hom` varchar(45) NOT NULL,
  `luz` varchar(3) DEFAULT NULL,
  `agua` varchar(3) DEFAULT NULL,
  `espejo` varchar(3) DEFAULT NULL,
  `jabon` varchar(3) DEFAULT NULL,
  `gelantibacterial` varchar(3) DEFAULT NULL,
  `basurero` varchar(3) DEFAULT NULL,
  `lavabos` varchar(3) DEFAULT NULL,
  `papel_servilletero` varchar(3) DEFAULT NULL,
  `inodoros` int(2) DEFAULT NULL,
  `idusuarioemp` int(2) NOT NULL,
  PRIMARY KEY (`idbanio_hom`),
  UNIQUE KEY `idbanio_hom_UNIQUE` (`idbanio_hom`),
  UNIQUE KEY `matriculabanio_hom_UNIQUE` (`matriculabanio_hom`),
  KEY `FKidusuarioemp_BH_idx` (`idusuarioemp`),
  CONSTRAINT `FKidusuarioemp_BH` FOREIGN KEY (`idusuarioemp`) REFERENCES `usuarioemp` (`idusuarioemp`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `banio_hom`
--

LOCK TABLES `banio_hom` WRITE;
/*!40000 ALTER TABLE `banio_hom` DISABLE KEYS */;
INSERT INTO `banio_hom` VALUES (1,'1-WC-A-HOM','SI','SI','SI','SI','SI','SI','SI','SI',4,1),(2,'1234','SI','SI','SI','SI','SI','SI','SI','SI',6,12),(3,'123','SI','SI','SI','SI','SI','SI','SI','SI',4,5),(4,'78','SI','SI','SI','SI','SI','SI','SI','SI',3,8),(5,'8294','NO','SI','SI','SI','SI','SI','SI','SI',6,1),(6,'4','NO','NO','NO','NO','NO','NO','NO','NO',9,6),(7,'123456789hgfs','NO','SI','SI','SI','SI','SI','SI','SI',1,8),(8,'c','NO','NO','SI','SI','SI','SI','SI','SI',78,5),(9,'lwjkd','si','si','no','no','','','','',6,5),(10,'akjsdh','si','no','no','no','','','','',7,4),(11,'10-WC-D-HOM','NO','SI','SI','SI','','','','',4,1),(13,'200-WC-A-HOM','NO','SI','SI','SI','SI','SI','SI','SI',4,12),(14,'456-WC-T-HOM','SI','SI','NO','SI','SI','SI','SI','SI',6,7);
/*!40000 ALTER TABLE `banio_hom` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `banio_muje`
--

DROP TABLE IF EXISTS `banio_muje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `banio_muje` (
  `idbanio_muje` int(2) NOT NULL AUTO_INCREMENT,
  `matriculabanio_muje` varchar(25) NOT NULL,
  `luz` varchar(3) DEFAULT NULL,
  `agua` varchar(3) DEFAULT NULL,
  `espejo` varchar(3) DEFAULT NULL,
  `jabon` varchar(3) DEFAULT NULL,
  `gelantibacterial` varchar(3) DEFAULT NULL,
  `basurero` varchar(3) DEFAULT NULL,
  `lavabos` varchar(3) DEFAULT NULL,
  `papel_servilletero` varchar(3) DEFAULT NULL,
  `inodoros` int(2) DEFAULT NULL,
  `idusuarioemp` int(3) NOT NULL,
  PRIMARY KEY (`idbanio_muje`),
  UNIQUE KEY `idbanio_muje_UNIQUE` (`idbanio_muje`),
  UNIQUE KEY `matriculabanio_muje_UNIQUE` (`matriculabanio_muje`),
  KEY `FKidusuarioempBM_idx` (`idusuarioemp`),
  CONSTRAINT `FKidusuarioempBM` FOREIGN KEY (`idusuarioemp`) REFERENCES `usuarioemp` (`idusuarioemp`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `banio_muje`
--

LOCK TABLES `banio_muje` WRITE;
/*!40000 ALTER TABLE `banio_muje` DISABLE KEYS */;
INSERT INTO `banio_muje` VALUES (1,'1-WC-A-MUJE','SI','SI','SI','SI','SI','SI','SI','SI',4,1),(2,'2-WC-A-MUJE','SI','SI','SI','SI','SI','SI','SI','SI',4,4);
/*!40000 ALTER TABLE `banio_muje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `baniohcheck`
--

DROP TABLE IF EXISTS `baniohcheck`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `baniohcheck` (
  `idcheck` int(2) NOT NULL,
  `idBanioH` int(2) NOT NULL,
  KEY `fk idBanioH_mm_idx` (`idBanioH`),
  KEY `fk idchek_mm` (`idcheck`),
  CONSTRAINT `fk idBanioH_mm` FOREIGN KEY (`idBanioH`) REFERENCES `banio_hom` (`idbanio_hom`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idchek_mm` FOREIGN KEY (`idcheck`) REFERENCES `checklist` (`idchecklist`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `baniohcheck`
--

LOCK TABLES `baniohcheck` WRITE;
/*!40000 ALTER TABLE `baniohcheck` DISABLE KEYS */;
/*!40000 ALTER TABLE `baniohcheck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `baniomcheck`
--

DROP TABLE IF EXISTS `baniomcheck`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `baniomcheck` (
  `Idcheckmuj` int(2) NOT NULL,
  `idBanioM` int(2) NOT NULL,
  KEY `fk Idcheckmuj_mm_idx` (`Idcheckmuj`),
  KEY `fk idBanioM_mm_idx` (`idBanioM`),
  CONSTRAINT `fk Idcheckmuj_mm` FOREIGN KEY (`Idcheckmuj`) REFERENCES `checklist` (`idchecklist`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idBanioM_mm` FOREIGN KEY (`idBanioM`) REFERENCES `banio_muje` (`idbanio_muje`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `baniomcheck`
--

LOCK TABLES `baniomcheck` WRITE;
/*!40000 ALTER TABLE `baniomcheck` DISABLE KEYS */;
/*!40000 ALTER TABLE `baniomcheck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `checklist`
--

DROP TABLE IF EXISTS `checklist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `checklist` (
  `idchecklist` int(2) NOT NULL AUTO_INCREMENT,
  `nombrecheck` varchar(45) NOT NULL,
  `fecha_check` datetime NOT NULL,
  PRIMARY KEY (`idchecklist`),
  UNIQUE KEY `idchecklist_UNIQUE` (`idchecklist`),
  UNIQUE KEY `nombrecheck_UNIQUE` (`nombrecheck`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checklist`
--

LOCK TABLES `checklist` WRITE;
/*!40000 ALTER TABLE `checklist` DISABLE KEYS */;
/*!40000 ALTER TABLE `checklist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ciudad` (
  `ID_Ciudad` int(3) NOT NULL AUTO_INCREMENT,
  `Nombre_Ciudad` varchar(80) NOT NULL,
  `idestado` int(2) NOT NULL,
  PRIMARY KEY (`ID_Ciudad`),
  UNIQUE KEY `ID_Ciudad_UNIQUE` (`ID_Ciudad`),
  UNIQUE KEY `Nombre_Ciudad_UNIQUE` (`Nombre_Ciudad`),
  KEY `fk idEstado_ciudad_idx` (`idestado`),
  CONSTRAINT `fk idEstado_ciudad` FOREIGN KEY (`idestado`) REFERENCES `estado` (`idestado`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
INSERT INTO `ciudad` VALUES (1,'merida',4),(2,'jalapa',7),(3,'temax',2),(4,'uman',2);
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `colonia`
--

DROP TABLE IF EXISTS `colonia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `colonia` (
  `ID_Colonia` int(5) NOT NULL AUTO_INCREMENT,
  `Nombre_Colonia` varchar(80) NOT NULL,
  `ID_Ciudad` int(3) NOT NULL,
  PRIMARY KEY (`ID_Colonia`),
  UNIQUE KEY `ID_Colonia_UNIQUE` (`ID_Colonia`),
  UNIQUE KEY `Nombre_Colonia_UNIQUE` (`Nombre_Colonia`),
  KEY `fk idCiudad_colonia_idx` (`ID_Ciudad`),
  CONSTRAINT `fk idCiudad_colonia` FOREIGN KEY (`ID_Ciudad`) REFERENCES `ciudad` (`ID_Ciudad`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `colonia`
--

LOCK TABLES `colonia` WRITE;
/*!40000 ALTER TABLE `colonia` DISABLE KEYS */;
INSERT INTO `colonia` VALUES (1,'san pedro',1),(2,'altabrisa',1),(3,'Francisco montejo',1),(17,'Madero',1);
/*!40000 ALTER TABLE `colonia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cubiculocheck`
--

DROP TABLE IF EXISTS `cubiculocheck`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cubiculocheck` (
  `idcheckcubi` int(2) NOT NULL,
  `idcub` int(2) NOT NULL,
  KEY `fk idcheckcubi_mm_idx` (`idcheckcubi`),
  KEY `fk idcub_mm_idx` (`idcub`),
  CONSTRAINT `fk idcheckcubi_mm` FOREIGN KEY (`idcheckcubi`) REFERENCES `checklist` (`idchecklist`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idcub_mm` FOREIGN KEY (`idcub`) REFERENCES `cubiculos` (`idcubiculo`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cubiculocheck`
--

LOCK TABLES `cubiculocheck` WRITE;
/*!40000 ALTER TABLE `cubiculocheck` DISABLE KEYS */;
/*!40000 ALTER TABLE `cubiculocheck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cubiculos`
--

DROP TABLE IF EXISTS `cubiculos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cubiculos` (
  `idcubiculo` int(2) NOT NULL AUTO_INCREMENT,
  `matricula_cubiculo` varchar(25) NOT NULL,
  `papelera` varchar(3) DEFAULT NULL,
  `papel` varchar(3) DEFAULT NULL,
  `inodoro_roto` varchar(3) DEFAULT NULL,
  `agua` varchar(3) DEFAULT NULL,
  `puerta` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`idcubiculo`),
  UNIQUE KEY `idcubiculos_UNIQUE` (`idcubiculo`),
  UNIQUE KEY `matricula_cubiculo_UNIQUE` (`matricula_cubiculo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cubiculos`
--

LOCK TABLES `cubiculos` WRITE;
/*!40000 ALTER TABLE `cubiculos` DISABLE KEYS */;
INSERT INTO `cubiculos` VALUES (3,'110-WC-A-HOM-CUB2','si','si','no','no','no'),(10,'456-WC-T-HOM-CUB1','SI','SI','SI','SI','SI');
/*!40000 ALTER TABLE `cubiculos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edificio`
--

DROP TABLE IF EXISTS `edificio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `edificio` (
  `ID_Edificio` int(2) NOT NULL AUTO_INCREMENT,
  `letra_Edificio` varchar(1) NOT NULL,
  PRIMARY KEY (`ID_Edificio`),
  UNIQUE KEY `ID_Edificio_UNIQUE` (`ID_Edificio`),
  UNIQUE KEY `letra_Edificio_UNIQUE` (`letra_Edificio`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edificio`
--

LOCK TABLES `edificio` WRITE;
/*!40000 ALTER TABLE `edificio` DISABLE KEYS */;
INSERT INTO `edificio` VALUES (4,'4'),(5,'5'),(6,'6'),(1,'A'),(2,'B'),(3,'C'),(7,'D'),(8,'E'),(9,'F'),(10,'G'),(11,'H'),(12,'I'),(13,'J');
/*!40000 ALTER TABLE `edificio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado`
--

DROP TABLE IF EXISTS `estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estado` (
  `idestado` int(2) NOT NULL AUTO_INCREMENT,
  `nombre_estado` varchar(25) NOT NULL,
  PRIMARY KEY (`idestado`),
  UNIQUE KEY `idpais_UNIQUE` (`idestado`),
  UNIQUE KEY `nombre_estado_UNIQUE` (`nombre_estado`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado`
--

LOCK TABLES `estado` WRITE;
/*!40000 ALTER TABLE `estado` DISABLE KEYS */;
INSERT INTO `estado` VALUES (8,'baja california'),(7,'guatemala'),(1,'mexico'),(6,'morelos'),(9,'Puebla'),(4,'sinaloa'),(5,'texas'),(3,'tlaxcala'),(2,'yucatan');
/*!40000 ALTER TABLE `estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `migitorios`
--

DROP TABLE IF EXISTS `migitorios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `migitorios` (
  `idmigitorio` int(2) NOT NULL,
  `matricula_migitorios` varchar(25) NOT NULL,
  `agua` varchar(3) DEFAULT NULL,
  `rotos` varchar(2) DEFAULT NULL,
  `tuberia_buena` varchar(2) DEFAULT NULL,
  `idBanioshom` int(2) NOT NULL,
  PRIMARY KEY (`idmigitorio`),
  UNIQUE KEY `idmigitorio_UNIQUE` (`idmigitorio`),
  UNIQUE KEY `matricula_migitorios_UNIQUE` (`matricula_migitorios`),
  KEY `fk idBANIOhom_idx` (`idBanioshom`),
  CONSTRAINT `fk idBANIOhom` FOREIGN KEY (`idBanioshom`) REFERENCES `banio_hom` (`idbanio_hom`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `migitorios`
--

LOCK TABLES `migitorios` WRITE;
/*!40000 ALTER TABLE `migitorios` DISABLE KEYS */;
/*!40000 ALTER TABLE `migitorios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mijitorioscheck`
--

DROP TABLE IF EXISTS `mijitorioscheck`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mijitorioscheck` (
  `idcheckmiji` int(2) NOT NULL,
  `idMigitorio` int(2) NOT NULL,
  KEY `fk idchekmiji_mm_idx` (`idcheckmiji`),
  KEY `fk idMijitorio_mm_idx` (`idMigitorio`),
  CONSTRAINT `fk idMigitorio_mm` FOREIGN KEY (`idMigitorio`) REFERENCES `migitorios` (`idmigitorio`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idchekmiji_mm` FOREIGN KEY (`idcheckmiji`) REFERENCES `checklist` (`idchecklist`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mijitorioscheck`
--

LOCK TABLES `mijitorioscheck` WRITE;
/*!40000 ALTER TABLE `mijitorioscheck` DISABLE KEYS */;
/*!40000 ALTER TABLE `mijitorioscheck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produccheck`
--

DROP TABLE IF EXISTS `produccheck`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produccheck` (
  `idcheckpro` int(2) NOT NULL,
  `idprod` int(2) NOT NULL,
  KEY `fk  idchekpro_mm_idx` (`idcheckpro`),
  KEY `fk idpro_mm_idx` (`idprod`),
  CONSTRAINT `fk  idchekpro_mm` FOREIGN KEY (`idcheckpro`) REFERENCES `checklist` (`idchecklist`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idpro_mm` FOREIGN KEY (`idprod`) REFERENCES `productos` (`idproductos`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produccheck`
--

LOCK TABLES `produccheck` WRITE;
/*!40000 ALTER TABLE `produccheck` DISABLE KEYS */;
/*!40000 ALTER TABLE `produccheck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `idproductos` int(2) NOT NULL AUTO_INCREMENT,
  `nombre_pro` varchar(45) NOT NULL,
  PRIMARY KEY (`idproductos`),
  UNIQUE KEY `idproductos_UNIQUE` (`idproductos`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'cloro'),(9,'escoba'),(11,'mechudo');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reportes`
--

DROP TABLE IF EXISTS `reportes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reportes` (
  `idreportes` int(2) NOT NULL AUTO_INCREMENT,
  `fecharep` datetime NOT NULL,
  `IDCheck` int(2) NOT NULL,
  PRIMARY KEY (`idreportes`),
  UNIQUE KEY `idreportes_UNIQUE` (`idreportes`),
  KEY `fk idcheck_reporte_idx` (`IDCheck`),
  CONSTRAINT `fk idcheck_reporte` FOREIGN KEY (`IDCheck`) REFERENCES `checklist` (`idchecklist`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reportes`
--

LOCK TABLES `reportes` WRITE;
/*!40000 ALTER TABLE `reportes` DISABLE KEYS */;
/*!40000 ALTER TABLE `reportes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rol` (
  `idrol` int(1) NOT NULL AUTO_INCREMENT,
  `nombre_rol` varchar(20) NOT NULL,
  PRIMARY KEY (`idrol`),
  UNIQUE KEY `idrol_UNIQUE` (`idrol`),
  UNIQUE KEY `nombre_rol_UNIQUE` (`nombre_rol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'admnistrador'),(3,'empleado'),(2,'gerente');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicio`
--

DROP TABLE IF EXISTS `servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servicio` (
  `idservicio` int(2) NOT NULL,
  `nombre_serv` varchar(45) NOT NULL,
  `fechayhora_serv` datetime NOT NULL,
  PRIMARY KEY (`idservicio`),
  UNIQUE KEY `idservicio_UNIQUE` (`idservicio`),
  UNIQUE KEY `nombre_serv_UNIQUE` (`nombre_serv`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
/*!40000 ALTER TABLE `servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `serviciocheck`
--

DROP TABLE IF EXISTS `serviciocheck`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `serviciocheck` (
  `idcheckserv` int(2) NOT NULL,
  `IDserv` int(2) NOT NULL,
  KEY `fk idcheckser_mm_idx` (`idcheckserv`),
  KEY `fk idserv_mm_idx` (`IDserv`),
  CONSTRAINT `fk idcheckser_mm` FOREIGN KEY (`idcheckserv`) REFERENCES `checklist` (`idchecklist`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idserv_mm` FOREIGN KEY (`IDserv`) REFERENCES `servicio` (`idservicio`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serviciocheck`
--

LOCK TABLES `serviciocheck` WRITE;
/*!40000 ALTER TABLE `serviciocheck` DISABLE KEYS */;
/*!40000 ALTER TABLE `serviciocheck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefono`
--

DROP TABLE IF EXISTS `telefono`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `telefono` (
  `idtelefono` int(1) NOT NULL AUTO_INCREMENT,
  `numero_telefono` int(10) NOT NULL,
  `IDEmpleado` int(3) NOT NULL,
  PRIMARY KEY (`idtelefono`),
  UNIQUE KEY `idtelefono_UNIQUE` (`idtelefono`),
  UNIQUE KEY `numero_telefono_UNIQUE` (`numero_telefono`),
  KEY `fk idempleado_tel_idx` (`IDEmpleado`),
  CONSTRAINT `fk idempleado_tel` FOREIGN KEY (`IDEmpleado`) REFERENCES `usuarioemp` (`idusuarioemp`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefono`
--

LOCK TABLES `telefono` WRITE;
/*!40000 ALTER TABLE `telefono` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefono` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turno`
--

DROP TABLE IF EXISTS `turno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `turno` (
  `idturno` int(1) NOT NULL AUTO_INCREMENT,
  `nombre_turno` varchar(10) NOT NULL,
  PRIMARY KEY (`idturno`),
  UNIQUE KEY `idturno_UNIQUE` (`idturno`),
  UNIQUE KEY `nombre_turno_UNIQUE` (`nombre_turno`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turno`
--

LOCK TABLES `turno` WRITE;
/*!40000 ALTER TABLE `turno` DISABLE KEYS */;
INSERT INTO `turno` VALUES (3,'diurno'),(1,'matutino'),(2,'vespertino');
/*!40000 ALTER TABLE `turno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarioemp`
--

DROP TABLE IF EXISTS `usuarioemp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarioemp` (
  `idusuarioemp` int(3) NOT NULL AUTO_INCREMENT,
  `nombre_usuarioemp` varchar(45) NOT NULL,
  `apellido_paterno` varchar(45) NOT NULL,
  `apellido_materno` varchar(45) NOT NULL,
  `Edad` int(2) NOT NULL,
  `contrasenia` varchar(10) NOT NULL,
  `calle` varchar(60) NOT NULL,
  `cruzamientos` varchar(120) NOT NULL,
  `casa` int(3) NOT NULL,
  `ID_Ciudad` int(2) NOT NULL,
  `ID_Colonia` int(2) NOT NULL,
  `idestado` int(2) NOT NULL,
  `idrol` int(2) NOT NULL,
  `idturno` int(1) NOT NULL,
  PRIMARY KEY (`idusuarioemp`),
  UNIQUE KEY `idusuarioemp_UNIQUE` (`idusuarioemp`),
  UNIQUE KEY `contrasenia_UNIQUE` (`contrasenia`),
  KEY `fk idciudad_usuario_idx` (`ID_Ciudad`),
  KEY `fk idcolonia_usuario_idx` (`ID_Colonia`),
  KEY `fk idrol_usuario_idx` (`idrol`),
  KEY `fk idestado_usuario _idx` (`idestado`),
  KEY `fk idturno_usuario_idx` (`idturno`),
  CONSTRAINT `fk idciudad_usuario` FOREIGN KEY (`ID_Ciudad`) REFERENCES `ciudad` (`ID_Ciudad`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idcolonia_usuario` FOREIGN KEY (`ID_Colonia`) REFERENCES `colonia` (`ID_Colonia`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idestado_usuario ` FOREIGN KEY (`idestado`) REFERENCES `estado` (`idestado`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idrol_usuario` FOREIGN KEY (`idrol`) REFERENCES `rol` (`idrol`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk idturno_usuario` FOREIGN KEY (`idturno`) REFERENCES `turno` (`idturno`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarioemp`
--

LOCK TABLES `usuarioemp` WRITE;
/*!40000 ALTER TABLE `usuarioemp` DISABLE KEYS */;
INSERT INTO `usuarioemp` VALUES (1,'vladimir','lopez','kao',18,'holadios','46','33 y 31',567,1,2,2,3,1),(4,'irving','lopez','kao',34,'elded','46','27 y 29',567,1,2,2,3,1),(5,'alam','estrada','valdez',23,'misterobot','34','31 y 30',67,1,3,2,3,2),(6,'jose luis','carrillo','vargas',78,'chepo','67','45 y 47',678,1,3,2,3,1),(7,'vanessa','herrera','kuh',23,'utm','46','43 y 45',564,1,3,2,3,3),(8,'jose','carillo','vargas',18,'prepa1','24','20 y 23',23,1,3,2,3,3),(9,'alberto','lopez','perez',34,'peero','21','20 y 23',678,1,2,2,3,1),(10,'alberto','herrera','hernandez',67,'gato','23','19 y 21',678,1,2,2,3,1),(11,'pedro','kao','lopez',56,'mundo','56','53 y 55',987,1,3,2,3,2),(12,'beto','fleites','perez',45,'pajaro','78','23 y 25',546,3,2,2,3,1),(14,'eduardo','lugo','escalante',45,'loteria','23','21 y 23',456,1,3,2,3,3),(15,'Alex','herrera','kuh',23,'qsd','12','23',32,1,3,6,1,3),(16,'ana','he','as',23,'adf','78','24',45,3,3,1,3,2);
/*!40000 ALTER TABLE `usuarioemp` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-28 23:55:15
