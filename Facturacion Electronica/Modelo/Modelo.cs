using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Modelo
    {
        private Int32 id;
        private DateTime createdAt;
        private DateTime updatedAt;

        public Int32 ID
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public DateTime UpdatedAt
        {
            get { return updatedAt; }
            set { updatedAt = value; }
        }
    }
}
