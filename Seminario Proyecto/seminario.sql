-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 09-11-2015 a las 02:54:25
-- Versión del servidor: 5.6.17
-- Versión de PHP: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `seminario`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `articulo`
--

CREATE TABLE IF NOT EXISTS `articulo` (
  `Numero` int(35) NOT NULL,
  `Descripcion` varchar(35) NOT NULL,
  `Precio` double NOT NULL,
  `Upc` int(32) NOT NULL,
  PRIMARY KEY (`Numero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `articulo`
--

INSERT INTO `articulo` (`Numero`, `Descripcion`, `Precio`, `Upc`) VALUES
(1, 'contable', 150, 0),
(2, 'iva', 55, 1);
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `idcliente` int(32) NOT NULL,
  `cliente` varchar(32) NOT NULL,
  `Nit` int(32) NOT NULL,
  `Direccion` varchar(32) NOT NULL,
  `dpi_cte` int(20) NOT NULL,
  `telefono_cte` int(15) NOT NULL,
  `estado_cte` tinyint(1) NOT NULL,
  PRIMARY KEY (`idcliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`idcliente`, `cliente`, `Nit`, `Direccion`, `dpi_cte`, `telefono_cte`, `estado_cte`) VALUES
(1, 'jose ambrosio', 151088, '2 av zona 2', 2254875, 2465878, 1),
(2, 'Aceros Prefabricados', 154785, 'Calzada atanazio tzul 3-25', 2545648, 254588, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE IF NOT EXISTS `detallefactura` (
  `NumeroFactura` int(32) NOT NULL,
  `NumeroArticulo` int(32) NOT NULL,
  `Piezas` int(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE IF NOT EXISTS `factura` (
  `Numero` int(32) NOT NULL,
  `Cliente` varchar(32) NOT NULL,
  `Rfc` int(32) NOT NULL,
  `Direccion` varchar(32) NOT NULL,
  `FechaFacturacion` date NOT NULL,
  PRIMARY KEY (`Numero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_empleados`
--

CREATE TABLE IF NOT EXISTS `tbl_empleados` (
  `idtbl_empleados` int(32) NOT NULL,
  `nombre_emp` varchar(32) NOT NULL,
  `apellido_emp` varchar(32) NOT NULL,
  `dpi_emp` int(32) NOT NULL,
  `fecha` date NOT NULL,
  `nit_emp` varchar(15) NOT NULL,
  `dire_emp` varchar(65) NOT NULL,
  PRIMARY KEY (`idtbl_empleados`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_empleados`
--

INSERT INTO `tbl_empleados` (`idtbl_empleados`, `nombre_emp`, `apellido_emp`, `dpi_emp`, `fecha`, `nit_emp`, `dire_emp`) VALUES
(1, 'jose', 'ambrosio', 15566366, '2015-11-03', '2558458', 'Ciudad de Guatemala');
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_proveedor`
--

CREATE TABLE IF NOT EXISTS `tbl_proveedor` (
  `id_proveedor` int(5) NOT NULL,
  `nom_prov` varchar(50) NOT NULL,
  `nit_prov` varchar(20) NOT NULL,
  `telefono_prov` int(15) NOT NULL,
  `direc_prov` varchar(65) NOT NULL,
  `estado_prov` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_proveedor`
--

INSERT INTO `tbl_proveedor` (`id_proveedor`, `nom_prov`, `nit_prov`, `telefono_prov`, `direc_prov`, `estado_prov`) VALUES
(1, '2546548', 'El Progreso', 4642156, 'Zona 1', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario`
--

CREATE TABLE IF NOT EXISTS `tbl_usuario` (
  `idtbl_usuario` int(20) NOT NULL,
  `tbl_empleados_idtbl_empleados` int(20) NOT NULL,
  `tipo_usuario` int(20) NOT NULL,
  `nom_usuario` varchar(20) NOT NULL,
  `contra_usuario` varchar(20) NOT NULL,
  PRIMARY KEY (`idtbl_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_usuario`
--

INSERT INTO `tbl_usuario` (`idtbl_usuario`, `tbl_empleados_idtbl_empleados`, `tipo_usuario`, `nom_usuario`, `contra_usuario`) VALUES
(1, 1, 1, 'jaar', '123');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
