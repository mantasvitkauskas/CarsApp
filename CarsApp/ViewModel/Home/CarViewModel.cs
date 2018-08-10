using CarsApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarsApp.ViewModel.Home
{
    public class CarViewModel
    {
        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_CarsInfo", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Car car = new Car();

                        car.Number = reader["Number"].ToString();
                        car.Year_Made = Convert.ToDateTime(reader["Year_Made"]);
                        car.Model = reader["Model"].ToString();
                        car.CurrentSegmentName = reader["CurrentSegmentName"].ToString();
                        car.CurrentUserName = reader["CurrentUserName"].ToString();
                        car.StatusName = reader["StatusName"].ToString();
                        car.PreviousSegmentName = reader["PreviousSegmentName"].ToString();
                        car.PreviousUserName = reader["PreviousUserName"].ToString();

                        cars.Add(car);
                    }
                }
            }

            return cars;
        }
    }
}