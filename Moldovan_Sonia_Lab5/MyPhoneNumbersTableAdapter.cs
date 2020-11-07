using System;

namespace Moldovan_Sonia_Lab5.PhoneNumbersDataSetTableAdapters
{
	public partial class PhoneNumbersTableAdapter
	{
		public PhoneNumbersTableAdapter(String connectionString)
		{
			this.ClearBeforeFill = true;
			this.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
		}
	}
}
