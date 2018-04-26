/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : 127.0.0.1:3306
Source Database       : facturacion

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2018-04-25 18:29:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for categorias
-- ----------------------------
DROP TABLE IF EXISTS `categorias`;
CREATE TABLE `categorias` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of categorias
-- ----------------------------
INSERT INTO `categorias` VALUES ('1', 'Caldos');
INSERT INTO `categorias` VALUES ('2', 'Fondos');
INSERT INTO `categorias` VALUES ('3', 'Guarniciones');
INSERT INTO `categorias` VALUES ('4', 'Bebidas Frías');
INSERT INTO `categorias` VALUES ('5', 'Bebidas Calientes');

-- ----------------------------
-- Table structure for clientes
-- ----------------------------
DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `persona` enum('0','1') NOT NULL DEFAULT '0',
  `ruc` char(11) DEFAULT NULL,
  `razon_social` text,
  `dni` char(8) DEFAULT NULL,
  `nombres` varchar(255) DEFAULT NULL,
  `apellidos` varchar(255) DEFAULT NULL,
  `direccion` text NOT NULL,
  `telefono` varchar(9) NOT NULL,
  `correo` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of clientes
-- ----------------------------

-- ----------------------------
-- Table structure for comprobantes
-- ----------------------------
DROP TABLE IF EXISTS `comprobantes`;
CREATE TABLE `comprobantes` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `version_ubl` varchar(10) DEFAULT NULL,
  `numeracion` varchar(13) DEFAULT NULL,
  `fecha_emision` datetime DEFAULT NULL,
  `tipo` enum('Factura','Boleta de Venta','Nota de Debito','Nota de Credito') DEFAULT NULL,
  `tipo_moneda` varchar(10) DEFAULT NULL,
  `tipo_pago` varchar(20) DEFAULT NULL,
  `fecha_vencimiento` datetime DEFAULT NULL,
  `serie` varchar(4) DEFAULT NULL,
  `correlativo` varchar(8) DEFAULT NULL,
  `hash` varchar(255) DEFAULT NULL,
  `subtotal` decimal(18,2) unsigned NOT NULL DEFAULT '0.00',
  `descuento` decimal(18,2) unsigned NOT NULL DEFAULT '0.00',
  `igv` decimal(18,2) unsigned NOT NULL DEFAULT '0.00',
  `total` decimal(18,2) unsigned NOT NULL DEFAULT '0.00',
  `mesa` char(2) NOT NULL,
  `estado` enum('Pendiente','Emitida','Enviada','Aceptada','Rechazada') NOT NULL,
  `cliente_id` int(10) unsigned DEFAULT NULL,
  `usuario_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cliente_id` (`cliente_id`),
  KEY `usuario_id` (`usuario_id`),
  KEY `mesa_id` (`mesa`),
  CONSTRAINT `comprobantes_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `clientes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `comprobantes_ibfk_2` FOREIGN KEY (`usuario_id`) REFERENCES `usuarios` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of comprobantes
-- ----------------------------

-- ----------------------------
-- Table structure for comprobante_producto
-- ----------------------------
DROP TABLE IF EXISTS `comprobante_producto`;
CREATE TABLE `comprobante_producto` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `posicion` int(10) unsigned NOT NULL,
  `cantidad` int(10) unsigned NOT NULL,
  `afectacion_igv` varchar(25) DEFAULT NULL,
  `igv` decimal(18,2) NOT NULL DEFAULT '0.00',
  `precio_neto` decimal(18,2) unsigned NOT NULL DEFAULT '0.00',
  `comprobante_id` int(10) unsigned NOT NULL,
  `producto_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `comprobante_id` (`comprobante_id`),
  KEY `producto_id` (`producto_id`),
  CONSTRAINT `comprobante_producto_ibfk_1` FOREIGN KEY (`comprobante_id`) REFERENCES `comprobantes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `comprobante_producto_ibfk_2` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of comprobante_producto
-- ----------------------------

-- ----------------------------
-- Table structure for envios
-- ----------------------------
DROP TABLE IF EXISTS `envios`;
CREATE TABLE `envios` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `codigo` varchar(25) NOT NULL,
  `respuesta` varchar(255) NOT NULL,
  `fecha` datetime NOT NULL,
  `comprobante_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `comprobante_id` (`comprobante_id`),
  CONSTRAINT `envios_ibfk_1` FOREIGN KEY (`comprobante_id`) REFERENCES `comprobantes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of envios
-- ----------------------------

-- ----------------------------
-- Table structure for mesas
-- ----------------------------
DROP TABLE IF EXISTS `mesas`;
CREATE TABLE `mesas` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `numero` int(10) unsigned NOT NULL,
  `estado` enum('Libre','Ocupada','Reservada') NOT NULL DEFAULT 'Libre',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of mesas
