-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-05-2023 a las 15:24:22
-- Versión del servidor: 10.4.14-MariaDB
-- Versión de PHP: 7.4.10

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
-- Estructura de tabla para la tabla `corte`
--

CREATE TABLE `corte` (
  `idCorte` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Cajero` varchar(50) NOT NULL,
  `Turno` varchar(15) NOT NULL,
  `Total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `corte`
--

INSERT INTO `corte` (`idCorte`, `Fecha`, `Cajero`, `Turno`, `Total`) VALUES
(0, '2023-05-06', 'ninguno', 'ninguno', 100),
(1, '2023-05-06', 'Carmen Montaño', 'TERCERO', 48.8),
(2, '2023-05-06', 'Carlos Cardenas', 'PRIMERO', 15),
(3, '2023-05-06', 'Carlos Cardenas', 'PRIMERO', 24),
(4, '2023-05-06', 'admon', 'SEGUNDO', 120),
(5, '2023-05-06', 'admon', 'TERCERO', 24),
(6, '2023-05-06', 'Carmen Montaño', 'SEGUNDO', 27),
(7, '2023-05-06', 'Carmen Montaño', 'PRIMERO', 35.65),
(8, '2023-05-06', 'Carlos Cardenas', 'PRIMERO', 0),
(9, '2023-05-06', 'Carlos Cardenas', 'PRIMERO', 0),
(10, '2023-05-07', 'Carlos Cardenas', 'SEGUNDO', 57.2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE `detallefactura` (
  `idDetalleFactura` int(11) NOT NULL,
  `CodigoProducto` varchar(20) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  `Cantidad` float NOT NULL,
  `SubTotal` float NOT NULL,
  `Iva` float NOT NULL,
  `Total` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `detallefactura`
--

INSERT INTO `detallefactura` (`idDetalleFactura`, `CodigoProducto`, `Descripcion`, `Cantidad`, `SubTotal`, `Iva`, `Total`) VALUES
(0,'-------','--------',0,0,0,0),(23,'ENTOMATADAS','Desayuno',1,0,0,19.55),(24,'PECHUGA RELLENA','Platillo',1,0,0,17.25),(25,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(26,'ENTOMATADAS','Desayuno',1,0,0,19.55),(27,'PECHUGARELLENA','Platillo',1,0,0,17.25),(28,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(29,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(30,'CREPAS','Postre',1,0,0,15),(31,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(32,'MICHELADAS','Bebida',1,0,0,12),(33,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(34,'COCA6','Refresco Coca Cola de 600 ml',1,0,0,12),(35,'CREPAS','Postre',1,0,0,12);


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `Codigo` int(11) NOT NULL,
  `CodigoExterno` varchar(20) NOT NULL,
  `Descripcion` varchar(40) NOT NULL,
  `Venta` varchar(20) NOT NULL,
  `Precio` float NOT NULL,
  `Iva` int(11) NOT NULL,
  `Stock` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`Codigo`, `CodigoExterno`, `Descripcion`, `Venta`, `Precio`, `Iva`, `Stock`) VALUES
(1,'COCA6','Refresco Coca Cola de 600 ml','orden',10,20,38),(2,'CREPAS','Postres','orden',12.5,20,29),(3,'MICHELADAS','Bebidas','orden',10,20,29),(4,'TASAJO','Platillo','orden',10,20,30),(5,'PASTA','Platillo','orden',14,15,29.5),(6,'PECHUGA RELLENA','Platillo','orden',15,15,29),(7,'PAPAS FRITAS','Platillos','orden',16.5,15,29.5),(8,'ENTOMATADAS','Desayuno','orden',17,15,29),(11,'NARANJADA','Bebida','orden',7,20,29),(12,'ENFROJOLADAS','Desayuno','orden',7,20,29),(13,'CAMARONES','Platillo','orden',7,20,30),(14,'FILETE','Platillo','orden',20,20,30),(15,'ENFRIJOLADAS','Desayuno','orden',20,20,30),(16,'CAFE','Bebida','orden',20,20,29);
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Clave` int(11) NOT NULL,
  `TipoUsuario` varchar(20) DEFAULT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Password` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Clave`, `TipoUsuario`, `Nombre`, `Password`) VALUES
(1, 'administrador', 'admon', '12345678'),
(2, 'cajero', 'Carlos Cardenas', '12345678'),
(3, 'cajero', 'Carmen Montaño', '12345678');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturadetalle`
--

CREATE TABLE `facturadetalle` (
  `idFacturaDetalle` int(11) NOT NULL,
  `Venta` int(11) NOT NULL,
  `Detalle` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `ventadetalle`
--

INSERT INTO `facturadetalle` (`idFacturaDetalle`, `Venta`, `Detalle`) VALUES
(0, 0, 0),
(11, 15, 29),
(12, 15, 30),
(13, 17, 32),
(14, 18, 33),
(15, 19, 34),
(16, 20, 36),
(17, 21, 38),
(18, 22, 42),
(19, 22, 45),
(20, 22, 49);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

CREATE TABLE `facturas` (
  `idFacturas` int(11) NOT NULL,
  `Hora` datetime NOT NULL,
  `Subtotal` float NOT NULL,
  `Iva` float NOT NULL,
  `Total` float NOT NULL,
  `Corte` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `facturas`
--

INSERT INTO `facturas` (`idFacturas`, `Hora`, `Subtotal`, `Iva`, `Total`, `Corte`) VALUES
(0, '2023-10-05 00:00:00', 0, 0, 0, 0),
(13, '2023-05-06 13:21:18', 42, 6.8, 48.8, 1),
(14, '2023-05-06 13:21:39', 42, 6.8, 48.8, 1),
(15, '2023-05-06 13:22:49', 10, 2, 12, 2),
(16, '2023-05-06 13:23:02', 12.5, 2.5, 15, 2),
(17, '2023-05-06 13:24:54', 20, 4, 24, 3),
(18, '2023-05-06 15:38:04', 100, 20, 120, 4),
(19, '2023-05-06 15:39:08', 20, 4, 24, 5),
(20, '2023-05-06 17:27:50', 22.5, 4.5, 27, 6),
(21, '2023-05-06 17:28:22', 31, 4.65, 35.65, 7),
(22, '2023-05-07 17:39:47', 47, 9.4, 56.4, 10),
(23, '2023-05-07 17:40:46', 27.75, 4.7875, 32.5375, 10),
(24, '2023-05-07 17:41:58', 49, 8.2, 57.2, 10);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `corte`
--
ALTER TABLE `corte`
  ADD PRIMARY KEY (`idCorte`);

--
-- Indices de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD PRIMARY KEY (`idDetalleFactura`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`Codigo`),
  ADD UNIQUE KEY `CodigoExterno` (`CodigoExterno`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Clave`);

--
-- Indices de la tabla `facturadetalle`
--
ALTER TABLE `facturadetalle`
  ADD PRIMARY KEY (`idFacturaDetalle`),
  ADD KEY `Venta_idx` (`Venta`),
  ADD KEY `Detalle_idx` (`Detalle`);

--
-- Indices de la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD PRIMARY KEY (`idFacturas`),
  ADD KEY `Corte_idx` (`Corte`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `corte`
--
ALTER TABLE `corte`
  MODIFY `idCorte` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  MODIFY `idDetalleFactura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `Codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Clave` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `facturadetalle`
--
ALTER TABLE `facturadetalle`
  MODIFY `idFacturaDetalle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `facturas`
--
ALTER TABLE `facturas`
  MODIFY `idFacturas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
