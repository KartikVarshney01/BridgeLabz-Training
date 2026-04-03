namespace FutureLogistics
{
    public class BrickTransport : GoodsTransport
    {
        private float brickSize;
        private int brickQuantity;
        private float brickPrice;

        public BrickTransport(string transportId, string transportDate, int transportRating,
                              float brickSize, int brickQuantity, float brickPrice)
            : base(transportId, transportDate, transportRating)
        {
            this.brickSize = brickSize;
            this.brickQuantity = brickQuantity;
            this.brickPrice = brickPrice;
        }

        public override string VehicleSelection()
        {
            if (brickQuantity < 300)
                return "Truck";
            else if (brickQuantity <= 500)
                return "Lorry";
            else
                return "MonsterLorry";
        }

        public override float CalculateTotalCharge()
        {
            float price = brickPrice * brickQuantity;
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
