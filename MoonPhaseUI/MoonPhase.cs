using SunMoonCalcs;
using System;
using System.Drawing;
using System.Linq;
using MoonFracPhaseAngle = SunMoonCalcs.SunMoonCalcs.MoonCalc.MoonFracPhaseAngle;
namespace MoonPhase
{
    public class MoonPhase
    {
        const double SynodicMonth = 29.530588853d;

        public double MinFraction { get; }
        public double MaxFraction { get; }
        public string Name_ES { get; }
        public string Name_EN { get; }
        public bool Waxing { get; }
        public bool Waning { get; }
        public int Id { get; }
        public MoonFracPhaseAngle Illumination { get; private set; }
                
        public double Age { get { return Illumination?.phase * SynodicMonth ?? 0d;  } }

        private MoonPhase(double minFraction, double maxFraction, bool waxing, bool waning, string nameES, string nameEN, int id)
        {
            Id = id;
            MinFraction = minFraction;
            MaxFraction = maxFraction;
            Waxing = waxing;
            Waning = waning;
            Name_ES = nameES;
            Name_EN = nameEN;
        }
        public static MoonPhase NewMoon = new MoonPhase(0, 0.02, true, true, "Luna Nueva", "New Moon", 1);
        public static MoonPhase WaxingCrescent = new MoonPhase(0.02, 0.35, true, false, "Creciente Cóncava", "Waxing Crescent", 2);
        public static MoonPhase FirstQuarter = new MoonPhase(0.35, 0.66, true, false, "Cuarto Creciente", "First Quarter", 3);
        public static MoonPhase WaxingGibbous = new MoonPhase(0.66, 0.99, true, false, "Creciente Convexa", "Waxing Gibbous", 4);
        public static MoonPhase FullMoon = new MoonPhase(0.99, 1.01, true, true, "Luna Llena", "Full Moon", 5);
        public static MoonPhase WaningGibbous = new MoonPhase(0.66, 0.99, false, true, "Menguante Convexa", "Waning Gibbous", 6);
        public static MoonPhase LastQuarter = new MoonPhase(0.35, 0.66, false, true, "Cuarto Menguante", "Last Quarter", 7);
        public static MoonPhase WaningCrescent = new MoonPhase(0.02, 0.35, false, true, "Menguante Cóncava", "Waning Crescent", 8);

        private const double RadToDeg = (double)180 / Math.PI;

        public override string ToString()
        {
            return $"{Name_EN} ({Illumination?.fraction * 100:N2}% | {Illumination?.angle * RadToDeg:N0}° | {Age:N2} days)";
        }

        public static MoonPhase[] AllPhases { get; } = new[]
        {
            NewMoon, WaxingCrescent, FirstQuarter, WaxingGibbous, FullMoon, WaningGibbous, LastQuarter, WaningCrescent
        };

        public static MoonPhase GetPhase(MoonFracPhaseAngle illumination)
        {
            MoonPhase phase;
            if (illumination.angle < 0)
            {
                phase = AllPhases.First(ph => ph.Waxing && illumination.fraction >= ph.MinFraction && illumination.fraction < ph.MaxFraction);
            }
            else
            {
                phase = AllPhases.First(ph => ph.Waning && illumination.fraction > ph.MinFraction && illumination.fraction <= ph.MaxFraction);
            }
            phase.Illumination = illumination;
            return phase;
        }

        public static MoonPhase GetPhase(DateTime dt)
        {
            var ilum = SunMoonCalcs.SunMoonCalcs.MoonCalc.GetMoonIllumination(dt);
            return GetPhase(ilum);
        }
    }


}
