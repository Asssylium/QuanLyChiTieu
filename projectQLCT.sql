create database projectPRN211;
use projectPRN211;
CREATE TABLE Account (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(255),
    password VARCHAR(255),
    firstname VARCHAR(255),
    lastname VARCHAR(255),
    gender VARCHAR(10),
    mail VARCHAR(255)
);
CREATE TABLE ChiTieu (
    id INT PRIMARY KEY,
    userid INT,
    chude VARCHAR(255),
    money DECIMAL(18, 2),
    datetime DATETIME,
    noidung VARCHAR(255),
    group_nam VARCHAR(255),
    FOREIGN KEY (userid) REFERENCES Account(id)
);
INSERT INTO Account (id, username, password, firstname, lastname, gender, email)
VALUES
    (1, 'user', 'EhG9(7k7', 'Hanh', 'Nguyen', 'Male', 'hanhng125@gmail.com'),
    (2, 'admin', '123', 'Hanh', 'Nguyen', 'Male', 'hanhndhe170885@gmail.com'),
    (7, 'Minh', '12345', 'Hello', 'World', 'Female', 'hanhndhe170885@gmail.com');

INSERT INTO ChiTieu(id, userid, chude, money, datetime, noidung, group_name)
VALUES
    (1, 1, 'Food', -120000.00, '2023-07-03 00:00:00.000', 'Lunch', 'Chi tieu hang ngay'),
    (2, 1, 'Shopping', 12300.34, '2023-07-19 00:00:00.000', 'Clothes', 'Chi tieu an choi'),
    (3, 1, 'Entertainment', 250000.40, '2023-07-09 00:00:00.000', 'Movie ticket', 'Chi tieu an choi'),
    (4, 2, 'Transportation', -10999.00, '2023-07-24 00:00:00.000', 'Bus fare', 'Chi tieu hang ngay'),
    (5, 2, 'Groceries', 40000.00, '2023-07-19 00:00:00.000', 'Weekly shopping', 'Chi tieu hang ngay'),
    (6, 2, 'Food', -150000.00, '2023-07-25 00:00:00.000', 'Snacks', 'Chi tieu an choi'),
    (7, 1, 'Transportation', -160000.23, '2023-06-13 00:00:00.000', 'Taxi', 'Chi tieu hang ngay'),
    (8, 2, 'Food', 20000.00, '2023-07-19 19:30:00.000', 'Dinner', 'Chi tieu hang ngay'),
    (9, 1, 'Shopping', 14400.00, '2023-05-15 00:00:00.000', 'Electronics', 'Chi tieu hang ngay'),
    (10, 2, 'Entertainment', 120000.00, '2023-07-17 00:00:00.000', 'Concert tickets', 'Chi tieu an choi'),
    (12, 1, 'Running', -20000.00, '2023-07-20 04:04:34.427', 'Running', 'Chi tieu hang ngay'),
    (14, 7, 'Shopping', -5000.00, '2023-07-20 10:27:14.823', 'Game', 'Chi tieu an choi'),
    (15, 1, 'Entertainment', -2500.40, '2023-07-09 00:00:00.000', 'Movie ticket', 'Chi tieu an choi');