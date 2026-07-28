using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.Common.Models
{
    public class BaseDto
    {

		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        private DateTime createDate;

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

		private DateTime upDatetime;

		public DateTime UpDatetime
        {
			get { return upDatetime; }
			set { upDatetime = value; }
		}



	}
}
