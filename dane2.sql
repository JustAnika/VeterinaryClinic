-- Stworzenie i usuniecie bazy danych --
--CREATE DATABASE Przychodnia
--USE Przychodnia
--DROP DATABASE Przychodnia
-- Stworzenie tabeli --
-- Logowanie --
GO
CREATE TABLE Logowanie
(Id_logowania CHAR(1),
Login_uzytkownika VARCHAR(100) PRIMARY KEY NOT NULL,
Haslo VARCHAR(100) NOT NULL)

-- Pacjent --
GO
CREATE TABLE Pacjent
(Id_zwierzecia INT IDENTITY PRIMARY KEY NOT NULL,
Imie_zwierzecia VARCHAR(100) NOT NULL,
Gatunek VARCHAR (40) NOT NULL,
Plec CHAR(1) NOT NULL,
Wiek INT NULL,
Opis VARCHAR(8000) NULL,
Imie VARCHAR(100) NOT NULL,
Nazwisko VARCHAR(100) NOT NULL,
Telefon DECIMAL NOT NULL)

-- Pracownik --
GO
CREATE TABLE Pracownik
(Id_pracownika VARCHAR(100) PRIMARY KEY NOT NULL,
Imie VARCHAR(100) NOT NULL,
Nazwisko VARCHAR(100) NOT NULL)

-- Badanie --
GO
CREATE TABLE Badanie
(Id_badania INT IDENTITY PRIMARY KEY NOT NULL,
Id_zwierzecia INT FOREIGN KEY (Id_zwierzecia) REFERENCES Pacjent ON DELETE CASCADE NOT NULL,
Id_pracownika VARCHAR(100) FOREIGN KEY (Id_pracownika) REFERENCES Pracownik ON DELETE CASCADE NOT NULL,
Data_badania DATETIME NOT NULL)

-- Wizyta --
GO
CREATE TABLE Wizyta
(Id_wizyty INT IDENTITY PRIMARY KEY NOT NULL,
Id_zwierzecia INT FOREIGN KEY (Id_zwierzecia) REFERENCES Pacjent ON DELETE CASCADE NOT NULL,
Id_pracownika VARCHAR(100) FOREIGN KEY (Id_pracownika) REFERENCES Pracownik ON DELETE CASCADE NOT NULL,
Data_wizyty DATETIME NOT NULL,
Id_pracowni INT NULL,
Lek VARCHAR(100) NULL,
Opis VARCHAR(8000) NULL)

-- Pracownia --
GO
CREATE TABLE Pracownia
(Id_pracowni INT IDENTITY PRIMARY KEY NOT NULL,
Nazwa VARCHAR(100) NOT NULL,
Id_wizyty INT FOREIGN KEY (Id_wizyty) REFERENCES Wizyta ON DELETE CASCADE NOT NULL,
Id_badania INT FOREIGN KEY (Id_badania) REFERENCES Badanie ON DELETE NO ACTION NOT NULL)

-- Dodatkowe obostrzenia --
-- Logowanie --
GO
ALTER TABLE Logowanie
ADD CONSTRAINT CK_Id
CHECK(Id_logowania LIKE 'V' OR Id_logowania LIKE 'T' OR Id_logowania LIKE 'P')

-- Pacjent --
GO
ALTER TABLE Pacjent
ADD CONSTRAINT CK_Plec
CHECK(Plec LIKE 'K' OR Plec LIKE 'M' OR Plec LIKE 'N')

GO
ALTER TABLE Pacjent
ADD CONSTRAINT CK_Telefon
CHECK(Telefon LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

-- Pracownik --
GO
ALTER TABLE Pracownik
ADD FOREIGN KEY (Id_pracownika)
REFERENCES Logowanie(Login_uzytkownika) 

-- Przykladowe dane --
GO
INSERT INTO	Logowanie
VALUES ('V', 'jankowalski', 'wete')

INSERT INTO	Logowanie
VALUES ('T', 'adanowak', 'tech')

INSERT INTO	Logowanie
VALUES ('P', 'monkaminska', 'piel')

SELECT * FROM Logowanie;