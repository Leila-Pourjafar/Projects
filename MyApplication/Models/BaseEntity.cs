namespace Models
{
	public abstract class BaseEntity : object
	{
		public BaseEntity() : base()
		{
			//Id = new System.Guid();

			Id = System.Guid.NewGuid();
		}

		// **********
		public System.Guid Id { get; set; }
		// **********
	}
}
