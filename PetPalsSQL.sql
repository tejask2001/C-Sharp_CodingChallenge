create table Pets (pet_id int identity primary key,[name] varchar(50),age int,Breed varchar(50),
[type] varchar(50),available_for_adoption bit);

create table Shelters (ShelterID int identity primary key,Name varchar(50),Location varchar(100));

create table Donations (DonationID int identity primary key,DonorName varchar(50),DonationType varchar(50),
DonationAmount decimal,DonationItem varchar(50),DonationDate datetime);

create table AdoptionEvents (EventID int identity primary key,EventName varchar(50),EventDate datetime,
Location varchar(100));

create table Participants (ParticipantID int identity primary key,ParticipantName varchar(50),
ParticipantType varchar(50),EventID int,foreign key (EventID) references AdoptionEvents(EventID)
on delete cascade);


insert into Pets values
('Buddy', 3, 'Golden Retriever', 'Dog', 1),
('Whiskers', 2, 'Siamese', 'Cat', 0),
('Rocky', 1, 'German Shepherd', 'Dog', 1),
('Mittens', 4, 'Persian', 'Cat', 1),
('Charlie', 2, 'Labrador Retriever', 'Dog', 0),
('Oreo', 1, 'Domestic Shorthair', 'Cat', 1),
('Max', 3, 'Beagle', 'Dog', 1),
('Luna', 2, 'Ragdoll', 'Cat', 0),
('Daisy', 4, 'Dachshund', 'Dog', 1),
('Simba', 1, 'Bengal', 'Cat', 1);

insert into Shelters values
('Happy Paws Shelter', 'Mumbai, India'),
('Safe Haven Animal Rescue', 'Delhi, India'),
('Paws and Claws Shelter', 'Bangalore, India'),
('Hearts of Gold Rescue', 'Chennai, India'),
('Hopeful Tails Adoption Center', 'Kolkata, India'),
('Compassion for Critters Shelter', 'Hyderabad, India'),
('Rescue and Rehome Foundation', 'Pune, India'),
('Furry Friends Sanctuary', 'Ahmedabad, India'),
('Joyful Tails Animal Haven', 'Jaipur, India'),
('Kindred Spirits Pet Refuge', 'Lucknow, India')

insert into Donations values
('Aarav Sharma', 'Cash', 1000.50, NULL, '2023-01-15T10:30:00'),
('Ishika Patel', 'Item', NULL, 'Pet Food', '2023-02-20T14:45:00'),
('Advait Singh', 'Cash', 500.75, NULL, '2023-03-05T12:15:00'),
('Ananya Verma', 'Item', NULL, 'Blankets', '2023-04-10T09:00:00'),
('Arjun Kapoor', 'Cash', 800.25, NULL, '2023-05-18T16:20:00'),
('Mira Reddy', 'Item', NULL, 'Toys', '2023-06-25T11:45:00'),
('Vir Mehra', 'Cash', 1200.00, NULL, '2023-07-30T13:30:00'),
('Neha Gupta', 'Item', NULL, 'Litter Box', '2023-08-12T08:00:00'),
('Rohan Khanna', 'Cash', 1500.50, NULL, '2023-09-28T17:10:00'),
('Sara Kumar', 'Item', NULL, 'Scratching Post', '2023-10-15T10:00:00')

insert into AdoptionEvents values
('Pawsome Adoption Day', '2023-01-20T14:00:00', 'Mumbai, India'),
('Furry Friends Fair', '2023-02-15T11:30:00', 'Delhi, India'),
('Adopt-A-Pet Carnival', '2023-03-10T13:45:00', 'Bangalore, India'),
('Hearts and Paws Expo', '2023-04-05T10:00:00', 'Chennai, India'),
('Hopeful Tails Adoption Fest', '2023-05-22T15:30:00', 'Kolkata, India'),
('Pet Adoption Fiesta', '2023-06-18T12:15:00', 'Hyderabad, India'),
('Rescue Rally', '2023-07-12T16:45:00', 'Pune, India'),
('Joyful Tails Meet & Greet', '2023-08-28T09:30:00', 'Ahmedabad, India'),
('Woof and Whisker Showcase', '2023-09-10T14:00:00', 'Jaipur, India'),
('Adoption Jubilee', '2023-10-05T11:00:00', 'Lucknow, India');

insert into Participants values
('Happy Paws Shelter', 'Shelter', 1),
('Pet Lovers Club', 'Adopter', 2),
('Paws and Claws Rescue', 'Shelter', 3),
('Animal Allies', 'Shelter', 4),
('Adopters United', 'Adopter', 5),
('Compassionate Care Foundation', 'Shelter', 6),
('Furry Friends Adoption Agency', 'Shelter', 7),
('Pet Enthusiasts Society', 'Adopter', 8),
('Hearts of Gold Volunteers', 'Shelter', 9),
('Caring Families Network', 'Adopter', 10);

select * from Pets
select * from Shelters
select * from Participants
select * from AdoptionEvents
select * from Donations


insert into participants values('harshal','adopter',2);

