using chaotic_attractors.Source.Utility;

namespace chaotic_attractors.Source.Attractors
{
    public class Lorenz : Attractor
    {
        public Lorenz(int x, int y, int z)
        {
            this.Location = new Coordinate(x, y, z);
        }

        public void Generate()
        {
            if (Location == null)
            {
                Location = new Coordinate(0, 0, 0);
            }
    
            int x = Location.X;
            int y = Location.Y;
            int z = Location.Z;
        }
    }
}