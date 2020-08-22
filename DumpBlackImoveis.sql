-- MariaDB dump 10.17  Distrib 10.4.13-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: blackimoveis
-- ------------------------------------------------------
-- Server version	10.4.13-MariaDB

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
-- Table structure for table `imoveis`
--

DROP TABLE IF EXISTS `imoveis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `imoveis` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `Sobrenome` varchar(100) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Telefone` int(11) DEFAULT NULL,
  `Tipo` varchar(30) DEFAULT NULL,
  `TipoServico` varchar(30) DEFAULT NULL,
  `Financiamento` tinyint(1) DEFAULT NULL,
  `Endereco` text DEFAULT NULL,
  `Cidade` varchar(30) DEFAULT NULL,
  `Sala` int(11) DEFAULT NULL,
  `Quarto` int(11) DEFAULT NULL,
  `Suite` int(11) DEFAULT NULL,
  `Varanda` varchar(20) DEFAULT NULL,
  `QrtoReversivel` varchar(20) DEFAULT NULL,
  `Armarios` varchar(20) DEFAULT NULL,
  `WCSocial` varchar(20) DEFAULT NULL,
  `Cozinha` varchar(20) DEFAULT NULL,
  `Copa` varchar(20) DEFAULT NULL,
  `ArmariosCozinha` varchar(20) DEFAULT NULL,
  `AreaServico` varchar(20) DEFAULT NULL,
  `WCServico` varchar(20) DEFAULT NULL,
  `Piscina` varchar(20) DEFAULT NULL,
  `SLFesta` varchar(20) DEFAULT NULL,
  `Garagem` varchar(20) DEFAULT NULL,
  `AreaUtil` decimal(10,2) DEFAULT NULL,
  `ValorImovel` decimal(10,2) DEFAULT NULL,
  `Condominio` decimal(10,2) DEFAULT NULL,
  `IPTU` decimal(10,2) DEFAULT NULL,
  `Comentario` text DEFAULT NULL,
  `Bairro` varchar(50) DEFAULT NULL,
  `Titulo` varchar(200) DEFAULT NULL,
  `Descricao` text DEFAULT NULL,
  `Post` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imoveis`
--

LOCK TABLES `imoveis` WRITE;
/*!40000 ALTER TABLE `imoveis` DISABLE KEYS */;
INSERT INTO `imoveis` VALUES (1,'Jorge','Black','jorgeh.black@gmail.com',0,'Apartamento','Aluguel',0,'R. da Hora, 593','Recife',2,4,1,'varanda-sim','qrto-reversivel-nao','Armarios-sim','WCSocial-sim','Cozinha-sim','Copa-nao','ArmariosCozinha-sim','AreaServico-sim','WCServico-nao','Piscina-sim','SLFesta-sim','Garagem-sim',2000.00,2.50,0.00,500.00,'Ótimo, viu!','Espinheiro',NULL,NULL,0),(2,'Roberta','Black','robbk@gmail.com',992940031,'Apartamento','Venda',0,'R. da Hora, 593','Recife',1,3,0,'Nao','Sim','Sim','Sim','Sim','Nao','Sim','Sim','Sim','Nao','Nao','Sim',100.00,300000.00,500.00,200.00,'Imóvel espaçoso e ventilado muito bem localizado. ','Espinheiro',NULL,NULL,0);
/*!40000 ALTER TABLE `imoveis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mensagens`
--

DROP TABLE IF EXISTS `mensagens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mensagens` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `Sobrenome` varchar(100) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Telefone` int(11) DEFAULT NULL,
  `Mensagens` text DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mensagens`
--

LOCK TABLES `mensagens` WRITE;
/*!40000 ALTER TABLE `mensagens` DISABLE KEYS */;
INSERT INTO `mensagens` VALUES (1,'Jorge','Black','jorgeh.black@gmail.com',994810031,'Adorei o site de vocês! Tem tudo que eu busco em uma corretora, estão de parabéns, viu!');
/*!40000 ALTER TABLE `mensagens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Login` varchar(50) DEFAULT NULL,
  `Senha` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Henrique Black','hnrqblck@gmail.com','gitablck','123'),(2,'Eduarda Black','eduardamblack@gmail.com','duda','123');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-22 15:22:57
