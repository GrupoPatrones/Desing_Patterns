--Se inicia Creando el usuario, la operación se puede realizar a través de Script o 
--de la interfaz de sql Developer, sobre una conexión con permisos para crear usuarios

-- USER SQL
CREATE USER "FALABELLA"
DEFAULT TABLESPACE "USERS"
TEMPORARY TABLESPACE "TEMP"
ACCOUNT UNLOCK ;

-- QUOTAS
ALTER USER "FALABELLA" QUOTA UNLIMITED ON USERS;

-- ROLES
ALTER USER "FALABELLA" DEFAULT ROLE "CONNECT","RESOURCE";

-- SYSTEM PRIVILEGES

GRANT CREATE SESSION TO "FALABELLA" WITH ADMIN OPTION

--Después de Crear el usuario, y de acuerdo a la documentación de ORACLE, se crear
--el Schema, a través de un script sobre la conexión que se cree usando el usuario
--que se acabó de crear

CREATE SCHEMA AUTHORIZATION "FALABELLA"
--Dentro del script Crear Schema se pueden poner los scripts de creación de los 
--objetos de la BD, y la asignación de permisos.

   CREATE TABLE "FALABELLA"."FAL_ARCHIVO" 
   (	"ARCHIVOID" NUMBER(6,0), 
	"ESTADOID" NUMBER(6,0) CONSTRAINT "CUST_ESTADOID_NN" NOT NULL ENABLE, 
	"FECHAGENERACION" DATE CONSTRAINT "CUST_FECHAGENERACION_NN" NOT NULL ENABLE, 
	"NOMBREARCHIVO" VARCHAR2(150 BYTE) CONSTRAINT "CUST_NOMBREARCHIVO_NN" NOT NULL ENABLE, 
	"RUTAARCHIVO" VARCHAR2(250 BYTE) CONSTRAINT "CUST_RUTAARCHIVO_NN" NOT NULL ENABLE, 
	"TIPOARCHIVOID" NUMBER(6,0) CONSTRAINT "CUST_TIPOARCHIVOID_NN" NOT NULL ENABLE, 
	"MODIFICADORARCHIVO" NUMBER(6,0) CONSTRAINT "CUST_MODIFICADORARCHIVO_NN" NOT NULL ENABLE, 
	 CONSTRAINT "PK_P_P1" PRIMARY KEY ("ARCHIVOID"))
	 
   GRANT ALL ON "FALABELLA"."FAL_ARCHIVO" TO "FALABELLA";
   
 --O simplemente se crea el Schema, y los objetos secrean a través de la interfaz 
 --gráfica de sql Developer.