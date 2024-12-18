namespace Design_Principles_Creational_Singleton
{
	public sealed class Logger //Not able to inherit
	{
		private static Logger loggerInstance;
		private static readonly object lockObject = new object();
		
		private Logger()
        	{
        	}
		
		public static Logger CreateLoggerInstance
		{
			get
			{
				if (loggerInstance == null)
				{
			                lock (lockObject)
			                {
			                    if (loggerInstance == null)
			                    {
			                        loggerInstance = new Logger();
			                    }
			                }
		            	}
		
		            	return loggerInstance;
		        }
		}
    	}

	internal class Program
    	{
		public static void Main(string[] args)
		{
			Logger logger = Logger.CreateLoggerInstance;
			Logger logger2 = Logger.CreateLoggerInstance;

			//Logger log = new Logger(); Not able to create instance due to private constructor
			
			Console.WriteLine(logger.GetHashCode());
			Console.WriteLine(logger2.GetHashCode());
	    	}
   	}
}
