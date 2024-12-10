CREATE DATABASE library;
USE library;
CREATE TABLE anime (
    id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(50)
);


ALTER TABLE anime ADD COLUMN year INT;

INSERT INTO anime (title, year) VALUES 
('Attack on Titan', 2013),
('Death Note', 2006),
('Naruto', 2002),
('Demon Slayer: Kimetsu no Yaiba', 2019),
('Spirited Away (Sen to Chihiro no Kamikakushi)', 2001);

SELECT * FROM anime;

CREATE PROCEDURE get_odd_year_anime()
SELECT * FROM anime WHERE year % 2 != 0;

CALL get_odd_year_anime();