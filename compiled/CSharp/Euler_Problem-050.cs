/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3z+ZddhBhuxBumLer07Pa99/ahI2J5ye5Tg1zMBViSgydIMp/3kJXVHMLb1CLw5zNM458O6Oy+3X+sXsi2/38u8PD59+L3/c3Zs+f"+
                                    "Tw8/rZL4ejzfLqZOZ1kgA0P9WmWGUTAKRsGQBw/2hzIw/N+zrSbcb9nhxGB387P3289uftEmeHdzYUlqoJnhu1eF23fmV/gs6r6zNff4xFerTsZ/Dnn5Q8d8eenUU9ef"+
                                    "vsgonqfvp2Raanpz7z3XJTVvlcp3vldnaDj+JtI1fL9d7T67XR6GfoKrv77vv/dW6PdfYYYH6rl8Fx7bWf6fMPNz4fxtq9Xan2/unt1n6cj/7vQDV8tfv05LN+tNK80T"+
                                    "mzj754p39mk7V766LPL1ZmHeLD21syv8DG8ufsHM8D1z+sRTz11/fnl5svv982vWpt/XxFec//qtkWdflcqL54vWJTAfuL9ubv7m33/8yuLvPPuz+Gvl/dQp1TxvpjIf"+
                                    "UMzdNWPZjCURMgWXjk/64RXC3uCcNTuT7/zlu7JfrthPsrPQjLvzcvbhb2v6b1jXrv559+DsUvHTDzXkjxVtvWvhb/g+ydDLvPvH0TJR+/k+YQ8ZHzC8y+l8vuVe+P2X"+
                                    "r/bIuqy7e9oj9L/RzU36j+O/z9m8Ny6hftJx3a4Xn26o+YeeXXR6qf30/3l3857fLrtXHsTwQCHv0888if33zO5zvtn+naP538FdM0J/8iV+S7az11v3+aePHXuD/TLb"+
                                    "Lzva48LYGequmxvfy89nWMDPAADs11TW6AUAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<2000&&y<512)?g[y*2000+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2000&&y<512)g[y*2000+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(1,0,2000);
        gw(2,0,500);
        gw(0,0,1000000);
        gw(3,0,2);
        gw(0,3,32);
        gw(1,3,32);
    _1:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
    _2:
        if(sp()!=0)goto _31;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3,0)+1);
        gw(3,0,gr(3,0)+1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+1L);

        {long v0=sp();t0=gr(sp(),v0);}
        t0-=32;
        if((t0)!=0)goto _6;else goto _4;
    _6:
        if(gr(0,0)>gr(3,0))goto _1;else goto _7;
    _7:
        gw(4,0,0);
        gw(3,0,0);
    _8:
        sa(gr(3,0)+1);
        gw(3,0,gr(3,0)+1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+1L);

        {long v0=sp();t0=gr(sp(),v0);}
        t0-=88;
        if((t0)!=0)goto _8;else goto _10;
    _10:
        sa(gr(3,0));
        sa(gr(4,0));
        gw(4,0,gr(4,0)+1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+1L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}

        if(gr(0,0)>gr(3,0))goto _8;else goto _11;
    _11:
        sa(0);
        sa(gr(4,0)-1);
        gw(4,0,gr(4,0)-1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+1L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(6,0,0);
        gw(7,0,-1);
        gw(8,0,0);
        gw(9,0,1);
    _12:
        sa(gr(7,0)+1);
        gw(7,0,gr(7,0)+1);
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+1L);

        {long v0=sp();t0=gr(sp(),v0);}
        t0+=gr(8,0);

        if(t0<gr(0,0))goto _30;else goto _13;
    _13:
        gw(7,0,gr(7,0)-1);
    _14:
        sa(gr(8,0));
        gw(5,0,gr(4,0));
    _15:
        sa(sr());
        t0=gr(5,0);
        sa(sp()-gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+1));


        if(sp()!=0)goto _17;else goto _16;
    _16:
        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _17:
        if((t0)!=0)goto _29;else goto _18;
    _18:
        sp();

        if(0>(gr(6,0)+gr(9,0)))goto _19;else goto _23;
    _19:
        if(gr(9,0)!=1)goto _20;else goto _22;
    _20:
        gw(8,0,gr(8,0)-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1));
        gw(7,0,gr(7,0)-1);
    _21:
        gw(9,0,gr(9,0)*-1);
        goto _14;
    _22:
        gw(8,0,gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1));
        gw(6,0,gr(6,0)+1);
        goto _21;
    _23:
        if(gr(9,0)!=1)goto _28;else goto _24;
    _24:
        sa((gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1))+gr(tm(gr(7,0)+1,gr(1,0)),(td(gr(7,0)+1,gr(1,0)))+1));
        sa(((gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1))+gr(tm(gr(7,0)+1,gr(1,0)),(td(gr(7,0)+1,gr(1,0)))+1))>=gr(0,0)?1:0);
    _25:
        if(sp()!=0)goto _26;else goto _27;
    _26:
        sp();
        goto _19;
    _27:
        gw(8,0,sp());
        t0=gr(9,0);
        gw(6,0,gr(9,0)+gr(6,0));
        t0+=gr(7,0);
        gw(7,0,t0);
        goto _14;
    _28:
        sa((gr(8,0)+gr(tm(gr(6,0)-1,gr(1,0)),(td(gr(6,0)-1,gr(1,0)))+1))-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1));
        sa(((gr(8,0)+gr(tm(gr(6,0)-1,gr(1,0)),(td(gr(6,0)-1,gr(1,0)))+1))-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1))>=gr(0,0)?1:0);
        goto _25;
    _29:
        gw(5,0,gr(5,0)-1);
        goto _15;
    _30:
        gw(8,0,t0);
        goto _12;
    _31:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+1L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3,0));

        sa(sr()<gr(0,0)?1:0);
        goto _2;
}
}
