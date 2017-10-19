/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
static void Main(string[]args)
{
        long t0,t1;
        gw(1,0,6);
        gw(2,0,128);
    _1:
        gw(2,0,gr(2,0)-1);
        sa(gr(1,0)-1);
        sa(gr(1,0)-1);
        gw((gr(2,0)%64)+9,((gr(1,0)-1)*2)+(gr(2,0)/64),0);
    _2:
        if(sp()!=0)goto _34;else goto _3;
    _3:
        sp();

        if((gr(2,0))!=0)goto _1;else goto _4;
    _4:
        gw(2,0,gr(1,0));
    _5:
        gw(2,0,gr(2,0)-1);
        gw(3,0,0);
        sa(1);
        sa(1+(0*(gr(2,0)+1)));
        sa((1+(0*(gr(2,0)+1)))<1000?1:0);
    _6:
        if(sp()!=0)goto _7;else goto _8;
    _7:
        sp();
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
        t1/=2;
        t1*=gr(2,0)+1;
        sa(sp()+t1);

        sa(sr()<1000?1:0);
        goto _6;
    _8:
        if(sr()>9999)goto _9;else goto _33;
    _9:
        sp();
        sp();

        if((gr(2,0))!=0)goto _5;else goto _10;
    _10:
        sa(gr(1,0)-1);
        sa(0);
        sa(6);
        sa(gr(1,0)-1);
        gw(5,gr(1,0)-1,0);
    _11:
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(7);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());

        if(sp()!=0)goto _12;else goto _32;
    _12:
        sa(sr());
        sa((sp()!=0)?0:1);
    _13:
        if(sp()!=0)goto _14;else goto _31;
    _14:
        sp();
    _15:
        gw(6,gr(1,1),gr(6,gr(1,1))+1);
        gw(1,2,gr(6,gr(1,1)));
        gw(1,3,gr(5,gr(1,1)));

        if((gr(1,2)-gr(1,0))!=0)goto _17;else goto _16;
    _16:
        gw(6,gr(1,1),-1);
        gw(5,gr(1,1),gr(5,gr(1,1))+1);
        goto _15;
    _17:
        if(gr(1,3)>127)goto _18;else goto _19;
    _18:
        gw(1,1,gr(1,1)-1);
        gw(7,gr(6,gr(1,1)),0);
        t0=9;
        goto _15;
    _19:
        if((gr(7,gr(1,2)))!=0)goto _21;else goto _20;
    _20:
        gw(1,4,gr((gr(1,3)%64)+9,(gr(1,3)/64)+(gr(1,2)*2)));

        if((gr(1,4))!=0)goto _22;else goto _21;
    _21:
        sa(0);
        sa(1);
        goto _13;
    _22:
        if((gr(1,1)*((gr((gr(5,gr(1,1)-1)%64)+9,(gr(5,gr(1,1)-1)/64)+(gr(6,gr(1,1)-1)*2))%100)-(gr(1,4)/100)))!=0)goto _21;else goto _23;
    _23:
        if((gr(1,0)-1)>gr(1,1))goto _24;else goto _25;
    _24:
        gw(7,gr(1,2),1);
        gw(1,1,gr(1,1)+1);
        gw(6,gr(1,1),-1);
        gw(5,gr(1,1),0);
        goto _15;
    _25:
        if(((gr(1,4)%100)-(gr((gr(5,0)%64)+9,(gr(5,0)/64)+(gr(6,0)*2))/100))!=0)goto _30;else goto _26;
    _26:
        gw(2,1,0);
        System.Console.Out.Write(gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2))+" ");
        System.Console.Out.Write('\n');
        t0=gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2));
    _27:
        t1=gr(2,1)+1;
        gw(2,1,gr(2,1)+1);
        t1-=gr(1,0);

        if((t1)!=0)goto _29;else goto _28;
    _28:
        System.Console.Out.Write("  = ");
        System.Console.Out.Write(t0+" ");
        return;
    _29:
        System.Console.Out.Write(gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2))+" ");
        System.Console.Out.Write('\n');
        t0+=gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2));
        goto _27;
    _30:
        t0=0;
        t1=4;
        goto _21;
    _31:
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(5);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(6);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _11;
    _32:
        gw(6,0,-1);
        gw(1,1,0);
        sp();
        goto _21;
    _33:
        gw((gr(3,0)%64)+9,(gr(3,0)/64)+(gr(2,0)*2),sp());
        gw(3,0,gr(3,0)+1);
        sa(0);
        goto _7;
    _34:
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()*2L);

        sa(sp()+(gr(2,0)/64));

        sa((gr(2,0)%64)+9);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        goto _2;
}
}
