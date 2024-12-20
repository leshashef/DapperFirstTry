
using DapperFirstTry.Data.Interfaces;
using DapperFirstTry.Data.Repositoryes;
using Microsoft.Data.SqlClient;
using System.Data;

string conn = "Data Source=sqliteTest.db;Cache=Shared;Mode=ReadWriteCreate;";

IUserRepository userRepo = new UserRepository(conn);

userRepo.CreateTable();

userRepo.Create(new DapperFirstTry.Data.ModelsDB.User { Age = 18, Name = "Lesha" });

var users = userRepo.GetUsers();

foreach (var user in users)
{
    Console.WriteLine($"id: {user.Id} || name: {user.Name} || age: {user.Age}");
}