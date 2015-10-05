using Xunit;

namespace Tests
{
	public class MessagingSpec
	{
		[Fact]
		public void ShowMessage ()
		{
			var messaging = new LittleSdk.Messaging.Messaging(new LittleSdk.LittleSdk());

			messaging.Send ("Hello World");
		}
	}
}
