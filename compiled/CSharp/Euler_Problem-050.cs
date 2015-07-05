/* compiled with BefunCompile v1.0.6 (c) 2015 */
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
static void Main(string[] args)
{
        gw(1L,0L,2000L);
        gw(2L,0L,500L);
        gw(0L,0L,1000000L);
        gw(3L,0L,2L);
        gw(0L,3L,32L);
        gw(1L,3L,32L);
    _1:
        gw(tm(gr(3L,0L),gr(1L,0L)),(td(gr(3L,0L),gr(1L,0L)))+1L,88L);
        sa(gr(3L,0L)+gr(3L,0L));
        sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
    _2:
        if(sp()!=0)goto _31;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-32L);
        if(sp()!=0)goto _6;else goto _4;
    _6:
        if(gr(0L,0L)>gr(3L,0L))goto _1;else goto _7;
    _7:
        gw(4L,0L,0L);
        gw(3L,0L,0L);
    _8:
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-88L);
        if(sp()!=0)goto _8;else goto _10;
    _10:
        sa(gr(3L,0L));
        sa(gr(4L,0L));
        gw(4L,0L,gr(4L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        if(gr(0L,0L)>gr(3L,0L))goto _8;else goto _11;
    _11:
        sa(0L);
        sa(gr(4L,0L)-1L);
        gw(4L,0L,gr(4L,0L)-1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(6L,0L,0L);
        gw(7L,0L,-1L);
        gw(8L,0L,0L);
        gw(9L,0L,1L);
    _12:
        sa(gr(7L,0L)+1L);
        gw(7L,0L,gr(7L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()+gr(8L,0L));
        if(sr()<gr(0L,0L))goto _13;else goto _14;
    _13:
        gw(8L,0L,sp());
        goto _12;
    _14:
        gw(7L,0L,gr(7L,0L)-1L);
        sp();
    _15:
        sa(gr(8L,0L));
        gw(5L,0L,gr(4L,0L));
    _16:
        sa(sr());
        sa(gr(5L,0L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-gr(tm(gr(5L,0L),gr(1L,0L)),(td(gr(5L,0L),gr(1L,0L)))+1L));
        if(sp()!=0)goto _18;else goto _17;
    _17:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _18:
        if(sp()!=0)goto _30;else goto _19;
    _19:
        sp();
        if(0L>(gr(6L,0L)+gr(9L,0L)))goto _20;else goto _24;
    _20:
        if(gr(9L,0L)!=1L)goto _21;else goto _23;
    _21:
        gw(8L,0L,gr(8L,0L)-gr(tm(gr(7L,0L),gr(1L,0L)),(td(gr(7L,0L),gr(1L,0L)))+1L));
        gw(7L,0L,gr(7L,0L)-1L);
    _22:
        gw(9L,0L,gr(9L,0L)*-1L);
        goto _15;
    _23:
        gw(8L,0L,gr(8L,0L)-gr(tm(gr(6L,0L),gr(1L,0L)),(td(gr(6L,0L),gr(1L,0L)))+1L));
        gw(6L,0L,gr(6L,0L)+1L);
        goto _22;
    _24:
        if(gr(9L,0L)!=1L)goto _29;else goto _25;
    _25:
        sa((gr(8L,0L)-gr(tm(gr(6L,0L),gr(1L,0L)),(td(gr(6L,0L),gr(1L,0L)))+1L))+gr(tm(gr(7L,0L)+1L,gr(1L,0L)),(td(gr(7L,0L)+1L,gr(1L,0L)))+1L));
        sa(((gr(8L,0L)-gr(tm(gr(6L,0L),gr(1L,0L)),(td(gr(6L,0L),gr(1L,0L)))+1L))+gr(tm(gr(7L,0L)+1L,gr(1L,0L)),(td(gr(7L,0L)+1L,gr(1L,0L)))+1L))>=gr(0L,0L)?1:0);
    _26:
        if(sp()!=0)goto _27;else goto _28;
    _27:
        sp();
        goto _20;
    _28:
        gw(8L,0L,sp());
        sa(gr(9L,0L));
        gw(6L,0L,gr(9L,0L)+gr(6L,0L));
        sa(sp()+gr(7L,0L));
        gw(7L,0L,sp());
        goto _15;
    _29:
        sa((gr(8L,0L)+gr(tm(gr(6L,0L)-1L,gr(1L,0L)),(td(gr(6L,0L)-1L,gr(1L,0L)))+1L))-gr(tm(gr(7L,0L),gr(1L,0L)),(td(gr(7L,0L),gr(1L,0L)))+1L));
        sa(((gr(8L,0L)+gr(tm(gr(6L,0L)-1L,gr(1L,0L)),(td(gr(6L,0L)-1L,gr(1L,0L)))+1L))-gr(tm(gr(7L,0L),gr(1L,0L)),(td(gr(7L,0L),gr(1L,0L)))+1L))>=gr(0L,0L)?1:0);
        goto _26;
    _30:
        gw(5L,0L,gr(5L,0L)-1L);
        goto _16;
    _31:
        sa(sr());
        sa(32L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3L,0L));
        sa(sr()<gr(0L,0L)?1:0);
        goto _2;
}}