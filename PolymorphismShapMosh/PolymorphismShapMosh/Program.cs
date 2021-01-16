using System;
using System.Collections.Generic;

namespace PolymorphismShapMosh
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base (connectionString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Open Sql Connection");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Close Sql Connection");
        }

    }
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Open Oracle Connection");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Close Oracle Connection");
        }

    }
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }
        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException();
            }
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
    public class DbCommand
    {
        public DbConnection DbConnection { get; }
        public string Command { get; }

        public DbCommand(DbConnection dbConnection, string command)
        {
            if (dbConnection == null || String.IsNullOrWhiteSpace(command))
            {
                throw new InvalidOperationException();
            }
            DbConnection = dbConnection;
            Command = command;
        }
        public void Execute()
        {
            DbConnection.OpenConnection();
            Console.WriteLine($"Run - {Command}");
            DbConnection.CloseConnection();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand dbCommand = new DbCommand(new SqlConnection("connection"), "Select * From Employees");
            dbCommand.Execute();

            //Circle circle = new Circle();
            //Rectangle rectangle = new Rectangle();
            //List<Shape> shapes = new List<Shape>();
            //shapes.Add(circle);
            //shapes.Add(rectangle);

            //Canvas canvas = new Canvas();
            //canvas.DrawShapes(shapes);

            Console.ReadLine();

        }
    }
}
