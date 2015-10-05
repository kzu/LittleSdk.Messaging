namespace LittleSdk.Messaging
{
	public class Messaging : IMessaging
	{
		private ILittleSdk sdk;

		public Messaging (ILittleSdk sdk)
		{
			this.sdk = sdk;
		}

		public void Send (string message)
		{
			sdk.Write (message);
		}
	}
}
