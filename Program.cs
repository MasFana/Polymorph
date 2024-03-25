class Program
{
    public static void Main(string[] args)
    {
        Lingkaran bulat = new Lingkaran(12);
        bulat.Gambar();
        Persegi kotak = new Persegi(10, 10);
        kotak.Gambar();
        PersegiPanjang persegiPanjang = new PersegiPanjang(10, 20);
        persegiPanjang.Gambar();
        JajarGenjang jajarGenjang = new JajarGenjang(10, 20);
        jajarGenjang.Gambar();

    }
}

class Menggambar
{
    protected int panjang;
    protected int lebar;
    protected int radius;
    public Menggambar(int panjang,int lebar){
        this.panjang = panjang;
        this.lebar = lebar;
    }
    public Menggambar(int radius){
        this.radius = radius;
    }
    public Menggambar(){
        System.Console.WriteLine("Minimal kasih constructor lah ya");
    }
    public virtual void Gambar(){
        System.Console.WriteLine("Sedang Menggambar");
    }

}
class Lingkaran : Menggambar{
    public Lingkaran(int r) : base(r){
        
    }
    public override void Gambar()
    {
        System.Console.WriteLine($"Menggambar lingkaran dengan radius : {base.radius} Luas : {3.14*base.radius*base.radius}");
    }
}
class Persegi : Menggambar
{
    public Persegi(int p,int l) : base(p,l)
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
    public JajarGenjang(int alas,int tinggi) : base(0, 0)
    {
        this.alas = alas;
        this.tinggi = tinggi;
    }
    public override void Gambar()
    {
        System.Console.WriteLine($"Menggambar jajar genjang dengan a,t : {alas},{tinggi} Luas : {alas * tinggi}");
    }
}
class Olshop
{
    
}
class Perbankan
{ 
    protected string nama;
    protected string norekening;
    protected int saldo;
    protected double bunga = 0.1;
    public Perbankan(string nama,string norekening){
        this.nama = nama;
        this.norekening = norekening;
    }
    public void Penyetoran(int duit){
        saldo = saldo + duit;
        System.Console.WriteLine($"Berhasil Menambah saldo : {duit} total : {saldo}");
    }
    public virtual void CekSaldo(){
        System.Console.WriteLine($"{nama}, {norekening} Saldo anda : {saldo}");
        System.Console.WriteLine($"Bulan depan anda akan mendapatkan bunga {saldo*bunga}");
    }
    public virtual void Penarikan(int banyak){
        if(saldo - banyak < 0){
            System.Console.WriteLine("Saldo tidak mencukupi");
        }else{
            saldo = saldo - banyak;
            System.Console.WriteLine($"Penarikan {banyak} berhasil sisa saldo {saldo}");
        }
    }
    class Giro : Perbankan
    {
        public Giro(string nama,string norekening):base(nama,norekening){
        }
        public override void Penarikan(int banyak)
        {
            if(saldo - banyak <-100000){
                saldo = saldo - banyak;
                System.Console.WriteLine($"Penarikan saldo melebihi batas 100.000 saldo anda : {saldo}");            
            }
            else{
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
    class Debit : Perbankan{
        public Debit(string nama,string norekening):base(nama,norekening){

        }
        public override void CekSaldo()
        {
            System.Console.WriteLine("Tipe Rekening : Giro");
            base.CekSaldo();
        }
    }

}