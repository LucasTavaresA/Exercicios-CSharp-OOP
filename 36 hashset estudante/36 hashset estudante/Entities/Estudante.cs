namespace _36_hashset_estudante.Entities
{
    class Estudante
    {
        public int Id { get; set; }
        public int count = 0;

        public Estudante(int id)
        {
            Id = id;
            count++;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Estudante)) return false;
            Estudante other = obj as Estudante;
            return Id.Equals(other.Id);
        }
    }
}
