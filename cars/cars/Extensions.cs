using cars.models;

namespace cars
{
    public static class Extensions
    {
        public static CarDto AsDto(this Car car)
        {
            return new CarDto(car.Id, car.Name, car.Description, car.CreatedTime);
        }
    }
}
