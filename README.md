# inventario-POO

Restaurar los paquetes de NuGet sugeridos:
  -FontAwesome.Sharp
  -MySql.Data


La base de datos usada es MySql: 

  CREATE DATABASE logins
  USE logins
  
  CREATE TABLE users (
  id int primary key auto_increment NOT NULL,
  user VARCHAR(45) NOT NULL,
  pass VARCHAR(45) NOT NULL,
  correo VARCHAR(45) NOT NULL
  )

  CREATE TABLE product (
  id_pro int primary key NOT NULL,
  producto varchar(45) NOT NULL,
  cantidad int NOT NULL,
  precio int NOT NULL
  )

CREATE TABLE compras (
  id_compra INT PRIMARY KEY AUTO_INCREMENT,
  id_pro INT NOT NULL,
  producto VARCHAR(45) NOT NULL,
  cantidad INT NOT NULL,
  precio INT NOT NULL,
  FOREIGN KEY (id_pro) REFERENCES product(id_pro)
)
