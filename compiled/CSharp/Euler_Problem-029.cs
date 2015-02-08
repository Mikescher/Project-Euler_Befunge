/* compiled with BefunCompile v1.0.4 (c) 2015 */
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
static void Main(string[] args)
{
        goto _0;
    _0:
        gw(1,0,357913941);
        gw(10,0,9802);
        gw(2,0,201);
        sa(gr(2,0));
        gw(8,0,52);
        goto _21;
    _1:
        gw(8,0,100);
        sp();
        sa(100);
        sa(gr(8,0));
        sa(100);
        goto _2;
    _2:
        sa(gr(2,0));
        gw(gr(2,0),1,0);
        goto _22;
    _3:
        gw(gr(2,0),1,1);
        sp();
        gw(4,0,sp());
        goto _4;
    _4:
        gw(5,0,0);
        gw(6,0,gr(2,0));
        goto _23;
    _5:
        gw(7,0,1);
        sp();
        sa(tm((0)+(gr(gr(7,0),1)),gr(1,0)));
        goto _26;
    _6:
        sa(gr(2,0));
        gw(9,0,52);
        goto _25;
    _7:
        sp();
        gw(gr(3,0),gr(9,0),sp());
        sp();
        goto _29;
    _8:
        gw(8,0,100);
        sa(sr());
        sa(gr(8,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _2;
    _9:
        sp();
        System.Console.Out.Write((long)(gr(10,0)));
        return;
    _10:
        gw(8,0,sp());
        sa(sr());
        sa(gr(8,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _2;
    _11:
        gw(10,0,(gr(10,0))-(1));
        sp();
        goto _29;
    _12:
        gw(9,0,52);
        goto _25;
    _13:
        return;
    _14:
        gw(9,0,sp());
        goto _25;
    _15:
        sa(9);
        sa(sp()*sp());
        sa(gr(gr(7,0),1));
        sa(sp()+sp());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _26;
    _16:
        gw(6,0,sp());
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        gw(5,0,sp());
        goto _23;
    _17:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _22;
    _18:
        gw(8,0,52);
        goto _21;
    _19:
        gw(8,0,sp());
        goto _21;
    _20:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        if(sp()!=0)goto _18; else goto _1;
    _21:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(8,0));
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa((gr(8,0))-(1));
        if((((gr(8,0))-(1))-(1))!=0)goto _19;else goto _20;
    _22:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _3; else goto _17;
    _23:
        sa(((gr(gr(6,0),1))*(gr(4,0)))+(gr(5,0)));
        gw(gr(6,0),1,tm(((gr(gr(6,0),1))*(gr(4,0)))+(gr(5,0)),10));
        sa((gr(6,0))-(1));
        if(((gr(6,0))-(1))!=0)goto _16;else goto _24;
    _24:
        sp();
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        if(sp()!=0)goto _4; else goto _5;
    _25:
        gw(3,0,sp());
        sa(sr());
        sa(gr(gr(3,0),gr(9,0)));
        if((gr(gr(3,0),gr(9,0)))!=0)goto _28;else goto _7;
    _26:
        sa((gr(7,0))+(1));
        gw(7,0,(gr(7,0))+(1));
        sa(gr(2,0));
        {long v0=sp();sa(sp()-v0);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _15; else goto _6;
    _27:
        sa(gr(3,0));
        sa((gr(9,0))-(1));
        if((((gr(9,0))-(1))-(1))!=0)goto _14;else goto _30;
    _28:
        {long v0=sp();sa(sp()-v0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _11; else goto _27;
    _29:
        sa((gr(8,0))-(1));
        if((((gr(8,0))-(1))-(1))!=0)goto _10;else goto _31;
    _30:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _12; else goto _13;
    _31:
        sp();
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _8; else goto _9;
}}