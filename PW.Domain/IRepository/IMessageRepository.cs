﻿using _01_Framework.Infrastructure;
using PW.Domain.Models;

namespace PW.Domain.IRepository
{
    public interface IMessageRepository : IRepository<int, Message>
    {
    }
}
