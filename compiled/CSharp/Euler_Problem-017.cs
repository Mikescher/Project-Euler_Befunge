/* compiled with BefunCompile v1.0.2 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACVkEFuwyAQRa8yBmcDcgOGAYoQ6kGQ3UUlb7Ni5dy92E5lEiVWMxvg8/7MhwzvlVAKtVaIWhnjnLWfzplD3hhEtOYIqqp9M8/C505WSoBHKVS3ETWL"+
                                    "3ns5EUG6JC90GG9Sv0n9Za74/GIuYz2SHwIC2jb8g39R4dGyNosekZ/7KZXldN/c3/sLqdn3HjiWTGc5WfHHR5Gib2gefblJhRzEJMNiLOdTM1et1zR5z7X1J1fiWFd+"+
                                    "qVVO5NVWBiRY7Bs8HD/vtksq2WUup5A8hZHvVALZPff7+ble1dcHH4E2QH0CysMve1WrzNACAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=o.Skip(1).ToArray();for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<48&&y<15)?g[y*48+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<48&&y<15)g[y*48+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static readonly System.Random r = new System.Random();
private static bool rd(){ return r.Next(2)!=0; }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        goto _10;
    _0:
        if(sp()!=0)goto _30; else goto _11;
    _1:
        if(sp()!=0)goto _29; else goto _12;
    _2:
        if(sp()!=0)goto _13; else goto _20;
    _3:
        if(sp()!=0)goto _14; else goto _15;
    _4:
        if(sp()!=0)goto _16; else goto _17;
    _5:
        if(sp()!=0)goto _19; else goto _18;
    _6:
        if(sp()!=0)goto _26; else goto _21;
    _7:
        if(sp()!=0)goto _28; else goto _27;
    _8:
        if(sp()!=0)goto _22; else goto _25;
    _9:
        if(sp()!=0)goto _24; else goto _23;
    _10:
        gw(20,1,(gr(20,1))-(48));
        sa(20);
        sa(20);
        goto _0;
    _11:
        gw(20,2,(gr(20,2))-(48));
        sa(20);
        sa(20);
        goto _1;
    _12:
        sp();
        sp();
        sa(0);
        sa(1000);
        sa(0);
        sa(1000);
        sa(0);
        goto _2;
    _13:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        goto _3;
    _14:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _13;
    _15:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        goto _4;
    _16:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _2;
    _17:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _5;
    _18:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _17;
    _19:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _20:
        sa(sr());
        sa(100);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _6;
    _21:
        sa(sr());
        sa(1000);
        {long v0=sp();sa(sp()-v0);}
        goto _8;
    _22:
        sa(sr());
        sa(100);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa((sp()!=0)?0:1);
        goto _9;
    _23:
        sa(sr());
        sa(100);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(100);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(7);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(3);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _2;
    _24:
        sa(100);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(7);
        sa(0);
        sa(1);
        goto _2;
    _25:
        sp();
        sa(3);
        sa(8);
        sa(0);
        sa(1);
        goto _2;
    _26:
        sa(sr());
        sa(20);
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _7;
    _27:
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(0);
        sa(1);
        goto _2;
    _28:
        sa(sr());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _2;
    _29:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(sr());
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
    _30:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(sr());
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(48);
        {long v0=sp();sa(sp()-v0);}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _0;
}}