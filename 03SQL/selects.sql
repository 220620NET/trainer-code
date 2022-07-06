--drop schema music;
--drop table music.playlists_songs, music.playlists, music.songs, music.albums, music.artists;

create schema music;

create table music.artists(
	id int identity,
	name varchar(100) not null,
	primary key(id)
);

create table music.albums(
	id int identity,
	name varchar(100) not null,
	artist_fk int foreign key references music.artists(id) not null,
	primary key(id)
);

create table music.songs(
	id int identity,
	name varchar(100) not null,
	album_fk int foreign key references music.albums(id) not null,
	primary key(id)
);

create table music.playlists(
	id int identity,
	name varchar(100) not null,
	primary key(id)
);


create table music.playlists_songs(
	playlist_fk int foreign key references music.playlists(id) not null,
	song_fk int foreign key references music.songs(id) not null,
	primary key (playlist_fk, song_fk)
);


--artists
insert into music.artists (name) values ('Linkin Park');
insert into music.artists (name) values ('Cage The Elephant');
insert into music.artists (name) values ('Outkast');
insert into music.artists (name) values ('Paramore');

--albums

insert into music.albums (name, artist_fk) values ('Hybrid Theory', 1);
insert into music.albums (name, artist_fk) values ('Minutes To Midnight', 1);

insert into music.albums (name, artist_fk) values ('Melophobia', 2);
insert into music.albums (name, artist_fk) values ('Cage The Elephant', 2);

insert into music.albums (name, artist_fk) values ('ATLiens', 3);

insert into music.albums (name, artist_fk) values ('Riot!', 4);
insert into music.albums (name, artist_fk) values ('Brand New Eyes', 4);

-- songs

insert into music.songs (name, album_fk) values ('Papercut', 1);
insert into music.songs (name, album_fk) values ('One Step Closer', 1);
insert into music.songs (name, album_fk) values ('With You', 1);
insert into music.songs (name, album_fk) values ('Points of Authority', 1);
insert into music.songs (name, album_fk) values ('Crawling', 1);
insert into music.songs (name, album_fk) values ('Runaway', 1);
insert into music.songs (name, album_fk) values ('By Myself', 1);
insert into music.songs (name, album_fk) values ('In the End', 1);
insert into music.songs (name, album_fk) values ('A place for My Head', 1);
insert into music.songs (name, album_fk) values ('Forgotten', 1);
insert into music.songs (name, album_fk) values ('Cure for the Itch', 1);
insert into music.songs (name, album_fk) values ('Pushing Me Away', 1);
insert into music.songs (name, album_fk) values ('My December', 1);
insert into music.songs (name, album_fk) values ('High Voltage', 1);
insert into music.songs (name, album_fk) values ('Papercut Live', 1);

insert into music.songs (name, album_fk) values ('Wake', 2);
insert into music.songs (name, album_fk) values ('Given Up', 2);
insert into music.songs (name, album_fk) values ('Leave Out All The Rest', 2);
insert into music.songs (name, album_fk) values ('Bleed It Out', 2);
insert into music.songs (name, album_fk) values ('Shadow of the Day', 2);
insert into music.songs (name, album_fk) values ('What Ive Done', 2);
insert into music.songs (name, album_fk) values ('Hands Held High', 2);
insert into music.songs (name, album_fk) values ('No More Sorrow', 2);
insert into music.songs (name, album_fk) values ('Valentines Day', 2);
insert into music.songs (name, album_fk) values ('In Between', 2);
insert into music.songs (name, album_fk) values ('In Pieces', 2);
insert into music.songs (name, album_fk) values ('The Little Things Give You Away', 2);

insert into music.songs (name, album_fk) values ('Spiderhead', 3);
insert into music.songs (name, album_fk) values ('Come a Little Closer', 3);
insert into music.songs (name, album_fk) values ('Telescope', 3);
insert into music.songs (name, album_fk) values ('Its Just Forever', 3);
insert into music.songs (name, album_fk) values ('Take It or Leave It', 3);
insert into music.songs (name, album_fk) values ('Halo', 3);
insert into music.songs (name, album_fk) values ('Black Widow', 3);
insert into music.songs (name, album_fk) values ('Hypocrite', 3);
insert into music.songs (name, album_fk) values ('Teeth', 3);
insert into music.songs (name, album_fk) values ('Cigarette Daydreams', 3);


