/* transpiled with BefunCompile v1.1.0 (c) 2015 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADt1NFOwjAUBuBXGd24WTM9HWzAQhp8AN8At5sl9bJXvTI8u6erEEKGOsVo6v8nhNK1Z+cbFJf801AsmehOYwnccMMNN9xxBG644YYb7jgCN9xwww13"+
                                    "HIEbbrjhhjuOwA033HDDHUfghhtuuOGOI3DDDTfccMcRuOGGG2644wjcyPXoRDw9Hh4OPs8zIYfkMs8VWdEcpJB5VUke96LMlSzJut9u+SaZrtj+QBcfZWqXoUexFJfN"+
                                    "7u4MyarKjvNjhbfjW/1vJCQbbWd00lJ1z/ezVF+We5d07RnrYpa67vN1RiqUZBin12Qb2q/JWH6polFF2nYZD/yb6Puwgq/tS0qM5rXKOq14t7JLspoqsvyh5mHNc2ZJ"+
                                    "Jq/IyIZPydzP2Hqo68sNZV2XkVrx8k2+8hukIjP3I9mshlLF0MJbexuyC77/gsyGjGlefOf+/HHJ4RhmTodr560Pg50+gdxx1nXttKcU0nZtOmsKdfZtTK/zreOis6C0"+
                                    "2Wnm6tovEW+2/S9ky3/OYZAkr+fUiHQoOQAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<248&&y<59)?g[y*248+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<248&&y<59)g[y*248+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1;
        gw(1,0,357913941);
        gw(10,0,9802);
        gw(2,0,201);
        sa(gr(2,0));
        gw(8,0,52);
    _1:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(8,0));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        t0=gr(8,0)-1;

        if(gr(8,0)!=2)goto _31;else goto _2;
    _2:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _3;else goto _4;
    _3:
        gw(8,0,52);
        goto _1;
    _4:
        gw(8,0,100);
        sp();
        sa(100);
        sa(gr(8,0));
        sa(100);
    _5:
        sa(gr(2,0));
        gw(gr(2,0),1,0);
    _6:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _8;else goto _7;
    _7:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _6;
    _8:
        gw(gr(2,0),1,1);
        sp();
        gw(4,0,sp());
    _9:
        gw(5,0,0);
        gw(6,0,gr(2,0));
    _10:
        t0=(gr(gr(6,0),1)*gr(4,0))+gr(5,0);
        gw(gr(6,0),1,tm((gr(gr(6,0),1)*gr(4,0))+gr(5,0),10));
        t1=gr(6,0)-1;

        if(gr(6,0)!=1)goto _30;else goto _11;
    _11:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _9;else goto _12;
    _12:
        gw(7,0,1);
        sp();
        sa(tm(gr(gr(7,0),1),gr(1,0)));
    _13:
        t0=gr(7,0)+1;
        gw(7,0,gr(7,0)+1);
        t0-=gr(2,0);
        t0--;

        if((t0)!=0)goto _29;else goto _14;
    _14:
        sa(gr(2,0));
        gw(9,0,52);
    _15:
        gw(3,0,sp());
        sa(sr());
        t0=gr(gr(3,0),gr(9,0));

        if((gr(gr(3,0),gr(9,0)))!=0)goto _16;else goto _28;
    _16:
        sa(sp()-t0);

        t1=sp();
        t1=(t1!=0)?0:1;

        if((t1)!=0)goto _22;else goto _17;
    _17:
        sa(gr(3,0));
        t0=gr(9,0)-1;

        if(gr(9,0)!=2)goto _21;else goto _18;
    _18:
        sa(sp()-1L);


        if(sr()!=1)goto _20;else goto _19;
    _19:
        return;
    _20:
        gw(9,0,52);
        goto _15;
    _21:
        gw(9,0,t0);
        goto _15;
    _22:
        gw(10,0,gr(10,0)-1);
        sp();
    _23:
        t0=gr(8,0)-1;

        if(gr(8,0)!=2)goto _27;else goto _24;
    _24:
        sa(sp()-1L);


        if(sr()!=1)goto _25;else goto _26;
    _25:
        gw(8,0,100);
        sa(sr());
        sa(gr(8,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _5;
    _26:
        System.Console.Out.Write(gr(10,0));
        sp();
        return;
    _27:
        gw(8,0,t0);
        sa(sr());
        sa(gr(8,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _5;
    _28:
        gw(gr(3,0),gr(9,0),sp());
        sp();
        goto _23;
    _29:
        sa(sp()*9L);

        sa(sp()+gr(gr(7,0),1));

        sa(tm(sp(),gr(1,0)));
        goto _13;
    _30:
        gw(6,0,t1);
        t0/=10;
        gw(5,0,t0);
        goto _10;
    _31:
        gw(8,0,t0);
        goto _1;
}
}
