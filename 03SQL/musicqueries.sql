
/*
 * Any time you use a DQL statement, it is going to return a result set
 * 
 * What is a result set?
 * 		- a temporary table given back from a DQL statement
 * */

/*
 *  the * references all of the columns in the table
 * */
select name from music.artists;


/*
 * What is an alias?
 * 	nicknames you can give entities in your statement
 * 	
 * 	you can put aliases on column names and table names
 * */
select name as artist_names from music.artists;

select fluffybunny.name from music.artists as fluffybunny;


select * from music.songs;

-- the where keyword allows us to filter records in a table
select * from music.songs where album_fk = 2;

select * from music.songs where album_fk = 1 or album_fk = 2;

select * from music.songs where name = 'crawling' and album_fk = 1;


select * from music.songs where album_fk = 1 or album_fk = 2 or album_fk = 3 or album_fk = 4;

--you can acheive the same thing as the statement above using the in keyword
select * from music.songs where album_fk in (1,2,3,4);

select * from music.songs where album_fk between 1 and 4;

select * from music.songs where album_fk > 0 and album_fk < 5;
select * from music.songs where album_fk < 5;

-- not equal
select * from music.songs where name != 'Papercut';
select * from music.songs where name <> 'Papercut';
select * from music.songs where not name = 'Papercut';


-- null references
select * from music.songs where name is null;


--Like keyword finds patterns in columns
/*
 * % wildcard is a standin for 0 or more characters
 * 
 * _ one character
 * */

select * from music.songs;

select * from music.songs where name like 'B%';


-- sorting records we can use the order by keyword
select * from music.songs order by name desc;

-- sorting by descending order of albumfk THEN sorting by the name in ascending order
select * from music.songs order by album_fk desc, name asc;





/*
 * aggregate functions
 * 		- aggregate functions do a calculation on a grouping of records producing one result
 * 
 * 
 * count()
 * */


select count(*) as song_count from music.songs; -- count prints the amount of records to achieve 1 result

select * from music.songs;

select sum(album_fk) as album_fk_sum from music.songs;

select max(album_fk) as largest_num_in_albumfk_column from music.songs;

select min(album_fk) as smallest_num_in_albumfk_column from music.songs;




/*
 * group by
 * 		allows aggregate functions to work on smaller pockets of records
 * 
 * difference between where and having?
 * 		- where filters on the original result set (before group by and the aggregate function)
 * 		- having filters after the new result set has been generated (after group by and the aggregate function)
 * */

select album_fk, count(album_fk) as song_count from music.songs group by album_fk having count(album_fk) > 11;



/*
 * scalar functions
 * 		- manipulate the data in one specific record
 * */

select 'Hello World';

--numbers
select abs(-99); -- absolute value
select floor(88.77); -- rounds down
select ceiling(88.77); -- rounds up
select round(88.77,0); -- rounds to the nearest whole number

--characters
select upper('HeLlO WoRlD'); -- converts the string to uppercase
select lower('HeLlO WoRlD'); -- converts the string to lowercase
select len('HeLlO WoRlD'); -- counts the length of the string


select name, len(name) from music.songs;


/*
 * What is a join?
 * 	joins are a way of combining 2 or more tables given a common column
 * 
 * 	inner join: displays only records that the common column has in common
 * 	outer join: display all values from both tables. 
 * 				If the other table doesnt have a correlated value, it will display null
 *	left join: displays all records from left table and matches all correlated records to the right table. 
 *					there is null values if there isnt a correlation
 *	right join: displays all records from right table and matches all correlated records to the left table. 
 *					there is null values if there isnt a correlation
 * 
 * */

select * from music.songs;




select * from music.songs as s 
inner join music.albums as a on s.album_fk = a.id;


--inner join music.artists as ar on a.artist_fk = ar.id;


/*
 * sets can combine the rows of 2 tables together in the same columns
 * 
 * Requirement:
 * 	- you need the same amount of columns
 * 	- the columns have to be the same datatype
 * 
 * Types of sets:
 * 	- union: combines all from both tables 
 * 	- intersect: only displays records that they both have the same values for
 * 	- except: displays everything from the first table and removes records that they both have the same values for
 * */

select * from music.playlists
union
select * from music.artists;

select * from music.playlists
intersect
select * from music.artists;

select * from music.playlists
except
select * from music.artists;


