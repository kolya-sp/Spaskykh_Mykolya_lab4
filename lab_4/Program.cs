using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    interface ISudno
    {
        void vivesti_tip_palnogo();
        void dozapravka(int obiem);
    }
    abstract class Sudno :ISudno
    {
        public string name { get;  set; }
        public int shvidkist { get;  set; }
        public int gruzo_pidyomnist { get;  set; }
        public string tip_palnogo { get;  set; }
        public int obiem_palnogo { get;  set; }
        public abstract void vivesti_tip_palnogo();
        public abstract void dozapravka(int obiem);
    }
    class vantajniy_korabel: Sudno,ISudno
    {
        public vantajniy_korabel(int shvidkist, int obiem_palnogo) 
        {
            this.name = "vantajniy_korabel";
            this.shvidkist = shvidkist;
            this.gruzo_pidyomnist = 100000;
            this.tip_palnogo = "судовое маловязкое топливо";
            this.obiem_palnogo = obiem_palnogo;
        }
        public override void vivesti_tip_palnogo()
        {
            Console.WriteLine("тип пального " + tip_palnogo);
        }
        public override void dozapravka(int obiem)
        {
            obiem_palnogo += obiem;
            Console.WriteLine("пiсля дозаправки +" + obiem + " об*ем пального судна " + name + " став " + obiem_palnogo);
        }
    }
    class tanker : Sudno, ISudno
    {
        public tanker (int shvidkist, int obiem_palnogo)
        {
            this.name = "tanker";
            this.shvidkist = shvidkist;
            this.gruzo_pidyomnist = 50000;
            this.tip_palnogo = "Ф5";
            this.obiem_palnogo = obiem_palnogo;
        }
        public override void vivesti_tip_palnogo()
        {
            Console.WriteLine("тип пального " + tip_palnogo);
        }
        public override void dozapravka(int obiem)
        {
            obiem_palnogo += obiem;
            Console.WriteLine("пiсля дозаправки +" + obiem + " об*ем пального судна " + name + " став " + obiem_palnogo);
        }
    }
    class kater : Sudno, ISudno
    {
        public kater(int shvidkist, int obiem_palnogo)
        {
            this.name = "kater";
            this.shvidkist = shvidkist;
            this.gruzo_pidyomnist = 50;
            this.tip_palnogo = "Ф12";
            this.obiem_palnogo = obiem_palnogo;
        }
        public override void vivesti_tip_palnogo()
        {
            Console.WriteLine("тип пального " + tip_palnogo);
        }
        public override void dozapravka(int obiem)
        {
            obiem_palnogo += obiem;
            Console.WriteLine("пiсля дозаправки +" + obiem + " об*ем пального судна " + name + " став " + obiem_palnogo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Sudno> korabli = new List<Sudno>();
            korabli.Add(new vantajniy_korabel(50,1000));
            korabli.Add(new tanker(60,2000));
            korabli.Add(new kater(80,100));
            foreach (ISudno korabel in korabli)
            {
                korabel.dozapravka(20);
                korabel.vivesti_tip_palnogo();
            }
            Console.ReadKey();
        }
    }
}
