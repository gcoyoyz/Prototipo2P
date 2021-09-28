create database siu;
use siu;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ingalumnos` (IN `carnet_alumno` VARCHAR(15), IN `nombre_alumno` VARCHAR(45), IN `direccion_alumno` VARCHAR(45), IN `telefono_alumno` VARCHAR(45) , IN `email_alumno` VARCHAR(20), IN `estatus_alumno` VARCHAR(1))  BEGIN
	insert into alumnos (carnet_alumno, nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno) values (carnet_alumno, nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno);
END$$

DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultalumnos`()  BEGIN
    select carnet_alumno as carnet_alumno, nombre_alumno, direccion_alumno, telefono_alumno, email_alumno, estatus_alumno from alumnos; 
END$$

DELIMITER ;

CREATE TABLE alumnos
 (
  carnet_alumno VARCHAR(15),
  nombre_alumno VARCHAR(45),
  direccion_alumno VARCHAR(45),
  telefono_alumno VARCHAR(45),
  email_alumno VARCHAR(20),
  estatus_alumno VARCHAR(1),
  PRIMARY KEY (carnet_alumno)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ingcursos` (IN `codigo_curso` VARCHAR(5), IN `nombre_curso` VARCHAR(45), IN `estatus_curso` VARCHAR(1))  BEGIN
	insert into alumnos (carnet_curso, nombre_curso, estatus_curso) values (carnet_curso, nombre_curso, estatus_curso);
END$$

DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultacursos`()  BEGIN
    select codigo_curso as ID, nombre_curso, estatus_curso from cursos; 
END$$

DELIMITER ;

CREATE TABLE cursos
(
  codigo_curso VARCHAR(5),
  nombre_curso VARCHAR(45),
  estatus_curso VARCHAR(1),
  PRIMARY KEY (codigo_curso)
 ) ENGINE = InnoDB DEFAULT CHARSET=latin1;
 
 CREATE TABLE facultades
(
  codigo_facultad VARCHAR(5),
  nombre_facultad VARCHAR(45),
  estatus_facultad VARCHAR(1),
  PRIMARY KEY (codigo_facultad)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE carreras
(
  codigo_carrera VARCHAR(5),
  nombre_carrera VARCHAR(45),
  codigo_facultad VARCHAR(5),
  estatus_carrera VARCHAR(1),
  PRIMARY KEY (codigo_carrera),
  FOREIGN KEY (codigo_facultad) REFERENCES facultades(codigo_facultad)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE asignacioncursosalumnos
(
  codigo_carrera VARCHAR(5),
  codigo_curso VARCHAR(5),
  carnet_alumno VARCHAR(15),
  nota_asignacioncursoalumnos FLOAT(10,2), 
  PRIMARY KEY (codigo_carrera, codigo_curso, carnet_alumno),
  FOREIGN KEY (codigo_carrera) REFERENCES carreras(codigo_carrera),
  FOREIGN KEY (codigo_curso) REFERENCES cursos(codigo_curso),
  FOREIGN KEY (carnet_alumno) REFERENCES alumnos(carnet_alumno)
  ) ENGINE = InnoDB DEFAULT CHARSET=latin1;