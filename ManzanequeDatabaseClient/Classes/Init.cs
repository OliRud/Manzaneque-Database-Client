using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzanequeDatabaseClient.Classes
{
    public class Init
    {
        public void initialise()
        {
            RunSql execute = new RunSql();
            execute.initialise();

            string create_database = """
                -- Create Offices Table
                CREATE TABLE IF NOT EXISTS tblOffices (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    LocationName VARCHAR(100) UNIQUE,
                    Address VARCHAR(100),
                    Specialisation VARCHAR(50),
                    ContactNumber VARCHAR(15)
                );

                -- Create Employees Table
                CREATE TABLE IF NOT EXISTS tblEmployees (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    Name VARCHAR(100),
                    ContactNumber VARCHAR(20),
                    Email VARCHAR(100),
                    Location VARCHAR(100),
                    EmploymentStart DATE,
                    EmploymentEnd DATE DEFAULT NULL,
                    JobTitle VARCHAR(50),
                    Department VARCHAR(50),
                    FOREIGN KEY (Location) REFERENCES tblOffices(LocationName)
                );

                -- Create Hardware Table
                CREATE TABLE IF NOT EXISTS tblHardware (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    Name VARCHAR(80),
                    SerialNumber INT UNIQUE -- Unique for ticket tracking
                );

                -- Create Software Table
                CREATE TABLE IF NOT EXISTS tblSoftware (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    Type VARCHAR(60),
                    AssetID VARCHAR(10) UNIQUE
                );

                -- Create Technicians Table
                CREATE TABLE IF NOT EXISTS tblTechnicians (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    Name VARCHAR(100)
                );

                -- Create Specialism Table (linking to Technicians)
                CREATE TABLE IF NOT EXISTS tblSpecialism (
                    TechnicianID INT,
                    Specialty VARCHAR(100),
                    PRIMARY KEY (TechnicianID, Specialty),
                    FOREIGN KEY (TechnicianID) REFERENCES tblTechnicians(ID)
                );

                -- Create Tickets Table
                CREATE TABLE IF NOT EXISTS tblTickets (
                    TicketID INT AUTO_INCREMENT PRIMARY KEY,
                    EmployeeID INT,
                    OperatorID INT, -- Usually links to another Employee or Technician
                    Time DATETIME DEFAULT CURRENT_TIMESTAMP,
                    Location VARCHAR(100),
                    HW_serialnumber INT,
                    SW_AssetID VARCHAR(10),
                    Note VARCHAR(250),
                    TechnicianAssigned INT,
                    Status BOOLEAN DEFAULT FALSE,
                    FOREIGN KEY (EmployeeID) REFERENCES tblEmployees(ID),
                    FOREIGN KEY (HW_serialnumber) REFERENCES tblHardware(SerialNumber),
                    FOREIGN KEY (SW_AssetID) REFERENCES tblSoftware(AssetID),
                    FOREIGN KEY (TechnicianAssigned) REFERENCES tblTechnicians(ID)
                );

                """;

            execute.Push(create_database);

            string dummy_Data = """
                INSERT IGNORE INTO tblOffices (LocationName, Address, Specialisation, ContactNumber)
                VALUES 
                ('London Central', '100 Bishopsgate, London', 'Headquarters', '020 7946 0000'),
                ('Manchester Hub', '24 Piccadilly, Manchester', 'Technical Support', '0161 496 0011'),
                ('Birmingham Site', '12 New Street, Birmingham', 'Hardware Repair', '0121 496 0022'),
                ('Leeds Office', '45 The Headrow, Leeds', 'Software Dev', '0113 496 0033'),
                ('Liverpool Branch', '88 Albert Dock, Liverpool', 'Logistics', '0151 496 0044'),
                ('Bristol Tech', '19 Park St, Bristol', 'Network Security', '0117 496 0055'),
                ('Newcastle Base', '32 Grey St, Newcastle', 'Data Management', '0191 496 0066'),
                ('Sheffield Office', '77 Arundel Gate, Sheffield', 'Customer Service', '0114 496 0077'),
                ('Oxford Research', '10 High St, Oxford', 'R&D', '01865 496008'),
                ('Cambridge Tech', '55 King’s Parade, Cambridge', 'AI Research', '01223 496009'),
                ('Nottingham Unit', '14 Wheeler Gate, Nottingham', 'Training', '0115 496 0010'),
                ('Brighton Office', '22 Queens Rd, Brighton', 'Digital Design', '01273 496011'),
                ('Leicester Site', '9 High St, Leicester', 'General Support', '0116 496 0012'),
                ('Southampton Hub', '40 High St, Southampton', 'Maritime IT', '023 8096 0013'),
                ('York Branch', '31 Stonegate, York', 'Administration', '01904 496014');

                
                INSERT IGNORE INTO tblEmployees (Name, ContactNumber, Email, Location, EmploymentStart, EmploymentEnd, JobTitle, Department)
                VALUES 
                -- London Central
                ('Arthur Pendragon', '07700 900101', 'a.pendragon@ldn.com', 'London Central', '2024-01-01', '2025-12-31', 'IT Lead', 'IT'),
                ('Beatrice Webb', '07700 900102', 'b.webb@ldn.com', 'London Central', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Charles Darwin', '07700 900103', 'c.darwin@ldn.com', 'London Central', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Dorothy Hodgkin', '07700 900104', 'd.hodgkin@ldn.com', 'London Central', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Edward Jenner', '07700 900105', 'e.jenner@ldn.com', 'London Central', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Manchester Hub
                ('Fiona Gallagher', '07700 900201', 'f.gallagher@mcr.com', 'Manchester Hub', '2024-01-01', '2025-06-30', 'IT Lead', 'IT'),
                ('George Orwell', '07700 900202', 'g.orwell@mcr.com', 'Manchester Hub', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Harriet Martineau', '07700 900203', 'h.martineau@mcr.com', 'Manchester Hub', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Isaac Newton', '07700 900204', 'i.newton@mcr.com', 'Manchester Hub', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Jasmine Smith', '07700 900205', 'j.smith@mcr.com', 'Manchester Hub', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Birmingham Site
                ('Kevin Hart', '07700 900301', 'k.hart@bhm.com', 'Birmingham Site', '2024-01-01', '2024-09-15', 'IT Lead', 'IT'),
                ('Laura Marling', '07700 900302', 'l.marling@bhm.com', 'Birmingham Site', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Mark Rylance', '07700 900303', 'm.rylance@bhm.com', 'Birmingham Site', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Nancy Astor', '07700 900304', 'n.astor@bhm.com', 'Birmingham Site', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Oscar Wilde', '07700 900305', 'o.wilde@bhm.com', 'Birmingham Site', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Leeds Office
                ('Penelope Cruz', '07700 900401', 'p.cruz@lds.com', 'Leeds Office', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Quentin Blake', '07700 900402', 'q.blake@lds.com', 'Leeds Office', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Rose Tyler', '07700 900403', 'r.tyler@lds.com', 'Leeds Office', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Simon Cowell', '07700 900404', 's.cowell@lds.com', 'Leeds Office', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Thomas Hardy', '07700 900405', 't.hardy@lds.com', 'Leeds Office', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Liverpool Branch
                ('Ursula Corbero', '07700 900501', 'u.corbero@liv.com', 'Liverpool Branch', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Victor Hugo', '07700 900502', 'v.hugo@liv.com', 'Liverpool Branch', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Wendy Cope', '07700 900503', 'w.cope@liv.com', 'Liverpool Branch', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Xavier Woods', '07700 900504', 'x.woods@liv.com', 'Liverpool Branch', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Yvonne Strahovski', '07700 900505', 'y.strahovski@liv.com', 'Liverpool Branch', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Bristol Tech
                ('Zachary Quinto', '07700 900601', 'z.quinto@brs.com', 'Bristol Tech', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Abigail Adams', '07700 900602', 'a.adams@brs.com', 'Bristol Tech', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Benjamin Zephaniah', '07700 900603', 'b.zephaniah@brs.com', 'Bristol Tech', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Catherine Tate', '07700 900604', 'c.tate@brs.com', 'Bristol Tech', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('David Attenborough', '07700 900605', 'd.attenborough@brs.com', 'Bristol Tech', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Newcastle Base
                ('Elizabeth Fry', '07700 900701', 'e.fry@ncl.com', 'Newcastle Base', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Franklin Booth', '07700 900702', 'f.booth@ncl.com', 'Newcastle Base', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Grace Darling', '07700 900703', 'g.darling@ncl.com', 'Newcastle Base', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Henry Moore', '07700 900704', 'h.moore@ncl.com', 'Newcastle Base', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Isabella Bird', '07700 900705', 'i.bird@ncl.com', 'Newcastle Base', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Sheffield Office
                ('Jack Reacher', '07700 900801', 'j.reacher@shf.com', 'Sheffield Office', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Karen Gillan', '07700 900802', 'k.gillan@shf.com', 'Sheffield Office', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Liam Neeson', '07700 900803', 'l.neeson@shf.com', 'Sheffield Office', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Megan Rapinoe', '07700 900804', 'm.rapinoe@shf.com', 'Sheffield Office', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Nathan Fillion', '07700 900805', 'n.fillion@shf.com', 'Sheffield Office', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Oxford Research
                ('Olivia Colman', '07700 900901', 'o.colman@oxf.com', 'Oxford Research', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Peter Capaldi', '07700 900902', 'p.capaldi@oxf.com', 'Oxford Research', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Queenie Goldstein', '07700 900903', 'q.goldstein@oxf.com', 'Oxford Research', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Richard Ayoade', '07700 900904', 'r.ayoade@oxf.com', 'Oxford Research', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Sophie Turner', '07700 900905', 's.turner@oxf.com', 'Oxford Research', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Cambridge Tech
                ('Toby Jones', '07700 901001', 't.jones@cam.com', 'Cambridge Tech', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Uma Thurman', '07700 901002', 'u.thurman@cam.com', 'Cambridge Tech', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Vincent Rossi', '07700 901003', 'v.rossi@cam.com', 'Cambridge Tech', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Willow Smith', '07700 901004', 'w.smith@cam.com', 'Cambridge Tech', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Xander Cage', '07700 901005', 'x.cage@cam.com', 'Cambridge Tech', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Nottingham Unit
                ('Yasmin Khan', '07700 901101', 'y.khan@not.com', 'Nottingham Unit', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Zane Lowe', '07700 901102', 'z.lowe@not.com', 'Nottingham Unit', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Amelia Earhart', '07700 901103', 'a.earhart@not.com', 'Nottingham Unit', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Barney Stinson', '07700 901104', 'b.stinson@not.com', 'Nottingham Unit', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Clara Oswald', '07700 901105', 'c.oswald@not.com', 'Nottingham Unit', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Brighton Office
                ('Dexter Morgan', '07700 901201', 'd.morgan@btn.com', 'Brighton Office', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Edith Piaf', '07700 901202', 'e.piaf@btn.com', 'Brighton Office', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Felix Kjellberg', '07700 901203', 'f.kjellberg@btn.com', 'Brighton Office', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Gloria Estefan', '07700 901204', 'g.estefan@btn.com', 'Brighton Office', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Hugo Weaving', '07700 901205', 'h.weaving@btn.com', 'Brighton Office', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Leicester Site
                ('Iris Apfel', '07700 901301', 'i.apfel@lei.com', 'Leicester Site', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Jasper Conran', '07700 901302', 'j.conran@lei.com', 'Leicester Site', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Kira Knightley', '07700 901303', 'k.knightley@lei.com', 'Leicester Site', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Leo Tolstoy', '07700 901304', 'l.tolstoy@lei.com', 'Leicester Site', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Maya Angelou', '07700 901305', 'm.angelou@lei.com', 'Leicester Site', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- Southampton Hub
                ('Noah Centineo', '07700 901401', 'n.centineo@sou.com', 'Southampton Hub', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Opal Tometi', '07700 901402', 'o.tometi@sou.com', 'Southampton Hub', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Paul McCartney', '07700 901403', 'p.mccartney@sou.com', 'Southampton Hub', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Quinn Fabray', '07700 901404', 'q.fabray@sou.com', 'Southampton Hub', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Ruby Rose', '07700 901405', 'r.rose@sou.com', 'Southampton Hub', '2024-01-01', NULL, 'DevOps Engineer', 'Software'),

                -- York Branch
                ('Seth Rollins', '07700 901501', 's.rollins@yrk.com', 'York Branch', '2024-01-01', NULL, 'IT Lead', 'IT'),
                ('Thea Queen', '07700 901502', 't.queen@yrk.com', 'York Branch', '2024-01-01', NULL, 'Systems Analyst', 'IT'),
                ('Ulysses Grant', '07700 901503', 'u.grant@yrk.com', 'York Branch', '2024-01-01', NULL, 'Office Admin', 'Admin'),
                ('Vera Wang', '07700 901504', 'v.wang@yrk.com', 'York Branch', '2024-01-01', NULL, 'Support Tech', 'Hardware'),
                ('Wyatt Earp', '07700 901505', 'w.earp@yrk.com', 'York Branch', '2024-01-01', NULL, 'DevOps Engineer', 'Software');
                
                

                """;

            execute.Push(dummy_Data);
        }
    }
}
