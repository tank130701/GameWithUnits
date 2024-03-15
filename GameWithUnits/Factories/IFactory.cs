using System.Dynamic;
using GameWithUnits.Models.Units;

namespace GameWithUnits.Factories;

interface IFactory
{
    List<Unit> Create();
}