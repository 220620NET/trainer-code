create schema todoapp;

drop table todoapp.todos;

create table todoapp.todos(
	id int identity,
	description varchar(200) not null,
	is_complete bit default 0,
	primary key (id)
);

-- get all todos
select * from todoapp.todos;

-- creating a todo
insert into todoapp.todos (description) values ('do dishes');

-- deleting one todo
delete from todoapp.todos where id = 2;

