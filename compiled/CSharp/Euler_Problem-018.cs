/* compiled with BefunCompile v1.0.5 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABAC9VMtqw0AM/JUhySnGRVp5X6GYfkhJevPVp3x/R17ogxjakrjCOCvh7OxoRns4jNGOEJlFJu0Df1XmUWWy4ymw1E072fUxdsdX7T4LHb9Ysln9feKf"+
                                    "mPba768XLk4fWzG/4jZyXCnivFb8ZTzf5Gu4NSINN9W1Lx93Eg/NGDJKuHvzEYe/nFYLLKJkqHzdhGKHvom2iN2EbYvQUT7P2xr9Sd7G/fnSj99Ep8RN3iY3zTK3XHR6"+
                                    "egkCGZwvWadVre8Se03uxrdCFMHcYGKwW623iVIgATkjG4SUDSn/B26t3l62OvAACZqQBfV+m/0Ug/oTEmJCMQyCIg5ttj1uQQ4ORGsZF9lZV3agbogb6ShCD97tEDEY"+
                                    "qiIG1Iyo0M1sxpaqOlnq29zFmyRzqKl78XXcxmZklxeCtqCQICtkHQuiIGTvNoV4ePjgJPcz2ZXqbeccmSzEE1L1q4xmM30wriNSzbJQ4wjXZY6K41bzJvhJljstPNTh"+
                                    "73sJfUqABwAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<120&&y<16)?g[y*120+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<120&&y<16)g[y*120+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(0,0,15);
        gw(2,0,gr(0,0)-1);
        gw(1,0,0);
        gw(gr(1,0),gr(2,0)+1,((gr(gr(1,0)*3,gr(2,0)+1)-48)*10)+(gr((gr(1,0)*3)+1,gr(2,0)+1)-48));
        sp();
        sp();
    _1:
        sa(gr(1,0)+1);
        gw(1,0,gr(1,0)+1);
        sa(gr(2,0));
        {long v0=sp();sa(sp()-v0);}
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        if(sp()!=0)goto _11;else goto _2;
    _2:
        sa(gr(2,0));
        gw(2,0,gr(2,0)-1);
        gw(1,0,0);
        if(sp()!=0)goto _3;else goto _4;
    _3:
        gw(gr(1,0),gr(2,0)+1,((gr(gr(1,0)*3,gr(2,0)+1)-48)*10)+(gr((gr(1,0)*3)+1,gr(2,0)+1)-48));
        goto _1;
    _4:
        sa(gr(0,0)-2);
        gw(1,0,gr(0,0)-2);
        gw(2,0,sp());
    _5:
        sa(gr(gr(1,0),gr(2,0)+1));
        sa(gr(gr(1,0),gr(2,0)+2));
        sa(gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2));
        if(((gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2))>(0)?1:0)!=0)goto _6;else goto _10;
    _6:
        sp();
    _7:
        sa(sp()+sp());
        gw(gr(1,0),gr(2,0)+1,sp());
        sa(gr(1,0));
        gw(1,0,gr(1,0)-1);
        if(sp()!=0)goto _5;else goto _8;
    _8:
        sa(gr(2,0));
        sa(gr(2,0)-1);
        gw(2,0,gr(2,0)-1);
        gw(1,0,sp());
        if(sp()!=0)goto _5;else goto _9;
    _9:
        System.Console.Out.Write((long)(gr(0,1)));
        return;
    _10:
        {long v0=sp();sa(sp()-v0);}
        goto _7;
    _11:
        gw(gr(1,0),gr(2,0)+1,((gr(gr(1,0)*3,gr(2,0)+1)-48)*10)+(gr((gr(1,0)*3)+1,gr(2,0)+1)-48));
        goto _1;
}}