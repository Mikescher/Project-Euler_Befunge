/* compiled with BefunCompile v1.0.6 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADtU8uO2zAM/BVGdi7Sak3KseM1VKMfYjgB2kJXnXxq/71DO8kmu8kCRXvrEpBEvUbDITWXJVFRFOT/0hYQ2D/Ho/8Ljz7xPvH+EG+1+TAXm9cpZnTf"+
                                    "oqxj4lCW8e1uUZyQhWaizCGxLMjFekP9Po/uZWu7DgsU+cE7agOutWjCGbPQddZS4DwETuLhCKdBfM9jsFjCduWmicrImWsniWvKzoJCqPS1eM2P6YLCNdogrofZ0YdK"+
                                    "N5x1vfllOjsei+nQmx/fjFWvXt7ZvriapxuqJybNmNG3S79HX8wHfHIW3+IRkayyPLT5Vc/yMEGpe/q/ESxe9RhvcjK0Igmx6JBXP+RmGessIUE/vwFDqZM5kHFH+Hus"+
                                    "JwSKNQRKiHT1KgnzFHMSaZwCSKN+6+VdAuMMsb0sJ9c8rxM0BJV2kneSNC9R8RRkj1TKcuiuLPZSi2WceQU9r6CImq35bgD7rhgf2VCpFuJTsC7h7lZ2OlTeatxaFdg+"+
                                    "bn7SKV4+RwqWTlnmFGR/n+sHFlFyeLB/dk3jngKAXB9Ei9hDd0NfiMwT7PnrNVeVvuUz1cqD4qWEJk1ouxQ3nLPa6uILSPjoa90SO9lvqywlwdAHAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<25)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<25)g[y*80+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        gw(1L,0L,6L);
        gw(2L,0L,128L);
    _1:
        gw(2L,0L,gr(2L,0L)-1L);
        sa(gr(1L,0L)-1L);
        gw((tm(gr(2L,0L),64L))+9L,((gr(1L,0L)-1L)*2L)+(td(gr(2L,0L),64L)),0L);
    _2:
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _3;else goto _33;
    _3:
        sp();
        if((gr(2L,0L))==0)goto _4;else goto _1;
    _4:
        gw(2L,0L,gr(1L,0L));
    _5:
        gw(2L,0L,gr(2L,0L)-1L);
        gw(3L,0L,0L);
        sa(1L);
        sa(1L+(0L*(gr(2L,0L)+1L)));
        sa((1L+(0L*(gr(2L,0L)+1L)))<1000L?1:0);
    _6:
        if(sp()!=0)goto _7;else goto _9;
    _7:
        sp();
    _8:
        sa(sp()+1L);
        sa(sr());
        sa(sr());
        sa(sr());
        sa(sr());
        sa(sp()*sp());
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        sa(td(sp(),2L));
        sa(sp()*(gr(2L,0L)+1L));
        sa(sp()+sp());
        sa(sr()<1000L?1:0);
        goto _6;
    _9:
        if(sr()>9999L)goto _10;else goto _32;
    _10:
        sp();
        sp();
        if((gr(2L,0L))==0)goto _11;else goto _5;
    _11:
        sa(gr(1L,0L)-1L);
        gw(5L,gr(1L,0L)-1L,0L);
    _12:
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(6L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(7L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        if(sp()!=0)goto _13;else goto _31;
    _13:
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _15;else goto _14;
    _14:
        sa(sp()-1L);
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(5L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _12;
    _15:
        gw(6L,gr(1L,1L),gr(6L,gr(1L,1L))+1L);
        gw(1L,2L,gr(6L,gr(1L,1L)));
        gw(1L,3L,gr(5L,gr(1L,1L)));
        sp();
    _16:
        if(gr(1L,2L)-gr(1L,0L)==0)goto _17;else goto _18;
    _17:
        gw(6L,gr(1L,1L),-1L);
        gw(5L,gr(1L,1L),gr(5L,gr(1L,1L))+1L);
        gw(6L,gr(1L,1L),gr(6L,gr(1L,1L))+1L);
        gw(1L,2L,gr(6L,gr(1L,1L)));
        gw(1L,3L,gr(5L,gr(1L,1L)));
        goto _16;
    _18:
        if(gr(1L,3L)>127L)goto _19;else goto _20;
    _19:
        gw(1L,1L,gr(1L,1L)-1L);
        gw(7L,gr(6L,gr(1L,1L)),0L);
        gw(6L,gr(1L,1L),gr(6L,gr(1L,1L))+1L);
        gw(1L,2L,gr(6L,gr(1L,1L)));
        gw(1L,3L,gr(5L,gr(1L,1L)));
        goto _16;
    _20:
        if((gr(7L,gr(1L,2L)))!=0)goto _22;else goto _21;
    _21:
        gw(1L,4L,gr((tm(gr(1L,3L),64L))+9L,(td(gr(1L,3L),64L))+(gr(1L,2L)*2L)));
        if((gr(1L,4L))!=0)goto _23;else goto _22;
    _22:
        sa(0L);
        goto _15;
    _23:
        if((gr(1L,1L)*((tm(gr((tm(gr(5L,gr(1L,1L)-1L),64L))+9L,(td(gr(5L,gr(1L,1L)-1L),64L))+(gr(6L,gr(1L,1L)-1L)*2L)),100L))-(td(gr(1L,4L),100L))))!=0)goto _22;else goto _24;
    _24:
        if((gr(1L,0L)-1L)<=gr(1L,1L))goto _26;else goto _25;
    _25:
        gw(7L,gr(1L,2L),1L);
        gw(1L,1L,gr(1L,1L)+1L);
        gw(6L,gr(1L,1L),-1L);
        gw(5L,gr(1L,1L),0L);
        gw(6L,gr(1L,1L),gr(6L,gr(1L,1L))+1L);
        gw(1L,2L,gr(6L,gr(1L,1L)));
        gw(1L,3L,gr(5L,gr(1L,1L)));
        goto _16;
    _26:
        if((tm(gr(1L,4L),100L))!=(td(gr((tm(gr(5L,0L),64L))+9L,(td(gr(5L,0L),64L))+(gr(6L,0L)*2L)),100L)))goto _22;else goto _27;
    _27:
        gw(2L,1L,0L);
        sa(0L);
    _28:
        sa(gr((tm(gr(5L,gr(2L,1L)),64L))+9L,(td(gr(5L,gr(2L,1L)),64L))+(gr(6L,gr(2L,1L))*2L)));
        System.Console.Out.Write((long)(gr((tm(gr(5L,gr(2L,1L)),64L))+9L,(td(gr(5L,gr(2L,1L)),64L))+(gr(6L,gr(2L,1L))*2L))));
        sa(sp()+sp());
        System.Console.Out.Write('\n');
        sa(gr(2L,1L)+1L);
        gw(2L,1L,gr(2L,1L)+1L);
        sa(sp()-gr(1L,0L));
        if(sp()!=0)goto _28;else goto _30;
    _30:
        sa(32L);
        sa(61L);
        sa(32L);
        System.Console.Out.Write(' ');
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((char)(sp()));
        System.Console.Out.Write((long)(sp()));
        return;
    _31:
        gw(6L,0L,-1L);
        gw(1L,1L,0L);
        sp();
        goto _22;
    _32:
        gw((tm(gr(3L,0L),64L))+9L,(td(gr(3L,0L),64L))+(gr(2L,0L)*2L),sp());
        gw(3L,0L,gr(3L,0L)+1L);
        goto _8;
    _33:
        sa(sp()-1L);
        sa(sr());
        sa(0L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*2L);
        sa(sp()+(td(gr(2L,0L),64L)));
        sa((tm(gr(2L,0L),64L))+9L);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _2;
}}