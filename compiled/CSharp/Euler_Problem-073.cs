/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "Ah+LCAAAAAAABADt3N1Lk3EYxvHf6IEk6jGJRtLLBlYkJLPC5cjcZhi9sbIZi9FwEQ6D5kFWY5os1pspEkEr6syoDgIbUimijIWkEiwRlCcnix10VNtBg2m6YjX/hzGQ"+
                                    "7+foPrq5ji9ubk1PkciRROJLn2xybjFN25b0c5L58bUGl2+f60CNsdvmbLOMJHf82tPdojSfGlNHal9VpUYy5ZGGgErctCn1M0+HjP93xCf2CwAAAAAAsOpUz91eo8oN"+
                                    "2qxy9Mw5AAAAAACw2l0slqVcF3DrT9NWc6HDAAAAAACAvLt7uHrjyoVAyueWCh0GAAAAAADk3eaFuGmlC5jMfihpLHQaAAAAAACQd9Ggb1bya+Vw8IVn3cdd0wZDdtvV"+
                                    "72Z/1N0RCIQ69AM95XXPT8Yzzq8xjfXKwfUFemwAAAAA5FlaEr8Xl3/ceKsuGXtTcb00c0iEdRfutahnrdbOkLy495On/75mpwgXLR9zvHQNP+ibf2LXlaVju1PzXnuT"+
                                    "xbHJG+odtXjbk55HZSmvz3i2s6b/RKM9kRaVr3+2PYvELn1T3h3/25ytlQdOGxYMg0cSn93KhssO/3D9djE+MxWd1AWLlyYSoalka5c+0Dta9V4Vf9i+1pI5X6q906r6"+
                                    "B8tNsPstXAAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<2000&&y<12010)?g[y*2000+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2000&&y<12010)g[y*2000+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(1,1,12000);
        gw(5,1,0);
        gw(2,1,2000);
        gw(6,1,1);
        gw(7,1,1);
        sa(1);
        sa(1);
        sa(1>=gr(6,1)?1:0);
    _1:
        if(sp()!=0)goto _7;else goto _2;
    _2:
        sa(tm(sr(),gr(2,1)));
        sa(gr(7,1)+3);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;

        if((t0)!=0)goto _6;else goto _3;
    _3:
        gw(5,1,gr(5,1)+1);
        sa(sr());
        gw(8,1,sp());
        gw(9,1,gr(7,1));
    _4:
        if(((gr(8,1)>gr(1,1)?1:0)+(gr(9,1)>gr(1,1)?1L:0L))!=0)goto _6;else goto _5;
    _5:
        gw(tm(gr(8,1),gr(2,1)),gr(9,1)+3,0);
        t0=sr()+gr(8,1);
        gw(8,1,t0);
        gw(9,1,gr(7,1)+gr(9,1));
        goto _4;
    _6:
        sa(sp()+1L);

        sa(sr()>=gr(6,1)?1:0);
        goto _1;
    _7:
        sp();

        if(sr()!=gr(1,1))goto _9;else goto _8;
    _8:
        System.Console.Out.Write(gr(5,1)+" ");
        sp();
        return;
    _9:
        sa(sp()+1L);

        t0=td(sr()+1,2);
        gw(6,1,t0);
        sa(sr());
        gw(7,1,sp());
        sa((td(sr(),3))+1);
        sa(sr()>=gr(6,1)?1:0);
        goto _1;
}
}
