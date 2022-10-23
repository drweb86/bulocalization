using System;
using System.Runtime.Serialization;

namespace BULocalization.Core
{
	[Serializable]
	public class CommonTranslationException: Exception
	{
		public CommonTranslationException()
		{
		
		}
		
		public CommonTranslationException(string message)
			: base(message)
		{
		}
		
		public CommonTranslationException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
		
		protected CommonTranslationException(SerializationInfo info, StreamingContext innerException)
			: base(info, innerException)
		{
		}
	}
}
