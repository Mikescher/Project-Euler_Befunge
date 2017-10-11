/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3/LNvG0iwP1i/yPTlUbXVqdvzlJoi+a3Lj8v6RJl1JZacmaK7/Otuf07ZXEnrN/zZZ+cdV4iexrfrz59Tftsevr0tcO7wz0oLK678"+
                                    "PLvaHVX/Lff8K6otFRbb/W/369X9D7+oMAiXlZWJlbEzGIQaM4yCUTAKRsEoGPzgnzcjw4w9ejJ35HS6A8KTT0zfPp3dVXBWrHr2qoXeofNfZVm8eZ31+0g2a93585ut"+
                                    "w3JN9984E/ele8axTZZS1/4XxB6I/8bdWrVmWqrMqqVnDpeUFEb23t0kFaTV171P99WmM7e/nr75LancfFrm1OPBq7oXnf9bc4u/fb3/3oIH/XuqLEPeHm7aK7k69NbU"+
                                    "j1ON+IS38DrntEX0b9Q9bSi3fJNHZfS+7LDknKDAKz+17ksmzxX7nszEf/ni27IX/L83eufKdO3eW73qcUGUSaGGf9fjO+ecNvY8rjv2ff2Hw4HBfJrnv1rKzVuvl26p"+
                                    "vrMvWfi4740pH/MS7p499OejfabZ97vdb3Nqb4b/3CLxyEjzg4Hnz617Yp9s/1T2f3VU6Pf2nZ5/lcKOCtzecu+YOz+jZzvnrad7/hg+31n1vtguPv/Tkp0Vh4u/824s"+
                                    "fMX7Q1acAQDKcaipZwcAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<1000&&y<1515)?g[y*1000+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<1000&&y<1515)g[y*1000+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1,t2,t3;
        gw(2,0,1000);
        gw(3,0,1500000);
        sa(gr(3,0));
        gw(tm(gr(3,0),gr(2,0)),(td(gr(3,0),gr(2,0)))+3,0);
    _1:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _3;else goto _2;
    _2:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(2,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,0)));

        sa(sp()+3L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
    _3:
        gw(6,0,0);
        gw(8,0,1);
        sp();
    _4:
        if(((gr(8,0)*gr(8,0)*4)+(gr(8,0)*6)+2)>gr(3,0))goto _20;else goto _5;
    _5:
        sa(gr(8,0)+1);
        gw(9,0,gr(8,0)+1);
    _6:
        sa(sr());
        t0=sr()*2;
        sa(sp()*t0);

        t1=sp();
        sa(sp()*gr(8,0)*2);

        sa(t1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());

        t0=sp();
        t0=t0>gr(3,0)?1:0;

        if((t0)!=0)goto _19;else goto _7;
    _7:
        t0=(gr(9,0)*gr(9,0))-(gr(8,0)*gr(8,0));
        gw(2,1,(gr(9,0)*gr(9,0))-(gr(8,0)*gr(8,0)));
        t1=gr(8,0)*gr(9,0)*2;
        gw(3,1,gr(8,0)*gr(9,0)*2);
        t2=(gr(9,0)*gr(9,0))+(gr(8,0)*gr(8,0));
        gw(4,1,(gr(9,0)*gr(9,0))+(gr(8,0)*gr(8,0)));
        t3=t1+t2;
        t1=t0+t3;
        gw(6,1,t1);

        if(gr(2,1)>gr(3,1))goto _18;else goto _8;
    _8:
        sa(1);
        sa(gr(6,1)>gr(3,0)?1:0);
    _9:
        if(sp()!=0)goto _17;else goto _10;
    _10:
        t0=sr()*((((gr(2,1)*7)+gr(3,1))*5)+gr(4,1));
        gw(8,1,t0);
        sa(sr()*gr(6,1));
        sa(tm(sr(),gr(2,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,0)));

        sa(sp()+3L);

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());

        if(sp()!=0)goto _13;else goto _11;
    _11:
        sp();
        sa(sr()*gr(6,1));
        sa(gr(8,1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(2,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,0)));

        sa(sp()+3L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(6,0,gr(6,0)+1);
    _12:
        sa(sp()+1L);

        sa((sr()*gr(6,1))>gr(3,0)?1:0);
        goto _9;
    _13:
        if(sr()!=gr(8,1))goto _14;else goto _16;
    _14:
        sa((sp()<0)?1:0);


        if(sp()!=0)goto _12;else goto _15;
    _15:
        sa(sr()*gr(6,1));
        sa(-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(2,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(2,0)));

        sa(sp()+3L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(6,0,gr(6,0)-1);
        goto _12;
    _16:
        sp();
        goto _12;
    _17:
        sp();
        sa(gr(9,0)+1);
        gw(9,0,gr(9,0)+1);
        goto _6;
    _18:
        t0=gr(2,1);
        gw(2,1,gr(3,1));
        gw(3,1,t0);
        goto _8;
    _19:
        gw(8,0,gr(8,0)+1);
        goto _4;
    _20:
        System.Console.Out.Write(gr(6,0)+" ");
        return;
}
}
