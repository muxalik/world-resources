CREATE DATABASE resources;

USE resources;

CREATE TABLE users
(
  id BIGINT IDENTITY PRIMARY KEY,
  login VARCHAR(255) NOT NULL,
  password VARCHAR(255) NOT NULL,
);

CREATE TABLE resources
(
  id BIGINT IDENTITY PRIMARY KEY,
  name VARCHAR(255),
  unit VARCHAR (255),
);

CREATE TABLE countries
(
  id BIGINT IDENTITY PRIMARY KEY,
  name VARCHAR(255),
);

CREATE TABLE country_resource
(
  country_id BIGINT,
  resource_id BIGINT,
  amount FLOAT(5),
  FOREIGN KEY (country_id) REFERENCES countries(id),
  FOREIGN KEY (resource_id) REFERENCES resources(id),
);

CREATE TABLE consumptions
(
  country_id BIGINT,
  resource_id BIGINT,
  amount FLOAT(5),
  period_start DATE,
  period_end DATE,
  FOREIGN KEY (country_id) REFERENCES countries(id),
  FOREIGN KEY (resource_id) REFERENCES resources(id),
);
