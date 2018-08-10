using Flunt.Notifications;
using System;

namespace BookStore.Domain.Base
{
    public class Entity : Notifiable
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
