/* compiled with BefunCompile v1.0.2 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABAC9jz0KAjEQha+SnZhmh5hMhogECbZeYrcR0qZK6dkddxVEEGOzrxjmD977mt9AbQMPynCFTDYNus3Jc/XEFW4XwMA1By5yNoRr4wp4sJ7LSFwwxYjm"+
                                    "cFRNdWla6k5/rOdJD5VDslQ4VCaHMVYnZjIimWcznvpMVuUFgAUm84uA3whQKRkTWXnpjf9N5/2D4NfXX/HVHUV2dgFeAgAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=o.Skip(1).ToArray();for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<101&&y<6)?g[y*101+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<101&&y<6)g[y*101+x]=v;}
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
        goto _3;
    _0:
        if(sp()!=0)goto _4; else goto _8;
    _1:
        if(sp()!=0)goto _7; else goto _6;
    _2:
        if(sp()!=0)goto _10; else goto _9;
    _3:
        sa(99);
        sa(0);
        goto _0;
    _4:
        gw(3,3,199);
        sp();
        sa((0)+((gr((tm(gr(3,3),100))+(1),td(gr(3,3),100)))-(48)));
        goto _5;
    _5:
        sa(gr(3,3));
        gw(3,3,(gr(3,3))-(1));
        sa((sp()!=0)?0:1);
        goto _1;
    _6:
        sa((gr((tm(gr(3,3),100))+(1),td(gr(3,3),100)))-(48));
        sa(sp()+sp());
        goto _5;
    _7:
        System.Console.Out.Write((long)(sp()));
        return;
    _8:
        sa(sr());
        gw(0,3,sp());
        gw(1,3,0);
        gw(2,3,199);
        goto _9;
    _9:
        sa((((gr((tm(gr(2,3),100))+(1),td(gr(2,3),100)))-(48))*(gr(0,3)))+(gr(1,3)));
        gw((tm(gr(2,3),100))+(1),td(gr(2,3),100),(tm((((gr((tm(gr(2,3),100))+(1),td(gr(2,3),100)))-(48))*(gr(0,3)))+(gr(1,3)),10))+(48));
        sa(10);
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        gw(1,3,sp());
        sa((gr(2,3))-(1));
        gw(2,3,(gr(2,3))-(1));
        sa((sp()!=0)?0:1);
        goto _2;
    _10:
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _0;
}}