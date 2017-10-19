/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADtlk1r4zAQhv/KRE6hRHgzIztNGYzopfceezBO2N0wUFo6hF2dsv+946Q0DTFNadmc9CALydY7X5LACXvAGkyncLd+flj9+gO3fx9Xayj7+c/H1RPM"+
                                    "5/At7rd8z8YpinPwf1M4ZyaZTCaTyWQymfNwlj/ICG7lgAkVCDigTmrUUKE6cIxBKWhKWLEnwap5U6Gt6AcY2bRy0Vo3DV7cvSuLtOAKhcnbIk62Kp2Oo4kFaAFsWadd"+
                                    "5ouuWJpPwbrZlNZbCAcC9WEqSO2FdX1g0Xxv3e7DUZtHezzXKO3yVWnxjbt4EDW4chPHvXqGai8nkUrGdm+r9vpREt37YLjta2chdcdZHqoWqeCBBUnx2v12ivOJ+3fp"+
                                    "xqer9yHN4Fv8gqWIV6QVSbTaLPttrv2MpJUrEm9fjisUyTORYrCnIo2mtQpL2QbhmpRIlqPJyCzZqCYpeUa6edV2JR3ZG8zmuMx7rMIjO0VzoXAgjGQeLZrdvsZxoD4J"+
                                    "pk+c1AGfdnZp26SAHwXc7K+uUmU3h6rGLpJXX9tQaHhDjBfnT8AoYw8AAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<101&&y<39)?g[y*101+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<101&&y<39)g[y*101+x]=v;}
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0,t1,t2;
        gw(1,0,101);
        gw(2,0,1);
        gw(4,0,101);
        gw(3,0,2);
        gw(0,2,32);
        gw(1,2,32);
    _1:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+2,88);
        sa(gr(3,0)+gr(3,0));
        sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
    _2:
        if(sp()!=0)goto _28;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3,0)+1);
        sa(gr(3,0)+1);
        gw(3,0,gr(3,0)+1);
        sa(tm(sp(),gr(1,0)));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+2L);

        {long v0=sp();t0=gr(sp(),v0);}
        t0-=32;
        if((t0)!=0)goto _6;else goto _4;
    _6:
        if(gr(4,0)>gr(3,0))goto _1;else goto _7;
    _7:
        gw(3,0,0);
        sa(0);
        sa(gr(0,2)-88);
    _8:
        if(sp()!=0)goto _9;else goto _27;
    _9:
        sa(sp()+1L);


        if((sr()-gr(4,0))!=0)goto _26;else goto _10;
    _10:
        sp();
        sa(gr(3,0));
        gw(5,0,gr(3,0));
        sa(sp()*gr(1,0));
    _11:
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+4L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        if(sp()!=0)goto _11;else goto _13;
    _13:
        gw(7,0,5000);
        gw(8,0,100);
        gw(1,1,1);
        sp();
        sa(1);
    _14:
        gw(2,1,0);
        gw(3,1,0);
    _15:
        t0=gr(3,1)-gr(5,0);
        t1=gr(gr(3,1),2);
        gw(4,1,gr(gr(3,1),2));
        t1=t1>gr(1,1)?1:0;
        t1=(t1!=0)?0:1;
        t2=t0*t1;

        if((t2)!=0)goto _16;else goto _23;
    _16:
        t0=gr(1,1)-gr(4,1);
        gw(5,1,gr(1,1)-gr(4,1));

        if((t0)!=0)goto _17;else goto _22;
    _17:
        gw(6,1,0);
        sa(gr(3,1));
        sa(gr(3,1)<0?1:0);
    _18:
        if(sp()!=0)goto _20;else goto _19;
    _19:
        sa(sr()+4);
        sa(gr(5,1));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();t0=gr(sp(),v0);}
        t0+=gr(6,1);
        gw(6,1,t0);
        sa(sp()-1L);

        sa(sr()<0?1:0);
        goto _18;
    _20:
        t0=gr(2,1)+gr(6,1);
        gw(gr(1,1),gr(3,1)+4,gr(6,1));
        gw(2,1,t0);
        sp();
    _21:
        gw(3,1,gr(3,1)+1);
        goto _15;
    _22:
        gw(gr(1,1),gr(3,1)+4,1);
        goto _21;
    _23:
        if(gr(2,1)>gr(7,0))goto _24;else goto _25;
    _24:
        System.Console.Out.Write(gr(1,1)+" ");
        return;
    _25:
        sa(sp()+1L);

        sa(sr());
        gw(1,1,sp());
        goto _14;
    _26:
        sa(sr());
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+2L);

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-88L);
        goto _8;
    _27:
        sa(sr());
        sa(gr(3,0));
        sa(gr(3,0));
        gw(3,0,gr(3,0)+1);
        sa(tm(sp(),gr(1,0)));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+2L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _9;
    _28:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1,0)));

        sa(sp()+2L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3,0));

        sa(sr()<gr(4,0)?1:0);
        goto _2;
}
}
