/* compiled with BefunCompile v1.0.2 (c) 2015 */
public static class Program 
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrc3HLNvG4gwPNj/aOnLpce6Y6x9BQ++2fS7z7rFLEe77aJh8LZ5nx6rt+v5ZlxeumHSpRr5Iye+FSct+a5ivf3mqYwptbt+/vz76vX6"+
                                    "N4/fv149e82L7/tj4v+eeOXJtiHdnWGogwObUw+EnX1we8G5TZMj2vLm3FL/aFKirliyPPQF202FtlXaq9+V3X66kC/WY6FvcOu2M8lZy9Zn9adnGq/6VPahMkDmbtyy"+
                                    "yaUZyTOvz36+W+BWSd48p21/jyTe3Ci+rF9+3x6LWdsXZjnPiLP5/+rshA235+4p9PV6sOr8na1zfH/XbntuqPo+p058hlHFjrVsmxw3VqRVlVeaZjlbWvvNjpiSu6Jc"+
                                    "Ysvh0o0X4zfXPfL6+9WF12f2pk7FZS8z5qitj8jnK6yuEZ/mVvp3iuUr1qerrz26W3NtHX+G+KsZ310FlsdKfF/7cQV/gLD+iritsx5arL3/10ru3OU7Yslz57fmCe1a"+
                                    "lfFIZcvRTQHnpk+O54pwCzv6+2H737t/pL8UmFWr/BV3lT4XtNbnv+TJ+u8FLW2r+7bf2qP13dl06609et9Xny1y9eQ+tS7fdU+D6y+RUulz1/tWtvzN/GcXaXq6faPn"+
                                    "f75dN777yvYs/xe2s3zH14/sevJ84QmazAwAB/3uX5ICAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=o.Skip(1).ToArray();for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<400&&y<518)?g[y*400+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<400&&y<518)g[y*400+x]=v;}
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
        goto _16;
    _0:
        if(sp()!=0)goto _18; else goto _19;
    _1:
        if(sp()!=0)goto _21; else goto _20;
    _2:
        if(sp()!=0)goto _17; else goto _22;
    _3:
        if(sp()!=0)goto _23; else goto _24;
    _4:
        if(sp()!=0)goto _23; else goto _25;
    _5:
        if(sp()!=0)goto _27; else goto _26;
    _6:
        if(sp()!=0)goto _28; else goto _29;
    _7:
        if(sp()!=0)goto _30; else goto _32;
    _8:
        if(sp()!=0)goto _38; else goto _34;
    _9:
        if(sp()!=0)goto _41; else goto _40;
    _10:
        if(sp()!=0)goto _39; else goto _42;
    _11:
        if(sp()!=0)goto _46; else goto _43;
    _12:
        if(sp()!=0)goto _44; else goto _36;
    _13:
        if(sp()!=0)goto _35; else goto _45;
    _14:
        if(sp()!=0)goto _33; else goto _36;
    _15:
        if(sp()!=0)goto _35; else goto _37;
    _16:
        gw(1,0,400);
        gw(2,0,500);
        gw(0,0,200000);
        gw(3,0,2);
        gw(0,3,32);
        gw(1,3,32);
        goto _17;
    _17:
        gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3),88);
        sa((gr(3,0))+(gr(3,0)));
        sa((gr(0,0))>((gr(3,0))+(gr(3,0)))?1:0);
        goto _0;
    _18:
        sa(sr());
        sa(32);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(3,0));
        sa(sp()+sp());
        sa(sr());
        sa(gr(0,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _0;
    _19:
        sp();
        goto _20;
    _20:
        sa((gr(3,0))+(1));
        gw(3,0,(gr(3,0))+(1));
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(32);
        {long v0=sp();sa(sp()-v0);}
        goto _1;
    _21:
        sa((gr(0,0))>(gr(3,0))?1:0);
        goto _2;
    _22:
        gw(4,0,0);
        gw(3,0,0);
        goto _23;
    _23:
        sa((gr(3,0))+(1));
        gw(3,0,(gr(3,0))+(1));
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        sa(88);
        {long v0=sp();sa(sp()-v0);}
        goto _3;
    _24:
        sa(gr(3,0));
        sa(gr(4,0));
        gw(4,0,(gr(4,0))+(1));
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa((gr(0,0))>(gr(3,0))?1:0);
        goto _4;
    _25:
        gw(tm((gr(4,0))-(1),gr(1,0)),(td((gr(4,0))-(1),gr(1,0)))+(3),0);
        gw(4,0,0);
        gw(5,0,0);
        sa(1);
        sa(1);
        sa(tm(1,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3))));
        goto _5;
    _26:
        sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
        gw(5,0,(gr(5,0))+(1));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        goto _27;
    _27:
        sa(sr());
        sa((gr(4,0))+(1));
        gw(4,0,(gr(4,0))+(1));
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        goto _6;
    _28:
        sa(sr());
        sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _5;
    _29:
        sp();
        sa((gr(5,0))-(4));
        goto _7;
    _30:
        gw(4,0,0);
        gw(5,0,0);
        goto _31;
    _31:
        sa(4);
        sa(sp()+sp());
        sa(sr());
        sa(sr());
        sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _5;
    _32:
        gw(8,0,0);
        sa(sr());
        sa(sr());
        sa(sr());
        sa(4);
        sa(sp()+sp());
        gw(6,0,sp());
        gw(7,0,sp());
        sa(3);
        {long v0=sp();sa(sp()-v0);}
        goto _33;
    _33:
        sa(sr());
        sa(gr(7,0));
        {long v0=sp();sa(sp()-v0);}
        goto _8;
    _34:
        sa((gr(8,0))+(1));
        gw(8,0,(gr(8,0))+(1));
        sa(4);
        {long v0=sp();sa(sp()-v0);}
        goto _15;
    _35:
        sa(1);
        sa(sp()+sp());
        sa(sr());
        sa(gr(6,0));
        {long v0=sp();sa(sp()-v0);}
        goto _14;
    _36:
        gw(4,0,0);
        gw(5,0,0);
        sp();
        goto _31;
    _37:
        sa(3);
        {long v0=sp();sa(sp()-v0);}
        System.Console.Out.Write((long)(sp()));
        sp();
        return;
    _38:
        gw(4,0,0);
        gw(5,0,0);
        sa(sr());
        goto _39;
    _39:
        sa(sr());
        sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        goto _9;
    _40:
        sa(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+(3)));
        gw(5,0,(gr(5,0))+(1));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        goto _41;
    _41:
        sa(sr());
        sa((gr(4,0))+(1));
        gw(4,0,(gr(4,0))+(1));
        sa(sr());
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()%v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(gr(1,0));
        {long v0=sp();sa((v0==0)?0:(sp()/v0));}
        sa(3);
        sa(sp()+sp());
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        sa((sp()!=0)?0:1);
        goto _10;
    _42:
        sp();
        sa((gr(5,0))-(4));
        goto _11;
    _43:
        gw(8,0,(gr(8,0))+(1));
        goto _44;
    _44:
        sa((gr(8,0))-(4));
        goto _13;
    _45:
        sa(3);
        {long v0=sp();sa(sp()-v0);}
        System.Console.Out.Write((long)(sp()));
        sp();
        return;
    _46:
        gw(8,0,0);
        sa(sr());
        sa(gr(7,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa((sp()>v0)?1:0);}
        goto _12;
}}