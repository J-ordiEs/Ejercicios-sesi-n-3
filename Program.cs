Client client1 = new Client("Jorge", 612312312, "Av siempre viva", "qweasdas@asd.com", true);
Console.WriteLine(client1);


public struct Client
{
    public Client(string name, int phone, string address, string email, bool isNewClient )
    {
        Name = name;
        Phone = phone;
        Address = address;
        Email = email;
        IsNewClient = isNewClient;
    }

    public string Name { get; }
    public int Phone { get; }
    public string Address { get; }
    public string Email { get; }
    public bool IsNewClient { get; }

    public override string ToString() => $@"
    Nombre: {Name} 
    Tel: {Phone} 
    Direccion: {Address} 
    Email: {Email} 
    Cliente nuevo: {IsNewClient}
    ";
}