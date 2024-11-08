﻿namespace FurnitureImporter.Entities.Furniture
{
    public class Furniture : IEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
    }
}
