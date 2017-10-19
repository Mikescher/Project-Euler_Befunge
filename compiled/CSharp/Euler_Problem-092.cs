/* transpiled with BefunCompile v1.3.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADtkbFuxCAMhl/FASKdQGkMEbrGilC3vkCHq4SSbqxMTNd3r7ksvUo5tRJjPWAJ7N/fbwooBW8gQbYJ2KOh3uXSVq81379eA712UX5Rk62eJ/EuIKPx"+
                                    "3oJaDksDiFfxrGlyWXy600lorZ3L6DDjhJkL7EAYiav62UROY6bu+hfWzGrGUkJ3JrWsd9PrfoqEYz4IziUKzJc+ZNnoO0iiTq4bsdGhq292uHFVzUrNFs4xeUyRDtYW"+
                                    "MAby3vSkIxBLKGVtCRMmawDYfvCYlcNE14qfR54azdxz+kkcpt3xOvLGE3qT0S8Q1AvA7nhvKJYIBvvgQ26xbiu74IMXhBKShCcJSkK9vWtdQONDrS/WbUIrAAUAAA==";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<16)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<16)g[y*80+x]=v;}
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        gw(3,2,568);
        gw(2,2,10000000);
        gw(2,0,0);
        gw(3,0,0);
        gw(79,7,0);
        sa(567);
        sa(567);
    _1:
        if(sp()!=0)goto _21;else goto _2;
    _2:
        gw(10,0,1);
        gw(27,1,89);
        sp();
        sa(gr(2,2));
        sa(gr(2,2));
        sa(gr(2,2)>gr(3,2)?1:0);
    _3:
        if(sp()!=0)goto _6;else goto _4;
    _4:
        sa(sr());
        sa((sr()%71)+9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/71L);

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());

        if(sp()!=0)goto _13;else goto _5;
    _5:
        sp();
        sa(sr());
        sa(7);
        sa(gr(2,0));
        gw(2,0,gr(2,0)+1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    _6:
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr()%10);
        sa(sr());
        sa(sp()*sp());

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
    _7:
        if(sp()!=0)goto _12;else goto _8;
    _8:
        sp();
        sp();
        sa(1);
    _9:
        if(sp()!=0)goto _11;else goto _10;
    _10:
        System.Console.Out.Write(gr(3,0)+" ");
        sp();
        sp();
        return;
    _11:
        sa(sr()>gr(3,2)?1:0);
        goto _3;
    _12:
        gw(5,0,sp());
        sa(sp()+sp());

        sa(((gr(5,0)/10)%10)*((gr(5,0)/10)%10));
        sa(gr(5,0)/10);
        sa(gr(5,0)/10);
        goto _7;
    _13:
        if(sr()!=89)goto _19;else goto _14;
    _14:
        gw(3,0,gr(3,0)+1);
    _15:
        gw(5,0,sp());
        sp();
        sa(gr(2,0));
    _16:
        if((gr(2,0))!=0)goto _18;else goto _17;
    _17:
        sp();
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        goto _9;
    _18:
        sa(sp()-1L);

        sa(sr());
        gw(2,0,sp());
        sa(7);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(gr(sp(),v0));}
        sa(gr(5,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sr()%71)+9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/71L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(gr(2,0));
        goto _16;
    _19:
        if(sr()!=1)goto _20;else goto _15;
    _20:
        sp();
        goto _6;
    _21:
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sr()%71)+9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()/71L);

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _1;
}
}
