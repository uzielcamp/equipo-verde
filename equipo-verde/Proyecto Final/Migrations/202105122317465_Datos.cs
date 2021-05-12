namespace Proyecto_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Datos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advisers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                        Cellphone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                        Photo = c.String(maxLength: 240),
                        Department = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Cellphone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                        Photo = c.String(maxLength: 240),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false, maxLength: 100),
                        Postalcode = c.String(nullable: false, maxLength: 10),
                        Phonenumber = c.String(nullable: false, maxLength: 15),
                        Website = c.String(nullable: false, maxLength: 240),
                        Email = c.String(nullable: false, maxLength: 100),
                        Photo = c.String(maxLength: 240),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(maxLength: 15),
                        Cellphone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                        Photo = c.String(maxLength: 240),
                        Department = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coordinators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Cellphone = c.String(nullable: false, maxLength: 15),
                        Email = c.String(maxLength: 100),
                        Photo = c.String(maxLength: 240),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        PhoneNomber = c.String(maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 50),
                        Photo = c.String(maxLength: 250),
                        Description = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Birthdate = c.String(nullable: false, maxLength: 20),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                        Cellphone = c.String(nullable: false, maxLength: 15),
                        Email = c.String(maxLength: 100),
                        Photo = c.String(maxLength: 240),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Majors");
            DropTable("dbo.Coordinators");
            DropTable("dbo.Contacts");
            DropTable("dbo.Companies");
            DropTable("dbo.Coaches");
            DropTable("dbo.Advisers");
        }
    }
}
