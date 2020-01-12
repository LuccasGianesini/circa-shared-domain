namespace Circa.Shared.Domain
{
    public class InitiativeOrder
    {
        public string CharId { get; set; }
        public string CharName { get; set; }

        public int Position { get; set; }

        public int Rolled { get; set; }
        
        public bool Lowered { get; set; }
    }
}