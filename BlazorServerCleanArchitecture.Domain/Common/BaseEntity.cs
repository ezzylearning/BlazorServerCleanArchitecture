using BlazorServerCleanArchitecture.Domain.Common.Interfaces;

using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerCleanArchitecture.Domain.Common
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; } 
    }
}
