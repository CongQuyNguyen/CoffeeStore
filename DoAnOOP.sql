-- Thêm item vào bảng Coffee
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Mint Soda', 50, 25000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Kiwi Soda', 50, 30000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Strawberry Soda', 50, 30000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Orange Soda', 50, 30000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Mulberry Soda', 50, 30000);

INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Black Coffee', 50, 18000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Milk Coffee', 50, 20000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Filtered coffee', 50, 25000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Faint silver', 50, 25000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Cacao', 50, 25000);

INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Carrot Juice', 50, 35000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Saboche Juice', 50, 35000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Pineapple Juice', 50, 35000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Orange Juice', 50, 35000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Lemon Juice', 50, 35000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Apple Juice', 50, 35000);

INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Blueberry Smoothie', 50, 40000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Kiwi Smoothie', 50, 40000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Strawberry Smoothie', 50, 40000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Mulberry Smoothie', 50, 40000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Mango Smoothie', 50, 40000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Apple Smoothie', 50, 40000);

INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Lipton Lemon Tea', 50, 25000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Jasmine Tea', 50, 25000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Strawberry Tea', 50, 25000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Peach Tea', 50, 25000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Lychee Tea', 50, 25000);
INSERT INTO dbo.Coffee (Name, Quantity, Price) VALUES ('Apple Tea', 50, 25000);

-- Thêm thông tin nhân viên vào bảng Barista
INSERT INTO dbo.Barista (Phone, Email, Name, Address, Birthday) VALUES ('+84976870127', 'br01@gmail.com', 'Duc Sang Nguyen', 'Tp Ho Chi Minh', '2004-07-27');
INSERT INTO dbo.Barista (Phone, Email, Name, Address, Birthday) VALUES ('+84913451663', 'br02@gmail.com', 'Truong Son Le', 'Tp Can Tho', '2003-12-20');
INSERT INTO dbo.Barista (Phone, Email, Name, Address, Birthday) VALUES ('+84954153853', 'br03@gmail.com', 'Duy Phong Nguyen', 'Da Nang', '2004-05-11');
INSERT INTO dbo.Barista (Phone, Email, Name, Address, Birthday) VALUES ('+84915114613', 'br04@gmail.com', 'Tien Anh Nguyen', 'Tp Hue', '2004-11-15');

-- Kiểm tra các thông tin món uống
SELECT * FROM dbo.Coffee;

-- Kiểm tra thông tin nhân viên
SELECT * FROM dbo.Barista;
