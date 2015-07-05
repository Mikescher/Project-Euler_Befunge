/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrc3HLNvG4gwPNj/aOnLpce6Y6x9BQ++2fS7z7rFLEe77aJh8LZ5nx6rt+v5ZlxeumHSpRr5Iye+FSct+a5ivf3mqYwptbt+/vz76vX6"+
                                    "N4/fv149e82L7/tj4v+eeOXJtiHdnWGogwObUw+EnX1we8G5TZMj2vLm3FL/aFKirliyPPQF202FtlXaq9+V3X66kC/WY6FvcOu2M8lZy9Zn9adnGq/6VPahMkDmbtyy"+
                                    "yaUZyTOvz36+W+BWSd48p21/jyTe3Ci+rF9+3x6LWdsXZjnPiLP5/+rshA235+4p9PV6sOr8na1zfH/XbntuqPo+p058hlHFjrVsmxw3VqRVlVeaZjlbWvvNjpiSu6Jc"+
                                    "Ysvh0o0X4zfXPfL6+9WF12f2pk7FZS8z5qitj8jnK6yuEZ/mVvp3iuUr1qerrz26W3NtHX+G+KsZ310FlsdKfF/7cQV/gLD+iritsx5arL3/10ru3OU7Yslz57fmCe1a"+
                                    "lfFIZcvRTQHnpk+O54pwCzv6+2H737t/pL8UmFWr/BV3lT4XtNbnv+TJ+u8FLW2r+7bf2qP13dl06609et9Xny1y9eQ+tS7fdU+D6y+RUulz1/tWtvzN/GcXaXq6faPn"+
                                    "f75dN777yvYs/xe2s3zH14/sevJ84QmazAwAB/3uX5ICAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<400&&y<518)?g[y*400+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<400&&y<518)g[y*400+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,400L);
        gw(2L,0L,500L);
        gw(0L,0L,200000L);
        gw(3L,0L,2L);
        gw(0L,3L,32L);
        gw(1L,3L,32L);
    _1:
        gw(tm(gr(3L,0L),gr(1L,0L)),(td(gr(3L,0L),gr(1L,0L)))+3L,88L);
        sa(gr(3L,0L)+gr(3L,0L));
        sa((gr(3L,0L)+gr(3L,0L))<gr(0L,0L)?1:0);
    _2:
        if(sp()!=0)goto _34;else goto _3;
    _3:
        sp();
    _4:
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-32L);
        if(sp()!=0)goto _6;else goto _4;
    _6:
        if(gr(0L,0L)>gr(3L,0L))goto _1;else goto _7;
    _7:
        gw(4L,0L,0L);
        gw(3L,0L,0L);
    _8:
        sa(gr(3L,0L)+1L);
        gw(3L,0L,gr(3L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()-88L);
        if(sp()!=0)goto _8;else goto _10;
    _10:
        sa(gr(3L,0L));
        sa(gr(4L,0L));
        gw(4L,0L,gr(4L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        if(gr(0L,0L)>gr(3L,0L))goto _8;else goto _11;
    _11:
        gw(tm(gr(4L,0L)-1L,gr(1L,0L)),(td(gr(4L,0L)-1L,gr(1L,0L)))+3L,0L);
        gw(4L,0L,0L);
        gw(5L,0L,0L);
        sa(1L);
        sa(1L);
        sa(tm(1L,gr(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+3L)));
    _12:
        if(sp()!=0)goto _13;else goto _33;
    _13:
        sa(sr());
        sa(gr(4L,0L)+1L);
        gw(4L,0L,gr(4L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();sa((sp()<v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _32;else goto _14;
    _14:
        sp();
        if(gr(5L,0L)!=4L)goto _31;else goto _15;
    _15:
        gw(8L,0L,0L);
        sa(sr());
        sa(sr());
        sa(sr()+4L);
        gw(6L,0L,sp());
        gw(7L,0L,sp());
        sa(sp()-3L);
    _16:
        if(sr()!=gr(7L,0L))goto _22;else goto _17;
    _17:
        sa(gr(8L,0L)+1L);
        gw(8L,0L,gr(8L,0L)+1L);
        sa(sp()-4L);
        if(sp()!=0)goto _18;else goto _21;
    _18:
        sa(sp()+1L);
        if(sr()!=gr(6L,0L))goto _16;else goto _19;
    _19:
        gw(4L,0L,0L);
        gw(5L,0L,0L);
        sp();
    _20:
        sa(sp()+4L);
        sa(sr());
        sa(tm(sr(),gr(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+3L)));
        goto _12;
    _21:
        sa(sp()-3L);
        System.Console.Out.Write((long)(sp()));
        sp();
        return;
    _22:
        gw(4L,0L,0L);
        gw(5L,0L,0L);
        sa(sr());
    _23:
        if(tm(sr(),gr(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+3L))!=0)goto _24;else goto _30;
    _24:
        sa(sr());
        sa(gr(4L,0L)+1L);
        gw(4L,0L,gr(4L,0L)+1L);
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();sa((sp()<v0)?1:0);}
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _23;else goto _25;
    _25:
        sp();
        if(gr(5L,0L)!=4L)goto _26;else goto _29;
    _26:
        gw(8L,0L,0L);
        if(sr()<gr(7L,0L))goto _27;else goto _19;
    _27:
        if(gr(8L,0L)!=4L)goto _18;else goto _28;
    _28:
        sa(sp()-3L);
        System.Console.Out.Write((long)(sp()));
        sp();
        return;
    _29:
        gw(8L,0L,gr(8L,0L)+1L);
        goto _27;
    _30:
        sa(gr(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+3L));
        gw(5L,0L,gr(5L,0L)+1L);
        {long v0=sp();sa(td(sp(),v0));}
        goto _24;
    _31:
        gw(4L,0L,0L);
        gw(5L,0L,0L);
        goto _20;
    _32:
        sa(tm(sr(),gr(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+3L)));
        goto _12;
    _33:
        sa(gr(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+3L));
        gw(5L,0L,gr(5L,0L)+1L);
        {long v0=sp();sa(td(sp(),v0));}
        goto _13;
    _34:
        sa(sr());
        sa(32L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(1L,0L)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(1L,0L)));
        sa(sp()+3L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+gr(3L,0L));
        sa(sr()<gr(0L,0L)?1:0);
        goto _2;
}}