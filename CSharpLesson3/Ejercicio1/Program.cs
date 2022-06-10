Console.WriteLine("Hello, World!");

Client Client = new Client("Adrian Garcia", "1123904279", "Flores","eg@gmail.com",true);

Console.WriteLine(Client.ToString());

Console.ReadKey();
public struct Client 
{
    public Client(string fullName, string phone, string address, string email, bool newClient)
    {
        FullName = fullName;
        Phone = phone;  
        Address = address;
        Email = email;
        NewClient = newClient;
    }

    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public bool NewClient { get; set; }

    public override string ToString() => $"({FullName}, {Phone}, {Address}, {Email} , {NewClient})";
}