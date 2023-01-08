public sealed class M3:BMW{ //Al utilizar la palabra clave sealed en una clase, indicamos qeu no será posible heredar esta clase a otras.
    public M3(int hp, string color, string model):base(hp,color,model){
        this.Model = model;
    }

    public /*override*/ void Repair()
    {
        base.Repair();
    }
}