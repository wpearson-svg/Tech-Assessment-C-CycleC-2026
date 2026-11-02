1. Create an Entity-Relationship Diagram (ERD) showing entities, attributes, and relationships.
You may:
Hand-draw the ERD and take a clear photo.
OR use a digital tool (e.g., Figma, Canva, draw.io) and take a screenshot.

2. Save the image and place it in your “Task 4” folder.

3. SQL Schema (reference Northwind Database; same database used in Geek Week)
Write CREATE TABLE statements for at least three entities, including:
Primary keys (PK)
Foreign keys (FK)
Appropriate data types and NOT NULL constraints.

Please add your SQL query below AND add an explanation: 

```
CREATE TABLE Locations (
    LocationID INT PRIMARY KEY,
    LocationName VARCHAR(100) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    City VARCHAR(100) NOT NULL,
    State VARCHAR(50) NOT NULL,
    ZipCode VARCHAR(20) NOT NULL
);

CREATE TABLE Regions (
    RegionID INT PRIMARY KEY,
    RegionName VARCHAR(100) NOT NULL
);

CREATE TABLE Shrink (
    ShrinkID INT PRIMARY KEY,
    LocationID INT NOT NULL,
    RegionID INT NOT NULL,
    ShrinkAmount DECIMAL(10, 2) NOT NULL,
    DateRecorded DATE NOT NULL,
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID),
    FOREIGN KEY (RegionID) REFERENCES Regions(RegionID)
);
```
```
First
Creates a locations table that includes columns for LocationID, LocationName, Address, City, State, and ZipCode. The LocationID column should be the primary key, and all other columns should be required (NOT NULL).
Second
Creates a regions table that includes columns for RegionID and RegionName. The RegionID column should be the primary key, and the RegionName column should be required (NOT NULL).
Third
Create a shrink table that includes columns for ShrinkID, LocationID, RegionID, ShrinkAmount, and DateRecorded. The ShrinkID column should be the primary key, and all other columns should be required (NOT NULL). The LocationID and RegionID columns should reference the Locations and Regions tables, respectively.
```

4. For submission, commit and push.
