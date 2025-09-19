using NUnit.Framework;
using EcdlBooking.Data;
using EcdlBooking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// https://www.youtube.com/watch?v=VBT9CR9sl-A

[TestClass]
public class EntityRelationshipTests
{   
    private ApplicationDbContext _context;
    
    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "Tabella")
            .Options;

    }
    [TestMethod]
    public void ApplicationUser_RelationshipSchool_IsCorrect()
    {

        //Arrange Inizializzazione degli oggetti

        var utente = new ApplicationUser { Id = "", Name = "Gianmarco" };
        _context.Utenti.Add(utente);
        _context.SaveChanges(); 





        
    }

}
