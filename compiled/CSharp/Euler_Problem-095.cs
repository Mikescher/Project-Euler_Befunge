/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "Ah+LCAAAAAAABADt0OtLU3EcBvCfd7volAQp2OaKigpdYl5I54glEUqFUStZ6pBminlLnE7zSIG+8AZmC29bvskXRgsrZm257CALbGosXXI82+Skh3nZpsep03mW9qJ/"+
                                    "ot/z4sPzhe+rh90UDPbjD1ZmDcXYbd/6H0JxdH4eevNZ4akTI2EHf58cDJtdHrqfmHXGkdqOSNp/RksCH/TYpKG5ma8OdGYHK+3zH0LRp1Nvfem1htOqx8wvSsd6pjfK"+
                                    "GcZxTsbWbkU5b+yXlPV7Vs4lax8hfpJt7dsrAivn8t7pnrcHMHx8GUxfBuef6M6mI4B13J91sfnvlwAKhUKhUCgUCoVCoVAoFAqFQqHQ/948AGhZZaQyhi6LL5Y35XAT"+
                                    "hMYCr804ESkULhnKk6/1q5Ryl4RlUag1q5IajaW12603uOj3Ne8ON5poP1BvkXEmpTqpvUyj7UwkaJk5g69gFW2qMQvvKKjiEehGKY/W4GieVkW6kpDwdfEACZyIWM00"+
                                    "jVWYx4WYS2JGRLiuwrxYfqd3sc4zbQoCHoYd+SgKQXJCGvmiYmlcyTS2tLq2xj82wparCS2SP8QAqnk3yxMZa2ZWUsTZT9VdcpQa4W5oJhxmB91k8QceWyVamcVFyXSC"+
                                    "ZLdqxFkTmFQ9lsRqwC8YMKxNjxMRdAGyPWdYXUvReYsR2aHS7YUmUsTju2RdeqWcukpgaVYfa3d1BmWM8LjntIps0RWvasbdv4uvnJ/ls3+1LJXNtBq1urvXxwQmsk1P"+
                                    "TKW84dvzj2wAZ8tKjF5NWerobeeukf812oiX6noCbSULKr/PyfG7Gx0URqZV5yhzv4UCywvcLSgaj6PIzp0CqlRAj4662kIZD/nm78YqRdBW4WsGqI2kX86j6fhw8jix"+
                                    "nXhu2cUEw9zNvb2prepEYjCDcA3xWsYtvQlGnLs5wFakAnK1gxoxDecC6yOvf/jznuZb0WzwB1p9toPEGQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<2017&&y<1013)?g[y*2017+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2017&&y<1013)g[y*2017+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1;
        gw(1,9,1000);
        gw(2,9,1017);
        gw(3,9,1000000);
        gw(1,2,0);
        gw(1,4,0);
        gw(1,5,gr(3,9));
        sa(gr(3,9)-1);
        gw((td(gr(3,9)-1,gr(1,9)))+9,tm(gr(3,9)-1,gr(1,9)),0);
    _1:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((td(sr(),gr(1,9)))+gr(2,9));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),gr(1,9)));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());

        if(sp()!=0)goto _28;else goto _2;
    _2:
        gw(1,3,1);
        sp();
        sa(1);
    _3:
        sa(2);
        sa(2*gr(1,3));
        sa((2*gr(1,3))<gr(3,9)?1:0);
    _4:
        if(sp()!=0)goto _27;else goto _5;
    _5:
        sp();
        sp();
        sa(sp()+1L);


        if(sr()!=gr(3,9))goto _6;else goto _7;
    _6:
        sa(sr());
        gw(1,3,sp());
        goto _3;
    _7:
        gw(2,3,6);
        sp();
        sa(((gr((td(6,gr(1,9)))+9,tm(6,gr(1,9))))!=0)?0:1);
    _8:
        if(sp()!=0)goto _12;else goto _9;
    _9:
        sa(gr(2,3)+1);

        if((gr(2,3)+1)!=gr(3,9))goto _10;else goto _11;
    _10:
        sa(sr());
        gw(2,3,sp());
        sa((td(sr(),gr(1,9)))+9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),gr(1,9)));

        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        goto _8;
    _11:
        System.Console.Out.Write(gr(1,5)+" ");
        sp();
        return;
    _12:
        sa(gr(2,3));
        gw(7,0,gr(2,3));
        gw(1,2,1);
        sa((td(sr(),gr(1,9)))+gr(2,9));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),gr(1,9)));

        {long v0=sp();t0=gr(sp(),v0);}
        gw(2,2,t0);
    _13:
        t0=gr(2,2);

        if(gr(2,2)>0)goto _14;else goto _9;
    _14:
        if(t0<gr(3,9))goto _15;else goto _9;
    _15:
        if(t0!=gr(2,3))goto _16;else goto _9;
    _16:
        gw(3,1,0);
        gw(3,2,0);
        sa(0);
        sa(gr(7,0)-gr(2,2));
    _17:
        if(sp()!=0)goto _23;else goto _18;
    _18:
        gw(3,1,1);
        sa(sr());
        t0=gr(1,2);
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}

        t1=sp();
        gw(3,2,t1);

        if(gr(3,2)>gr(1,4))goto _22;else goto _19;
    _19:
        sp();

        if((gr(3,1))!=0)goto _9;else goto _20;
    _20:
        if((gr((td(gr(2,2),gr(1,9)))+9,tm(gr(2,2),gr(1,9))))==0)goto _21;else goto _9;
    _21:
        sa(gr(2,2));
        sa(gr(2,2));
        sa(7);
        sa(gr(1,2));
        gw(1,2,gr(1,2)+1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((td(sr(),gr(1,9)))+9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),gr(1,9)));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(2,2,gr((td(gr(2,2),gr(1,9)))+gr(2,9),tm(gr(2,2),gr(1,9))));
        goto _13;
    _22:
        gw(1,4,gr(3,2));
        sa(sr());
        sa(7);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();t0=gr(sp(),v0);}
        gw(1,5,t0);
    _23:
        sa(sr());
        sa(7);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();t0=gr(sp(),v0);}
        t0=t0<gr(1,5)?1:0;
        t0*=gr(3,1);

        if((t0)!=0)goto _26;else goto _24;
    _24:
        sa(sp()+1L);


        if(sr()!=gr(1,2))goto _25;else goto _19;
    _25:
        sa(sr());
        sa(7);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-gr(2,2));
        goto _17;
    _26:
        sa(sr());
        sa(7);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();t0=gr(sp(),v0);}
        gw(1,5,t0);
        goto _24;
    _27:
        sa(sr());
        sa((td(sr(),gr(1,9)))+gr(2,9));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),gr(1,9)));

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()+gr(1,3));

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((td(sr(),gr(1,9)))+gr(2,9));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),gr(1,9)));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+1L);

        sa(sr()*gr(1,3));
        sa(sr()<gr(3,9)?1:0);
        goto _4;
    _28:
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((td(sr(),gr(1,9)))+9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sp(),gr(1,9)));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _1;
}
}
