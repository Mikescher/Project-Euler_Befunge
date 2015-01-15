/* compiled with BefunCompile v1.0.2 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABAC9VMtqw0AM/JUhySnGRVp5X6GYfkhJevPVp3x/R17ogxjakrjCOCvh7OxoRns4jNGOEJlFJu0Df1XmUWWy4ymw1E072fUxdsdX7T4LHb9Ysln9feKf"+
                                    "mPba768XLk4fWzG/4jZyXCnivFb8ZTzf5Gu4NSINN9W1Lx93Eg/NGDJKuHvzEYe/nFYLLKJkqHzdhGKHvom2iN2EbYvQUT7P2xr9Sd7G/fnSj99Ep8RN3iY3zTK3XHR6"+
                                    "egkCGZwvWadVre8Se03uxrdCFMHcYGKwW623iVIgATkjG4SUDSn/B26t3l62OvAACZqQBfV+m/0Ug/oTEmJCMQyCIg5ttj1uQQ4ORGsZF9lZV3agbogb6ShCD97tEDEY"+
                                    "qiIG1Iyo0M1sxpaqOlnq29zFmyRzqKl78XXcxmZklxeCtqCQICtkHQuiIGTvNoV4ePjgJPcz2ZXqbeccmSzEE1L1q4xmM30wriNSzbJQ4wjXZY6K41bzJvhJljstPNTh"+
                                    "73sJfUqABwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=o.Skip(1).ToArray();for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<120&&y<16)?g[y*120+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<120&&y<16)g[y*120+x]=v;}
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
        goto _5;
    _0:
        if(sp()!=0)goto _16; else goto _7;
    _1:
        if(sp()!=0)goto _15; else goto _8;
    _2:
        if(sp()!=0)goto _9; else goto _12;
    _3:
        if(sp()!=0)goto _9; else goto _13;
    _4:
        if((((gr(gr(1,0),(gr(2,0))+(2)))-(gr((gr(1,0))+(1),(gr(2,0))+(2))))>(0)?1:0)!=0)goto _14;else goto _10;
    _5:
        gw(0,0,15);
        gw(2,0,(gr(0,0))-(1));
        gw(1,0,0);
        gw(gr(1,0),(gr(2,0))+(1),(((gr((gr(1,0))*(3),(gr(2,0))+(1)))-(48))*(10))+((gr(((gr(1,0))*(3))+(1),(gr(2,0))+(1)))-(48)));
        sp();
        sp();
        goto _6;
    _6:
        sa((gr(1,0))+(1));
        gw(1,0,(gr(1,0))+(1));
        sa(gr(2,0));
        {long v0=sp();sa(sp()-v0);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        goto _0;
    _7:
        sa(gr(2,0));
        gw(2,0,(gr(2,0))-(1));
        gw(1,0,0);
        goto _1;
    _8:
        sa((gr(0,0))-(2));
        gw(1,0,(gr(0,0))-(2));
        gw(2,0,sp());
        goto _9;
    _9:
        sa(gr(gr(1,0),(gr(2,0))+(1)));
        sa(gr(gr(1,0),(gr(2,0))+(2)));
        sa((gr(gr(1,0),(gr(2,0))+(2)))-(gr((gr(1,0))+(1),(gr(2,0))+(2))));
        goto _4;
    _10:
        {long v0=sp();sa(sp()-v0);}
        goto _11;
    _11:
        sa(sp()+sp());
        gw(gr(1,0),(gr(2,0))+(1),sp());
        sa(gr(1,0));
        gw(1,0,(gr(1,0))-(1));
        goto _2;
    _12:
        sa(gr(2,0));
        sa((gr(2,0))-(1));
        gw(2,0,(gr(2,0))-(1));
        gw(1,0,sp());
        goto _3;
    _13:
        System.Console.Out.Write((long)(gr(0,1)));
        return;
    _14:
        sp();
        goto _11;
    _15:
        gw(gr(1,0),(gr(2,0))+(1),(((gr((gr(1,0))*(3),(gr(2,0))+(1)))-(48))*(10))+((gr(((gr(1,0))*(3))+(1),(gr(2,0))+(1)))-(48)));
        goto _6;
    _16:
        gw(gr(1,0),(gr(2,0))+(1),(((gr((gr(1,0))*(3),(gr(2,0))+(1)))-(48))*(10))+((gr(((gr(1,0))*(3))+(1),(gr(2,0))+(1)))-(48)));
        goto _6;
}}