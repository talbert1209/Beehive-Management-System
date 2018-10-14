namespace Beehive_Management_System
{
    public class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;

        public double WeightMg { get; set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        public virtual double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}