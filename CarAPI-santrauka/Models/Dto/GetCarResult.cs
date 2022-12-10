namespace CarAPI_santrauka.Models.Dto
{
    public class GetCarResult
    {
        /// <summary>
        /// Autogeneraciniis ID is duomenu bazes
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Automobilio gamintojo pavadinimas
        /// </summary>
        public string Mark { get; set; }
        public string Model { get; set; }
        /// <summary>
        /// Automobilio pagaminimo metai. Formatas : yyyy-MM-dd
        /// </summary>
        public string Year { get; set; }
        public string PlateNumber { get; set; }
        /// <summary>
        /// Automobilio pavaru dezes tipas. Galimos reiksmes : Manual/Automatic
        /// </summary>
        public string GearBox { get; set; }
        /// <summary>
        /// Automobiilio kuro tipas. Galimos reiksmes : Petrol/Diesel/Electric
        /// </summary>
        public string Fuel { get; set;}

    }
}