insert into music.songs (name, album_fk) values ('In One Ear', 4);
insert into music.songs (name, album_fk) values ('James Brown', 4);
insert into music.songs (name, album_fk) values ('Aint No Rest for the Wicked', 4);
insert into music.songs (name, album_fk) values ('Tiny Little Robots', 4);
insert into music.songs (name, album_fk) values ('Lotus', 4);
insert into music.songs (name, album_fk) values ('Back Against the Wall', 4);
insert into music.songs (name, album_fk) values ('Drones In The Valley', 4);
insert into music.songs (name, album_fk) values ('Judas', 4);
insert into music.songs (name, album_fk) values ('Back Stabbin Betty', 4);
insert into music.songs (name, album_fk) values ('Soil To The Sun', 4);
insert into music.songs (name, album_fk) values ('Free Love', 4);
insert into music.songs (name, album_fk) values ('Cover Me Again', 4);


insert into music.songs (name, album_fk) values ('You May Die', 5);
insert into music.songs (name, album_fk) values ('Two Dope Boyz', 5);
insert into music.songs (name, album_fk) values ('ATLiens', 5);
insert into music.songs (name, album_fk) values ('Wheelz of Steel', 5);
insert into music.songs (name, album_fk) values ('Jazzy Belle', 5);
insert into music.songs (name, album_fk) values ('Elevators', 5);
insert into music.songs (name, album_fk) values ('Ova Da Wudz', 5);
insert into music.songs (name, album_fk) values ('Babylon', 5);
insert into music.songs (name, album_fk) values ('Wailin', 5);
insert into music.songs (name, album_fk) values ('Millennium', 5);
insert into music.songs (name, album_fk) values ('E.T.', 5);
insert into music.songs (name, album_fk) values ('Elevators', 5);

insert into music.songs (name, album_fk) values ('For a Pessimist', 6);
insert into music.songs (name, album_fk) values ('Thats What You Get', 6);
insert into music.songs (name, album_fk) values ('Hallelujah', 6);
insert into music.songs (name, album_fk) values ('Misery Business', 6);
insert into music.songs (name, album_fk) values ('When It Rains', 6);
insert into music.songs (name, album_fk) values ('Let The Flames Begin', 6);
insert into music.songs (name, album_fk) values ('Miracle', 6);
insert into music.songs (name, album_fk) values ('crushcrushcrush', 6);
insert into music.songs (name, album_fk) values ('We Are Broken', 6);
insert into music.songs (name, album_fk) values ('Fences', 6);
insert into music.songs (name, album_fk) values ('Born for This', 6);
insert into music.songs (name, album_fk) values ('Misery Business Acoustic', 6);

insert into music.songs (name, album_fk) values ('Careful', 7);
insert into music.songs (name, album_fk) values ('Ignorance', 7);
insert into music.songs (name, album_fk) values ('Playing God', 7);
insert into music.songs (name, album_fk) values ('Brick by Boring Brick', 7);
insert into music.songs (name, album_fk) values ('Turn It Off', 7);
insert into music.songs (name, album_fk) values ('The Only Exception', 7);
insert into music.songs (name, album_fk) values ('Feeling Sorry', 7);
insert into music.songs (name, album_fk) values ('Looking Up', 7);
insert into music.songs (name, album_fk) values ('Where the Lines Overlap', 7);
insert into music.songs (name, album_fk) values ('Misguided Ghosts', 7);
insert into music.songs (name, album_fk) values ('All I Wanted', 7);

-- playlists

insert into music.playlists (name) values ('Happy Songs'); 
insert into music.playlists (name) values ('Sad Songs'); 

--playlists songs
insert into music.playlists_songs (playlist_fk, song_fk) values (1,24); 
insert into music.playlists_songs (playlist_fk, song_fk) values (1,60); 
insert into music.playlists_songs (playlist_fk, song_fk) values (1,57); 
insert into music.playlists_songs (playlist_fk, song_fk) values (1,71); 
insert into music.playlists_songs (playlist_fk, song_fk) values (1,54); 

insert into music.playlists_songs (playlist_fk, song_fk) values (2,10); 
insert into music.playlists_songs (playlist_fk, song_fk) values (2,65); 
insert into music.playlists_songs (playlist_fk, song_fk) values (2,8); 
insert into music.playlists_songs (playlist_fk, song_fk) values (2,66); 
insert into music.playlists_songs (playlist_fk, song_fk) values (2,70); 

