/* compiled with BefunCompile v1.0.7 (c) 2015 */
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
        long t0,t1;
        gw(1,0,6);
        gw(2,0,128);
    _1:
        gw(2,0,gr(2,0)-1);
        sa(gr(1,0)-1);
        gw((tm(gr(2,0),64))+9,((gr(1,0)-1)*2)+(td(gr(2,0),64)),0);
    _2:
        sa(sr());
        sa((sp()!=0)?0:1);
        if(sp()!=0)goto _3;else goto _33;
    _3:
        sp();
        if((gr(2,0))==0)goto _4;else goto _1;
    _4:
        gw(2,0,gr(1,0));
    _5:
        gw(2,0,gr(2,0)-1);
        gw(3,0,0);
        sa(1);
        sa(1+(0*(gr(2,0)+1)));
        sa((1+(0*(gr(2,0)+1)))<1000?1:0);
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
        t0=sp();
        sa(t0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();sa(sp()-v0);}
        t1=sp();
        t1=td(t1,2);
        t1=t1*(gr(2,0)+1);
        sa(sp()+t1);
        sa(sr()<1000?1:0);
        goto _6;
    _9:
        if(sr()>9999)goto _10;else goto _32;
    _10:
        sp();
        sp();
        if((gr(2,0))==0)goto _11;else goto _5;
    _11:
        sa(gr(1,0)-1);
        gw(5,gr(1,0)-1,0);
    _12:
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(7);
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
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(5);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _12;
    _15:
        gw(6,gr(1,1),gr(6,gr(1,1))+1);
        gw(1,2,gr(6,gr(1,1)));
        gw(1,3,gr(5,gr(1,1)));
        sp();
    _16:
        if(gr(1,2)-gr(1,0)==0)goto _17;else goto _18;
    _17:
        gw(6,gr(1,1),-1);
        gw(5,gr(1,1),gr(5,gr(1,1))+1);
        gw(6,gr(1,1),gr(6,gr(1,1))+1);
        gw(1,2,gr(6,gr(1,1)));
        gw(1,3,gr(5,gr(1,1)));
        goto _16;
    _18:
        if(gr(1,3)>127)goto _19;else goto _20;
    _19:
        gw(1,1,gr(1,1)-1);
        gw(7,gr(6,gr(1,1)),0);
        gw(6,gr(1,1),gr(6,gr(1,1))+1);
        gw(1,2,gr(6,gr(1,1)));
        gw(1,3,gr(5,gr(1,1)));
        goto _16;
    _20:
        if((gr(7,gr(1,2)))!=0)goto _22;else goto _21;
    _21:
        gw(1,4,gr((tm(gr(1,3),64))+9,(td(gr(1,3),64))+(gr(1,2)*2)));
        if((gr(1,4))!=0)goto _23;else goto _22;
    _22:
        sa(0);
        goto _15;
    _23:
        if((gr(1,1)*((tm(gr((tm(gr(5,gr(1,1)-1),64))+9,(td(gr(5,gr(1,1)-1),64))+(gr(6,gr(1,1)-1)*2)),100))-(td(gr(1,4),100))))!=0)goto _22;else goto _24;
    _24:
        if((gr(1,0)-1)<=gr(1,1))goto _26;else goto _25;
    _25:
        gw(7,gr(1,2),1);
        gw(1,1,gr(1,1)+1);
        gw(6,gr(1,1),-1);
        gw(5,gr(1,1),0);
        gw(6,gr(1,1),gr(6,gr(1,1))+1);
        gw(1,2,gr(6,gr(1,1)));
        gw(1,3,gr(5,gr(1,1)));
        goto _16;
    _26:
        if((tm(gr(1,4),100))!=(td(gr((tm(gr(5,0),64))+9,(td(gr(5,0),64))+(gr(6,0)*2)),100)))goto _22;else goto _27;
    _27:
        gw(2,1,0);
        sa(0);
    _28:
        sa(gr((tm(gr(5,gr(2,1)),64))+9,(td(gr(5,gr(2,1)),64))+(gr(6,gr(2,1))*2)));
        System.Console.Out.Write('\n');
        sa(sr());
        System.Console.Out.Write((long)(sp()));
        sa(sp()+sp());
        t0=gr(2,1)+1;
        gw(2,1,gr(2,1)+1);
        t0=t0-gr(1,0);
        if((t0)!=0)goto _28;else goto _30;
    _30:
        System.Console.Out.Write("  = ");
        System.Console.Out.Write((long)(sp()));
        return;
    _31:
        gw(6,0,-1);
        gw(1,1,0);
        sp();
        goto _22;
    _32:
        gw((tm(gr(3,0),64))+9,(td(gr(3,0),64))+(gr(2,0)*2),sp());
        gw(3,0,gr(3,0)+1);
        goto _8;
    _33:
        sa(sp()-1L);
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*2L);
        sa(sp()+(td(gr(2,0),64)));
        sa((tm(gr(2,0),64))+9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _2;
}}