-- create database labproject;
use labproject;

drop table if exists submission;
drop table if exists std_class;
drop table if exists Comment;
drop table if exists ClassMaterial;
drop table if exists Announcement;
drop table if exists Assignment;
drop table if exists classpost;
drop table if exists Class;
drop table if exists User_;

-- table for users (two types: student and teacher)
create table User_(
  userid int primary key,
  fullname varchar(255) NOT NULL,
  email varchar(255) NOT NULL,
  password varchar(255) NOT NULL,
  username varchar(255) not null,
  user_type varchar(255) NOT NULL
);

-- table for class
create table Class(
  class_code varchar(100) PRIMARY KEY,
  class_name varchar(255) not null,
  class_section varchar(100) not null,
  teacher_id int not null,-- teacher that created the class

  foreign key (teacher_id) references User_(userid) on delete cascade
);

-- table for class post (three types: assignment, annoucement, class material)
create table classpost(
	classpost_id int primary key,
	class_code varchar(100) not null,
	date_issued date not null, -- includes time and date
	userid int not null, -- person that created the post

	foreign key (class_code) references Class(class_code) on delete cascade,
	foreign key (userid) references User_(userid) on delete no action
);

-- table for classpost type assignment
create table Assignment(
	classpost_id int not null, 
	due_date date NOT NULL, -- includes time and date
	assignment_desc varchar(255) not null,

	foreign key (classpost_id) references classpost(classpost_id) on delete no action,
	primary key(classpost_id)
);

-- table for classpost type Announcement
create table Announcement(
  classpost_id int not null,
  announcement_desc varchar(255),
  
  foreign key (classpost_id) references classpost(classpost_id) on delete no action,
  primary key (classpost_id)
);

-- table for class post type class material
create table ClassMaterial(
  classpost_id int not null,
  material_desc varchar(255),

  foreign key (classpost_id) references classpost(classpost_id) on delete no action,
  primary key (classpost_id)
  
);

-- table for comment
create table Comment(
  comment_id int primary key,
  comment_desc varchar(255) not null,
  userid int not null,
  classpost_id int not null,

  foreign key (userid) references User_(userid) on delete no action,
  foreign key (classpost_id) references classpost(classpost_id) on delete no action,
);

-- table for recording students in a class
create table std_class (
	userid int not null,-- of type student
	class_code varchar(100) not null,

	foreign key (userid) references User_(userid) on delete no action,
	foreign key (class_code) references Class(class_code) on delete cascade, 
	primary key (userid, class_code)
);

-- table for assignmnet and user id for submimssion
create table submission(
	userid int not null,-- of type student
	classpost_id int not null,
	grade char default '-',

	foreign key (userid) references User_(userid) on delete no action,
	foreign key (classpost_id) references classpost(classpost_id) on delete no action
);

--Insertions
INSERT INTO User_ (userid, fullname, email, password, username, user_type ) VALUES 
	('1', 'Ali Khan', 'arham11@gmail.com', '1234', 'alikahn11', 'Student'),
    ('2', 'Sarah Abigail', 'sarahabi@gmail.com', '1111', 'sarahabigail', 'Teacher');

INSERT INTO Class (class_code, class_name, class_section, teacher_id) VALUES
	('00sq1o', 'Database SE-Q', 'Q', '2'),
    ('00sp11', 'Database SE-P', 'P', '2');

INSERT INTO classpost(classpost_id, class_code, date_issued, userid) VALUES
	('1', '00sq1o', '2023-05-12', '2'),
    ('2', '00sq1o', '2023-05-13', '2'),
    ('3', '00sp11', '2023-05-13', '2');
    
INSERT INTO Announcement (classpost_id, announcement_desc) VALUES
	('1', 'I will post the material for the topic we covered in our last class by tmr.');
    
INSERT INTO ClassMaterial (classpost_id, material_desc) VALUES
	('2', 'I have attatched the ppt below.');

INSERT INTO Assignment (classpost_id, due_date, assignment_desc) VALUES
	('3', '2023-05-20','This is your last assignment for this semester.');
    
INSERT INTO Comment(comment_id, comment_desc, userid, classpost_id) VALUES
	('1', 'Mam can you please extend the deadline.', '1', '3');
    
INSERT INTO std_class(userid, class_code) VALUES
	('1', '00sq1o');
    
INSERT INTO submission (userid, classpost_id, grade)VALUES
	('1', '3', 'A');

	
--function to count number of users
create function getUserCount()
returns int
as
begin

return (select count(*) from User_);
end

--function to count number of posts
create function getClassPostCount()
returns int
as
begin

return (select count(classpost_id) from classpost);
end

--function to count number of comments
create function getCommentCount()
returns int
as
begin

return (select count(classpost_id) from Comment);
end

--function to count submitted status
create function getSubmittedStatus(@postid int)
returns int
as
begin

return (select count(classpost_id) from submission where classpost_id=@postid);
end

--function to return data for annoucements
create procedure displayAnnouncement @code varchar(100)
as
begin
select act.classpost_id, act.announcement_desc, cp.date_issued, u.fullname
from Announcement act
inner join classpost cp on act.classpost_id=cp.classpost_id
inner join User_ u on u.userid=cp.userid
where cp.class_code=@code
end

--procedure to display CM
create procedure displayClassMaterial @code varchar(100)
as
begin
select cm.classpost_id, cm.material_desc, cp.date_issued, u.fullname
from ClassMaterial cm
inner join classpost cp on cm.classpost_id=cp.classpost_id
inner join User_ u on u.userid=cp.userid
where cp.class_code=@code
end

--procedure to display comments
create procedure displayComment @postid int
as
begin

select cmt.comment_id, cmt.comment_desc, u.fullname
from Comment cmt
inner join User_ u on u.userid=cmt.userid
where cmt.classpost_id=@postid
end

--function to display assignment details
create procedure displayAssignment @code varchar(100)
as
begin
select asgn.classpost_id, asgn.assignment_desc, asgn.due_date, u.fullname, cp.date_issued
from Assignment asgn
inner join classpost cp on asgn.classpost_id=cp.classpost_id
inner join User_ u on u.userid=cp.userid
where cp.class_code=@code
end

--procedure to display students in a class
create procedure getStudentList @code varchar(100)
as
begin
select u.fullname, u.email
from User_ u
inner join std_class std on std.userid=u.userid
where std.class_code=@code
end

--procedure to display grades of one assignment
create procedure getGradeList @postid int
as
begin
select u.fullname, sub.grade
from User_ u
inner join submission sub on sub.userid=u.userid
where sub.classpost_id=@postid
end

--procedure to display the classes a student is in
create procedure getStudentClasses @userid int
as
begin
select c.class_code, c.class_name, c.class_section
from Class c 
inner join std_class std on std.class_code=c.class_code
where std.userid=@userid
end

--procedure to display grades with names
create procedure getGrades @classpost int
as
begin
select u.userid, u.fullname, sub.grade
from User_ u
inner join submission sub on sub.userid=u.userid
where sub.classpost_id=@classpost
end

