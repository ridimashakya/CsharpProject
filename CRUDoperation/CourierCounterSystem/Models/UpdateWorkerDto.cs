﻿namespace CRUDoperation.Models
{
    public class UpdateWorkerDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public decimal Wages { get; set; }
    }
}
