/* transpiled with BefunCompile v1.2.0 (c) 2017 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABAC1UcFuwyAM/RV36S5F2WxYTEAR2mfsUKVHrpw49eNnQ5tW6y6rNEfB5snPzzYVnjSzGTgKwDMCyc9BvJW7RfBsBQ/NO5ofeTyDJ8nTXPEsPBKMGDuP"+
                                    "GLyjB553gkuuo+7br3U4gA1aq/fz2OcMblYNC/bivWC9ltQI+CtvFty1GXQW3HTdjB2zc+v1J+/ZfQ6b/Y33rN7XZv+o96SlaTIp0jHWFCV8J+OwaPT6cWA2xmJBixkF"+
                                    "zvkFX8Y4YWGuyj3HkcoClTJ6LEadHmxv8dRj7vECbai0B+8PazITZjJFyOJYjlqXW2d3YYG7ZZyPI8VWdWqlRXmh805RZRUIxjBDwQW8fBerJg2wHwAHCO0sGiwp6pA+"+
                                    "D+sJYsAcyYRV1Mq2H0XH3VBPMbbcIL0eeepBPuyEGWPtyQbwyltLa+MIGa2uqd+yuIllo7nd42VGBvvwLntMF7030PJJn8HenkE2zutN72qf+9M67MaMIRpaWiNepQpy"+
                                    "HIWYMzpZ2/IN4Pew4JgEAAA=";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<56&&y<21)?g[y*56+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<56&&y<21)g[y*56+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0,t1;
        gw(10,10,1);
        sa(9);
    _1:
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sr());
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        if(sp()!=0)goto _1;else goto _3;
    _3:
        gw(3,0,5);
        gw(2,0,48);
        sp();
        sa(49);
    _4:
        sa(0);
        sa(gr(gr(2,0),gr(3,0))-48);
        gw(5,0,gr(gr(2,0),gr(3,0))-48);
        sa(sp()+12L);

        sa(7);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(0);
        sa(gr(gr(2,0)+1,gr(3,0))-48);
        gw(6,0,gr(gr(2,0)+1,gr(3,0))-48);
        sa(sp()+12L);

        sa(7);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(0);
        sa(gr(gr(2,0)+2,gr(3,0))-48);
        gw(7,0,gr(gr(2,0)+2,gr(3,0))-48);
        sa(sp()+12L);

        sa(7);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(gr(5,0)+1,gr(6,0)+1,2);
        gw(gr(5,0)+1,gr(7,0)+1,2);
        gw(gr(6,0)+1,gr(7,0)+1,2);
        gw(gr(7,0)+1,gr(5,0)+1,0);
        gw(gr(7,0)+1,gr(6,0)+1,0);
        gw(gr(6,0)+1,gr(5,0)+1,0);
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _18;else goto _5;
    _5:
        gw(9,0,0);
        sp();
        sa(9);
        sa(gr(21,7));
    _6:
        if(sp()!=0)goto _7;else goto _17;
    _7:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _9;else goto _8;
    _8:
        sa(sr()+12);
        sa(7);
        {long v0=sp();sa(gr(sp(),v0));}
        goto _6;
    _9:
        sa(sp()+1L);
    _10:
        if(sr()-gr(9,0)==0)goto _13;else goto _11;
    _11:
        sa(sr());
        sa(sr());
        sa(sr()+12);
        sa(9);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()+1L);

        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+11L);

        sa(9);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sp()+1L);

        {long v0=sp();t0=gr(sp(),v0);}
        sa(sp()*t0);

        t1=sp();
        t1=(t1!=0)?0:1;

        if((t1)!=0)goto _9;else goto _12;
    _12:
        sa(sr());
        sa(sr());
        sa(sr()+12);
        sa(9);
        {long v0=sp();t0=gr(sp(),v0);}
        gw(2,0,t0);
        sa(sp()+11L);

        sa(9);
        {long v0=sp();sa(gr(sp(),v0));}
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+12L);

        sa(9);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()-1L);

        sa(sr());
        sa(gr(2,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+12L);

        sa(9);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _10;
    _13:
        System.Console.Out.Write(gr(12,9)+" ");
        sp();
        sa(1);
        sa((1-gr(9,0)!=0)?0:1);
    _14:
        if(sp()!=0)goto _15;else goto _16;
    _15:
        sp();
        return;
    _16:
        sa(sr()+12);
        sa(9);
        {long v0=sp();t0=gr(sp(),v0);}
        System.Console.Out.Write(t0+" ");
        sa(sp()+1L);

        sa((sr()-gr(9,0)!=0)?0:1);
        goto _14;
    _17:
        sa(sr());
        sa(gr(9,0));
        gw(9,0,gr(9,0)+1);
        sa(sp()+12L);

        sa(9);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _7;
    _18:
        t0=(td(sr(),10))+1;
        gw(3,0,t0);
        t0=((tm(sr(),10))*4)+12;
        gw(2,0,t0);
        goto _4;
}
}
