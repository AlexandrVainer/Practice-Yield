using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practice_Yield
{
    public class Agency
    {
        public Car[] Cars { get; set; }

        public IEnumerator<Car> GetEnumerator()
        {
            foreach (Car car in Cars)
                yield return car;
        }
        public IEnumerable<Car> GetCars(int modelYear)
        {
            foreach (Car car in Cars)
                if (car.ModelYear == modelYear)
                {
                    yield return car;
                }
        }
        public IEnumerable<Car> GetCars(string maker)
        {
            foreach (Car car in Cars)
                if (car.Maker == maker)
                {
                    yield return car;
                }
        }

    }
}
