using MidiControllerProject.Library.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiControllerProject.Library.Scales
{
    public static class ScalesBook
    {
        /// <summary>
        /// Returns all scales.
        /// </summary>
        /// <returns></returns>
        public static List<Scale> GetAllScales()
        {
            List<Scale> scales = new List<Scale>();

            scales.Add(new CMajorScale());
            scales.Add(new CSharpMajorScale());
            scales.Add(new DMajorScale());
            scales.Add(new DSharpMajorScale());
            scales.Add(new EMajorScale());
            scales.Add(new FMajorScale());
            scales.Add(new FSharpMajorScale());
            scales.Add(new GMajorScale());
            scales.Add(new GSharpMajorScale());
            scales.Add(new AMajorScale());
            scales.Add(new ASharpMajorScale());
            scales.Add(new BMajorScale());

            return scales;
        }

        /// <summary>
        /// Returns all Major Scales.
        /// </summary>
        /// <returns></returns>
        public static List<Scale> GetMajorScales()
        {
            List<Scale> scales = new List<Scale>();

            scales.Add(new CMajorScale());
            scales.Add(new CSharpMajorScale());
            scales.Add(new DMajorScale());
            scales.Add(new DSharpMajorScale());
            scales.Add(new EMajorScale());
            scales.Add(new FMajorScale());
            scales.Add(new FSharpMajorScale());
            scales.Add(new GMajorScale());
            scales.Add(new GSharpMajorScale());
            scales.Add(new AMajorScale());
            scales.Add(new ASharpMajorScale());
            scales.Add(new BMajorScale());

            return scales;
        }

        public static List<Scale> GetMatchingScales(List<Note> notes)
        {
            List<Scale> matchingScales = new List<Scale>();

            foreach (Scale scale in GetAllScales())
            {
                if (scale.IsMatchingScale(notes))
                    matchingScales.Add(scale);
            }

            return matchingScales;
        }
    }
}
