-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.6.21 - MySQL Community Server (GPL)
-- SO del servidor:              Win32
-- HeidiSQL Versión:             10.3.0.5771
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para innovationstrategies
CREATE DATABASE IF NOT EXISTS `innovationstrategies` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `innovationstrategies`;

-- Volcando estructura para tabla innovationstrategies.drivers
CREATE TABLE IF NOT EXISTS `drivers` (
  `Dni` varchar(50) DEFAULT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Surnames` varchar(100) DEFAULT NULL,
  `Points` int(11) DEFAULT '50'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla innovationstrategies.infringementdrivers
CREATE TABLE IF NOT EXISTS `infringementdrivers` (
  `Date` datetime DEFAULT NULL,
  `Dni` varchar(50) DEFAULT NULL,
  `NumberInfringement` int(11) DEFAULT NULL,
  `VehicleRegistration` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla innovationstrategies.infringementtype
CREATE TABLE IF NOT EXISTS `infringementtype` (
  `Number` int(11) NOT NULL AUTO_INCREMENT,
  `Infringement` varchar(50) DEFAULT NULL,
  `Points` int(11) DEFAULT NULL,
  PRIMARY KEY (`Number`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla innovationstrategies.vehicledrivers
CREATE TABLE IF NOT EXISTS `vehicledrivers` (
  `Dni` varchar(50) DEFAULT NULL,
  `VehicleRegistration` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla innovationstrategies.vehicles
CREATE TABLE IF NOT EXISTS `vehicles` (
  `VehicleRegistration` varchar(50) DEFAULT NULL,
  `Brand` varchar(50) DEFAULT NULL,
  `Model` varchar(50) DEFAULT NULL,
  `Dni` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
