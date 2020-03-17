using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace TPR.Basics
{
    public class Report:Entity
    {
        [MaxLength(256)]
        public string Name { get; set; }
    }
}
