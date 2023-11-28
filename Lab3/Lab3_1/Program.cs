namespace Lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CharacterСontrol control_ch = new CharacterСontrol();
            Character character = new Character();
            
            IMovement boat = new RiverAdapter(character);
            control_ch.TravelCharacter(boat);

            IMovement hangGlider = new CanyonAdapter(character);
            control_ch.TravelCharacter(hangGlider);
        }
    }
}