using Orleans;
using Orleans.Concurrency;
using System.Threading.Tasks;
using System;
using Server;
using Shared;

namespace Server
{
    public interface ICreature : ICreatureImpl
    {
    }

    public interface ICreatureImpl : IUnitImpl
    {
        Task Create(CreatureEntry entry);
    }
}