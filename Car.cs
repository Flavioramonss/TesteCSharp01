public class Car {
    public int Code { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Brand { get; set; } = string.Empty;

    public string Color { get; set; } = string.Empty;

    public int Year { get; set; }

    public Car() {

    }

    public override string ToString() {
        return $"{Code}: {Name}";
    }
}