﻿using TechStation.Domain.Commons;
using TechStation.Domain.Enums;

namespace TechStation.Domain.Entities;

    public class UserRole : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
