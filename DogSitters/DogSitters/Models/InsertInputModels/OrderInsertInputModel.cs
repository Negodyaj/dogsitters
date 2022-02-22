﻿namespace DogSitters.API.Models
{
    public class OrderInsertInputModel
    {
        public DogOutputModel Dog { get; set; }
        public int SitterId { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime TimeStart { get; set; }
        public UserOutputModel User { get; set; }
    }
}
