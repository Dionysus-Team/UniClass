namespace UniClass.Domain.Features.Entities
{
    public class Matter
    {
        private string _name {  get; set; }
        private string _tutor { get; set; }

        public Matter() { }

        public Matter(string name, string tutor)
        {
            _name = name;
            _tutor = tutor;
        }
    }
}
