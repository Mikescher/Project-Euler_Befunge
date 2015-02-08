/* compiled with BefunCompile v1.0.4 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADtUbsOgzAM/JXwWhpRnAEGy4r6IVFBaqWsTJn4+NpFPAW0Hdh6g2X5nPPFjp+xgRYAWmvAI4DXnJsck1CnwJSNH7EwaDReHJaoM8ehqHTbcI/qEWx6"+
                                    "vfXpXc3QgqGN8sRq48EoGirwjnajd41wTHcROup4QG6QJ1Ca1iGJ0Ouq0Fi6jIPUFZK44D9qkgbOMRdLJJkHcmKdFtK22TDIqzh0NL1YtIV87Wg2y/I1hnxYXzLimyXN"+
                                    "X678jljaBLn1/Mgf9ryj8zNWOtumBaRolzvPz1/nJJ0XFH7TnYAEAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<72&&y<16)?g[y*72+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<72&&y<16)g[y*72+x]=v;}
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
        gw(1,0,100);
        gw(0,0,0);
        goto _12;
    _1:
        gw(1,0,0);
        sp();
        goto _14;
    _2:
        gw(1,0,(gr(1,0))+(1));
        goto _14;
    _3:
        sa(gr(0,0));
        gw(1,0,gr(0,0));
        goto _15;
    _4:
        sa(gr(0,0));
        goto _15;
    _5:
        gw(1,0,99);
        goto _6;
    _6:
        sa(sp()+sp());
        goto _13;
    _7:
        sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)));
        gw(tm(gr(1,0),10),(td(gr(1,0),10))+(6),0);
        {long v0=sp();sa(sp()-v0);}
        goto _16;
    _8:
        gw(1,0,99);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _6;
    _9:
        sp();
        System.Console.Out.Write((long)(sp()));
        return;
    _10:
        sp();
        sp();
        goto _16;
    _11:
        gw(1,0,sp());
        goto _12;
    _12:
        sa(gr(1,0));
        gw(0,0,(gr(1,0))+(gr(0,0)));
        sa(1);
        {long v0=sp();sa(sp()-v0);}
        sa(sr());
        if(sp()!=0)goto _11; else goto _1;
    _13:
        sa(sr());
        sa(gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)));
        if((((gr(tm(gr(1,0),10),(td(gr(1,0),10))+(6)))!=0)?0:1)!=0)goto _10;else goto _18;
    _14:
        sa(99);
        sa(gr(1,0));
        gw(tm(gr(1,0),10),(td(gr(1,0),10))+(6),((gr(1,0))+(1))*((gr(1,0))+(1)));
        {long v0=sp();sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _2; else goto _3;
    _15:
        sa((gr(1,0))-(1));
        gw(1,0,(gr(1,0))-(1));
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _5; else goto _4;
    _16:
        sa(gr(1,0));
        gw(1,0,(gr(1,0))-(1));
        if(sp()!=0)goto _13; else goto _17;
    _17:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _9; else goto _8;
    _18:
        {long v0=sp();sa((sp()>v0)?1:0);}
        if(sp()!=0)goto _7; else goto _16;
}}