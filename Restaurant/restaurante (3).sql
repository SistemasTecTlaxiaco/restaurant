-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-05-2023 a las 20:07:28
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `restaurante`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `IdCliente` int(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `DireccionC` text NOT NULL,
  `TelefonoC` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`IdCliente`, `Nombre`, `DireccionC`, `TelefonoC`) VALUES
(1, 'lucas ', ' san sebastian', 2147483647),
(2, 'Maria', '0', 953124587);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `corte`
--

CREATE TABLE `corte` (
  `IdCorte` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Cajero` varchar(50) NOT NULL,
  `Turno` varchar(15) NOT NULL,
  `Total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `corte`
--

INSERT INTO `corte` (`IdCorte`, `Fecha`, `Cajero`, `Turno`, `Total`) VALUES
(1, '2023-05-16', '1', 'matutino', 123),
(2, '2023-05-10', '1', 'matutino', 254);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE `detallefactura` (
  `IdDetalleFactura` int(11) NOT NULL,
  `IdOrdenarOrd` varchar(20) NOT NULL,
  `Cantidad` float NOT NULL,
  `Subtotal` float NOT NULL,
  `Iva` float NOT NULL,
  `TotalD` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `detallefactura`
--

INSERT INTO `detallefactura` (`IdDetalleFactura`, `IdOrdenarOrd`, `Cantidad`, `Subtotal`, `Iva`, `TotalD`) VALUES
(3, '1', 2, 45, 9, 54),
(4, '1', 2, 56, 4, 60);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `IdEmpleados` int(11) NOT NULL,
  `Nombree` varchar(45) NOT NULL,
  `Cargoe` varchar(20) NOT NULL,
  `Telefonoe` int(10) NOT NULL,
  `Direccione` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`IdEmpleados`, `Nombree`, `Cargoe`, `Telefonoe`, `Direccione`) VALUES
(1, 'marcos', 'mesero', 56234879, 'san pedro'),
(2, 'lucas mar', 'cajero1', 53264875, 'san juan'),
(3, 'marcos', 'mesero', 56234879, 'san pedro'),
(4, 'lucas mar', 'cajero1', 53264875, 'san juan');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturadetalle`
--

CREATE TABLE `facturadetalle` (
  `IdFacturaDetalle` int(11) NOT NULL,
  `Factura` int(11) NOT NULL,
  `Detalle` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `facturadetalle`
--

INSERT INTO `facturadetalle` (`IdFacturaDetalle`, `Factura`, `Detalle`) VALUES
(7, 25, 28),
(8, 26, 29);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

CREATE TABLE `facturas` (
  `IdFactura` int(11) NOT NULL,
  `Hora` datetime NOT NULL,
  `Subtotal` float NOT NULL,
  `Iva` float NOT NULL,
  `Total` float NOT NULL,
  `Corte` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `facturas`
--

INSERT INTO `facturas` (`IdFactura`, `Hora`, `Subtotal`, `Iva`, `Total`, `Corte`) VALUES
(9, '2023-05-26 02:27:57', 57, 9, 66, 10),
(15, '2023-05-26 02:27:57', 23, 5, 28, 57);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mesa`
--

CREATE TABLE `mesa` (
  `Id_mesa` int(3) NOT NULL,
  `Numesa` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `mesa`
--

INSERT INTO `mesa` (`Id_mesa`, `Numesa`) VALUES
(8, 12),
(9, 14);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ordenar`
--

CREATE TABLE `ordenar` (
  `IdOrdenar` int(11) NOT NULL,
  `Platillos` varchar(40) NOT NULL,
  `Desayunos` varchar(40) NOT NULL,
  `Postres` varchar(40) NOT NULL,
  `Bebidas` varchar(40) NOT NULL,
  `Iva` int(11) NOT NULL,
  `Stock` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `ordenar`
--

INSERT INTO `ordenar` (`IdOrdenar`, `Platillos`, `Desayunos`, `Postres`, `Bebidas`, `Iva`, `Stock`) VALUES
(0, 'pechuga rellena', 'entomatadas', 'brownie', 'refrescos', 16, 0),
(11, 'Cordon blue', 'enfrijoladas', 'crepas', 'agua ', 16, 0),
(12, 'pechuga rellena', 'entomatadas', 'brownie', 'refrescos', 16, 45),
(14, 'Cordon blue', 'enfrijoladas', 'crepas', 'agua ', 16, 78),
(18, 'Arrachera', 'huevos divorciados', 'pastel', 'limonada', 16, 0),
(20, 'fajitas de pollo', 'entomatadas', 'durazno con crema', 'cafe americano', 16, 0),
(21, 'alambre de pollo', 'enchiladas verdes', 'Oaxaca de mis amores', 'cafe de olla', 16, 0),
(22, 'al mojo de ajo', 'huevo con jamon', 'helado', 'jugo de naranja', 16, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`IdCliente`);

--
-- Indices de la tabla `corte`
--
ALTER TABLE `corte`
  ADD PRIMARY KEY (`IdCorte`);

--
-- Indices de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD PRIMARY KEY (`IdDetalleFactura`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`IdEmpleados`);

--
-- Indices de la tabla `facturadetalle`
--
ALTER TABLE `facturadetalle`
  ADD PRIMARY KEY (`IdFacturaDetalle`);

--
-- Indices de la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD PRIMARY KEY (`IdFactura`);

--
-- Indices de la tabla `mesa`
--
ALTER TABLE `mesa`
  ADD PRIMARY KEY (`Id_mesa`);

--
-- Indices de la tabla `ordenar`
--
ALTER TABLE `ordenar`
  ADD PRIMARY KEY (`IdOrdenar`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
