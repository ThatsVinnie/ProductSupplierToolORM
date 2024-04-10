create database product_supplier;

create table supplier(
	id INT AUTO_INCREMENT NOT NULL,
    _name VARCHAR(255) NOT NULL,
    cnpj VARCHAR(18) NOT NULL,
	email VARCHAR(255),
    primary key(id)
);

create table product(
	id INT AUTO_INCREMENT NOT NULL,
    _name VARCHAR(255) NOT NULL,
    descr VARCHAR(255),
    price DECIMAL(10,2) NOT NULL,
    quantity INT NOT NULL,
    id_supplier INT,
    primary key(id),
    foreign key(id_supplier) references supplier(id)
);