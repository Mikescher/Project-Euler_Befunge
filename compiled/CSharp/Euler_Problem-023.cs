/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrd3z/Y1GQgc+BiuyCV+Qs95Kafispvshq8SJ8dVPzpy+D3DbqGJL3YVltr/23+kRGexwtLL93KU/qh4MxAPdkx0/x+vve7ZrP4HBlW+"+
                                    "4mvliy3rZ0fv0Tu1RU9lzRrfyyEqHRXhNle3XixI/rSrVOqX76Y7715Nbckxlbm+vbD4J8uOxm18kROrNffMUJG6tXffsuAmzaJsdf8KGa6Ji3+/4Qvc2Dvre+OpPRH6"+
                                    "qUZtMz177G1PTIhVnVe2Y6eUyfVKu43Zvxd+iN+/7f+Jl1mBXgVLK2KFTbJ+B9QYmey0e6MmaWW8unOb/5bYRbJCb00CrY3+3qq9PddB7i93/dK3Pw8nX/yZknSH9e+N"+
                                    "mB8MfXNF5t6ssi8PjpTY1zx51f2Hr55dm7lOJDOhzSrlmNUU/dmy1bets0udrV9Gsa8s2Zyyx0X088NzMar/fj5dkb0muOdY7R7GFXMF1Rs6GRgAPr8OZ4ABAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<400&&y<88)?g[y*400+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<400&&y<88)g[y*400+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,400L);
        gw(0L,0L,30000L);
        sa(gr(0L,0L)-1L);
        sa(gr(0L,0L)-1L);
        gw(2L,0L,gr(0L,0L)-1L);
    _1:
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),2L));
        sa(sr());
        if(sp()!=0)goto _2;else goto _22;
    _2:
        sa(sr());
        sa(gr(2L,0L));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(tm(sp(),v0));}
        if(sp()!=0)goto _21;else goto _3;
    _3:
        sa(sr());
        gw(3L,0L,sp());
        sa(sp()+sp());
        sa(gr(3L,0L)-1L);
        sa(gr(3L,0L)-1L);
    _4:
        if(sp()!=0)goto _2;else goto _5;
    _5:
        sp();
        sa((sp()>gr(2L,0L))?1:0);
        gw(tm(gr(2L,0L),gr(1L,0L)),(td(gr(2L,0L),gr(1L,0L)))+1L,sp());
    _6:
        sa(sr());
        if(sp()!=0)goto _20;else goto _7;
    _7:
        gw(0L,1L,0L);
        gw(4L,0L,gr(0L,0L));
        sp();
        sp();
    _8:
        sa(gr(4L,0L)-1L);
        gw(4L,0L,gr(4L,0L)-1L);
        if(sp()!=0)goto _14;else goto _9;
    _9:
        gw(8L,0L,0L);
        gw(2L,0L,gr(0L,0L));
    _10:
        gw(2L,0L,gr(2L,0L)-1L);
        if(td(gr(tm(gr(2L,0L),gr(1L,0L)),(td(gr(2L,0L),gr(1L,0L)))+1L),2L)!=0)goto _12;else goto _11;
    _11:
        gw(8L,0L,gr(8L,0L)+gr(2L,0L));
    _12:
        if((gr(2L,0L))!=0)goto _10;else goto _13;
    _13:
        System.Console.Out.Write((long)(gr(8L,0L)));
        return;
    _14:
        if(tm(gr(tm(gr(4L,0L),gr(1L,0L)),(td(gr(4L,0L),gr(1L,0L)))+1L),2L)!=0)goto _15;else goto _8;
    _15:
        gw(5L,0L,gr(4L,0L)+1L);
    _16:
        sa(gr(5L,0L)-1L);
        gw(5L,0L,gr(5L,0L)-1L);
        if(sp()!=0)goto _17;else goto _8;
    _17:
        if(tm(gr(tm(gr(5L,0L),gr(1L,0L)),(td(gr(5L,0L),gr(1L,0L)))+1L),2L)!=0)goto _18;else goto _16;
    _18:
        if((gr(4L,0L)+gr(5L,0L))>gr(0L,0L))goto _16;else goto _19;
    _19:
        gw(tm(gr(4L,0L)+gr(5L,0L),gr(1L,0L)),(td(gr(4L,0L)+gr(5L,0L),gr(1L,0L)))+1L,(tm(gr(tm(gr(4L,0L)+gr(5L,0L),gr(1L,0L)),(td(gr(4L,0L)+gr(5L,0L),gr(1L,0L)))+1L),2L))+2L);
        goto _16;
    _20:
        sa(sp()-1L);
        sa(sr());
        sa(sr());
        gw(2L,0L,sp());
        goto _1;
    _21:
        sa(sp()-1L);
        sa(sr());
        goto _4;
    _22:
        gw(tm(gr(2L,0L),gr(1L,0L)),(td(gr(2L,0L),gr(1L,0L)))+1L,1L>gr(2L,0L)?1:0);
        goto _6;
}}