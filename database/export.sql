--------------------------------------------------------
--  File created - Tuesday-December-25-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table PROFILE
--------------------------------------------------------

  CREATE TABLE "EMP"."PROFILE" 
   (	"ID" NUMBER(38,0), 
	"NAME" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table QUYEN
--------------------------------------------------------

  CREATE TABLE "EMP"."QUYEN" 
   (	"ID" NUMBER(38,0), 
	"NAME" VARCHAR2(40 BYTE), 
	"TYPE" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table ROLE
--------------------------------------------------------

  CREATE TABLE "EMP"."ROLE" 
   (	"ID" NUMBER(38,0), 
	"NAME" VARCHAR2(40 BYTE), 
	"PASSWORD" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table TBS
--------------------------------------------------------

  CREATE TABLE "EMP"."TBS" 
   (	"ID" NUMBER, 
	"NAME" VARCHAR2(40 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table TEMP_TBS
--------------------------------------------------------

  CREATE TABLE "EMP"."TEMP_TBS" 
   (	"ID" NUMBER(38,0), 
	"NAME" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table USERS
--------------------------------------------------------

  CREATE TABLE "EMP"."USERS" 
   (	"ID" NUMBER(*,0), 
	"USERNAME" VARCHAR2(20 BYTE), 
	"PASS" VARCHAR2(40 BYTE), 
	"NAME" VARCHAR2(30 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Sequence PROFILE_ID
--------------------------------------------------------

   CREATE SEQUENCE  "EMP"."PROFILE_ID"  MINVALUE 1 MAXVALUE 10000 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
--------------------------------------------------------
--  DDL for Sequence ROLE_ID
--------------------------------------------------------

   CREATE SEQUENCE  "EMP"."ROLE_ID"  MINVALUE 1 MAXVALUE 10000 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
--------------------------------------------------------
--  DDL for Sequence USER_ID
--------------------------------------------------------

   CREATE SEQUENCE  "EMP"."USER_ID"  MINVALUE 1 MAXVALUE 10000 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE  GLOBAL ;
REM INSERTING into EMP.PROFILE
SET DEFINE OFF;
Insert into EMP.PROFILE (ID,NAME) values (4,'proflie');
REM INSERTING into EMP.QUYEN
SET DEFINE OFF;
Insert into EMP.QUYEN (ID,NAME,TYPE) values (1,'CREATE PROFILE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (2,'ALTER PROFILE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (3,'DROP PROFILE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (4,'CREATE ROLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (5,'ALTER ANY ROLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (6,'DROP ANY ROLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (7,'GRANT ANY ROLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (8,'CREATE SESSION','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (9,'CREATE ANY TABLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (11,'DROP ANY TABLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (10,'ALTER ANY TABLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (12,'SELECT ANY TABLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (13,'DELETE ANY TABLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (14,'INSERT ANY TABLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (15,'UPDATE ANY TABLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (16,'CREATE TABLE','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (17,'CREATE USER','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (18,'ALTER USER','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (19,'DROP USER','1');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (20,'SELECT','2');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (21,'INSERT','2');
Insert into EMP.QUYEN (ID,NAME,TYPE) values (22,'DELETE','2');
REM INSERTING into EMP.ROLE
SET DEFINE OFF;
Insert into EMP.ROLE (ID,NAME,PASSWORD) values (9,'role1','-1');
REM INSERTING into EMP.TBS
SET DEFINE OFF;
Insert into EMP.TBS (ID,NAME) values (1,'tbs_01');
Insert into EMP.TBS (ID,NAME) values (2,'tbs_02');
Insert into EMP.TBS (ID,NAME) values (3,'tbs_03');
Insert into EMP.TBS (ID,NAME) values (4,'tbs_04');
REM INSERTING into EMP.TEMP_TBS
SET DEFINE OFF;
REM INSERTING into EMP.USERS
SET DEFINE OFF;
Insert into EMP.USERS (ID,USERNAME,PASS,NAME) values (14,'hoangquan','f1e213a96d7281736ada3ca044278b694830d93f','hoangquan');
Insert into EMP.USERS (ID,USERNAME,PASS,NAME) values (16,'minh263','5a15f1be70cfb530c95bda5e0e87017a7ae43dbe','minh263');
Insert into EMP.USERS (ID,USERNAME,PASS,NAME) values (15,'hoangquan1','cb85f29d9ecc9b6524b00a0d184e0c1c28bc2aff','hoangquan1');
--------------------------------------------------------
--  DDL for Index ROLE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "EMP"."ROLE_PK" ON "EMP"."ROLE" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index QUYEN_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "EMP"."QUYEN_PK" ON "EMP"."QUYEN" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index TEMP_TBS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "EMP"."TEMP_TBS_PK" ON "EMP"."TEMP_TBS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index USERS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "EMP"."USERS_PK" ON "EMP"."USERS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PROFILE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "EMP"."PROFILE_PK" ON "EMP"."PROFILE" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index TBS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "EMP"."TBS_PK" ON "EMP"."TBS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Procedure PROFILE_CREATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."PROFILE_CREATE" (pname varchar2,
pses varchar2,
pconect varchar2,
pidle varchar2)
is
setsession varchar2(200):='';
setconecttime varchar2(200):='';
setidletime varchar2(200):='';
begin
if(pses='DEFAULT') then
  setsession:=' SESSIONS_PER_USER DEFAULT';
  elsif(pses='UNLIMITED') then
    setsession:=' SESSIONS_PER_USER UNLIMITED';
    else 
      setsession:=' SESSIONS_PER_USER '||pses;
end if;
if(pconect='DEFAULT') then
  setconecttime:=' connect_time DEFAULT';
  elsif(pconect='UNLIMITED') then
    setconecttime:=' connect_time UNLIMITED';
    else 
     setconecttime:=' connect_time '||pconect;
  end if;
if(pidle='DEFAULT') then
  setidletime:=' idle_time DEFAULT';
  elsif(pidle='UNLIMITED') then
    setidletime:=' idle_time UNLIMITED';
    else 
     setidletime:=' idle_time '||pidle;
end if;
  execute immediate 'CREATE PROFILE '||pname||' LIMIT'||setsession||setconecttime||setidletime;
end;

/
--------------------------------------------------------
--  DDL for Procedure PROFILE_DELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."PROFILE_DELETE" (pname varchar2)
is
begin
  delete from PROFILE where NAME = pname;
  execute immediate 'DROP PROFILE '||pname||' CASCADE';
end;

/
--------------------------------------------------------
--  DDL for Procedure PROFILE_INSERT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."PROFILE_INSERT" (pname varchar2)
is
begin
insert into profile values(profile_id.nextval,pname);
end;

/
--------------------------------------------------------
--  DDL for Procedure PROFILE_UPDATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."PROFILE_UPDATE" (pname varchar2,
pses varchar2,
pconect varchar2,
pidle varchar2)
is
setsession varchar2(200):='';
setconecttime varchar2(200):='';
setidletime varchar2(200):='';
begin
if(pses='DEFAULT') then
  setsession:=' SESSIONS_PER_USER DEFAULT';
  elsif(pses='UNLIMITED') then
    setsession:=' SESSIONS_PER_USER UNLIMITED';
    else 
      setsession:=' SESSIONS_PER_USER '||pses;
end if;
if(pconect='DEFAULT') then
  setconecttime:=' connect_time DEFAULT';
  elsif(pconect='UNLIMITED') then
    setconecttime:=' connect_time UNLIMITED';
    else 
     setconecttime:=' connect_time '||pconect;
  end if;
if(pidle='DEFAULT') then
  setidletime:=' idle_time DEFAULT';
  elsif(pidle='UNLIMITED') then
    setidletime:=' idle_time UNLIMITED';
    else 
     setidletime:=' idle_time '||pidle;
end if;
  execute immediate 'ALTER PROFILE '||pname||' LIMIT'||setsession||setconecttime||setidletime;
end;

/
--------------------------------------------------------
--  DDL for Procedure QUYENHETHONG_ROLE_USER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."QUYENHETHONG_ROLE_USER" (pname varchar2,prole_user varchar2,pgrant varchar2)
is
begin
IF(pgrant='-1') then
  execute immediate 'grant '||pname||' to '||prole_user;
  else 
     execute immediate 'grant '||pname||' to '||prole_user||' WITH ADMIN OPTION';
     end if;
end;

/
--------------------------------------------------------
--  DDL for Procedure QUYENOBJECTCOL_USER_ROLE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."QUYENOBJECTCOL_USER_ROLE" (pname varchar2,pobject varchar2,prole_user varchar2,colname varchar2)
is
begin
  execute immediate 'grant '||pname||' ('||colname||') ON '||pobject||' to '||prole_user;
end;

/
--------------------------------------------------------
--  DDL for Procedure QUYENOBJECT_USER_ROLE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."QUYENOBJECT_USER_ROLE" (pname varchar2,pobject varchar2,prole_user varchar2,pgrant varchar2)
is
begin
if(pgrant='-1') then
  execute immediate 'GRANT '||pname||' ON '||pobject||' TO '||prole_user;
  else 
     execute immediate 'GRANT '||pname||' ON '||pobject||' TO '||prole_user||' WITH GRANT OPTION';
    end if;
end;

/
--------------------------------------------------------
--  DDL for Procedure REQUYENHETHONG_ROLE_USER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."REQUYENHETHONG_ROLE_USER" (pname varchar2,prole_user varchar2)
is
begin
  execute immediate 'revoke '||pname||' from '||prole_user;
end;

/
--------------------------------------------------------
--  DDL for Procedure REQUYENOBJECTCOL_USER_ROLE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."REQUYENOBJECTCOL_USER_ROLE" (pname varchar2,pobject varchar2,prole_user varchar2,colname varchar2)
is
begin
  execute immediate 'revoke '||pname||' ('||colname||') ON '||pobject||' from '||prole_user;
end;

/
--------------------------------------------------------
--  DDL for Procedure REQUYENOBJECT_ALL
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."REQUYENOBJECT_ALL" (pname varchar2,pobject varchar2)
is
begin
execute immediate 'revoke all on '||pobject ||' from '||pname;
end;

/
--------------------------------------------------------
--  DDL for Procedure REQUYENOBJECT_USER_ROLE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."REQUYENOBJECT_USER_ROLE" (pname varchar2,pobject varchar2,prole_user varchar2)
is
begin
  execute immediate 'revoke '||pname||' ON '||pobject||' from '||prole_user;
end;

/
--------------------------------------------------------
--  DDL for Procedure ROLE_CHANGEPASS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."ROLE_CHANGEPASS" (pname varchar2,ppass varchar2)
is
begin
update ROLE set PASSWORD=ppass where name = pname;
execute immediate 'alter role '||pname||' IDENTIFIED BY '||ppass;
end;

/
--------------------------------------------------------
--  DDL for Procedure ROLE_CREATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."ROLE_CREATE" (pname varchar2,ppass varchar2)
is
stmquery varchar2(200):='';
begin
if(ppass='-1') then
stmquery:='create role '||pname;
else 
stmquery:='create role '||pname||' IDENTIFIED BY '||ppass;
end if;
execute immediate ''||stmquery;
end;

/
--------------------------------------------------------
--  DDL for Procedure ROLE_DELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."ROLE_DELETE" (pname varchar2)
is
begin
delete from role where name=pname;
execute immediate 'drop role '||pname;
end;

/
--------------------------------------------------------
--  DDL for Procedure ROLE_INSERT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."ROLE_INSERT" (pname varchar2, ppass varchar2)
is
begin
insert into role values(role_id.nextval,pname,ppass);
end;

/
--------------------------------------------------------
--  DDL for Procedure USER_DEFAULT_TAB
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."USER_DEFAULT_TAB" (pusername varchar2,ptab varchar2)
is
begin
execute immediate 'alter user '||pusername||' DEFAULT TABLESPACE '||ptab;
end;

/
--------------------------------------------------------
--  DDL for Procedure USER_DELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."USER_DELETE" (pname varchar2)
is
begin
delete from USERS where username=pname;
execute immediate 'drop user '||pname;
end;

/
--------------------------------------------------------
--  DDL for Procedure USER_INSERT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."USER_INSERT" (pusername varchar2,ppass varchar2,pname varchar2)
is
begin
execute immediate 'create user '||pusername||' identified by '||ppass;
insert into users values(user_id.nextval,pusername,convert_sha1(ppass),pname);
end;

/
--------------------------------------------------------
--  DDL for Procedure USER_PROFILE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."USER_PROFILE" (pusername varchar2,pprofile varchar2)
is
begin
execute immediate 'alter user '||pusername||'  PROFILE '||pprofile ;
end;

/
--------------------------------------------------------
--  DDL for Procedure USER_QUOTA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."USER_QUOTA" (pusername varchar2,ptab varchar2,psize varchar2)
is
begin
execute immediate 'alter user '||pusername||' quota '||psize||'M on '||ptab;
end;

/
--------------------------------------------------------
--  DDL for Procedure USER_STATUS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."USER_STATUS" (puername varchar2,ppstatus varchar2)
is
begin
execute immediate 'alter user '||puername||' account '||ppstatus;
end;

/
--------------------------------------------------------
--  DDL for Procedure USER_TEMPORARY_TAB
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."USER_TEMPORARY_TAB" (pusername varchar2,ptab varchar2)
is
begin
execute immediate 'alter user '||pusername||' TEMPORARY TABLESPACE '||ptab;
end;

/
--------------------------------------------------------
--  DDL for Procedure USER_UPDATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."USER_UPDATE" (pusername varchar2,ppass varchar2,pname varchar2)
is
begin
execute immediate 'alter user '||pusername||' identified by '||ppass;
update users set name=pname,pass=convert_sha1(ppass) where username=pusername;
end;

/
--------------------------------------------------------
--  DDL for Procedure WELCOME_MSG
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "EMP"."WELCOME_MSG" (p_name IN VARCHAR2) 
IS
BEGIN
dbms_output.put_line('Welcome'|| p_name);
END;

/
--------------------------------------------------------
--  DDL for Function CHECK_LOGIN
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE FUNCTION "EMP"."CHECK_LOGIN" (pusername varchar2,ppass varchar2)
return int
is
  isid int:=0;
begin
  select count(id) into isid from users where username=pusername and pass=convert_sha1(ppass);
  if(isid=1)then return 1;
  end if;
  return 0;
end;

/
--------------------------------------------------------
--  DDL for Function CHECK_USER_LOCKED
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE FUNCTION "EMP"."CHECK_USER_LOCKED" (pusername varchar2)
return int
is
status varchar2(40):='';
begin
select account_status into status from dba_users where username=upper(pusername);
if(status='OPEN')then
return 0;
end if;
return 1;
end;

/
--------------------------------------------------------
--  DDL for Function CONVERT_SHA1
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE FUNCTION "EMP"."CONVERT_SHA1" (p_pass varchar2)
return varchar2
is
  p_string varchar2(20) :=p_pass;
  lv_hash_value_sh1    raw (100);
  lv_varchar_key_sh1   varchar2 (40);
begin
  lv_hash_value_sh1 :=
     dbms_crypto.hash (src   => utl_raw.cast_to_raw (p_string),
                       typ   => dbms_crypto.hash_sh1);

  -- convert into varchar2
  select   lower (to_char (rawtohex (lv_hash_value_sh1)))
    into   lv_varchar_key_sh1
    from   dual;

  --
  dbms_output.put_line('String to encrypt : '||p_string);
  dbms_output.put_line('SHA1 encryption : '||lv_varchar_key_sh1);
  return lv_varchar_key_sh1;
end;

/
--------------------------------------------------------
--  DDL for Function GET_EMPLOYEE
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE FUNCTION "EMP"."GET_EMPLOYEE" 
  (pusername varchar2)
  return sys_refcursor
as  
  l_rc sys_refcursor;
begin
  open l_rc
   for select account_status,
      default_tablespace,
      temporary_tablespace,
      profile 
      from DBA_USERS
      where username='EMP';
  return l_rc; 
end;

/
--------------------------------------------------------
--  DDL for Function ONLY_PERSON_INDEP
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE FUNCTION "EMP"."ONLY_PERSON_INDEP" ( 
p_schema  IN  VARCHAR2 DEFAULT NULL, p_object  IN  VARCHAR2 DEFAULT NULL) 
RETURN VARCHAR2 
AS total int;
BEGIN 
select count(mapb) into total from nhanvien where rownum=1;
RETURN 'mapb !='||total; 
END;

/
--------------------------------------------------------
--  Constraints for Table ROLE
--------------------------------------------------------

  ALTER TABLE "EMP"."ROLE" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "EMP"."ROLE" ADD CONSTRAINT "ROLE_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table PROFILE
--------------------------------------------------------

  ALTER TABLE "EMP"."PROFILE" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "EMP"."PROFILE" ADD CONSTRAINT "PROFILE_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table USERS
--------------------------------------------------------

  ALTER TABLE "EMP"."USERS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "EMP"."USERS" ADD CONSTRAINT "USERS_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table TEMP_TBS
--------------------------------------------------------

  ALTER TABLE "EMP"."TEMP_TBS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "EMP"."TEMP_TBS" ADD CONSTRAINT "TEMP_TBS_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table TBS
--------------------------------------------------------

  ALTER TABLE "EMP"."TBS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "EMP"."TBS" ADD CONSTRAINT "TBS_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table QUYEN
--------------------------------------------------------

  ALTER TABLE "EMP"."QUYEN" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "EMP"."QUYEN" ADD CONSTRAINT "QUYEN_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
