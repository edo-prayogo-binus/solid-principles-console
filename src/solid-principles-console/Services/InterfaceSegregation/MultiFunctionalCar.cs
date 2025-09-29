namespace solid_principles_console.Services.InterfaceSegregation
{
    public class MultiFunctionalCar : IMultiFunctionalVehicle
    {
        #region prop and ctor
        private readonly ICar _car;
        private readonly IAirplane _airplane;

        public MultiFunctionalCar(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }
        #endregion

        #region main method
        public void Drive()
        {
            _car.Drive();
        }

        public void Fly()
        {
            _airplane.Fly();
        }
        #endregion
    }
}
