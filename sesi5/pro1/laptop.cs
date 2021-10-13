using System;
public class Laptop
{
    //Attribute/Variable
    public string merk;
    public int ram;
    public int storage;

    //Setter
    public void SetMerk(string merk)
    {
        this.merk = merk;
    }
    public void SetRam(int ram)
    {
        this.ram = ram;
    }
    public void SetStorage(int storage)
    {
        this.storage = storage;
    }

    //Getter
    public string GetMerk()
    {
        return this.merk;
    }

    public int GetRam()
    {
        return ram;
    }

    public int GetStorage()
    {
        return storage;
    }

    //Method
    public void Chatting()
    {
        Console.WriteLine($"{this.merk} sedang chatting");
    }

    public void Sosmed()
    {
        Console.WriteLine($"{this.merk} sedang sosmed");
    }

    public void OnlineShop()
    {
        Console.WriteLine($"{this.merk} sedang online shop");
    }
}