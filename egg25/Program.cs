using System.Text.Json;
namespace Program
{
	class egg25
	{
		static void Main()
		{
			Car car = new(0);
            string json = JsonSerializer.Serialize(car);
			Console.WriteLine(json);
			Car? newCar = JsonSerializer.Deserialize<Car>(json);
			Console.WriteLine(newCar.isOn);
			Console.WriteLine(newCar.speed);
        }
	}
}
	class Car
	{
		public bool isOn;
		public int speed;
		public Car(int speed)
		{
			if (speed != 0)
				this.isOn = true;
			else if (speed == 0)
				this.isOn = false;
			this.speed = speed;
		}
	}