using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.DTOs.Character
{
    public class GetCharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Inteligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}