-- ----------------------------
INSERT INTO `mesas` VALUES ('1', '1', 'Libre');
INSERT INTO `mesas` VALUES ('2', '2', 'Libre');
INSERT INTO `mesas` VALUES ('3', '3', 'Libre');
INSERT INTO `mesas` VALUES ('4', '4', 'Libre');
INSERT INTO `mesas` VALUES ('5', '5', 'Libre');
INSERT INTO `mesas` VALUES ('6', '6', 'Libre');
INSERT INTO `mesas` VALUES ('7', '7', 'Libre');
INSERT INTO `mesas` VALUES ('8', '8', 'Libre');
INSERT INTO `mesas` VALUES ('9', '9', 'Libre');
INSERT INTO `mesas` VALUES ('10', '10', 'Libre');
INSERT INTO `mesas` VALUES ('11', '11', 'Libre');
INSERT INTO `mesas` VALUES ('12', '12', 'Libre');
INSERT INTO `mesas` VALUES ('13', '13', 'Libre');
INSERT INTO `mesas` VALUES ('14', '14', 'Libre');
INSERT INTO `mesas` VALUES ('15', '15', 'Libre');
INSERT INTO `mesas` VALUES ('16', '16', 'Libre');
INSERT INTO `mesas` VALUES ('17', '17', 'Libre');
INSERT INTO `mesas` VALUES ('18', '18', 'Libre');
INSERT INTO `mesas` VALUES ('19', '19', 'Libre');
INSERT INTO `mesas` VALUES ('20', '20', 'Libre');
INSERT INTO `mesas` VALUES ('21', '21', 'Libre');
INSERT INTO `mesas` VALUES ('22', '22', 'Libre');
INSERT INTO `mesas` VALUES ('23', '23', 'Libre');
INSERT INTO `mesas` VALUES ('24', '24', 'Libre');
INSERT INTO `mesas` VALUES ('25', '25', 'Libre');
INSERT INTO `mesas` VALUES ('26', '26', 'Libre');
INSERT INTO `mesas` VALUES ('27', '27', 'Libre');
INSERT INTO `mesas` VALUES ('28', '28', 'Libre');
INSERT INTO `mesas` VALUES ('29', '29', 'Libre');
INSERT INTO `mesas` VALUES ('30', '30', 'Libre');
INSERT INTO `mesas` VALUES ('31', '31', 'Libre');
INSERT INTO `mesas` VALUES ('32', '32', 'Libre');
INSERT INTO `mesas` VALUES ('33', '33', 'Libre');
INSERT INTO `mesas` VALUES ('34', '34', 'Libre');
INSERT INTO `mesas` VALUES ('35', '35', 'Libre');
INSERT INTO `mesas` VALUES ('36', '36', 'Libre');
INSERT INTO `mesas` VALUES ('37', '37', 'Libre');
INSERT INTO `mesas` VALUES ('38', '38', 'Libre');
INSERT INTO `mesas` VALUES ('39', '39', 'Libre');
INSERT INTO `mesas` VALUES ('40', '40', 'Libre');
INSERT INTO `mesas` VALUES ('51', '41', 'Libre');
INSERT INTO `mesas` VALUES ('52', '42', 'Libre');
INSERT INTO `mesas` VALUES ('53', '43', 'Libre');
INSERT INTO `mesas` VALUES ('54', '44', 'Libre');
INSERT INTO `mesas` VALUES ('55', '45', 'Libre');
INSERT INTO `mesas` VALUES ('56', '46', 'Libre');
INSERT INTO `mesas` VALUES ('57', '47', 'Libre');
INSERT INTO `mesas` VALUES ('58', '48', 'Libre');
INSERT INTO `mesas` VALUES ('59', '49', 'Libre');
INSERT INTO `mesas` VALUES ('60', '50', 'Libre');

