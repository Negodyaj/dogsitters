﻿namespace DogSitters.API.Models
{
    public class OrderUpdateInputModel
    {
        public SitterOutputModel Sitter { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
    }
}
