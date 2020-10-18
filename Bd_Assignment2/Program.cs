using System;
using System.Data;
using System.Data.SqlClient;

namespace Bd_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTable dt = DB.Select("Select * From Room");

            foreach (DataRow dr in dt.Rows)
            {
                //House house = new House();
                //house.Id = (int)dr["Id"];
                //house.Rooms.Capacity = (int)dr["Rooms"];

                //Console.WriteLine($"The house id are {house.Id} and it contains {house.Rooms.Capacity}");

                Room room = new Room();

                room.Id = (int)dr["Id"];
                room.Rent = (double)dr["Rent"];

                Console.WriteLine($"The room id is {room.Id} and the rent is {room.Rent}");
            }
            



            //Console.WriteLine("Hello World!");
        }

        class DataOperation<T> where T : Entity
        {
            public void Insert(T item)
            {
                

            }

            public void Update(T item)
            {

            }

            public void Delete(T item)
            {

            }

            public void GetById(int id)
            {

            }

            public void GetAll()
            {

            }

        }

        

    }
}

