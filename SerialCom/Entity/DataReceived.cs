using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialCom.Entity
{
    public class DataReceived
    {
        [Column(IsPrimary = true, IsIdentity = true)]
        public int Id { get; set; }

        [Column(StringLength = -1)]
        public string Data { get; set; }
        public DateTime Timestamp { get; set; }
        [Column(StringLength = -1)]
        public string Remark { get; set; }
    }
}
