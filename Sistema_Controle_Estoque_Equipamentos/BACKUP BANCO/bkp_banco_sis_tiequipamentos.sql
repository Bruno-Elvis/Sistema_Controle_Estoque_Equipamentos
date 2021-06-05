CREATE DATABASE  IF NOT EXISTS `equipamentoti` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `equipamentoti`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: equipamentoti
-- ------------------------------------------------------
-- Server version	5.7.12-log

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
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamento` (
  `iddepartamento` int(11) NOT NULL AUTO_INCREMENT,
  `nomedepartamento` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`iddepartamento`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'TECNOLOGIA DA INFORMAÇÃO'),(2,'CALL CENTER'),(3,'CONTABILIDADE'),(4,'FINANCEIRO'),(5,'RH'),(6,'QUALIDADE'),(7,'ALMOXARIFADO');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipamento`
--

DROP TABLE IF EXISTS `equipamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipamento` (
  `codigobem` varchar(45) NOT NULL,
  `descricao` varchar(45) DEFAULT NULL,
  `idfornecedor` int(11) DEFAULT NULL,
  `idtipoaquisicao` int(11) DEFAULT NULL,
  `idtipoequipamento` int(11) DEFAULT NULL,
  `observacao` varchar(120) DEFAULT NULL,
  `iddepartamento` int(11) DEFAULT NULL,
  `alocado` bit(1) DEFAULT b'0',
  `baixa` bit(1) DEFAULT b'0',
  `idusuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigobem`),
  KEY `FK_DEPARTAMENTO_idx` (`iddepartamento`),
  KEY `FK_FORNECEDOR_idx` (`idfornecedor`),
  KEY `FK_TIPOAQUISICAO_idx` (`idtipoaquisicao`),
  KEY `FK_TIPOEQUIPAMENTO_idx` (`idtipoequipamento`),
  KEY `FK_USUARIO_idx` (`idusuario`),
  CONSTRAINT `FK_DEPARTAMENTO` FOREIGN KEY (`iddepartamento`) REFERENCES `departamento` (`iddepartamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_FORNECEDOR` FOREIGN KEY (`idfornecedor`) REFERENCES `fornecedor` (`idfornecedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_TIPOAQUISICAO` FOREIGN KEY (`idtipoaquisicao`) REFERENCES `tipoaquisicao` (`idtipoaquisicao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_TIPOEQUIPAMENTO` FOREIGN KEY (`idtipoequipamento`) REFERENCES `tipoequipamento` (`idtipoequipamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_USUARIO` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipamento`
--

LOCK TABLES `equipamento` WRITE;
/*!40000 ALTER TABLE `equipamento` DISABLE KEYS */;
INSERT INTO `equipamento` VALUES ('004','pc da roca',1,1,1,'pc lixo',3,'','\0',NULL),('005','pc da roca',1,1,1,'pc lixo',3,'','\0',NULL),('006','pc da roca',1,1,1,'pc lixo',5,'','\0',NULL),('007','pc da roca',1,1,1,'pc lixo',3,'','\0',NULL),('009','pc da roca',1,1,1,'pc lixo',1,'\0','\0',NULL),('010','pc da roca',1,1,1,'pc lixo',2,'','\0',NULL),('011','pc da roca',1,1,1,'pc lixo',1,'\0','\0',NULL),('012','pc da roca',1,1,1,'pc lixo',2,'','\0',NULL),('013','pc da roca',1,1,1,'pc lixo',1,'\0','\0',NULL),('014','pc da roca',1,1,1,'pc lixo',2,'','\0',NULL),('015','pc da roca',1,1,1,'pc lixo',1,'\0','\0',NULL),('016','pc da roca',1,1,1,'pc lixo',2,'','\0',NULL),('017','pc da roca',1,1,1,'pc lixo',2,'','\0',NULL),('018','pc da roca',1,1,1,'pc lixo',1,'\0','\0',NULL),('019','pc da roca',1,1,1,'pc lixo',2,'','\0',NULL),('020','pc da roca',1,1,1,'pc lixo',2,'','\0',NULL),('030','Pc da tia',6,6,4,'TEste',1,'\0','\0',NULL),('031','tste',1,1,1,'dfwfwer',NULL,'\0','',NULL),('032','dssgsfgdgf',1,1,1,'sdfsdf',1,'\0','\0',NULL),('033','dfgdfgdfgdfg',1,1,1,'sdfsdfsdf',1,'\0','\0',NULL),('035','fhfgnfhjfg',1,1,1,'sdfsdfsdfsdf',1,'\0','\0',NULL),('090','hrthrthrthr',1,1,1,'thrthrthrthrthrth',NULL,'\0','',NULL);
/*!40000 ALTER TABLE `equipamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fornecedor` (
  `idfornecedor` int(11) NOT NULL AUTO_INCREMENT,
  `nomefornecedor` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idfornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedor`
--

LOCK TABLES `fornecedor` WRITE;
/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` VALUES (1,'EMBRATEL'),(2,'DATALOGIC'),(3,'EPSON'),(4,'FESC'),(5,'GVT'),(6,'HP'),(7,'DELL'),(8,'GRANDSTREAM'),(9,'CANON'),(10,'LG'),(11,'SAMSUNG'),(12,'MICROSOFT'),(13,'3COM'),(14,'RECORD PRINT'),(15,'OI');
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historico`
--

DROP TABLE IF EXISTS `historico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historico` (
  `idhistorico` int(11) NOT NULL AUTO_INCREMENT,
  `datamov` date DEFAULT NULL,
  `codbem` varchar(45) NOT NULL,
  `iddepartamento` int(11) DEFAULT NULL,
  `tipomov` varchar(45) NOT NULL COMMENT 'CADASTRO EQUIPAMENTO\nALOCAÇÃO - INCLUIR\nSUBSTITUIÇÃO - REMOVER\nDESCARTE - BAIXA',
  `idusuario` int(11) NOT NULL,
  PRIMARY KEY (`idhistorico`),
  KEY `FK_DEPARTAMENTO_idx` (`iddepartamento`),
  KEY `FK_EQUIPAMENTO_idx` (`codbem`),
  KEY `Fk_user_idx` (`idusuario`),
  CONSTRAINT `FK-DEPARTAMENTO` FOREIGN KEY (`iddepartamento`) REFERENCES `departamento` (`iddepartamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK-EQUIPAMENTO` FOREIGN KEY (`codbem`) REFERENCES `equipamento` (`codigobem`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Fk_user` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historico`
--

LOCK TABLES `historico` WRITE;
/*!40000 ALTER TABLE `historico` DISABLE KEYS */;
INSERT INTO `historico` VALUES (17,'2017-02-07','004',1,'CADASTRO EQUIPAMENTO',7),(18,'2017-07-02','004',3,'ALOCAÇÃO - INCLUIR',7),(19,'2017-02-07','005',1,'CADASTRO EQUIPAMENTO',7),(20,'2017-02-07','006',1,'CADASTRO EQUIPAMENTO',7),(21,'2017-02-07','007',1,'CADASTRO EQUIPAMENTO',7),(22,'2017-02-07','009',1,'CADASTRO EQUIPAMENTO',7),(23,'2017-07-02','007',3,'ALOCAÇÃO - INCLUIR',7),(24,'2017-07-02','005',3,'ALOCAÇÃO - INCLUIR',7),(25,'2017-02-07','010',1,'CADASTRO EQUIPAMENTO',7),(26,'2017-02-07','011',1,'CADASTRO EQUIPAMENTO',7),(27,'2017-02-07','012',1,'CADASTRO EQUIPAMENTO',7),(28,'2017-02-07','013',1,'CADASTRO EQUIPAMENTO',7),(29,'2017-02-07','014',1,'CADASTRO EQUIPAMENTO',7),(30,'2017-02-07','015',1,'CADASTRO EQUIPAMENTO',7),(31,'2017-02-07','016',1,'CADASTRO EQUIPAMENTO',7),(32,'2017-02-07','017',1,'CADASTRO EQUIPAMENTO',7),(33,'2017-02-07','018',1,'CADASTRO EQUIPAMENTO',7),(34,'2017-02-07','019',1,'CADASTRO EQUIPAMENTO',7),(35,'2017-02-07','020',1,'CADASTRO EQUIPAMENTO',7),(36,'2017-07-02','010',2,'ALOCAÇÃO - INCLUIR',7),(38,'2017-07-02','012',2,'ALOCAÇÃO - INCLUIR',7),(39,'2017-07-02','014',2,'ALOCAÇÃO - INCLUIR',7),(40,'2017-07-02','016',2,'ALOCAÇÃO - INCLUIR',7),(41,'2017-07-02','017',2,'ALOCAÇÃO - INCLUIR',7),(42,'2017-07-02','020',2,'ALOCAÇÃO - INCLUIR',7),(43,'2017-07-02','019',2,'ALOCAÇÃO - INCLUIR',7),(44,'2017-07-02','030',1,'CADASTRO EQUIPAMENTO',7),(46,'2017-07-02','031',1,'CADASTRO EQUIPAMENTO',7),(48,'2017-07-02','031',4,'ALOCAÇÃO - INCLUIR',7),(49,'2017-07-02','006',5,'ALOCAÇÃO - INCLUIR',7),(50,'2017-07-02','031',1,'SUBSTITUIÇÃO - REMOVER',7),(51,'2017-07-02','031',6,'ALOCAÇÃO - INCLUIR',7),(52,'2017-07-02','031',1,'SUBSTITUIÇÃO - REMOVER',7),(53,'2017-07-02','031',NULL,'DESCARTE - BAIXA',7),(54,'2017-07-02','032',1,'CADASTRO EQUIPAMENTO',7),(55,'2017-07-02','033',1,'CADASTRO EQUIPAMENTO',7),(56,'2017-07-02','035',1,'CADASTRO EQUIPAMENTO',7),(57,'2017-07-02','090',1,'CADASTRO EQUIPAMENTO',7),(58,'2017-07-02','090',3,'ALOCAÇÃO - INCLUIR',7),(59,'2017-07-02','090',NULL,'DESCARTE - BAIXA',7);
/*!40000 ALTER TABLE `historico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoaquisicao`
--

DROP TABLE IF EXISTS `tipoaquisicao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoaquisicao` (
  `idtipoaquisicao` int(11) NOT NULL AUTO_INCREMENT,
  `nometipoaquisicao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idtipoaquisicao`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoaquisicao`
--

LOCK TABLES `tipoaquisicao` WRITE;
/*!40000 ALTER TABLE `tipoaquisicao` DISABLE KEYS */;
INSERT INTO `tipoaquisicao` VALUES (1,'COMODATO'),(2,'LEASING 2012'),(3,'LEASING 2013'),(4,'LEASING 2014'),(5,'LEASING 2015'),(6,'LEASING 2016'),(7,'LEASING 2017'),(8,'PATRIMÔNIO');
/*!40000 ALTER TABLE `tipoaquisicao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoequipamento`
--

DROP TABLE IF EXISTS `tipoequipamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoequipamento` (
  `idtipoequipamento` int(11) NOT NULL AUTO_INCREMENT,
  `nometipoequipamento` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idtipoequipamento`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoequipamento`
--

LOCK TABLES `tipoequipamento` WRITE;
/*!40000 ALTER TABLE `tipoequipamento` DISABLE KEYS */;
INSERT INTO `tipoequipamento` VALUES (1,'ALL IN ONE'),(2,'ATA'),(3,'COMPUTADOR DESKTOP'),(4,'DATASHOW'),(5,'IMPRESSORA'),(6,'LEITOR COD DE BARRAS'),(7,'LINK DE DADOS'),(8,'MODEM'),(9,'MONITOR'),(10,'NOBREAK'),(11,'NOTEBOOK'),(12,'SCANNER'),(13,'STORAGE'),(14,'SWITCH');
/*!40000 ALTER TABLE `tipoequipamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `nomeusuario` varchar(120) DEFAULT NULL,
  `senha` varchar(45) DEFAULT NULL,
  `login` varchar(45) DEFAULT NULL,
  `iddepartamento` int(11) NOT NULL,
  PRIMARY KEY (`idusuario`),
  KEY `FK_DEPARTAMENTO_idx` (`iddepartamento`),
  CONSTRAINT `FK_DEP` FOREIGN KEY (`iddepartamento`) REFERENCES `departamento` (`iddepartamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (7,'Luiz Savio','123456','luizss',1),(8,'Paulo Ricardo','12345','paulorr',3);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'equipamentoti'
--

--
-- Dumping routines for database 'equipamentoti'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_departamentocreate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_departamentocreate`(out p_iddepartamento int, p_nomedepartamento varchar(120))
BEGIN
INSERT INTO departamento (nomedepartamento) 
VALUES (p_nomedepartamento);

set p_iddepartamento = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_departamentodetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_departamentodetails`(p_iddepartamento int(11))
BEGIN
select * from departamento
where iddepartamento = p_iddepartamento;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_departamentoedit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_departamentoedit`(p_iddepartamento int(11), p_nomedepartamento varchar(120))
BEGIN
update departamento
set nomedepartamento = p_nomedepartamento
    where iddepartamento = p_iddepartamento;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_departamentolist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_departamentolist`()
BEGIN
select * from departamento;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_equipamentoalocar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_equipamentoalocar`(out p_idhistorico int(11), p_codigobem varchar(45), p_iddepartamento int(11), p_datamov date, p_idusuario int(11))
BEGIN

declare exit handler for sqlexception
    begin
		rollback;
        resignal;
	end;
    
    start transaction;
    
    update equipamento
    set iddepartamento = p_iddepartamento,
    alocado = b'1'
    where codigobem = p_codigobem;
    
    insert into historico(datamov, codbem, iddepartamento, tipomov, idusuario)
    values(p_datamov, p_codigobem, p_iddepartamento, 'ALOCAÇÃO - INCLUIR', p_idusuario);
    
	set p_idhistorico = last_insert_id();
    
    commit;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_equipamentobaixa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_equipamentobaixa`(out p_idhistorico int(11), p_codigobem varchar(45), p_datamov date, p_idusuario int(11))
BEGIN

declare exit handler for sqlexception
    begin
		rollback;
        resignal;
	end;
    
    start transaction;
    
    update equipamento
    set iddepartamento = null,
    alocado = b'0',
    baixa = b'1'
    where codigobem = p_codigobem;
    
    insert into historico(datamov, codbem, iddepartamento, tipomov, idusuario)
    values(p_datamov, p_codigobem, null, 'DESCARTE - BAIXA', p_idusuario);
    
	set p_idhistorico = last_insert_id();
    
    commit;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_equipamentocreate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_equipamentocreate`(p_codigobem varchar(45), 
	p_descricao varchar(45), 
    p_idfornecedor int(11), 
    p_idtipoaquisicao int(11), 
    p_idtipoequipamento int(11), 
    p_observacao varchar(120), 
	out p_idhistorico int(11),
    p_datamov date,
    p_idusuario int(11))
BEGIN

declare exit handler for sqlexception
    begin
		rollback;
        resignal;
	end;
    
    start transaction;
    
    insert into equipamento(codigobem, descricao, idfornecedor, idtipoaquisicao, idtipoequipamento, observacao, iddepartamento, alocado, baixa)
    values(p_codigobem, p_descricao, p_idfornecedor, p_idtipoaquisicao, p_idtipoequipamento,p_observacao, 1, b'0', b'0');
    
    
    insert into historico(datamov, codbem, iddepartamento, tipomov, idusuario)
    values(p_datamov, p_codigobem, 1, 'CADASTRO EQUIPAMENTO', p_idusuario);
    
	set p_idhistorico = last_insert_id();
    
    COMMIT;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_equipamentodetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_equipamentodetails`(p_codigobem varchar(45))
BEGIN

SELECT * FROM equipamento
where codigobem = p_codigobem;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_equipamentoedit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_equipamentoedit`(p_codigobem varchar(45), 
	p_descricao varchar(45), 
    p_idfornecedor int(11), 
    p_idtipoaquisicao int(11), 
    p_idtipoequipamento int(11), 
    p_observacao varchar(120))
BEGIN

update equipamento
set 
descricao = p_descricao,
idfornecedor = p_idfornecedor,
idtipoaquisicao = p_idtipoaquisicao,
idtipoequipamento = p_idtipoequipamento,
observacao = p_observacao
where codigobem = p_codigobem;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_equipamentolist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_equipamentolist`(p_codigobem varchar(45))
BEGIN

SELECT *
 FROM equipamento e
 inner join fornecedor f on e.idfornecedor = f.idfornecedor
 inner join tipoaquisicao ta on e.idtipoaquisicao = ta.idtipoaquisicao
 inner join tipoequipamento te on e.idtipoequipamento = te.idtipoequipamento
 inner join departamento d on e.iddepartamento = d.iddepartamento
where baixa != b'1'
AND (p_codigobem is null or e.codigobem = p_codigobem);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_equipamentolistbaixado` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_equipamentolistbaixado`()
BEGIN

SELECT *
 FROM equipamento e
 inner join fornecedor f on e.idfornecedor = f.idfornecedor
 inner join tipoaquisicao ta on e.idtipoaquisicao = ta.idtipoaquisicao
 inner join tipoequipamento te on e.idtipoequipamento = te.idtipoequipamento
 left join departamento d on e.iddepartamento = d.iddepartamento
where baixa = b'1';

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_equipamentoremover` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_equipamentoremover`(out p_idhistorico int(11), p_codigobem varchar(45), p_datamov date, p_idusuario int(11))
BEGIN

declare exit handler for sqlexception
    begin
		rollback;
        resignal;
	end;
    
    start transaction;
    
    update equipamento
    set iddepartamento = 1,
    alocado = b'0'
    where codigobem = p_codigobem;
    
    insert into historico(datamov, codbem, iddepartamento, tipomov, idusuario)
    values(p_datamov, p_codigobem, 1, 'SUBSTITUIÇÃO - REMOVER', p_idusuario);
    
	set p_idhistorico = last_insert_id();
    
    commit;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_fornecedorlist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_fornecedorlist`()
BEGIN
select * from fornecedor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_historicodetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_historicodetails`(p_codbem varchar(45))
BEGIN
SELECT h.idhistorico, h.codbem, h.iddepartamento, h.tipomov, d.nomedepartamento, h.datamov, u.idusuario, u.nomeusuario 
FROM historico h
left join departamento d on h.iddepartamento = d.iddepartamento
inner join usuario u on h.idusuario = u.idusuario
where h.codbem = p_codbem
order by h.datamov, h.idhistorico desc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_tipoaquisicaolist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tipoaquisicaolist`()
BEGIN
select * from tipoaquisicao;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_tipoequipamentolist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_tipoequipamentolist`()
BEGIN
select * from tipoequipamento;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_usuariocreate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuariocreate`(out p_idusuario int(11), p_nomeusuario varchar(120), p_senha varchar(45), p_login varchar(45), p_iddepartamento int(11))
BEGIN
INSERT INTO usuario (nomeusuario, senha, login, iddepartamento) 
VALUES (P_nomeusuario, p_senha, p_login, p_iddepartamento);

set p_idusuario = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_usuariodelete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuariodelete`(p_idusuario int(11))
BEGIN
delete from usuario where idusuario = p_idusuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_usuariodetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuariodetails`(p_idusuario int(11))
BEGIN
select * from usuario
where idusuario = p_idusuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_usuarioedit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuarioedit`(p_idusuario int(11), p_nomeusuario varchar(120), p_senha varchar(45), p_login varchar(45), p_iddepartamento int(11))
BEGIN
update usuario
set nomeusuario = p_nomeusuario,
	senha = p_senha,
    login = p_login,
    iddepartamento = p_iddepartamento
    where idusuario = p_idusuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_usuariolist` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuariolist`()
BEGIN
select u.*, d.nomedepartamento from usuario u
inner join departamento d on u.iddepartamento = d.iddepartamento;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_usuariologin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_usuariologin`(p_login varchar(45), p_senha varchar(45))
BEGIN
SELECT * 
  FROM usuario
 WHERE login = p_login
   AND senha = p_Senha;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-02 17:27:43