-- ----------------------------
-- Table structure for productos
-- ----------------------------
DROP TABLE IF EXISTS `productos`;
CREATE TABLE `productos` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `codigo` varchar(30) DEFAULT NULL,
  `codigo_sunat` varchar(20) DEFAULT NULL,
  `nombre` varchar(255) NOT NULL,
  `precio_unitario` decimal(18,2) unsigned NOT NULL DEFAULT '0.00',
  `categoria_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `categoria_id` (`categoria_id`),
  CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`categoria_id`) REFERENCES `categorias` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of productos
-- ----------------------------
INSERT INTO `productos` VALUES ('1', null, null, 'Gallina c/ Arroz', '15.00', '1');
INSERT INTO `productos` VALUES ('2', null, null, 'Gallina c/ Fideo', '15.00', '1');
INSERT INTO `productos` VALUES ('3', null, null, 'Lomito Saltado', '16.00', '2');
INSERT INTO `productos` VALUES ('4', null, null, 'Lomito Montado', '17.00', '2');
INSERT INTO `productos` VALUES ('5', null, null, 'Saltado de Pollo', '16.00', '2');
INSERT INTO `productos` VALUES ('6', null, null, 'Tallarin Saltado', '16.00', '2');
INSERT INTO `productos` VALUES ('7', null, null, 'Churrasco', '17.00', '2');
INSERT INTO `productos` VALUES ('8', null, null, 'Churrasco Montado', '18.00', '2');
INSERT INTO `productos` VALUES ('9', null, null, 'Churrasco a lo Pobre', '19.00', '2');
INSERT INTO `productos` VALUES ('10', null, null, 'Milanesa', '17.00', '2');
INSERT INTO `productos` VALUES ('11', null, null, 'Arroz a la Cubana', '13.00', '2');
INSERT INTO `productos` VALUES ('12', null, null, 'Bistec', '17.00', '2');
INSERT INTO `productos` VALUES ('13', null, null, 'Bistec Montado', '18.00', '2');
INSERT INTO `productos` VALUES ('14', null, null, 'Bistec a lo Pobre', '19.00', '2');
INSERT INTO `productos` VALUES ('15', null, null, 'Porción Arroz', '4.00', '3');
INSERT INTO `productos` VALUES ('16', null, null, 'Porción Papas Fritas', '6.00', '3');
INSERT INTO `productos` VALUES ('17', null, null, 'Porción Ensalada', '5.00', '3');
INSERT INTO `productos` VALUES ('18', null, null, 'Porción Roscas', '3.50', '3');
INSERT INTO `productos` VALUES ('19', null, null, 'Porción Pan', '2.00', '3');
INSERT INTO `productos` VALUES ('20', null, null, 'Huevo Duro', '1.00', '3');
INSERT INTO `productos` VALUES ('21', null, null, 'Gaseosa LT. 1/2', '7.00', '4');
INSERT INTO `productos` VALUES ('22', null, null, 'Gaseosa LT.', '6.00', '4');
INSERT INTO `productos` VALUES ('23', null, null, 'Gaseosa 1/2 LT.', '4.00', '4');
INSERT INTO `productos` VALUES ('24', null, null, 'Gaseosa Personal', '2.00', '4');
INSERT INTO `productos` VALUES ('25', null, null, 'Agua S/G Personal', '3.00', '4');
INSERT INTO `productos` VALUES ('26', null, null, 'Agua C/G Personal', '3.00', '4');
INSERT INTO `productos` VALUES ('27', null, null, 'Gatorade Chico', '4.00', '4');
INSERT INTO `productos` VALUES ('28', null, null, 'Gatorade Grande', '5.00', '4');
INSERT INTO `productos` VALUES ('29', null, null, 'Jarra Chicha Morada', '8.00', '4');
INSERT INTO `productos` VALUES ('30', null, null, '1/2 Jarra Chicha Morada', '4.00', '4');
INSERT INTO `productos` VALUES ('31', null, null, 'Jarra Maracuyá', '11.00', '4');
INSERT INTO `productos` VALUES ('32', null, null, '1/2 Jarra Maracuyá', '6.00', '4');
INSERT INTO `productos` VALUES ('33', null, null, 'Taza Café', '3.00', '5');
INSERT INTO `productos` VALUES ('34', null, null, 'Té, Manz., Anís', '2.00', '5');

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `dni` char(8) NOT NULL,
  `nombres` varchar(255) NOT NULL,
  `apellidos` varchar(255) NOT NULL,
  `direccion` varchar(255) NOT NULL,
  `telefono` char(9) DEFAULT NULL,
  `usuario` varchar(25) NOT NULL,
  `clave` varchar(25) NOT NULL,
  `categoria` enum('1','2','3') NOT NULL DEFAULT '3',
  `estado` tinyint(3) unsigned NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO `usuarios` VALUES ('1', '45917242', 'Luis Gustavo', 'Torres Llanos', 'Lambayeque N°34', '949867834', 'ltorres', 'ltorres', '1', '1');
INSERT INTO `usuarios` VALUES ('2', '46665218', 'Rogger Alejandro', 'Ortiz Briceño', 'Las Capullanas G1', '982591679', 'rortiz', 'rortiz', '2', '1');
INSERT INTO `usuarios` VALUES ('4', '41785698', 'Ruben Jeinner', 'Mendienta Melendez', '', '', 'rmendieta', 'rmendieta', '3', '1');
