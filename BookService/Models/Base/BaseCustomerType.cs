using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookService.Models.Base
{
    public class BaseCustomerType
    {
        public int Id { get; set; }

        [Required]
        public string CustomerTypeName { get; set; }

        public int FlagRegister { get; set; }

        public int FlagDel { get; set; }

        public string OperaName { get; set; }

        public DateTime OperaTime { get; set; }
    }
}