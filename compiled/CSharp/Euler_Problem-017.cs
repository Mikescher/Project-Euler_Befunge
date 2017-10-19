/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        gw(20,1,gr(20,1)-48);
        sa(20);
        sa(20);
    _1:
        if(sp()!=0)goto _23;else goto _2;
    _2:
        gw(20,2,gr(20,2)-48);
        sa(20);
        sa(20);
    _3:
        if(sp()!=0)goto _22;else goto _4;
    _4:
        sp();
        sp();
        sa(0);
        sa(1000);
        sa(0);
        sa(1000);
        sa(0);
    _5:
        if(sp()!=0)goto _6;else goto _13;
    _6:
        sa(sp()+sp());

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _12;else goto _7;
    _7:
        sa(sp()+sp());

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _11;else goto _8;
    _8:
        sa(sp()+sp());

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());

        if(sp()!=0)goto _10;else goto _9;
    _9:
        sa(sp()+sp());

        System.Console.Out.Write("{0} ", (long)(sp()));
        return;
    _10:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _8;
    _11:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _5;
    _12:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _6;
    _13:
        if(sr()<100)goto _14;else goto _17;
    _14:
        if(sr()>20)goto _15;else goto _16;
    _15:
        sa(gr(sr()/10,2));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()%10L);

        sa(sr());
        sa((sp()!=0)?0:1);
        goto _5;
    _16:
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(0);
        sa(1);
        goto _5;
    _17:
        if(sr()!=1000)goto _19;else goto _18;
    _18:
        sp();
        sa(3);
        sa(8);
        sa(0);
        sa(1);
        goto _5;
    _19:
        if((sr()%100)!=0)goto _20;else goto _21;
    _20:
        sa(gr(sr()/100,1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()%100L);

        sa(7);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(3);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _5;
    _21:
        sa(sp()/100L);

        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(7);
        sa(0);
        sa(1);
        goto _5;
    _22:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        sa(sr());
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _3;
    _23:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        sa(sr());
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-48L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
}
}
