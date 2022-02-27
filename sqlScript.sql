#CREATE SCHEMA inventoryapp

DROP TABLE IF EXISTS inventory,log,wineries,items;

CREATE TABLE IF NOT EXISTS `wineries` (
  `id` int(4) NOT NULL  AUTO_INCREMENT COMMENT 'Clave primaria',
  `name` varchar(50) NOT NULL UNIQUE COMMENT 'nombre',
  `location` varchar(50) NOT NULL COMMENT 'Lugar',
  PRIMARY KEY (`id`)
) COMMENT='tabla bodegas';

CREATE TABLE IF NOT EXISTS `items` (
  `id` int(4) NOT NULL  AUTO_INCREMENT COMMENT 'Clave primaria',
  `name` varchar(50) NOT NULL UNIQUE COMMENT 'nombre',
  `description` varchar(200) COMMENT 'Descripcion del articulo',
  PRIMARY KEY (`id`)
) COMMENT='tabla de articulos';

CREATE TABLE IF NOT EXISTS `inventory` (
  `id` int(4) NOT NULL  AUTO_INCREMENT COMMENT 'Clave primaria',
  `stock` int(8) UNSIGNED COMMENT 'cantidad de articulos' ,
  `winerie_id` int(4) NOT NULL COMMENT 'Bodega',
  `item_id` int(4) NOT NULL COMMENT 'item',
  PRIMARY KEY (`id`),
  UNIQUE KEY (`winerie_id`,`item_id`),
  FOREIGN KEY (`winerie_id`) REFERENCES wineries(`id`) ON DELETE CASCADE,  
  FOREIGN KEY (`item_id`) REFERENCES items(`id`) ON DELETE CASCADE
) COMMENT='cantidad de producto';



CREATE TABLE IF NOT EXISTS `log` (
  `id` int(4) NOT NULL  AUTO_INCREMENT COMMENT 'Clave primaria',
  `fecha` TIMESTAMP NOT NULL DEFAULT (CURRENT_DATE) COMMENT 'fecha de transferencia',
  `origin_winerie` int(4) NOT NULL  COMMENT 'Bodega origen',
  `destination_winerie` int(4) NOT NULL  COMMENT 'Bodega destino',
  `item_id` int(4) NOT NULL COMMENT 'articulo trasferido',
  `amount` int(8) UNSIGNED NOT NULL COMMENT 'Cantidad de articulos',
  PRIMARY KEY (`id`),
  FOREIGN KEY (`item_id`) REFERENCES items(`id`) ON DELETE CASCADE,
  FOREIGN KEY (`origin_winerie`) REFERENCES wineries(`id`) ON DELETE CASCADE, 
  FOREIGN KEY (`destination_winerie`) REFERENCES wineries(`id`) ON DELETE CASCADE
) COMMENT='tabla de logs';


#insertando datos de prueba a la tabla winwries
INSERT INTO wineries (name, location) VALUES ("Bodega A","Chipre"), ("Bodega B","Cable"),("Bodega C","Centro");

#insertando datos de prueba a la tabla items
INSERT INTO items (name,description)
 VALUES ("dominos","Juego con piezas marcadas de numeros"),("naipe ingles"," juego de cartas con una baraja de 58 cartas"),
 ("naipe español","juego de cartas con una baraja de 48 cartas"),("UNO","juego de cartas de 158 cartas"),
 ("adivina quien","juego para niños de adivinar un personaje"),("serpientes y escaleras","juego infantil de mesa con interaccion de avanzar o retroceder");

 #insertando datos de prueba a la tabla inventory
INSERT INTO inventory (stock,winerie_id,item_id ) VALUES (40,1,2), (36,2,4),(57,3,4),
(21,1,3), (43,2,5),(76,3,1),
(29,1,4), (92,2,3),(74,3,6);


#consultas utilizadas info bodegas
select wineries.name as 'name_bodega',items.name as 'name_item',items.description,inventory.stock 
from wineries join inventory on wineries.id = inventory.winerie_id join items on items.id = inventory.item_id
where wineries.id = 1;

select id,name from wineries;

#consultas y sentencias utilizadas Tranferencia de articulos
select * from items join inventory on inventory.item_id = items.id where inventory.winerie_id = 3;

select stock from inventory where inventory.winerie_id = 1 and inventory.item_id = 6;

update inventory set inventory.stock = 23 WHERE inventory.winerie_id = 1 and inventory.item_id = 2;

INSERT INTO inventory (stock,winerie_id,item_id ) VALUES (40,1,2);

insert into log (origin_winerie,destination_winerie,item_id,amount) values (1,2,2,23);




