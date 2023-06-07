USE TREK;

DROP TABLE IF EXISTS production.Bikes;
DROP TABLE IF EXISTS production.Equipments;
DROP TABLE IF EXISTS production.Framesets;
DROP TABLE IF EXISTS production.Groopsets;
DROP TABLE IF EXISTS production.TypeOfBikes;
DROP TABLE IF EXISTS production.Wheelsets;

DROP TABLE IF EXISTS sparesEquipment.Brakes;
DROP TABLE IF EXISTS sparesEquipment.Gripses;
DROP TABLE IF EXISTS sparesEquipment.Handlebars;
DROP TABLE IF EXISTS sparesEquipment.Saddles;
DROP TABLE IF EXISTS sparesEquipment.SeatPosts;
DROP TABLE IF EXISTS sparesEquipment.Steerings;
DROP TABLE IF EXISTS sparesEquipment.Stems;

DROP TABLE IF EXISTS sparesFrameset.Forks;
DROP TABLE IF EXISTS sparesFrameset.Frames;

DROP TABLE IF EXISTS sparesGroopset.Carriages;
DROP TABLE IF EXISTS sparesGroopset.Pedalses;
DROP TABLE IF EXISTS sparesGroopset.Transmitions;

DROP TABLE IF EXISTS sparesTransmition.Cassettes;
DROP TABLE IF EXISTS sparesTransmition.Shifters;
DROP TABLE IF EXISTS sparesTransmition.Switches;

DROP TABLE IF EXISTS sparesWheelset.Hubs;
DROP TABLE IF EXISTS sparesWheelset.Rims;
DROP TABLE IF EXISTS sparesWheelset.Tires;

DROP TABLE IF EXISTS factory.Factories;
DROP TABLE IF EXISTS factory.JobTitles;
DROP TABLE IF EXISTS factory.Staffs;

DROP SCHEMA IF EXISTS production;
DROP SCHEMA IF EXISTS factory;
DROP SCHEMA IF EXISTS sparesWheelset;
DROP SCHEMA IF EXISTS sparesTransmition;
DROP SCHEMA IF EXISTS sparesGroopset;
DROP SCHEMA IF EXISTS sparesFrameset;
DROP SCHEMA IF EXISTS sparesEquipment;
