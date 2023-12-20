-- RESOURCES --

INSERT INTO resources
  (name, unit)
VALUES
  ('Нефть', 'Баррель'),
  ('Газ', '1000 кубических футов'),
  ('Уголь', 'Тонна'),
  ('Железная руда', 'Тонна'),
  ('Медь', 'Тонна'),
  ('Алюминий', 'Тонна'),
  ('Золото', 'Унция'),
  ('Серебро', 'Унция'),
  ('Платина', 'Унция'),
  ('Пшеница', 'Тонна'),
  ('Кукуруза', 'Тонна'),
  ('Рис', 'Тонна'),
  ('Сахар', 'Тонна'),
  ('Хлопок', 'Фунт'),
  ('Кофе', 'Фунт'),
  ('Какао', 'Тонна'),
  ('Олово', 'Тонна'),
  ('Цинк', 'Тонна'),
  ('Никель', 'Тонна'),
  ('Алмазы', 'Карат');


-- COUNTRIES --

INSERT INTO countries
  (name)
VALUES
  ('Соединенные Штаты Америки'),
  ('Китай'),
  ('Индия'),
  ('Бразилия'),
  ('Пакистан'),
  ('Нигерия'),
  ('Бангладеш'),
  ('Россия'),
  ('Мексика'),
  ('Япония'),
  ('Эфиопия'),
  ('Филиппины'),
  ('Египет'),
  ('Вьетнам'),
  ('Демократическая Республика Конго'),
  ('Турция'),
  ('Иран'),
  ('Германия'),
  ('Таиланд'),
  ('Соединенное Королевство');


-- COUTNRY_RESOURCE --

DECLARE @countryId INT
DECLARE @resourceId INT
DECLARE @amount FLOAT

DECLARE @counter INT
SET @counter = 1

WHILE @counter <= 50
BEGIN
  SET @countryId = (SELECT TOP 1
    id
  FROM countries
  ORDER BY NEWID())
  SET @resourceId = (SELECT TOP 1
    id
  FROM resources
  ORDER BY NEWID())
  SET @amount = ROUND(RAND() * 1000 + 100, 1)
  -- Генерация случайной величины от 100 до 1100

  INSERT INTO country_resource
    (country_id, resource_id, amount)
  VALUES
    (@countryId, @resourceId, @amount)
  SET @counter = @counter + 1
END


-- CONSUMPTIONS --

DECLARE @periodStart DATE
DECLARE @periodEnd DATE

SET @counter = 1

WHILE @counter <= 50
BEGIN
  SET @countryId = (SELECT TOP 1
    id
  FROM countries
  ORDER BY NEWID())
  SET @resourceId = (SELECT TOP 1
    id
  FROM resources
  ORDER BY NEWID())
  SET @amount = RAND() * 1000
  -- Генерация случайной величины от 0 до 1000
  SET @periodStart = DATEADD(DAY, -RAND() * 365, GETDATE())
  -- Генерация случайной даты в течение последних 365 дней
  SET @periodEnd = DATEADD(DAY, RAND() * 365, @periodStart)
  -- Генерация случайного временного интервала

  INSERT INTO consumptions
    (country_id, resource_id, amount, period_start, period_end)
  VALUES
    (@countryId, @resourceId, @amount, @periodStart, @periodEnd)

  SET @counter = @counter + 1
END

-- USERS -- 
INSERT INTO users
  (login, password)
VALUES
  ('admin', 'secret-password')
