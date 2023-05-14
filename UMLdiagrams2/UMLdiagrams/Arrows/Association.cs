using UMLdiagrams.Helpers;
using UMLdiagrams.Myclasses;

namespace UMLdiagrams.Arrows
{
    [Serializable]
    public class Association :Arrow_Template
    {
        public Association(ArrowArgs fromArgs, ArrowArgs toArgs) : base(fromArgs, toArgs)
        {}
    }
}
