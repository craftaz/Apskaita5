CREATE DATABASE IF NOT EXISTS **Pav CHARACTER SET cp1257;<|>
USE **Pav;<|>
CREATE TABLE IF NOT EXISTS **Pav.roles
(
ID INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
UserID INT UNSIGNED NOT NULL,
DatabaseName CHAR(255) NOT NULL,
RoleName CHAR(255) NOT NULL,
RoleLevel INT UNSIGNED NOT NULL
)ENGINE=InnoDB DEFAULT CHARSET=cp1257;<|>
CREATE TABLE IF NOT EXISTS **Pav.users
(
ID INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
Name CHAR(100) NOT NULL,
RealName CHAR(255) NOT NULL,
Password VARCHAR(255) NOT NULL,
Signature LONGBLOB,
UserPosition CHAR(255) NOT NULL,
UserDetails CHAR(255) NOT NULL,
UserLevel INT UNSIGNED NOT NULL
)ENGINE=InnoDB DEFAULT CHARSET=cp1257;<|>
CREATE PROCEDURE **Pav.AccLogin()
BEGIN
DECLARE s INT;
DECLARE n CHAR(100);
SET s=(SELECT COUNT(u.Name) FROM users u);
IF s<1 THEN INSERT INTO users(Name, RealName, Password, UserPosition, UserDetails, UserLevel) VALUES('root','','','','',0); END IF;
IF s<1 THEN INSERT INTO roles(UserID, DatabaseName, RoleName, RoleLevel) VALUES(Last_Insert_ID(), '','Admin', 3); END IF;
SET s=(SELECT LOCATE('@', REPLACE(REPLACE(USER(), '\'', ''), '`', '')));
IF s>1 THEN SET n=(SELECT LOWER(SUBSTR(REPLACE(REPLACE(USER(), '\'', ''), '`', ''), 1,
LOCATE('@', REPLACE(REPLACE(USER(), '\'', ''), '`', ''))-1))); END IF;
IF s<2 THEN SET n=(SELECT REPLACE(REPLACE(USER(), '\'', ''), '`', '')); END IF;
SET s=(SELECT COUNT(u.Name) FROM users u WHERE INSTR(LOWER(USER()), CONCAT(LOWER(u.Name), '@'))=1);
IF s<1 THEN INSERT INTO users(Name, RealName, Password, UserPosition, UserDetails, UserLevel)
VALUES(n,'','','','', 0); END IF;
SELECT u.Name, (SELECT COUNT(r.ID) FROM roles r WHERE r.UserID=u.ID AND LOWER(TRIM(r.RoleName))='admin') AS IsAdmin, u.RealName
FROM users u WHERE INSTR(LOWER(USER()), CONCAT(LOWER(u.Name), '@'))=1;
END<|>
CREATE PROCEDURE **Pav.AccLoginDatabase(IN DbName CHAR(255))
BEGIN
DECLARE s INT;
DECLARE n CHAR(100);
SET s=(SELECT COUNT(u.Name) FROM users u);
IF s<1 THEN INSERT INTO users(Name, RealName, Password, UserPosition, UserDetails, UserLevel) VALUES('root','','','','',0); END IF;
IF s<1 THEN INSERT INTO roles(UserID, DatabaseName, RoleName, RoleLevel) VALUES(Last_Insert_ID(), '','Admin', 3); END IF;
SET s=(SELECT LOCATE('@', REPLACE(REPLACE(USER(), '\'', ''), '`', '')));
IF s>1 THEN SET n=(SELECT LOWER(SUBSTR(REPLACE(REPLACE(USER(), '\'', ''), '`', ''), 1,
LOCATE('@', REPLACE(REPLACE(USER(), '\'', ''), '`', ''))-1))); END IF;
IF s<2 THEN SET n=(SELECT REPLACE(REPLACE(USER(), '\'', ''), '`', '')); END IF;
SET s=(SELECT COUNT(u.Name) FROM users u WHERE INSTR(LOWER(USER()), CONCAT(LOWER(u.Name), '@'))=1);
IF s<1 THEN INSERT INTO users(Name, RealName, Password, UserPosition, UserDetails, UserLevel)
VALUES(n,'','','','',0); END IF;
SELECT r.RoleName, r.RoleLevel FROM roles r, users u WHERE r.UserID=u.ID
AND INSTR(LOWER(USER()), CONCAT(LOWER(u.Name), '@'))=1 AND (LOWER(TRIM(r.DatabaseName))=LOWER(TRIM(DbName)) OR LOWER(TRIM(r.RoleName))='admin');
END<|>
CREATE PROCEDURE **Pav.GetUserInfo()
BEGIN
SELECT u.RealName, u.UserPosition, u.UserDetails, u.Signature, u.UserLevel FROM users u WHERE INSTR(LOWER(USER()), CONCAT(LOWER(u.Name), '@'))=1;
END<|>
CREATE PROCEDURE **Pav.SetUserInfo(IN nRealName CHAR(255), nSignature LONGBLOB,
nUserPosition CHAR(255), nUserDetails CHAR(255), nUserLevel INT)
BEGIN
UPDATE users u SET u.RealName=nRealName, u.Signature=nSignature, u.UserPosition=nUserPosition,
u.UserDetails=nUserDetails, u.UserLevel=nUserLevel WHERE INSTR(LOWER(USER()), CONCAT(LOWER(u.Name), '@'))=1;
END<|>
CREATE PROCEDURE **Pav.AccLoginDatabaseInternal(IN DbName CHAR(255), cUserName CHAR(255), cPassword CHAR(255))
BEGIN
DECLARE s INT;
DECLARE n CHAR(100);
SET s=(SELECT COUNT(u.Name) FROM users u);
IF s<1 THEN INSERT INTO users(Name, RealName, Password, UserPosition, UserDetails, UserLevel) VALUES(cUserName,'',cPassword,'','',0); END IF;
IF s<1 THEN INSERT INTO roles(UserID, DatabaseName, RoleName, RoleLevel) VALUES(Last_Insert_ID(), '','Admin', 3); END IF;
SELECT r.RoleName, r.RoleLevel FROM roles r, users u WHERE r.UserID=u.ID
AND LOWER(TRIM(u.Name))=LOWER(TRIM(cUserName)) AND u.Password=cPassword AND (LOWER(TRIM(r.DatabaseName))=LOWER(TRIM(DbName)) OR LOWER(TRIM(r.RoleName))='admin');
END<|>
CREATE PROCEDURE **Pav.AccLoginInternal(IN cUserName CHAR(255), cPassword CHAR(255))
BEGIN
DECLARE s INT;
DECLARE n CHAR(100);
SET s=(SELECT COUNT(u.Name) FROM users u);
IF s<1 THEN INSERT INTO users(Name, RealName, Password, UserPosition, UserDetails, UserLevel)
VALUES(cUserName,'',cPassword,'','',0); END IF;
IF s<1 THEN INSERT INTO roles(UserID, DatabaseName, RoleName, RoleLevel) VALUES(Last_Insert_ID(), '','Admin', 3); END IF;
SELECT u.Name, (SELECT COUNT(r.ID) FROM roles r WHERE r.UserID=u.ID AND LOWER(TRIM(r.RoleName))='admin') AS IsAdmin, u.RealName
FROM users u WHERE LOWER(TRIM(u.Name))=LOWER(TRIM(cUserName)) AND u.Password=cPassword;
END<|>
CREATE PROCEDURE **Pav.SetUserInfoInternal(IN nRealName CHAR(255), nSignature LONGBLOB,
nUserPosition CHAR(255), nUserDetails CHAR(255), nUserLevel INT, cUserName CHAR(255), cPassword CHAR(255))
BEGIN
UPDATE users u SET u.RealName=nRealName, u.Signature=nSignature, u.UserPosition=nUserPosition,
u.UserDetails=nUserDetails, u.UserLevel=nUserLevel WHERE LOWER(TRIM(u.Name))=LOWER(TRIM(cUserName)) AND u.Password=cPassword;
END<|>
CREATE PROCEDURE **Pav.GetUserInfoInternal(IN cUserName CHAR(255), cPassword CHAR(255))
BEGIN
SELECT u.RealName, u.UserPosition, u.UserDetails, u.Signature, u.UserLevel FROM users u WHERE LOWER(TRIM(u.Name))=LOWER(TRIM(cUserName)) AND u.Password=cPassword;
END<|>
CREATE PROCEDURE **Pav.GetAccessibleDatabasesInternal
(IN cUserName CHAR(255), cPassword CHAR(255), cDatabaseNamingConvention CHAR(255))
BEGIN
DECLARE s INT;
SET @n=(SELECT CONCAT('SHOW DATABASES LIKE ''', cDatabaseNamingConvention, '%'''));
SET s=(SELECT COUNT(r.ID) FROM users u LEFT JOIN roles r ON r.UserID=u.ID
WHERE TRIM(LOWER(u.Name))=TRIM(LOWER(cUserName)) AND u.Password=cPassword
AND TRIM(LOWER(r.RoleName))=TRIM(LOWER('admin')));
IF s>0 THEN
PREPARE ps FROM @n;
EXECUTE ps;
END IF;
IF s<1 THEN
SELECT DISTINCT r.DatabaseName FROM roles r
LEFT JOIN users u ON u.ID=r.UserID
WHERE LOWER(TRIM(u.Name))=LOWER(TRIM(cUserName)) AND u.Password=cPassword;
END IF;
END