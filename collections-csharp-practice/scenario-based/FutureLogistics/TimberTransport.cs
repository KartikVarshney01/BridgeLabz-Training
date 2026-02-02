namespace FutureLogistics
{
    public class TimberTransport : GoodsTransport
    {
        private float timberLength;
        private float timberRadius;
        private string timberType;
        private float timberPrice;

        public TimberTransport(string transportId, string transportDate, int transportRating,
                               float timberLength, float timberRadius,
                               string timberType, float timberPrice)
            : base(transportId, transportDate, transportRating)
        {
            this.timberLength = timberLength;
            this.timberRadius = timberRadius;
            this.timberType = timberType;
            this.timberPrice = timberPrice;
        }

        public override string VehicleSelection()
        {
            float area = 2 * 3.147f * timberRadius * timberLength;

            if (area < 250)
                return "Truck";
            else if (area <= 400)
                return "Lorry";
            else
                return "MonsterLorry";
        }

        public override float CalculateTotalCharge()
        {
            float volume = 3.147f * timberRadius * timberRadius * timberLength;
            float rate = timberType.Equals("Premium", StringComparison.OrdinalIgnoreCase)
                ? 0.25f : 0.15f;

            float price = volume * timberPrice * rate;
            float tax = price * 0.30f;

            float vehicleCost = VehicleSelection().ToLower() switch
            {
                "truck" => 1000,
                "lorry" => 1700,
                _ => 3000
            };

            float discountPercentage = transportRating switch
            {
                5 => 0.20f,
                3 or 4 => 0.10f,
                _ => 0.0f
            };

            return (price + tax + vehicleCost) - (price * discountPercentage);
        }
    }
}
