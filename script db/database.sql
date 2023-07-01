Drop table if exists logs;
create table if not exists logs (
	id bigserial primary key,
	creation_date timestamp,
	type varchar(10),
	message text
);
select * from logs;

select * from logs where type = 'error' order by creation_date desc;