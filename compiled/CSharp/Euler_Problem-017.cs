/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABACVkEFuwyAQRa8yBmcDcgOGAYoQ6kGQ3UUlb7Ni5dy92E5lEiVWMxvg8/7MhwzvlVAKtVaIWhnjnLWfzplD3hhEtOYIqqp9M8/C505WSoBHKVS3ETWL"+
                                    "3ns5EUG6JC90GG9Sv0n9Za74/GIuYz2SHwIC2jb8g39R4dGyNosekZ/7KZXldN/c3/sLqdn3HjiWTGc5WfHHR5Gib2gefblJhRzEJMNiLOdTM1et1zR5z7X1J1fiWFd+"+
                                    "qVVO5NVWBiRY7Bs8HD/vtksq2WUup5A8hZHvVALZPff7+ble1dcHH4E2QH0CysMve1WrzNACAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<48&&y<15)?g[y*48+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<48&&y<15)g[y*48+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(20L,1L,gr(20L,1L)-48L);
        sa(19L);
    _1:
        sa(sr());
        sa(sr());
        sa(sr());
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        if(sp()!=0)goto _24;else goto _2;
    _2:
        gw(20L,2L,gr(20L,2L)-48L);
        sa(19L);
    _3:
        sa(sr());
        sa(sr());
        sa(sr());
        sa(2L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        if(sp()!=0)goto _23;else goto _4;
    _4:
        sp();
        sp();
        sa(0L);
        sa(1000L);
        sa(0L);
        sa(1000L);
    _5:
        if(sr()<100L)goto _6;else goto _18;
    _6:
        if(sr()>20L)goto _17;else goto _7;
    _7:
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()+0L);
    _8:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        if(sp()!=0)goto _16;else goto _9;
    _9:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);
        sa(sr());
        if(sp()!=0)goto _13;else goto _10;
    _10:
        sa(sp()+sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _11;else goto _12;
    _11:
        sa(sp()+sp());
        System.Console.Out.Write((long)(sp()));
        return;
    _12:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _10;
    _13:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
    _14:
        if(sp()!=0)goto _15;else goto _5;
    _15:
        sa(sp()+sp());
        goto _8;
    _16:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+sp());
        goto _8;
    _17:
        sa(td(sr(),10L));
        sa(2L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),10L));
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _14;
    _18:
        if(sr()!=1000L)goto _20;else goto _19;
    _19:
        sp();
        sa(3L);
        sa(8L);
        goto _8;
    _20:
        if(tm(sr(),100L)==0)goto _22;else goto _21;
    _21:
        sa(td(sr(),100L));
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),100L));
        sa(7L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(3L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _14;
    _22:
        sa(td(sp(),100L));
        sa(1L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(7L);
        goto _8;
    _23:
        sa(sp()-1L);
        goto _3;
    _24:
        sa(sp()-1L);
        goto _1;
}}