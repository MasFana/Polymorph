using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        //Lingkaran bulat = new Lingkaran(12);
        //bulat.Gambar();
        //Persegi kotak = new Persegi(10, 10);
        //kotak.Gambar();
        //PersegiPanjang persegiPanjang = new PersegiPanjang(10, 20);
        //persegiPanjang.Gambar();
        //JajarGenjang jajarGenjang = new JajarGenjang(10, 20);
        //jajarGenjang.Gambar();

       /* Debit debitaku = new Debit("nopla", "732748309");
        debitaku.Penyetoran(50000);
        debitaku.CekSaldo();*/
        //Menggambar satuASADADA = new Menggambar();

        Elektronik laptop = new Elektronik("asus x44", 10000);
        Pakaian baju = new Pakaian("gucci", 50000);
        Buku cerita = new Buku("malin kundang", 20000);
        onlineshop.GetAllProducts();
        
        //cart.AddItem(laptop);
        //decimal total = cart.CalculateTotal();
        //Console.WriteLine("Total Harga: " + total.ToString("C"));

        //Console.ReadLine();






    }
}
public class onlineshop
{
    public string Name;
    public decimal Price;
    public string category;
    public int ongkir;
    public int jarak;
    public string cart;
    private static List<onlineshop> allProducts = new List<onlineshop>();


    public onlineshop(string name, decimal price, string category)
    {
        Name = name;
        Price = price;
        Console.WriteLine($"+ini adalah {name},kategorinya: \n {category},harganya{price}+");
        allProducts.Add(this);


    }
    public virtual void Ongkir(double jarak)
    {
        Console.WriteLine($"{ongkir*jarak}");
    }

    public static List<onlineshop> GetAllProducts()
    {
        decimal total = 0;
        int o = 1;
        foreach (var i in allProducts) {
            Console.WriteLine($"{o}.{i.Name} {i.Price}");
            total = (int)(total + i.Price);
            o++;
                }
        Console.WriteLine($"Total belanjaan di keranjang anda adalah {o-1} item dengan Total Rp:{total}");

        return allProducts;
    }

}
class Elektronik : onlineshop
{
    public Elektronik(string nama,decimal price) : base(nama,price,"Elektronik"){
         
    }
    public override void Ongkir(double jarak)
    {
        base.ongkir = 10000;
        base.Ongkir(jarak);
        Console.WriteLine(ongkir*jarak);
    }
}
class Pakaian : onlineshop
{
    public Pakaian(string nama, decimal price) : base(nama, price, "pakaian")
    {

    }
    public override void Ongkir(double jarak)
    {
        base.ongkir = 8000;
        base.Ongkir(1);
    }
  
}
class Buku : onlineshop
{
    public Buku(string nama, decimal price) : base(nama, price, "buku")
    { }
    public override void Ongkir(double jarak)
    {
        base.ongkir = 7000;
        base.Ongkir(1);


    }
}
// Kelas keranjang belanja
/*public class ShoppingCart
{
    private onlineshop item;

    public ShoppingCart()
    {
        item = null;
    }

    public void AddItem(onlineshop product)
    {
        item = product;
    }

    public decimal CalculateTotal()
    {
        if (item != null)
        {
            return item.Price;
        }
        else
        {
            return 0;
        }
    }
}
*/
class Menggambar
    {
        protected int panjang;
        protected int lebar;
        protected int radius;
        public Menggambar(int panjang, int lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }
        public Menggambar(int radius)
        {
            this.radius = radius;
        }
        public Menggambar()
        {
            System.Console.WriteLine("Minimal kasih constructor lah ya");
        }
        public virtual void Gambar()
        {
            System.Console.WriteLine("Sedang Menggambar");
        }

    }
    class Lingkaran : Menggambar
    {
        public Lingkaran(int r) : base(r)
        {

        }
        public override void Gambar()
        {
            System.Console.WriteLine($"Menggambar lingkaran dengan radius : {base.radius} Luas : {3.14 * base.radius * base.radius}");
        }
    }
    class Persegi : Menggambar
    {
        public Persegi(int p, int l) : base(p, l)
        {

        }
        public override void Gambar()
        {
            System.Console.WriteLine($"Menggambar persegi dengan p,l : {base.panjang},{base.lebar} Luas : {base.panjang * base.lebar}");
        }
    }
    class PersegiPanjang : Menggambar
    {
        public PersegiPanjang(int p, int l) : base(p, l)
        {

        }
        public override void Gambar()
        {
            System.Console.WriteLine($"Menggambar persegi panjang dengan p,l : {base.panjang},{base.lebar} Luas : {base.panjang * base.lebar}");
        }
    }
    class JajarGenjang : Menggambar
    {
        int alas;
        int tinggi;
        public JajarGenjang(int alas, int tinggi) : base(0, 0)
        {
            this.alas = alas;
            this.tinggi = tinggi;
        }
        public override void Gambar()
        {
            System.Console.WriteLine($"Menggambar jajar genjang dengan a,t : {alas},{tinggi} Luas : {alas * tinggi}");
        }
    }
    class Perbankan
    {
        protected string nama;
        protected string norekening;
        protected double saldo;
        protected double bunga = 0.1;
        public Perbankan(string nama, string norekening)
        {
            this.nama = nama;
            this.norekening = norekening;
        }
        public void Penyetoran(double duit)
        {
            saldo = saldo + duit;
            System.Console.WriteLine($"Berhasil Menambah saldo : {duit} total : {saldo}");
        }
        public virtual void CekSaldo()
        {
            System.Console.WriteLine($"{nama}, {norekening} Saldo anda : {saldo}");
            System.Console.WriteLine($"Bulan depan anda akan mendapatkan bunga {saldo * bunga}");
        }
        public virtual void Penarikan(double banyak)
        {
            if (saldo - banyak < 0)
            {
                System.Console.WriteLine("Saldo tidak mencukupi");
            }
            else
            {
                saldo = saldo - banyak;
                System.Console.WriteLine($"Penarikan {banyak} berhasil sisa saldo {saldo}");
            }
        }
    }
    class Giro : Perbankan
    {
        public Giro(string nama, string norekening) : base(nama, norekening)
        {
        }
        public override void Penarikan(double banyak)
        {
            if (saldo - banyak < -100000)
            {
                saldo = saldo - banyak;
                System.Console.WriteLine($"Penarikan saldo melebihi batas 100.000 saldo anda : {saldo}");
            }
            else
            {
                saldo = saldo - banyak;
                System.Console.WriteLine($"Penarikan berhasil {banyak} sisa saldo : {saldo}");
                System.Console.WriteLine($"Anda masih bisa menarik dana {100000 + saldo}");
            }
        }
        public override void CekSaldo()
        {
            System.Console.WriteLine("Tipe Rekening : Giro");
            base.CekSaldo();
        }
    }
    class Debit : Perbankan
    {
        public Debit(string nama, string norekening) : base(nama, norekening)
        {

        }
        public override void CekSaldo()
        {
            System.Console.WriteLine("Tipe Rekening : Debit");
            base.CekSaldo();
        }
    }
