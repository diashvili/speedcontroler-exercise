namespace G15;

internal interface ISpeedHandler
{
	void Warning(int exceededSpeed);
}

internal class SpeedController
{
	private int _currentSpeed;
	private ISpeedHandler _speedHandler;

	public SpeedController(ISpeedHandler speedHandler)
	{
		if (speedHandler == null)
		{
			throw new ArgumentNullException(nameof(speedHandler));
		}

		_speedHandler = speedHandler;
		MaxSpeed = Random.Shared.Next(200, 300);
	}

	public int MaxSpeed { get; private init; }

	public int CurrentSpeed
	{
		get
		{
			return _currentSpeed;
		}
		set
		{
			if (value > MaxSpeed)
			{
				_speedHandler.Warning(value - MaxSpeed);
			}
			_currentSpeed = value;
		}
	}
}