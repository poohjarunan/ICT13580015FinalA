using System;
using System.Collections.Generic;
using System.Text;
using SQLite;



namespace ICT13580015FinalA.Models
{
	public class Pooh
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }	
		public string Name { get; set; }
		public string Lastname { get; set; }
        public int Age { get; set; }
        public int Sex { get; set; }
		public string Department { get; set; }
		public int Phone { get; set; }
        public string Address { get; set; }
		public string Status { get; set; }
        public int Number { get; set; }
		public decimal Salary { get; set; }
        public string Email { get; set; }
		public int Children { get; set; }
	}


}
