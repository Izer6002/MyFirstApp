using System;

public class Class1
{
	public Class1()
	{
		public string FirstName, LastName;
		public int Age, ID;
		private static int count = 0;
		public Pesron(string FirstName, string LastName, int Age)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Age = Age;
			ID = ++count;
		}
		public Person()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Age = -1;
            ID = ++count;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Age: {Age}, ID: {ID}";
        }
	}
}

